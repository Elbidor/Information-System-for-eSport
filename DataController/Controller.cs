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
        public static List<Role> GetRoles()
        {
            var ctx = new CybersportDBEntities();
            var roles = ctx.Roles.ToList();
            return roles;
        }

    }
}
