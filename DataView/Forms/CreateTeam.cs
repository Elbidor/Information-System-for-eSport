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
            if(Controller.IsAlreadyHasATeam(Program.currentPlayer.PlayerID))
            {
                team = Controller.FindTeamByManager(Program.currentPlayer.PlayerID);
                TeamNameField.Text = team.Name;
                RegionBox.SelectedValue = team.RegionID;
                FirstPlayerBox.DataSource = Controller.GetFreePlayers(team.TeamID);
                SecondPlayerBox.DataSource = Controller.GetFreePlayers(team.TeamID);
                ThirdPlayerBox.DataSource = Controller.GetFreePlayers(team.TeamID);
                FourthPlayerBox.DataSource = Controller.GetFreePlayers(team.TeamID);
                FifthPlayerBox.DataSource = Controller.GetFreePlayers(team.TeamID);
            }
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
                if(!Controller.IsAlreadyHasATeam(Program.currentPlayer.PlayerID))
                {
                    team.TeamID = Guid.NewGuid();
                    team.ManagerID = Program.currentPlayer.PlayerID;
                    DateTime today = DateTime.Today;
                    Controller.CreateTeam(team);
                    Controller.AddPlayerInTeam((Guid)FirstPlayerBox.SelectedValue, team.TeamID, today);
                    Controller.AddPlayerInTeam((Guid)SecondPlayerBox.SelectedValue, team.TeamID, today);
                    Controller.AddPlayerInTeam((Guid)ThirdPlayerBox.SelectedValue, team.TeamID, today);
                    Controller.AddPlayerInTeam((Guid)FourthPlayerBox.SelectedValue, team.TeamID, today);
                    Controller.AddPlayerInTeam((Guid)FifthPlayerBox.SelectedValue, team.TeamID, today);
                }
                else
                {
                    Controller.EditTeam(team);
                    if(!Controller.CheckTeamMember((Guid)FirstPlayerBox.SelectedValue, team.TeamID)) Controller.AddPlayerInTeam((Guid)FirstPlayerBox.SelectedValue, team.TeamID, DateTime.Today);
                    if (!Controller.CheckTeamMember((Guid)SecondPlayerBox.SelectedValue, team.TeamID)) Controller.AddPlayerInTeam((Guid)SecondPlayerBox.SelectedValue, team.TeamID, DateTime.Today);
                    if (!Controller.CheckTeamMember((Guid)ThirdPlayerBox.SelectedValue, team.TeamID)) Controller.AddPlayerInTeam((Guid)ThirdPlayerBox.SelectedValue, team.TeamID, DateTime.Today);
                    if (!Controller.CheckTeamMember((Guid)FourthPlayerBox.SelectedValue, team.TeamID)) Controller.AddPlayerInTeam((Guid)FourthPlayerBox.SelectedValue, team.TeamID, DateTime.Today);
                    if (!Controller.CheckTeamMember((Guid)FifthPlayerBox.SelectedValue, team.TeamID)) Controller.AddPlayerInTeam((Guid)FifthPlayerBox.SelectedValue, team.TeamID, DateTime.Today);
                    List<Guid> newMembers = new List<Guid>();
                    newMembers.Add((Guid)FirstPlayerBox.SelectedValue);
                    newMembers.Add((Guid)SecondPlayerBox.SelectedValue);
                    newMembers.Add((Guid)ThirdPlayerBox.SelectedValue);
                    newMembers.Add((Guid)FourthPlayerBox.SelectedValue);
                    newMembers.Add((Guid)FifthPlayerBox.SelectedValue);
                    Controller.RefreshTeamMembers(newMembers, team.TeamID);
                }
                Owner.Enabled = true;
                Owner.Show();
                this.Close();
            }
        }
    }
}
