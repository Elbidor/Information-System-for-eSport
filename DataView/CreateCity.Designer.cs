namespace Information_System_for_eSport
{
    partial class CreateCity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CountryBox = new MetroFramework.Controls.MetroComboBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CityNameField = new MetroFramework.Controls.MetroTextBox();
            this.AddCity = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CountryBox
            // 
            this.CountryBox.DataSource = this.countryBindingSource;
            this.CountryBox.DisplayMember = "Country1";
            this.CountryBox.FormattingEnabled = true;
            this.CountryBox.ItemHeight = 24;
            this.CountryBox.Location = new System.Drawing.Point(24, 83);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(301, 30);
            this.CountryBox.TabIndex = 0;
            this.CountryBox.UseSelectable = true;
            this.CountryBox.ValueMember = "CountryID";
            this.CountryBox.Click += new System.EventHandler(this.OnTextboxClick);
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataSource = typeof(DataModel.Country);
            // 
            // CityNameField
            // 
            // 
            // 
            // 
            this.CityNameField.CustomButton.Image = null;
            this.CityNameField.CustomButton.Location = new System.Drawing.Point(267, 2);
            this.CityNameField.CustomButton.Name = "";
            this.CityNameField.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.CityNameField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CityNameField.CustomButton.TabIndex = 1;
            this.CityNameField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CityNameField.CustomButton.UseSelectable = true;
            this.CityNameField.CustomButton.Visible = false;
            this.CityNameField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.CityNameField.Lines = new string[] {
        "Название города"};
            this.CityNameField.Location = new System.Drawing.Point(24, 131);
            this.CityNameField.MaxLength = 32767;
            this.CityNameField.Name = "CityNameField";
            this.CityNameField.PasswordChar = '\0';
            this.CityNameField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CityNameField.SelectedText = "";
            this.CityNameField.SelectionLength = 0;
            this.CityNameField.SelectionStart = 0;
            this.CityNameField.ShortcutsEnabled = true;
            this.CityNameField.Size = new System.Drawing.Size(301, 36);
            this.CityNameField.TabIndex = 2;
            this.CityNameField.Text = "Название города";
            this.CityNameField.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CityNameField.UseSelectable = true;
            this.CityNameField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CityNameField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.CityNameField.Click += new System.EventHandler(this.OnTextboxClick);
            // 
            // AddCity
            // 
            this.AddCity.ActiveControl = null;
            this.AddCity.Location = new System.Drawing.Point(24, 199);
            this.AddCity.Name = "AddCity";
            this.AddCity.Size = new System.Drawing.Size(301, 62);
            this.AddCity.TabIndex = 3;
            this.AddCity.Text = "Добавить";
            this.AddCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddCity.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.AddCity.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.AddCity.UseSelectable = true;
            this.AddCity.Click += new System.EventHandler(this.AddCity_Click);
            // 
            // CreateCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 284);
            this.Controls.Add(this.AddCity);
            this.Controls.Add(this.CityNameField);
            this.Controls.Add(this.CountryBox);
            this.Name = "CreateCity";
            this.Text = "Добавить город";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateCity_FormClosed);
            this.Load += new System.EventHandler(this.CreateCity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox CountryBox;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private MetroFramework.Controls.MetroTextBox CityNameField;
        private MetroFramework.Controls.MetroTile AddCity;
    }
}