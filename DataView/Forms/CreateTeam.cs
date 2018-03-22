using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataController;
using DataModel;

namespace Information_System_for_eSport
{
    public partial class CreateTeam : MetroFramework.Forms.MetroForm
    {
        bool errorsExist = false;
        Team team = new Team();
        public CreateTeam()
        {
            InitializeComponent();
        }

        private void CreateTeam_Load(object sender, EventArgs e)
        {
            RegionBox.DataSource = Controller.GetRegions();
            FirstPlayerBox.DataSource = Controller.GetFreePlayers();
            SecondPlayerBox.DataSource = Controller.GetFreePlayers();
            ThirdPlayerBox.DataSource = Controller.GetFreePlayers();
            FourthPlayerBox.DataSource = Controller.GetFreePlayers();
            FifthPlayerBox.DataSource = Controller.GetFreePlayers();
        }
        private void OnTextboxClick(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTextBox textBox = (MetroFramework.Controls.MetroTextBox)sender;
            textBox.SelectAll();
        }
        private void CreateTeam_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Enabled = true;
            Owner.Show();        
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TeamNameField.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Необходимо ввести название команды", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorsExist = true;
            }
            else
            {
                team.TeamID = Guid.NewGuid();
                team.Name = TeamNameField.Text;
            }
            try
            {
                team.RegionID = (Guid)RegionBox.SelectedValue;
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "Необходимо выбрать регион.", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorsExist = true;
            }
            String[] chosenPlayers = { FirstPlayerBox.Text, SecondPlayerBox.Text, ThirdPlayerBox.Text, FourthPlayerBox.Text, FifthPlayerBox.Text };
            if (chosenPlayers.Distinct().Count() != chosenPlayers.Count())
            {
                MetroFramework.MetroMessageBox.Show(this, "Нельзя добавлять одного и того же игрока несколько раз.", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorsExist = true;
            }
            if (!errorsExist)
            {
                team.ManagerID = Program.currentPlayer.PlayerID;
                DateTime today = DateTime.Today;
                Controller.CreateTeam(team);
                Controller.AddPlayerInTeam((Guid)FirstPlayerBox.SelectedValue, team.TeamID, today);
                Controller.AddPlayerInTeam((Guid)SecondPlayerBox.SelectedValue, team.TeamID, today);
                Controller.AddPlayerInTeam((Guid)ThirdPlayerBox.SelectedValue, team.TeamID, today);
                Controller.AddPlayerInTeam((Guid)FourthPlayerBox.SelectedValue, team.TeamID, today);
                Controller.AddPlayerInTeam((Guid)FifthPlayerBox.SelectedValue, team.TeamID, today);
                Owner.Enabled = true;
                Owner.Show();
                this.Close();
            }
        }
    }
}
