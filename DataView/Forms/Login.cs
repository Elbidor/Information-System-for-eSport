using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataController;
using DataModel;

namespace Information_System_for_eSport.Forms
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(EmailField.Text);
                if (string.IsNullOrWhiteSpace(PasswordField.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Заполните поле пароля.", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Program.currentPlayer = Controller.FindPlayer(EmailField.Text, PasswordField.Text);
                    if(Program.currentPlayer != null)
                    {
                        Owner.Enabled = true;
                        this.Close();
                        try
                        {
                            Controller.SendEmail(Program.currentPlayer.Email, "login");
                        }
                        catch
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Не удалось отправить сообщение, возможно отсутствует подключение к интернету.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else MetroFramework.MetroMessageBox.Show(this, "Неправильно введен логин/пароль.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "Необходимо правильно ввести почту", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void OnTextboxClick(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTextBox textBox = (MetroFramework.Controls.MetroTextBox)sender;
            textBox.SelectAll();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Enabled = true;
        }
    }
}
