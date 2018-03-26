using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using DataModel;

namespace DataController
{
    public class Controller
    {
        #region Игроки

        /// <summary>
        /// Добавляет нового игрока в БД.
        /// </summary>
        /// <param name="player">Игрок</param>
        public static void CreatePlayer(Player player)
        {
            var ctx = new CybersportDBEntities();
            player.PlayerID = Guid.NewGuid();
            player.Country = ctx.Countries.ToList().First(c => c.CountryID == player.CountryID);
            player.Role = ctx.Roles.ToList().First(r => r.RoleID == player.RoleID);
            player.Rating = 0;
            player.PlayedMaps = 0;
            player.PlayedRounds = 0;
            PlayersInTeam pit = new PlayersInTeam();
            pit.ID = Guid.NewGuid();
            pit.Start = DateTime.Today;
            pit.PlayerID = player.PlayerID;
            pit.TeamID = ctx.Teams.Where(t => t.TeamID == Guid.Empty).FirstOrDefault().TeamID;
            player.PlayersInTeamsID = pit.ID;
            ctx.PlayersInTeams.Add(pit);
            ctx.Players.Add(player);            
            ctx.SaveChanges();
        }
        
        public static void AddPlayerInTeam(Guid playerID, Guid teamID, DateTime date)
        {
            var ctx = new CybersportDBEntities();
            Guid oldValueGuid = GetLastTeam(playerID);
            ctx.PlayersInTeams.First(x => x.ID == oldValueGuid && x.Finish == null).Finish = date;
            PlayersInTeam pit = new PlayersInTeam();
            pit.ID = Guid.NewGuid();
            pit.PlayerID = playerID;
            pit.TeamID = teamID;
            pit.Start = date;
            pit.Team = ctx.Teams.First(x => x.TeamID == teamID);
            pit.Player = ctx.Players.First(x => x.PlayerID == playerID);
            ctx.PlayersInTeams.Add(pit);
            ctx.SaveChanges();
        }

        public static bool IsAlreadyHasATeam(Guid managerID)
        {
            var ctx = new CybersportDBEntities();
            var test = ctx.Teams.Where(x => x.ManagerID == managerID).ToList();
            return test.Count() == 0 ? false : true;
        }

        public static void DeletePlayer(Player player)
        {
            var ctx = new CybersportDBEntities();
            if (player.Role.Role1 == "Администратор")
            {
                throw new Exception("Нельзя удалять единственного администратора!");
            }
            Player delPlayer = new Player
            {
                PlayerID = player.PlayerID
            };
            ctx.Players.Attach(delPlayer);
            ctx.Players.Remove(delPlayer);
            ctx.SaveChanges();
        }

        public static void EditPlayer(Player oldPlayer)
        {
            var ctx = new CybersportDBEntities();
            oldPlayer.Country = ctx.Countries.ToList().First(c => c.CountryID == oldPlayer.CountryID);
            oldPlayer.Role = ctx.Roles.ToList().First(r => r.RoleID == oldPlayer.RoleID);
            ctx.Entry(oldPlayer).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();

        }

        public static Player FindPlayer(Guid id)
        {
            var ctx = new CybersportDBEntities();
            return ctx.Players.ToList().First(pl => pl.PlayerID == id);
        }

        public static string ReturnNickname(Guid id)
        {
            var ctx = new CybersportDBEntities();
            return ctx.Players.ToList().First(pl => pl.PlayerID == id).Nickname;
        }

        public static Player FindPlayer(string log, string pass)
        {
            var ctx = new CybersportDBEntities();
            try
            {
                return ctx.Players.ToList().First(pl => pl.Email == log && pl.Password == pass);
            }
            catch
            {
                return null;
            }
        }

        public static List<Player> GetPlayers()
        {
            var ctx = new CybersportDBEntities();
            var players = ctx.Players.ToList();
            return players;
        }        

        public static List<PlayersInTeam> GetFreePlayers()
        {
            var ctx = new CybersportDBEntities();
            var freePlayers = ctx.PlayersInTeams.Where(p => p.TeamID == Guid.Empty && p.Finish == null).ToList();
            return freePlayers;
        }
        public static List<PlayersInTeam> GetFreePlayers(Guid teamID)
        {
            var ctx = new CybersportDBEntities();
            var freePlayers = ctx.PlayersInTeams.Where(p => (p.TeamID == Guid.Empty || p.TeamID == teamID) && p.Finish == null).ToList();
            return freePlayers;
        }

