using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            player.PlayerID = Guid.NewGuid();
            var ctx = new CybersportDBEntities();
            if (ctx.Players.Where(p => p.Nickname == player.Nickname).Count() != 0)
            {
                throw new Exception("К сожалению, этот никнейм уже занят.");
            }
            ctx.Players.Add(player);
            ctx.SaveChanges();
        }
    }
}
