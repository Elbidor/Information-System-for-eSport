using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using DataController;
using DataModel;

namespace Information_System_for_eSport
{
    static class Program
    {
        /// <summary>
        /// Текущий игрок
        /// </summary>
        static public Player currentPlayer = null;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
