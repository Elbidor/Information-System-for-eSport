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
        bool errorsExist = false;
        public Registration()
        {
            InitializeComponent();
        }
        private void OnTextboxClick (object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTextBox textBox = (MetroFramework.Controls.MetroTextBox)sender;
            textBox.SelectAll();
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
                player.Name = NameField.Text.Trim();
                player.Nickname = NicknameField.Text.Trim();
                player.Surname = SurnameField.Text.Trim();
                player.Password = PasswordField.Text.Trim();
                try
                {
                    player.Age = Convert.ToInt32(AgeField.Text);
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "Необходимо ввести положительное число в поле возраста", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorsExist = true;
                }
            }
            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(EmailField.Text);
                player.Email = EmailField.Text.Trim();
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

                if(Program.currentPlayer !=null)
                {
                    player.PlayerID = Program.currentPlayer.PlayerID;
                    player.RoleID = Program.currentPlayer.RoleID;
                    Controller.EditPlayer(player);                    
                }
                else
                {
                    player.RoleID = ReturnRole();
                    Controller.CreatePlayer(player);
                    Controller.SendEmail(player.Email, "registration");
                }      
                Program.currentPlayer = player;
                Owner.Enabled = true;
                Owner.Show();
                this.Close();                
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            CountryField.DataSource = Controller.GetCountries();
            if (Program.currentPlayer !=null)
            {
                NameField.Text = Program.currentPlayer.Name;
                SurnameField.Text = Program.currentPlayer.Surname;
                NicknameField.Text = Program.currentPlayer.Nickname;
                AgeField.Text = Program.currentPlayer.Age.ToString();
                CountryField.SelectedValue = Program.currentPlayer.CountryID;
                EmailField.Text = Program.currentPlayer.Email;
                PasswordField.Text = Program.currentPlayer.Password;
                AsManagerCheckBox.Visible = false;
                AsManagerCheckBox.Enabled = false;
                AsPlayerCheckBox.Visible = false;
                AsPlayerCheckBox.Enabled = false;
                AsOrganizerCheckBox.Visible = false;
                AsOrganizerCheckBox.Enabled = false;
            }
            else AsPlayerCheckBox.Checked = true;  
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

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Enabled = true;
            Owner.Show();
        }
    }
}