        public static List<Player> GetPlayers(Dictionary<string, string> filters)
        {
            string nameF = filters["Name"];
            string nicknameF = filters["Nickname"];
            string surnameF = filters["Surname"];
            int mapsF = Convert.ToInt32(filters["PlayedMaps"]);
            int roundsF = Convert.ToInt32(filters["PlayedRounds"]);
            int ratingF = Convert.ToInt32(filters["Rating"]);
            var ctx = new CybersportDBEntities();
            var playersF = ctx.Players.Where(p => (p.Name.Contains(nameF)
                                                    && p.Nickname.Contains(nicknameF)
                                                    && p.Surname.Contains(surnameF)
                                                    && p.Rating >= ratingF
                                                    && p.PlayedMaps >= mapsF
                                                    && p.PlayedRounds >= roundsF)).ToList();
            if (filters.ContainsKey("Age"))
            {
                int ageF = Convert.ToInt32(filters["Age"]);
                playersF = playersF.Where(p => p.Age == ageF).ToList();
            }
            if (filters.ContainsKey("CountryName"))
            {
                string countryNameF = filters["CountryName"].Trim();
                playersF = playersF.Where(p => p.CountryName.Equals(countryNameF)).ToList();
            }
            return playersF;
        }

        public static int GetPlayersMaxValues(string type)
        {
            var ctx = new CybersportDBEntities();
            int value = 0;
            switch (type)
            {
                case "rating":
                    value = ctx.Players.Max(p => p.Rating);
                    break;
                case "maps":
                    value = ctx.Players.Max(p => p.PlayedMaps);
                    break;
                case "rounds":
                    value = ctx.Players.Max(p => p.PlayedRounds);
                    break;
            }
            return value;
        }

        #endregion

        #region Команды
        public static void CreateTeam(Team team)
        {
            var ctx = new CybersportDBEntities();
            if (ctx.Teams.Where(tm => tm.Name == team.Name).Count() != 0)
            {
                throw new Exception("Уже есть команда с таким названием.");
            }
            team.Wins = 0;
            team.Draws = 0;
            team.Defeats = 0;
            team.Rating = 0;
            team.Region = ctx.Regions.ToList().First(r => r.RegionID == team.RegionID);
            ctx.Teams.Add(team);
            ctx.SaveChanges();
        }

        public static void CreateTeam()
        {
            var ctx = new CybersportDBEntities();
            Team t = new Team();
            t.TeamID = Guid.Empty;
            t.Name = "Без команды";
            t.Wins = 0;
            t.Draws = 0;
            t.Defeats = 0;
            t.Rating = 0;
            t.RegionID = ctx.Regions.First().RegionID;
            t.Region = ctx.Regions.ToList().First(r => r.RegionID == t.RegionID);
            ctx.Teams.Add(t);
            ctx.SaveChanges();
        }
        public static void EditTeam(Team oldTeam)
        {
            var ctx = new CybersportDBEntities();
            oldTeam.Region = ctx.Regions.ToList().First(r => r.RegionID == oldTeam.RegionID);
            Team changedTeam = ctx.Teams.Where(x => x.TeamID == oldTeam.TeamID).First();
            changedTeam.Name = oldTeam.Name;
            changedTeam.Money = oldTeam.Money;
            changedTeam.Defeats = oldTeam.Defeats;
            changedTeam.Draws = oldTeam.Draws;
            changedTeam.Wins = oldTeam.Wins;
            changedTeam.RegionID = oldTeam.RegionID;
            changedTeam.Region = oldTeam.Region;
            changedTeam.Rating = oldTeam.Rating;
            ctx.Entry(changedTeam).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();                      
        }
        public static void RefreshTeamMembers(List<Guid> newMembersIDs, Guid teamID)
        {
            var ctx = new CybersportDBEntities();
            var allTeamPlayers = ctx.PlayersInTeams.Where(p => p.TeamID == teamID && p.Finish == null).ToList();
            for (int i=0; i<allTeamPlayers.Count(); i++)
            {
                var search = newMembersIDs.FirstOrDefault(x => x == allTeamPlayers[i].PlayerID);
                if (search == Guid.Empty) AddPlayerInTeam(allTeamPlayers[i].PlayerID, Guid.Empty, DateTime.Today);
            }            
            ctx.SaveChanges();
        }
        public static Guid GetLastTeam(Guid playerID)
        {
            var ctx = new CybersportDBEntities();
            PlayersInTeam sc = (PlayersInTeam)ctx.PlayersInTeams
                .Where(x => x.PlayerID == playerID && x.Finish == null)
                .OrderByDescending(x => x.Start).First();
            return sc.ID;
        }
        public static bool CheckTeamMember (Guid playerID, Guid teamID)
        {
            var ctx = new CybersportDBEntities();
            var test = ctx.PlayersInTeams.Where(x => x.PlayerID == playerID && x.TeamID == teamID && x.Finish == null).ToList();
            return test.Count() == 0 ? false : true;
        }
        public static List<PlayersInTeam> GetCareer(Guid playerID)
        {
            var ctx = new CybersportDBEntities();
            var pitList = ctx.PlayersInTeams
                .Where(x => x.PlayerID == playerID)
                .OrderByDescending(x => x.Start).ToList();
            return pitList;
        }

