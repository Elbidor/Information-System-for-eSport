namespace Information_System_for_eSport
{
    partial class Registration
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
            this.NameField = new MetroFramework.Controls.MetroTextBox();
            this.NicknameField = new MetroFramework.Controls.MetroTextBox();
            this.SurnameField = new MetroFramework.Controls.MetroTextBox();
            this.CountryField = new MetroFramework.Controls.MetroComboBox();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cybersportDBDataSet2 = new Information_System_for_eSport.CybersportDBDataSet2();
            this.EmailField = new MetroFramework.Controls.MetroTextBox();
            this.PasswordField = new MetroFramework.Controls.MetroTextBox();
            this.AgeField = new MetroFramework.Controls.MetroTextBox();
            this.AsPlayerCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.AsManagerCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.AsOrganizerCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.countriesTableAdapter = new Information_System_for_eSport.CybersportDBDataSet2TableAdapters.CountriesTableAdapter();
            this.AcceptButton1 = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cybersportDBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // NameField
            // 
            // 
            // 
            // 
            this.NameField.CustomButton.Image = null;
            this.NameField.CustomButton.Location = new System.Drawing.Point(206, 2);
            this.NameField.CustomButton.Name = "";
            this.NameField.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.NameField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NameField.CustomButton.TabIndex = 1;
            this.NameField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NameField.CustomButton.UseSelectable = true;
            this.NameField.CustomButton.Visible = false;
            this.NameField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.NameField.Lines = new string[] {
        "Ваше имя"};
            this.NameField.Location = new System.Drawing.Point(25, 104);
            this.NameField.MaxLength = 32767;
            this.NameField.Name = "NameField";
            this.NameField.PasswordChar = '\0';
            this.NameField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NameField.SelectedText = "";
            this.NameField.SelectionLength = 0;
            this.NameField.SelectionStart = 0;
            this.NameField.ShortcutsEnabled = true;
            this.NameField.Size = new System.Drawing.Size(240, 36);
            this.NameField.TabIndex = 0;
            this.NameField.Text = "Ваше имя";
            this.NameField.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NameField.UseSelectable = true;
            this.NameField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NameField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.NameField.Click += new System.EventHandler(this.OnTextboxClick);
            // 
            // NicknameField
            // 
            // 
            // 
            // 
            this.NicknameField.CustomButton.Image = null;
            this.NicknameField.CustomButton.Location = new System.Drawing.Point(206, 2);
            this.NicknameField.CustomButton.Name = "";
            this.NicknameField.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.NicknameField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NicknameField.CustomButton.TabIndex = 1;
            this.NicknameField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NicknameField.CustomButton.UseSelectable = true;
            this.NicknameField.CustomButton.Visible = false;
            this.NicknameField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.NicknameField.Lines = new string[] {
        "Ваш никнейм"};
            this.NicknameField.Location = new System.Drawing.Point(25, 154);
            this.NicknameField.MaxLength = 32767;
            this.NicknameField.Name = "NicknameField";
            this.NicknameField.PasswordChar = '\0';
            this.NicknameField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NicknameField.SelectedText = "";
            this.NicknameField.SelectionLength = 0;
            this.NicknameField.SelectionStart = 0;
            this.NicknameField.ShortcutsEnabled = true;
            this.NicknameField.Size = new System.Drawing.Size(240, 36);
            this.NicknameField.TabIndex = 3;
            this.NicknameField.Text = "Ваш никнейм";
            this.NicknameField.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NicknameField.UseSelectable = true;
            this.NicknameField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NicknameField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.NicknameField.Click += new System.EventHandler(this.OnTextboxClick);
            // 
            // SurnameField
            // 
            // 
            // 
            // 
            this.SurnameField.CustomButton.Image = null;
            this.SurnameField.CustomButton.Location = new System.Drawing.Point(206, 2);
            this.SurnameField.CustomButton.Name = "";
            this.SurnameField.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.SurnameField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SurnameField.CustomButton.TabIndex = 1;
            this.SurnameField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SurnameField.CustomButton.UseSelectable = true;
            this.SurnameField.CustomButton.Visible = false;
            this.SurnameField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.SurnameField.Lines = new string[] {
        "Ваша фамилия"};
            this.SurnameField.Location = new System.Drawing.Point(25, 204);
            this.SurnameField.MaxLength = 32767;
            this.SurnameField.Name = "SurnameField";
            this.SurnameField.PasswordChar = '\0';
            this.SurnameField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SurnameField.SelectedText = "";
            this.SurnameField.SelectionLength = 0;
            this.SurnameField.SelectionStart = 0;
            this.SurnameField.ShortcutsEnabled = true;
            this.SurnameField.Size = new System.Drawing.Size(240, 36);
            this.SurnameField.TabIndex = 4;
            this.SurnameField.Text = "Ваша фамилия";
            this.SurnameField.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SurnameField.UseSelectable = true;
            this.SurnameField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SurnameField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SurnameField.Click += new System.EventHandler(this.OnTextboxClick);
            // 
            // CountryField
            // 
            this.CountryField.BackColor = System.Drawing.SystemColors.MenuBar;
            this.CountryField.DataSource = this.countriesBindingSource;
            this.CountryField.DisplayMember = "Country";
            this.CountryField.FormattingEnabled = true;
            this.CountryField.ItemHeight = 24;
            this.CountryField.Location = new System.Drawing.Point(25, 254);
            this.CountryField.Name = "CountryField";
            this.CountryField.Size = new System.Drawing.Size(240, 30);
            this.CountryField.Style = MetroFramework.MetroColorStyle.Green;
            this.CountryField.TabIndex = 5;
            this.CountryField.Tag = "Страна";
            this.CountryField.UseSelectable = true;
            this.CountryField.ValueMember = "CountryID";
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "Countries";
            this.countriesBindingSource.DataSource = this.cybersportDBDataSet2;
            // 
            // cybersportDBDataSet2
            // 
            this.cybersportDBDataSet2.DataSetName = "CybersportDBDataSet2";
            this.cybersportDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EmailField
            // 
            // 
            // 
            // 
            this.EmailField.CustomButton.Image = null;
            this.EmailField.CustomButton.Location = new System.Drawing.Point(206, 2);
            this.EmailField.CustomButton.Name = "";
            this.EmailField.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.EmailField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.EmailField.CustomButton.TabIndex = 1;
            this.EmailField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.EmailField.CustomButton.UseSelectable = true;
            this.EmailField.CustomButton.Visible = false;
            this.EmailField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.EmailField.Lines = new string[] {
        "Ваш email"};
            this.EmailField.Location = new System.Drawing.Point(325, 104);
            this.EmailField.MaxLength = 32767;
            this.EmailField.Name = "EmailField";
            this.EmailField.PasswordChar = '\0';
            this.EmailField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EmailField.SelectedText = "";
            this.EmailField.SelectionLength = 0;
            this.EmailField.SelectionStart = 0;
            this.EmailField.ShortcutsEnabled = true;
            this.EmailField.Size = new System.Drawing.Size(240, 36);
            this.EmailField.TabIndex = 8;
            this.EmailField.Text = "Ваш email";
            this.EmailField.Theme = MetroFramework.MetroThemeStyle.Light;
            this.EmailField.UseSelectable = true;
            this.EmailField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EmailField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.EmailField.Click += new System.EventHandler(this.OnTextboxClick);
            // 
            // PasswordField
            // 
            // 
            // 
            // 
            this.PasswordField.CustomButton.Image = null;
            this.PasswordField.CustomButton.Location = new System.Drawing.Point(206, 2);
            this.PasswordField.CustomButton.Name = "";
            this.PasswordField.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.PasswordField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PasswordField.CustomButton.TabIndex = 1;
            this.PasswordField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasswordField.CustomButton.UseSelectable = true;
            this.PasswordField.CustomButton.Visible = false;
            this.PasswordField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.PasswordField.Lines = new string[] {
        "Ваш пароль"};
            this.PasswordField.Location = new System.Drawing.Point(325, 154);
            this.PasswordField.MaxLength = 32767;
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '*';
            this.PasswordField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordField.SelectedText = "";
            this.PasswordField.SelectionLength = 0;
            this.PasswordField.SelectionStart = 0;
            this.PasswordField.ShortcutsEnabled = true;
            this.PasswordField.Size = new System.Drawing.Size(240, 36);
            this.PasswordField.TabIndex = 9;
            this.PasswordField.Text = "Ваш пароль";
            this.PasswordField.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasswordField.UseSelectable = true;
            this.PasswordField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PasswordField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PasswordField.Click += new System.EventHandler(this.OnTextboxClick);
            // 
            // AgeField
            // 
            // 
            // 
            // 
            this.AgeField.CustomButton.Image = null;
            this.AgeField.CustomButton.Location = new System.Drawing.Point(206, 2);
            this.AgeField.CustomButton.Name = "";
            this.AgeField.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.AgeField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AgeField.CustomButton.TabIndex = 1;
            this.AgeField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AgeField.CustomButton.UseSelectable = true;
            this.AgeField.CustomButton.Visible = false;
            this.AgeField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.AgeField.Lines = new string[] {
        "Ваш возраст"};
            this.AgeField.Location = new System.Drawing.Point(25, 299);
            this.AgeField.MaxLength = 32767;
            this.AgeField.Name = "AgeField";
            this.AgeField.PasswordChar = '\0';
            this.AgeField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AgeField.SelectedText = "";
            this.AgeField.SelectionLength = 0;
            this.AgeField.SelectionStart = 0;
            this.AgeField.ShortcutsEnabled = true;
            this.AgeField.Size = new System.Drawing.Size(240, 36);
            this.AgeField.TabIndex = 13;
            this.AgeField.Text = "Ваш возраст";
            this.AgeField.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AgeField.UseSelectable = true;
            this.AgeField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AgeField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.AgeField.Click += new System.EventHandler(this.OnTextboxClick);
            // 
            // AsPlayerCheckBox
            // 
            this.AsPlayerCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.AsPlayerCheckBox.Location = new System.Drawing.Point(325, 204);
            this.AsPlayerCheckBox.Name = "AsPlayerCheckBox";
            this.AsPlayerCheckBox.Size = new System.Drawing.Size(240, 34);
            this.AsPlayerCheckBox.TabIndex = 14;
            this.AsPlayerCheckBox.Text = "Как игрок";
            this.AsPlayerCheckBox.UseSelectable = true;
            this.AsPlayerCheckBox.Click += new System.EventHandler(this.OnRadioButtonClick);
            // 
            // AsManagerCheckBox
            // 
            this.AsManagerCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.AsManagerCheckBox.Location = new System.Drawing.Point(325, 254);
            this.AsManagerCheckBox.Name = "AsManagerCheckBox";
            this.AsManagerCheckBox.Size = new System.Drawing.Size(240, 30);
            this.AsManagerCheckBox.TabIndex = 15;
            this.AsManagerCheckBox.Text = "Как менеджер";
            this.AsManagerCheckBox.UseSelectable = true;
            this.AsManagerCheckBox.Click += new System.EventHandler(this.OnRadioButtonClick);
            // 
            // AsOrganizerCheckBox
            // 
            this.AsOrganizerCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.AsOrganizerCheckBox.Location = new System.Drawing.Point(325, 299);
            this.AsOrganizerCheckBox.Name = "AsOrganizerCheckBox";
            this.AsOrganizerCheckBox.Size = new System.Drawing.Size(240, 34);
            this.AsOrganizerCheckBox.TabIndex = 16;
            this.AsOrganizerCheckBox.Text = "Как организатор";
            this.AsOrganizerCheckBox.UseSelectable = true;
            this.AsOrganizerCheckBox.Click += new System.EventHandler(this.OnRadioButtonClick);
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // AcceptButton1
            // 
            this.AcceptButton1.Image = global::Information_System_for_eSport.Properties.Resources.security;
            this.AcceptButton1.ImageSize = 90;
            this.AcceptButton1.Location = new System.Drawing.Point(492, 204);
            this.AcceptButton1.Name = "AcceptButton1";
            this.AcceptButton1.Size = new System.Drawing.Size(118, 129);
            this.AcceptButton1.TabIndex = 17;
            this.AcceptButton1.UseSelectable = true;
            this.AcceptButton1.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(640, 357);
            this.Controls.Add(this.AcceptButton1);
            this.Controls.Add(this.AsOrganizerCheckBox);
            this.Controls.Add(this.AsManagerCheckBox);
            this.Controls.Add(this.AsPlayerCheckBox);
            this.Controls.Add(this.AgeField);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.EmailField);
            this.Controls.Add(this.CountryField);
            this.Controls.Add(this.SurnameField);
            this.Controls.Add(this.NicknameField);
            this.Controls.Add(this.NameField);
            this.Name = "Registration";
            this.Resizable = false;
            this.Text = "Регистрация нового пользователя";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registration_FormClosed);
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cybersportDBDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox NameField;
        private MetroFramework.Controls.MetroTextBox NicknameField;
        private MetroFramework.Controls.MetroTextBox SurnameField;
        private MetroFramework.Controls.MetroComboBox CountryField;
        private MetroFramework.Controls.MetroTextBox EmailField;
        private MetroFramework.Controls.MetroTextBox PasswordField;
        private MetroFramework.Controls.MetroTextBox AgeField;
        private MetroFramework.Controls.MetroCheckBox AsPlayerCheckBox;
        private MetroFramework.Controls.MetroCheckBox AsManagerCheckBox;
        private MetroFramework.Controls.MetroCheckBox AsOrganizerCheckBox;
        private CybersportDBDataSet2 cybersportDBDataSet2;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private CybersportDBDataSet2TableAdapters.CountriesTableAdapter countriesTableAdapter;
        private MetroFramework.Controls.MetroLink AcceptButton1;
    }
}