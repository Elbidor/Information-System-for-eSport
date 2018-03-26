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
    public partial class UpdateChamp : MetroFramework.Forms.MetroForm
    {
        Tournament champ = new Tournament();
        MetroFramework.Controls.MetroComboBox[] MBarr1 = null;
        MetroFramework.Controls.MetroComboBox[] MBarr2 = null;
        MetroFramework.Controls.MetroComboBox[] MBarr3 = null;
        MetroFramework.Controls.MetroComboBox[] Places = null;
        MetroFramework.Controls.MetroTextBox[] Prizes = null;
        MatchesInTournament mit = new MatchesInTournament();
        Set set = new Set();
        bool errorsExist = false;
        public UpdateChamp()
        {
            InitializeComponent();
        }

        private void UpdateChamp_Load(object sender, EventArgs e)
        {
            CityField.DataSource = Controller.GetCities();
            ChooseChampBox.DataSource = Controller.GetTournaments(Program.currentPlayer.PlayerID);
            MBarr1 = new MetroFramework.Controls.MetroComboBox[] { Set1Box1, Set2Box1, Set3Box1, Set4Box1, Set5Box1};
            MBarr3 = new MetroFramework.Controls.MetroComboBox[] { Set1Box2, Set2Box2, Set3Box2, Set4Box2, Set5Box2};
            MBarr2 = new MetroFramework.Controls.MetroComboBox[] { Map1Box, Map2Box, Map3Box, Map4Box, Map5Box };
            Places = new MetroFramework.Controls.MetroComboBox[] { Team1, Team2, Team3, Team4, Team5, Team6, Team7, Team8};
            Prizes = new MetroFramework.Controls.MetroTextBox[] { Prize1, Prize2, Prize3, Prize4, Prize5, Prize6, Prize7, Prize8};
            foreach (MetroFramework.Controls.MetroComboBox box in MBarr1)
            {
                for (int i = 1; i <= 16; i++)
                {
                    string[] numArr = { i.ToString() };
                    box.Items.AddRange(numArr);
                }
            }
            foreach (MetroFramework.Controls.MetroComboBox box in MBarr3)
            {
                for (int i = 1; i <= 16; i++)
                {
                    string[] numArr = { i.ToString() };
                    box.Items.AddRange(numArr);
                }
            }
            foreach (MetroFramework.Controls.MetroComboBox box in MBarr2)
            {
                box.DataSource = Controller.GetMaps();
            }            
            string[] numbers = { "1", "3", "5"};
            SetsCountBox.Items.AddRange(numbers);
            SetsCountBox.SelectedIndex = 0;
        }

        private void ChooseChampBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            champ = Controller.GetSingleTournament((Guid)ChooseChampBox.SelectedValue);
            ChangeInfoPanel.Enabled = true;
            AddMatchPanel.Enabled = true;
            ChangePlacesPanel.Enabled = true;
            ChampNameField.Text = champ.Name;
            CityField.SelectedValue = champ.CityID;
            MoneyField.Text = champ.Money.ToString();
            ChampStartDate.Value = champ.Start;
            ChampFinishDate.Value = champ.Finish;
            TeamBox1.DataSource = Controller.GetParticipants(champ.TournamentID);
            TeamBox2.DataSource = Controller.GetParticipants(champ.TournamentID);
            for(int i=0; i<champ.MembersCount; i++)
            {
                Places[i].Enabled = true;
                Prizes[i].Enabled = true;
            }
        }

        private void AcceptChanges_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ChampNameField.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Необходимо ввести название чемпионата", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorsExist = true;
            }
            else
            {
                champ.Name = ChampNameField.Text;
                try
                {
                    champ.Money = Convert.ToInt32(MoneyField.Text);
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "Необходимо ввести положительное число в поле призового фонда", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorsExist = true;
                }
            }
            try
            {
                champ.CityID = (Guid)CityField.SelectedValue;
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "Необходимо выбрать город.", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorsExist = true;
            }            
            if (ChampStartDate.Value > ChampFinishDate.Value)
            {
                MetroFramework.MetroMessageBox.Show(this, "Даты выбраны некорректно.", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorsExist = true;
            }
            if (!errorsExist)
            {
                champ.Start = ChampStartDate.Value;
                champ.Finish = ChampFinishDate.Value;
                Controller.EditTournament(champ);
                ChangeInfoPanel.Enabled = false;
            }
        }

        private void SetsCountBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            for(int i=1; i<MBarr1.Count(); i++)
            {
                if (i < (int)SetsCountBox.SelectedItem)
                {
                    MBarr1[i].Enabled = true;
                    MBarr2[i].Enabled = true;
                    MBarr3[i].Enabled = true;
                }
                else
                {
                    MBarr1[i].Enabled = false;
                    MBarr2[i].Enabled = false;
                    MBarr3[i].Enabled = false;
                }
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            mit.FirstTeamID = (Guid)TeamBox1.SelectedValue;
            mit.SecondTeamID = (Guid)TeamBox2.SelectedValue;
            mit.TournamentID = champ.TournamentID;
            Controller.AddMatchInChamp(mit);
            for (int i = 1; i < MBarr1.Count(); i++)
            {
                if (i < (int)SetsCountBox.SelectedItem)
                {
                    set.FirstTeam = (int)MBarr1[i].SelectedItem;
                    set.SecondTeam = (int)MBarr3[i].SelectedItem;
                    set.MapID = (Guid)MBarr2[i].SelectedValue;
                    Controller.AddSetsInMatch(set, mit);
                }
            }
            Controller.SetTeamResult(mit);
        }
    }
}
