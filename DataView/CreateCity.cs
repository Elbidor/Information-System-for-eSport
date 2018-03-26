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
    public partial class CreateCity : MetroFramework.Forms.MetroForm
    {
        bool errorsExist = false;
        City city = new City();
        public CreateCity()
        {
            InitializeComponent();
        }

        private void CreateCity_Load(object sender, EventArgs e)
        {
            CountryBox.DataSource = Controller.GetCountries();

        }
        private void OnTextboxClick(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTextBox textBox = (MetroFramework.Controls.MetroTextBox)sender;
            textBox.SelectAll();
        }

        private void CreateCity_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Enabled = true;
            Owner.Show();
        }

        private void AddCity_Click(object sender, EventArgs e)
        {
            try
            {
                city.CountryID = (int)CountryBox.SelectedValue; ;
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "Необходимо выбрать страну.", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorsExist = true;
            }
            if (string.IsNullOrWhiteSpace(CityNameField.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Необходимо ввести название чемпионата", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorsExist = true;
            }
            else
            {
                city.Name = CityNameField.Text;
            }
            if(!errorsExist)
            {
                city.CityID = Guid.NewGuid();
                Controller.CreateCity(city);
                Owner.Enabled = true;
                this.Close();
            }
        }
    }
}
