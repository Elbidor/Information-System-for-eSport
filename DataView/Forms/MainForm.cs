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
                NicknameLabel.Visible = true;
                NicknameLabel.Text = Program.currentPlayer.Nickname;
                metroLabel1.Visible = false;
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
            }
        }
    }
}
