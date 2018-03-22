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
            player.CountryName = player.Country.Country1.Trim();
            player.Rating = 0;
            player.PlayedMaps = 0;
            player.PlayedRounds = 0;
            PlayersInTeam pit = new PlayersInTeam();
            pit.ID = Guid.NewGuid();
            pit.Start = DateTime.Today;
            pit.PlayerID = player.PlayerID;
            pit.TeamID = ctx.Teams.Where(t => t.TeamID == Guid.Empty).FirstOrDefault().TeamID;
            player.PlayersInTeamsID = pit.ID;
            ctx.Players.Add(player);
            ctx.PlayersInTeams.Add(pit);
            ctx.SaveChanges();
        }
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
            team.RegionName = team.Region.Name;
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
        public static void AddPlayerInTeam(Guid playerID, Guid teamID, DateTime date)
        {
            var ctx = new CybersportDBEntities();
            Guid oldValueGuid = GetLastTeam(playerID);
            ctx.PlayersInTeams.First(x => x.ID == oldValueGuid).Finish = date;
            PlayersInTeam pit = new PlayersInTeam();
            pit.ID = Guid.NewGuid();
            pit.PlayerID = playerID;
            pit.TeamID = teamID;
            pit.Start = date;
            ctx.PlayersInTeams.Add(pit);
            ctx.SaveChanges();
        }
        public static Guid GetLastTeam(Guid playerID)
        {
            var ctx = new CybersportDBEntities();
            PlayersInTeam sc = (PlayersInTeam)ctx.PlayersInTeams
                .Where(x => x.PlayerID == playerID)
                .OrderByDescending(x => x.Start).First();
            return sc.ID;
        }
        public static bool IsAlreadyHasATeam (Guid managerID)
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
            oldPlayer.CountryName = oldPlayer.Country.Country1.Trim();
            ctx.Entry(oldPlayer).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();

        }
        public static Player FindPlayer(Guid id)
        {
            var ctx = new CybersportDBEntities();
            return ctx.Players.ToList().First(pl => pl.PlayerID == id);
        }
        public static string ReturnNickname (Guid id)
        {
            var ctx = new CybersportDBEntities();
            return ctx.Players.ToList().First(pl => pl.PlayerID == id).Nickname;
        }
        public static string ReturnLatestTeam(Guid id)
        {
            var ctx = new CybersportDBEntities();
            try
            {
               return ctx.PlayersInTeams
                .Where(x => x.PlayerID == id)
                .OrderByDescending(x => x.Start).First().Team.Name;
            }
            catch
            {
                return "Без команды";
            }
        }
        public static Team FindTeam (Guid id)
        {
            var ctx = new CybersportDBEntities();
            return ctx.Teams.ToList().First(t => t.TeamID == id);
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
        public static List<Team> GetTeams()
        {
            var ctx = new CybersportDBEntities();
            var teams = ctx.Teams.Where(t => t.TeamID != Guid.Empty).ToList();
            return teams;
        }

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
        public static List<Player> GetFreePlayers()
        {
            var ctx = new CybersportDBEntities();
            var freePlayers = ctx.Players.Where(p => p.PlayersInTeams.Where(x => x.PlayerID == p.PlayerID).FirstOrDefault().Team.Name == "Без команды" && p.PlayersInTeams.Where(x => x.PlayerID == p.PlayerID).FirstOrDefault().Finish == null).ToList();
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
        public static List<Country> GetCountries()
        {
            var ctx = new CybersportDBEntities();
            return ctx.Countries.OrderBy(c => c.Country1).ToList();
        }

        public static List<Role> GetRoles()
        {
            var ctx = new CybersportDBEntities();
            var roles = ctx.Roles.ToList();
            return roles;
        }

        public static Country GetCountries(int id)
        {
            var ctx = new CybersportDBEntities();
            var countries = ctx.Countries.ToList();
            Country country = countries.First(c => c.CountryID == id);
            return country;
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
