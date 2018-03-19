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
                    MetroFramework.MetroMessageBox.Show(this, "Необходимо заполнить все поля.", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Program.currentPlayer = Controller.FindPlayer(EmailField.Text, PasswordField.Text);
                }
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "Необходимо правильно ввести почту", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
