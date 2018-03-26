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
    public partial class CreateChamp : MetroFramework.Forms.MetroForm
    {
        MetroFramework.Controls.MetroComboBox[] MBarr = null;
        Tournament champ = new Tournament();
        bool errorsExist = false;
        public CreateChamp()
        {
            InitializeComponent();
        }

        private void CreateChamp_Load(object sender, EventArgs e)
        {

            string[] numbers = { "2", "4", "6", "8" };
            TeamCountBox.Items.AddRange(numbers);
            TeamCountBox.SelectedIndex = 0;
            CityField.DataSource = Controller.GetCities();
            MBarr = new MetroFramework.Controls.MetroComboBox[] { TeamBox1, TeamBox2, TeamBox3, TeamBox4, TeamBox5, TeamBox6, TeamBox7, TeamBox8};
            foreach (MetroFramework.Controls.MetroComboBox box in MBarr)
            {
                box.DataSource = Controller.GetTeams();
            }
        }

        private void TeamCountBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            for (int i = 0; i < MBarr.Count(); i++)
            {
                if (i < Convert.ToInt32(TeamCountBox.Text)) MBarr[i].Visible = true;
                else MBarr[i].Visible = false;
            }
        }

        private void OnTextboxClick(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTextBox textBox = (MetroFramework.Controls.MetroTextBox)sender;
            textBox.SelectAll();
        }

        private void CreateChamp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Enabled = true;
            Owner.Show();
        }

        private void AcceptButton2_Click(object sender, EventArgs e)
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
            string[] chosenTeams = new string [Convert.ToInt32(TeamCountBox.Text)];
            for(int i=0; i< chosenTeams.Length; i++)
            {
                chosenTeams[i] = MBarr[i].Text;
            }
            if (chosenTeams.Distinct().Count() != chosenTeams.Count())
            {
                MetroFramework.MetroMessageBox.Show(this, "Нельзя добавлять одну и ту же команду несколько раз.", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorsExist = true;
            }
            if(ChampStartDate.Value > ChampFinishDate.Value)
            {
                MetroFramework.MetroMessageBox.Show(this, "Даты выбраны некорректно.", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorsExist = true;
            }
            if (!errorsExist)
            {
                champ.TournamentID = Guid.NewGuid();
                champ.OrgID = Program.currentPlayer.PlayerID;
                champ.MembersCount = Convert.ToInt32(TeamCountBox.Text);
                champ.Start = ChampStartDate.Value;
                champ.Finish = ChampFinishDate.Value;
                Controller.CreateTournament(champ);
                for (int i = 0; i < MBarr.Count(); i++)
                {
                    if (i < Convert.ToInt32(TeamCountBox.Text)) Controller.AddParticipant(champ.TournamentID, (Guid)MBarr[i].SelectedValue);
                }
                Owner.Enabled = true;
                Owner.Show();
                this.Close();
            }
        }

        private void AddCityButton_Click(object sender, EventArgs e)
        {
            CreateCity ct = new CreateCity();
            ct.Owner = this;
            ct.Show();
            this.Enabled = false;
        }

        private void CreateChamp_EnabledChanged(object sender, EventArgs e)
        {
            CityField.DataSource = Controller.GetCities();
            CityField.Refresh();
            CityField.Update();
        }
    }
}
