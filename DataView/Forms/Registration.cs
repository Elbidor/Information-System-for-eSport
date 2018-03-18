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
    public partial class Registration : MetroFramework.Forms.MetroForm
    {
        public Player player = new Player();
        bool errorsExist;
        public Registration()
        {
            InitializeComponent();
        }
        private void OnTextboxClick (object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTextBox textBox = (MetroFramework.Controls.MetroTextBox)sender;
            textBox.Text = null;
        }
        private void OnRadioButtonClick(object sender, EventArgs e)
        {
            AsManagerCheckBox.Checked = false;
            AsPlayerCheckBox.Checked = false;
            AsOrganizerCheckBox.Checked = false;
            MetroFramework.Controls.MetroCheckBox radioButton = (MetroFramework.Controls.MetroCheckBox)sender;
            radioButton.Checked = true;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            errorsExist = false;
            if (string.IsNullOrWhiteSpace(NameField.Text) || string.IsNullOrWhiteSpace(NicknameField.Text) || string.IsNullOrWhiteSpace(SurnameField.Text) || string.IsNullOrWhiteSpace(AgeField.Text) || string.IsNullOrWhiteSpace(PasswordField.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Необходимо заполнить все поля.", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorsExist = true;
            }
            else
            {
                player.Name = NameField.Text;
                player.Nickname = NicknameField.Text;
                player.Surname = SurnameField.Text;
                player.Password = PasswordField.Text;
                if ((player.Age = Convert.ToInt32(AgeField.Text)) < 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Необходимо ввести положительное число в поле возраста", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorsExist = true;
                }
            }
            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(EmailField.Text);
                player.Email = EmailField.Text;
            }
            catch 
            {
                MetroFramework.MetroMessageBox.Show(this, "Необходимо правильно ввести почту", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorsExist = true;
            }
            try
            {
                player.CountryID = (int)CountryField.SelectedValue;
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "Необходимо выбрать страну.", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorsExist = true;
            }
            if(!errorsExist)
            {
                player.RoleID = ReturnRole();
                Controller.CreatePlayer(player);
                Owner.Enabled = true;
                this.Close();
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cybersportDBDataSet.Countries". При необходимости она может быть перемещена или удалена.
            this.countriesTableAdapter.Fill(this.cybersportDBDataSet.Countries);
            player.PlayerID = Guid.NewGuid();
            AsPlayerCheckBox.Checked = true;
        }        

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Enabled = true;
        }
        private Guid ReturnRole()
        {
            Guid checkedRoledID = new Guid();
            if(AsManagerCheckBox.Checked)
            {
                checkedRoledID = Controller.GetRoles().FirstOrDefault(role => role.Role1.Contains("Менеджер")).RoleID;
            }
            if (AsPlayerCheckBox.Checked)
            {
                checkedRoledID = Controller.GetRoles().FirstOrDefault(role => role.Role1.Contains("Игрок")).RoleID;
            }
            if (AsOrganizerCheckBox.Checked)
            {
                checkedRoledID = Controller.GetRoles().FirstOrDefault(role => role.Role1.Contains("Организатор")).RoleID;
            }
            return checkedRoledID;
        }

    }
}
