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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.playersTableAdapter.Fill(this.cybersportDBDataSet2.Players); 
            
        }

        private void Registation_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Owner = this;
            reg.Show();
            this.Enabled = false;
            this.Hide();
        }        

        private void EnterButton_Click(object sender, EventArgs e)
        {
            Forms.Login log = new Forms.Login();
            log.Owner = this;
            log.Show();
            this.Enabled = false;
        }

        private void Form1_EnabledChanged(object sender, EventArgs e)
        {
            ChangeView(Program.currentPlayer != null);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ChangeView(Program.currentPlayer == null);
        }
        private void ChangeView(bool isLogged)
        {
            if(isLogged)
            {
                EnterButton.Enabled = false;
                RegistrationButton.Enabled = false;
                EnterButton.Visible = false;
                RegistrationButton.Visible = false;
                ExitButton.Visible = true;
                ExitButton.Enabled = true;
                EditButton.Visible = true;
                EditButton.Enabled = true;
                DeleteButton.Enabled = true;
                DeleteButton.Visible = true;
                NicknameLabel.Visible = true;
                NicknameLabel.Text = Program.currentPlayer.Nickname;
                metroLabel1.Visible = false;
                this.playersTableAdapter.Fill(this.cybersportDBDataSet2.Players);
            }
            else
            {
                Program.currentPlayer = null;
                EnterButton.Enabled = true;
                RegistrationButton.Enabled = true;
                EnterButton.Visible = true;
                RegistrationButton.Visible = true;
                ExitButton.Visible = false;
                ExitButton.Enabled = false;
                NicknameLabel.Visible = false;
                NicknameLabel.Text = "";
                metroLabel1.Visible = true;
                EditButton.Visible = false;
                EditButton.Enabled = false;
                DeleteButton.Enabled = false;
                DeleteButton.Visible = false;
                PlayerGrid.DataSource = null;
                PlayerGrid.DataSource = playersBindingSource1;
                this.playersTableAdapter.Fill(this.cybersportDBDataSet2.Players);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Controller.DeletePlayer(Program.currentPlayer);
            Program.currentPlayer = null;
            Form1_EnabledChanged(sender, e);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Owner = this;
            reg.Show();
            this.Enabled = false;
            this.Hide();
        }

        private void PlayerGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (TabControl.SelectedTab.Name)
            {
                case "PlayerTab":
                    timer1.Start();
                    Player displayedPlayer = null;
                    foreach (DataGridViewRow row in PlayerGrid.SelectedRows)
                    {
                        displayedPlayer = Controller.FindPlayer((Guid)row.Cells[0].Value);
                    }
                    InformationPanel.Visible = true;
                    InformationPanel.Enabled = true;
                    InfoPanelNameField.Visible = true;
                    InfoPanelNicknameField.Visible = true;
                    InfoPanelSurnameField.Visible = true;
                    InfoPanelAgeField.Visible = true;
                    InfoPanelPlayedMapsField.Visible = true;
                    InfoPanelPlayedRoundsField.Visible = true;
                    InfoPanelCountryField.Visible = true;
                    InfoPanelCurrentTeam.Visible = true; 
                    InfoPanelNameField.Text = displayedPlayer.Name;
                    InfoPanelNicknameField.Text = displayedPlayer.Nickname;
                    InfoPanelSurnameField.Text = displayedPlayer.Name;
                    InfoPanelAgeField.Text = displayedPlayer.Age.ToString();
                    InfoPanelPlayedMapsField.Text = displayedPlayer.PlayedMaps.ToString();
                    InfoPanelPlayedRoundsField.Text = displayedPlayer.PlayedRounds.ToString();
                    InfoPanelCountryField.Text = displayedPlayer.CountryName;
                    InfoPanelCurrentTeam.Text = "***"; //Добавить связь с командами
                    break;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(InformationPanel.Width <=402) InformationPanel.Width += 60;
            else timer1.Stop();
        }
    }
}