        public static string ReturnLatestTeam(Guid id)
        {
            var ctx = new CybersportDBEntities();
            try
            {
                return ctx.PlayersInTeams
                 .Where(x => x.PlayerID == id && x.Finish == null)
                 .OrderBy(x => x.Finish).First().Team.Name;
            }
            catch
            {
                return "Без команды";
            }
        }

        public static Team FindTeamByID (Guid id)
        {
            var ctx = new CybersportDBEntities();
            return ctx.Teams.ToList().First(t => t.TeamID == id);
        }
        public static Team FindTeamByManager (Guid managerID)
        {
            var ctx = new CybersportDBEntities();
            return ctx.Teams.ToList().First(t => t.ManagerID == managerID);
        }

        public static List<Team> GetTeams()
        {
            var ctx = new CybersportDBEntities();
            var teams = ctx.Teams.Where(t => t.TeamID != Guid.Empty && t.ManagerID != Guid.Empty).ToList();
            return teams;
        }

        public static List<Team> GetTeams(Dictionary<string, string> filters)
        {
            string nameF = filters["Name"];
            int winsF = Convert.ToInt32(filters["Wins"]);
            int drawsF = Convert.ToInt32(filters["Draws"]);
            int defeatsF = Convert.ToInt32(filters["Defeats"]);
            int moneyF = Convert.ToInt32(filters["Money"]);
            int ratingF = Convert.ToInt32(filters["Rating"]);
            var ctx = new CybersportDBEntities();
            var teamsF = ctx.Teams.Where(p => (p.Name.Contains(nameF)
                                                    && p.Name != "Без команды"
                                                    && p.Rating >= ratingF
                                                    && p.Wins >= winsF
                                                    && p.Defeats >= defeatsF
                                                    && p.Money >= moneyF
                                                    && p.Draws >= drawsF)).ToList();
            if (filters.ContainsKey("RegionName"))
            {
                string regionF = filters["RegionName"];
                teamsF = teamsF.Where(p => p.RegionName.Contains(regionF)).ToList();
            }
            return teamsF;
        }

        public static void DeleteTeam(Guid id)
        {
            var ctx = new CybersportDBEntities();
            Team delTeam = ctx.Teams.Where(x => x.ManagerID == id).First();
            var playersIDs = ctx.PlayersInTeams.Where(p => p.TeamID == ctx.Teams.FirstOrDefault(t => t.ManagerID == id).TeamID).Select(s => s.PlayerID);
            foreach (Guid pID in playersIDs)
            {
                AddPlayerInTeam(pID, Guid.Empty, DateTime.Today);
            }
            delTeam.ManagerID = Guid.Empty;
            ctx.SaveChanges();
        }
        
        #endregion

        #region Регионы

        public static List<Region> GetRegions()
        {
            var ctx = new CybersportDBEntities();
            var regions = ctx.Regions.ToList();
            return regions;
        }

        public static string ReturnRegionName(Guid regID)
        {
            var ctx = new CybersportDBEntities();
            return ctx.Regions.First(x => x.RegionID == regID).Name;
        }

        #endregion

        #region Страны

        public static List<Country> GetCountries()
        {
            var ctx = new CybersportDBEntities();
            return ctx.Countries.OrderBy(c => c.Country1).ToList();
        }

