using System;
using System.Collections.Generic;
using System.Linq;
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
            if (ctx.Players.Where(p => p.Nickname == player.Nickname).Count() != 0)
            {
                throw new Exception("К сожалению, этот никнейм уже занят.");
            }
            player.Country = ctx.Countries.ToList().First(c => c.CountryID == player.CountryID);
            player.Role = ctx.Roles.ToList().First(r => r.RoleID == player.RoleID);
            player.CountryName = player.Country.Country1;
            player.Rating = 1.0;
            player.PlayedMaps = 0;
            player.PlayedRounds = 0;
            ctx.Players.Add(player);
            ctx.SaveChanges();
        }
        public static List<Country> GetCountries()
        {
            var ctx = new CybersportDBEntities();
            var countries = ctx.Countries.ToList();
            return countries;
        }
        public static Player FindPlayer (string log, string pass)
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
        public static List<Role> GetRoles()
        {
            var ctx = new CybersportDBEntities();
            var roles = ctx.Roles.ToList();
            return roles;
        }
        //public static Role GetRoles(Guid id)
        //{
        //    var ctx = new CybersportDBEntities();
        //    var roles = ctx.Roles.ToList();
        //    Role role = roles.First(r => r.RoleID == id);
        //    return role;
        //}

        //public static Country GetCountries(int id)
        //{
        //    var ctx = new CybersportDBEntities();
        //    var countries = ctx.Countries.ToList();
        //    Country country = countries.First(c => c.CountryID == id);
        //    return country;
        //}


    }
}
