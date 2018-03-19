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
            
        }
    }
}