        public static Country GetCountries(int id)
        {
            var ctx = new CybersportDBEntities();
            var countries = ctx.Countries.ToList();
            Country country = countries.First(c => c.CountryID == id);
            return country;
        }
        public static List<City> GetCities()
        {
            var ctx = new CybersportDBEntities();
            return ctx.Cities.OrderBy(c => c.Name).ToList();
        }

        public static void CreateCity(City city)
        {
            var ctx = new CybersportDBEntities();
            city.Country = ctx.Countries.ToList().First(c => c.CountryID == city.CountryID);
            ctx.Cities.Add(city);
            ctx.SaveChanges();
        }
        #endregion

        #region Роли
        public static List<Role> GetRoles()
        {
            var ctx = new CybersportDBEntities();
            var roles = ctx.Roles.ToList();
            return roles;
        }
        #endregion


        
        public static List<Tournament> GetTournaments()
        {
            var ctx = new CybersportDBEntities();
            var tour = ctx.Tournaments.Where(t => t.TournamentID != Guid.Empty).ToList();
            return tour;
        }

        public static List<Tournament> GetTournaments(Guid orgID)
        {
            var ctx = new CybersportDBEntities();
            var tour = ctx.Tournaments.Where(t => t.TournamentID != Guid.Empty && t.OrgID == orgID).ToList();
            return tour;
        }
        public static void AddParticipant(Guid champID, Guid teamID)
        {
            var ctx = new CybersportDBEntities();
            var tour = ctx.Tournaments.FirstOrDefault(t => t.TournamentID == champID);
            Participant pt = new Participant();
            pt.TeamID = teamID;
            pt.Team = ctx.Teams.ToList().First(t => t.TeamID == teamID);
            pt.TournamentID = champID;
            pt.Place = 0;
            pt.Money = 0;
            tour.Participants.Add(pt);
            ctx.SaveChanges();
        }
        public static void AddMatchInChamp(MatchesInTournament mit)
        {
            var ctx = new CybersportDBEntities();
            mit.MathID = Guid.NewGuid();
            mit.Date = DateTime.Today;
            mit.Tournament = ctx.Tournaments.FirstOrDefault(t => t.TournamentID == mit.TournamentID);
            mit.Team = ctx.Teams.FirstOrDefault(t => t.TeamID == mit.FirstTeamID);
            mit.Team1 = ctx.Teams.FirstOrDefault(t => t.TeamID == mit.SecondTeamID);
            ctx.MatchesInTournaments.Add(mit);
            ctx.SaveChanges();
        }
        public static void AddSetsInMatch(Set set, MatchesInTournament mit)
        {
            var ctx = new CybersportDBEntities();
            set.SetID = Guid.NewGuid();
            set.MatchID = mit.MathID;
            set.MatchesInTournament = ctx.MatchesInTournaments.FirstOrDefault(t => t.MathID == set.MatchID);
            set.Map = ctx.Maps.FirstOrDefault(t => t.MapID == set.MapID);
            ctx.Sets.Add(set);
            ctx.SaveChanges();
        }
        public static void SetTeamResult(MatchesInTournament mit)
        {
            var ctx = new CybersportDBEntities();
            var li = ctx.Sets.Where(x => x.MatchID == mit.MathID).ToList();
            int firstTeamReasult = 0, secondTeamResult = 0;
            foreach(Set s in li)
            {
                firstTeamReasult += s.FirstTeam;
                secondTeamResult += s.SecondTeam;
            }
            Team t = mit.Team;
            Team t1 = mit.Team1;
            if (firstTeamReasult> secondTeamResult)
            {
                t.Wins += 1;
                t1.Defeats += 1;
                t.Rating += 10;                
            }
            if (firstTeamReasult == secondTeamResult)
            {
                t.Draws += 1;
                t1.Draws += 1;
                t.Rating += 5;
                t1.Rating += 5;
            }
            if (firstTeamReasult < secondTeamResult)
            {
                t.Defeats += 1;
                t1.Wins += 1;
                t1.Rating += 10;
            }
            SetPlayersResults(t, firstTeamReasult);
            SetPlayersResults(t1, secondTeamResult);
            EditTeam(t);
            EditTeam(t1);
            ctx.SaveChanges();
        }
        public static void SetPlayersResults(Team team, int playedRounds)
        {
            var ctx = new CybersportDBEntities();
            var players = ctx.PlayersInTeams.Where(p => p.TeamID == team.TeamID && p.Finish == null).ToList();
            foreach (PlayersInTeam pit in players)
            {
                pit.Player.PlayedRounds += playedRounds;
                ctx.SaveChanges();
            }
        }
        public static Tournament GetSingleTournament(Guid champID)
        {
            var ctx = new CybersportDBEntities();
            var tour = ctx.Tournaments.FirstOrDefault(t => t.TournamentID == champID);
            return tour;
        }
        public static void EditTournament(Tournament oldChamp)
        {
            var ctx = new CybersportDBEntities();
            oldChamp.City = ctx.Cities.ToList().First(c => c.CityID == oldChamp.CityID);
            Tournament changedChamp = ctx.Tournaments.Where(x => x.TournamentID == oldChamp.TournamentID).First();
            changedChamp.Name = oldChamp.Name;
            changedChamp.Money = oldChamp.Money;
            changedChamp.CityID = oldChamp.CityID;
            changedChamp.City = oldChamp.City;
            changedChamp.Finish = oldChamp.Finish;
            changedChamp.Start = oldChamp.Start;
            changedChamp.MembersCount = oldChamp.MembersCount;
            ctx.Entry(changedChamp).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }
        public static List<Tournament> GetTournaments(Dictionary<string, string> filters)
        {
            string nameF = filters["Name"];
            int countTeamsF = Convert.ToInt32(filters["MembersCount"]);            
            int moneyF = Convert.ToInt32(filters["Money"]);
            var ctx = new CybersportDBEntities();

            var champF = ctx.Tournaments.Where(c => (c.Name.Contains(nameF)
                                                    && c.MembersCount >= countTeamsF
                                                    && c.Money >= moneyF)).ToList();
            if (filters.ContainsKey("CityID"))
            {
                Guid cityF = new Guid(filters["CityID"]);
                champF = champF.Where(p => p.CityID == cityF).ToList();
            }
            if (filters.ContainsKey("Start"))
            {
                DateTime startF = Convert.ToDateTime(filters["Start"]);
                champF = champF.Where(p => p.Start >= startF).ToList();
            }
            if (filters.ContainsKey("Finish"))
            {
                DateTime finishF = Convert.ToDateTime(filters["Finish"]);
                champF = champF.Where(p => p.Finish <= finishF).ToList();
            }
            return champF;
        }
        public static void CreateTournament(Tournament champ)
        {
            var ctx = new CybersportDBEntities();
            if (ctx.Tournaments.Where(tm => tm.Name == champ.Name).Count() != 0)
            {
                throw new Exception("Уже есть чемпионат с таким названием.");
            }
            champ.City = ctx.Cities.ToList().First(c => c.CityID == champ.CityID);
            ctx.Tournaments.Add(champ);
            ctx.SaveChanges();
        }
        public static List<Participant> GetParticipants(Guid champID)
        {
            var ctx = new CybersportDBEntities();
            return ctx.Participants.Where(p=>p.TournamentID == champID).ToList();
        }

