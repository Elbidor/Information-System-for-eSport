namespace Information_System_for_eSport
{
    partial class CreateChamp
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
            this.ChampNameField = new MetroFramework.Controls.MetroTextBox();
            this.CityField = new MetroFramework.Controls.MetroComboBox();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddCityButton = new MetroFramework.Controls.MetroLink();
            this.AcceptButton2 = new MetroFramework.Controls.MetroLink();
            this.TeamCountBox = new MetroFramework.Controls.MetroComboBox();
            this.TeamBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ChampStartDate = new MetroFramework.Controls.MetroDateTime();
            this.ChampFinishDate = new MetroFramework.Controls.MetroDateTime();
            this.MoneyField = new MetroFramework.Controls.MetroTextBox();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TeamBox2 = new MetroFramework.Controls.MetroComboBox();
            this.TeamBox3 = new MetroFramework.Controls.MetroComboBox();
            this.TeamBox4 = new MetroFramework.Controls.MetroComboBox();
            this.TeamBox5 = new MetroFramework.Controls.MetroComboBox();
            this.TeamBox6 = new MetroFramework.Controls.MetroComboBox();
            this.TeamBox7 = new MetroFramework.Controls.MetroComboBox();
            this.TeamBox8 = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ChampNameField
            // 
            // 
            // 
            // 
            this.ChampNameField.CustomButton.Image = null;
            this.ChampNameField.CustomButton.Location = new System.Drawing.Point(248, 2);
            this.ChampNameField.CustomButton.Name = "";
            this.ChampNameField.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.ChampNameField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ChampNameField.CustomButton.TabIndex = 1;
            this.ChampNameField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ChampNameField.CustomButton.UseSelectable = true;
            this.ChampNameField.CustomButton.Visible = false;
            this.ChampNameField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.ChampNameField.Lines = new string[] {
        "Название турнира"};
            this.ChampNameField.Location = new System.Drawing.Point(23, 75);
            this.ChampNameField.MaxLength = 32767;
            this.ChampNameField.Name = "ChampNameField";
            this.ChampNameField.PasswordChar = '\0';
            this.ChampNameField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ChampNameField.SelectedText = "";
            this.ChampNameField.SelectionLength = 0;
            this.ChampNameField.SelectionStart = 0;
            this.ChampNameField.ShortcutsEnabled = true;
            this.ChampNameField.Size = new System.Drawing.Size(282, 36);
            this.ChampNameField.TabIndex = 1;
            this.ChampNameField.Text = "Название турнира";
            this.ChampNameField.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ChampNameField.UseSelectable = true;
            this.ChampNameField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ChampNameField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ChampNameField.Click += new System.EventHandler(this.OnTextboxClick);
            // 
            // CityField
            // 
            this.CityField.BackColor = System.Drawing.SystemColors.MenuBar;
            this.CityField.DataSource = this.cityBindingSource;
            this.CityField.DisplayMember = "Name";
            this.CityField.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CityField.FormattingEnabled = true;
            this.CityField.ItemHeight = 24;
            this.CityField.Location = new System.Drawing.Point(23, 126);
            this.CityField.Name = "CityField";
            this.CityField.Size = new System.Drawing.Size(154, 30);
            this.CityField.TabIndex = 19;
            this.CityField.Tag = "Страна";
            this.CityField.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CityField.UseSelectable = true;
            this.CityField.ValueMember = "CityID";
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(DataModel.City);
            // 
            // AddCityButton
            // 
            this.AddCityButton.Image = global::Information_System_for_eSport.Properties.Resources.add;
            this.AddCityButton.ImageSize = 20;
            this.AddCityButton.Location = new System.Drawing.Point(183, 126);
            this.AddCityButton.Name = "AddCityButton";
            this.AddCityButton.Size = new System.Drawing.Size(28, 30);
            this.AddCityButton.TabIndex = 20;
            this.AddCityButton.UseSelectable = true;
            this.AddCityButton.Click += new System.EventHandler(this.AddCityButton_Click);
            // 
            // AcceptButton2
            // 
            this.AcceptButton2.Image = global::Information_System_for_eSport.Properties.Resources.security;
            this.AcceptButton2.ImageSize = 90;
            this.AcceptButton2.Location = new System.Drawing.Point(366, 248);
            this.AcceptButton2.Name = "AcceptButton2";
            this.AcceptButton2.Size = new System.Drawing.Size(118, 129);
            this.AcceptButton2.TabIndex = 18;
            this.AcceptButton2.UseSelectable = true;
            this.AcceptButton2.Click += new System.EventHandler(this.AcceptButton2_Click);
            // 
            // TeamCountBox
            // 
            this.TeamCountBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TeamCountBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TeamCountBox.FormattingEnabled = true;
            this.TeamCountBox.ItemHeight = 24;
            this.TeamCountBox.Location = new System.Drawing.Point(252, 126);
            this.TeamCountBox.Name = "TeamCountBox";
            this.TeamCountBox.Size = new System.Drawing.Size(53, 30);
            this.TeamCountBox.TabIndex = 21;
            this.TeamCountBox.Tag = "Страна";
            this.TeamCountBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TeamCountBox.UseSelectable = true;
            this.TeamCountBox.SelectionChangeCommitted += new System.EventHandler(this.TeamCountBox_SelectionChangeCommitted);
            // 
            // TeamBox1
            // 
            this.TeamBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TeamBox1.DataSource = this.teamBindingSource;
            this.TeamBox1.DisplayMember = "Name";
            this.TeamBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TeamBox1.FormattingEnabled = true;
            this.TeamBox1.ItemHeight = 24;
            this.TeamBox1.Location = new System.Drawing.Point(23, 239);
            this.TeamBox1.Name = "TeamBox1";
            this.TeamBox1.Size = new System.Drawing.Size(154, 30);
            this.TeamBox1.TabIndex = 22;
            this.TeamBox1.Tag = "Страна";
            this.TeamBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TeamBox1.UseSelectable = true;
            this.TeamBox1.ValueMember = "TeamID";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(24, 213);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(145, 20);
            this.metroLabel1.TabIndex = 30;
            this.metroLabel1.Text = "Выберите команды";
            // 
            // ChampStartDate
            // 
            this.ChampStartDate.Location = new System.Drawing.Point(323, 75);
            this.ChampStartDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.ChampStartDate.Name = "ChampStartDate";
            this.ChampStartDate.Size = new System.Drawing.Size(161, 30);
            this.ChampStartDate.TabIndex = 31;
            // 
            // ChampFinishDate
            // 
            this.ChampFinishDate.Location = new System.Drawing.Point(323, 126);
            this.ChampFinishDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.ChampFinishDate.Name = "ChampFinishDate";
            this.ChampFinishDate.Size = new System.Drawing.Size(161, 30);
            this.ChampFinishDate.TabIndex = 32;
            // 
            // MoneyField
            // 
            // 
            // 
            // 
            this.MoneyField.CustomButton.Image = null;
            this.MoneyField.CustomButton.Location = new System.Drawing.Point(248, 2);
            this.MoneyField.CustomButton.Name = "";
            this.MoneyField.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.MoneyField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MoneyField.CustomButton.TabIndex = 1;
            this.MoneyField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MoneyField.CustomButton.UseSelectable = true;
            this.MoneyField.CustomButton.Visible = false;
            this.MoneyField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.MoneyField.Lines = new string[] {
        "Призовой фонд"};
            this.MoneyField.Location = new System.Drawing.Point(23, 162);
            this.MoneyField.MaxLength = 32767;
            this.MoneyField.Name = "MoneyField";
            this.MoneyField.PasswordChar = '\0';
            this.MoneyField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MoneyField.SelectedText = "";
            this.MoneyField.SelectionLength = 0;
            this.MoneyField.SelectionStart = 0;
            this.MoneyField.ShortcutsEnabled = true;
            this.MoneyField.Size = new System.Drawing.Size(282, 36);
            this.MoneyField.TabIndex = 33;
            this.MoneyField.Text = "Призовой фонд";
            this.MoneyField.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MoneyField.UseSelectable = true;
            this.MoneyField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MoneyField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.MoneyField.Click += new System.EventHandler(this.OnTextboxClick);
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataSource = typeof(DataModel.Team);
            // 
            // TeamBox2
            // 
            this.TeamBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TeamBox2.DataSource = this.teamBindingSource;
            this.TeamBox2.DisplayMember = "Name";
            this.TeamBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TeamBox2.FormattingEnabled = true;
            this.TeamBox2.ItemHeight = 24;
            this.TeamBox2.Location = new System.Drawing.Point(183, 239);
            this.TeamBox2.Name = "TeamBox2";
            this.TeamBox2.Size = new System.Drawing.Size(154, 30);
            this.TeamBox2.TabIndex = 34;
            this.TeamBox2.Tag = "Страна";
            this.TeamBox2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TeamBox2.UseSelectable = true;
            this.TeamBox2.ValueMember = "TeamID";
            // 
            // TeamBox3
            // 
            this.TeamBox3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TeamBox3.DataSource = this.teamBindingSource;
            this.TeamBox3.DisplayMember = "Name";
            this.TeamBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TeamBox3.FormattingEnabled = true;
            this.TeamBox3.ItemHeight = 24;
            this.TeamBox3.Location = new System.Drawing.Point(23, 275);
            this.TeamBox3.Name = "TeamBox3";
            this.TeamBox3.Size = new System.Drawing.Size(154, 30);
            this.TeamBox3.TabIndex = 35;
            this.TeamBox3.Tag = "Страна";
            this.TeamBox3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TeamBox3.UseSelectable = true;
            this.TeamBox3.ValueMember = "TeamID";
            // 
            // TeamBox4
            // 
            this.TeamBox4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TeamBox4.DataSource = this.teamBindingSource;
            this.TeamBox4.DisplayMember = "Name";
            this.TeamBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TeamBox4.FormattingEnabled = true;
            this.TeamBox4.ItemHeight = 24;
            this.TeamBox4.Location = new System.Drawing.Point(183, 275);
            this.TeamBox4.Name = "TeamBox4";
            this.TeamBox4.Size = new System.Drawing.Size(154, 30);
            this.TeamBox4.TabIndex = 36;
            this.TeamBox4.Tag = "Страна";
            this.TeamBox4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TeamBox4.UseSelectable = true;
            this.TeamBox4.ValueMember = "TeamID";
            // 
            // TeamBox5
            // 
            this.TeamBox5.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TeamBox5.DataSource = this.teamBindingSource;
            this.TeamBox5.DisplayMember = "Name";
            this.TeamBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TeamBox5.FormattingEnabled = true;
            this.TeamBox5.ItemHeight = 24;
            this.TeamBox5.Location = new System.Drawing.Point(23, 311);
            this.TeamBox5.Name = "TeamBox5";
            this.TeamBox5.Size = new System.Drawing.Size(154, 30);
            this.TeamBox5.TabIndex = 37;
            this.TeamBox5.Tag = "Страна";
            this.TeamBox5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TeamBox5.UseSelectable = true;
            this.TeamBox5.ValueMember = "TeamID";
            // 
            // TeamBox6
            // 
            this.TeamBox6.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TeamBox6.DataSource = this.teamBindingSource;
            this.TeamBox6.DisplayMember = "Name";
            this.TeamBox6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TeamBox6.FormattingEnabled = true;
            this.TeamBox6.ItemHeight = 24;
            this.TeamBox6.Location = new System.Drawing.Point(183, 311);
            this.TeamBox6.Name = "TeamBox6";
            this.TeamBox6.Size = new System.Drawing.Size(154, 30);
            this.TeamBox6.TabIndex = 38;
            this.TeamBox6.Tag = "Страна";
            this.TeamBox6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TeamBox6.UseSelectable = true;
            this.TeamBox6.ValueMember = "TeamID";
            // 
            // TeamBox7
            // 
            this.TeamBox7.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TeamBox7.DataSource = this.teamBindingSource;
            this.TeamBox7.DisplayMember = "Name";
            this.TeamBox7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TeamBox7.FormattingEnabled = true;
            this.TeamBox7.ItemHeight = 24;
            this.TeamBox7.Location = new System.Drawing.Point(24, 347);
            this.TeamBox7.Name = "TeamBox7";
            this.TeamBox7.Size = new System.Drawing.Size(154, 30);
            this.TeamBox7.TabIndex = 39;
            this.TeamBox7.Tag = "Страна";
            this.TeamBox7.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TeamBox7.UseSelectable = true;
            this.TeamBox7.ValueMember = "TeamID";
            // 
            // TeamBox8
            // 
            this.TeamBox8.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TeamBox8.DataSource = this.teamBindingSource;
            this.TeamBox8.DisplayMember = "Name";
            this.TeamBox8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TeamBox8.FormattingEnabled = true;
            this.TeamBox8.ItemHeight = 24;
            this.TeamBox8.Location = new System.Drawing.Point(183, 347);
            this.TeamBox8.Name = "TeamBox8";
            this.TeamBox8.Size = new System.Drawing.Size(154, 30);
            this.TeamBox8.TabIndex = 40;
            this.TeamBox8.Tag = "Страна";
            this.TeamBox8.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TeamBox8.UseSelectable = true;
            this.TeamBox8.ValueMember = "TeamID";
            // 
            // CreateChamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 394);
            this.Controls.Add(this.TeamBox8);
            this.Controls.Add(this.TeamBox7);
            this.Controls.Add(this.TeamBox6);
            this.Controls.Add(this.TeamBox5);
            this.Controls.Add(this.TeamBox4);
            this.Controls.Add(this.TeamBox3);
            this.Controls.Add(this.TeamBox2);
            this.Controls.Add(this.MoneyField);
            this.Controls.Add(this.ChampFinishDate);
            this.Controls.Add(this.ChampStartDate);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.TeamBox1);
            this.Controls.Add(this.TeamCountBox);
            this.Controls.Add(this.AddCityButton);
            this.Controls.Add(this.CityField);
            this.Controls.Add(this.AcceptButton2);
            this.Controls.Add(this.ChampNameField);
            this.Name = "CreateChamp";
            this.Text = "Создать турнир";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateChamp_FormClosed);
            this.Load += new System.EventHandler(this.CreateChamp_Load);
            this.EnabledChanged += new System.EventHandler(this.CreateChamp_EnabledChanged);
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox ChampNameField;
        private MetroFramework.Controls.MetroLink AcceptButton2;
        private MetroFramework.Controls.MetroComboBox CityField;
        private MetroFramework.Controls.MetroLink AddCityButton;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private MetroFramework.Controls.MetroComboBox TeamCountBox;
        private MetroFramework.Controls.MetroComboBox TeamBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime ChampStartDate;
        private MetroFramework.Controls.MetroDateTime ChampFinishDate;
        private MetroFramework.Controls.MetroTextBox MoneyField;
        private System.Windows.Forms.BindingSource teamBindingSource;
        private MetroFramework.Controls.MetroComboBox TeamBox2;
        private MetroFramework.Controls.MetroComboBox TeamBox3;
        private MetroFramework.Controls.MetroComboBox TeamBox4;
        private MetroFramework.Controls.MetroComboBox TeamBox5;
        private MetroFramework.Controls.MetroComboBox TeamBox6;
        private MetroFramework.Controls.MetroComboBox TeamBox7;
        private MetroFramework.Controls.MetroComboBox TeamBox8;
    }
}