        public static List<Map> GetMaps()
        {
            var ctx = new CybersportDBEntities();
            return ctx.Maps.ToList();
        }

        /// <summary>
        /// Отправка письма пользователю на почту.
        /// </summary>
        /// <param name="receiver"></param>
        /// <param name="purpose"></param>
        public static void SendEmail(string receiver, string purpose)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("shotfuse2@gmail.com");
                message.To.Add(new MailAddress(receiver));
                message.Subject = "Выполнен вход в Cybersport Information System";
                if (purpose == "login") message.Body = "Доброго времени суток!\n\nВами был выполнен вход в информационную систему. Приятного пользования!\nС уважением,\nКрасильников Роман\nСтудент БИ-16-1";
                if (purpose == "registration") message.Body = "Доброго времени суток!\n\nТолько что вы были зарегистрированы в информационной системе. Приятного пользования!\nС уважением,\nКрасильников Роман\nСтудент БИ-16-1";
                if (purpose == "joinTeam") message.Body = "Доброго времени суток!\n\nВы были приглашены в команду! Зайдите в ИС, чтобы дать свой ответ.\nС уважением,\nКрасильников Роман\nСтудент БИ-16-1";
                if (purpose == "joinTournament") message.Body = "Доброго времени суток!\n\nВашу команду пригласили на турнир! Зайдите в ИС, чтобы дать свой ответ.\nС уважением,\nКрасильников Роман\nСтудент БИ-16-1";
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("shotfuse2@gmail.com", "59904939240Zz");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



    }
}
