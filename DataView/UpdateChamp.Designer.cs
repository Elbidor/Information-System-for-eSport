namespace Information_System_for_eSport
{
    partial class UpdateChamp
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
            this.ChooseChampBox = new MetroFramework.Controls.MetroComboBox();
            this.tournamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChangeInfoPanel = new MetroFramework.Controls.MetroPanel();
            this.AcceptChanges = new MetroFramework.Controls.MetroTile();
            this.ChampFinishDate = new MetroFramework.Controls.MetroDateTime();
            this.ChampStartDate = new MetroFramework.Controls.MetroDateTime();
            this.MoneyField = new MetroFramework.Controls.MetroTextBox();
            this.AddCityButton = new MetroFramework.Controls.MetroLink();
            this.CityField = new MetroFramework.Controls.MetroComboBox();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChampNameField = new MetroFramework.Controls.MetroTextBox();
            this.ChangePlacesPanel = new MetroFramework.Controls.MetroPanel();
            this.Prize8 = new MetroFramework.Controls.MetroTextBox();
            this.Prize7 = new MetroFramework.Controls.MetroTextBox();
            this.Prize6 = new MetroFramework.Controls.MetroTextBox();
            this.Prize5 = new MetroFramework.Controls.MetroTextBox();
            this.Prize4 = new MetroFramework.Controls.MetroTextBox();
            this.Prize3 = new MetroFramework.Controls.MetroTextBox();
            this.Prize2 = new MetroFramework.Controls.MetroTextBox();
            this.Prize1 = new MetroFramework.Controls.MetroTextBox();
            this.AcceptPrizes = new MetroFramework.Controls.MetroTile();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Team8 = new MetroFramework.Controls.MetroComboBox();
            this.Team7 = new MetroFramework.Controls.MetroComboBox();
            this.Team6 = new MetroFramework.Controls.MetroComboBox();
            this.Team5 = new MetroFramework.Controls.MetroComboBox();
            this.Team4 = new MetroFramework.Controls.MetroComboBox();
            this.Team3 = new MetroFramework.Controls.MetroComboBox();
            this.Team2 = new MetroFramework.Controls.MetroComboBox();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.Team1 = new MetroFramework.Controls.MetroComboBox();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddMatchPanel = new MetroFramework.Controls.MetroPanel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.Set5Box2 = new MetroFramework.Controls.MetroComboBox();
            this.Set5Box1 = new MetroFramework.Controls.MetroComboBox();
            this.Set4Box2 = new MetroFramework.Controls.MetroComboBox();
            this.Set4Box1 = new MetroFramework.Controls.MetroComboBox();
            this.Set3Box2 = new MetroFramework.Controls.MetroComboBox();
            this.Set3Box1 = new MetroFramework.Controls.MetroComboBox();
            this.Set2Box2 = new MetroFramework.Controls.MetroComboBox();
            this.Set2Box1 = new MetroFramework.Controls.MetroComboBox();
            this.Set1Box2 = new MetroFramework.Controls.MetroComboBox();
            this.Map5Box = new MetroFramework.Controls.MetroComboBox();
            this.mapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Map4Box = new MetroFramework.Controls.MetroComboBox();
            this.SetsCountBox = new MetroFramework.Controls.MetroComboBox();
            this.Map3Box = new MetroFramework.Controls.MetroComboBox();
            this.Map1Box = new MetroFramework.Controls.MetroComboBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.Set1Box1 = new MetroFramework.Controls.MetroComboBox();
            this.Map2Box = new MetroFramework.Controls.MetroComboBox();
            this.TeamBox2 = new MetroFramework.Controls.MetroComboBox();
            this.participantBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.TeamBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.participantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tournamentBindingSource)).BeginInit();
            this.ChangeInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            this.ChangePlacesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            this.AddMatchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ChooseChampBox
            // 
            this.ChooseChampBox.DataSource = this.tournamentBindingSource;
            this.ChooseChampBox.DisplayMember = "Name";
            this.ChooseChampBox.FormattingEnabled = true;
            this.ChooseChampBox.ItemHeight = 24;
            this.ChooseChampBox.Location = new System.Drawing.Point(27, 103);
            this.ChooseChampBox.Name = "ChooseChampBox";
            this.ChooseChampBox.Size = new System.Drawing.Size(282, 30);
            this.ChooseChampBox.TabIndex = 0;
            this.ChooseChampBox.UseSelectable = true;
            this.ChooseChampBox.ValueMember = "TournamentID";
            this.ChooseChampBox.SelectionChangeCommitted += new System.EventHandler(this.ChooseChampBox_SelectionChangeCommitted);
            // 
            // tournamentBindingSource
            // 
            this.tournamentBindingSource.DataSource = typeof(DataModel.Tournament);
            // 
            // ChangeInfoPanel
            // 
            this.ChangeInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChangeInfoPanel.Controls.Add(this.AcceptChanges);
            this.ChangeInfoPanel.Controls.Add(this.ChampFinishDate);
            this.ChangeInfoPanel.Controls.Add(this.ChampStartDate);
            this.ChangeInfoPanel.Controls.Add(this.MoneyField);
            this.ChangeInfoPanel.Controls.Add(this.AddCityButton);
            this.ChangeInfoPanel.Controls.Add(this.CityField);
            this.ChangeInfoPanel.Controls.Add(this.ChampNameField);
            this.ChangeInfoPanel.Enabled = false;
            this.ChangeInfoPanel.HorizontalScrollbarBarColor = true;
            this.ChangeInfoPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ChangeInfoPanel.HorizontalScrollbarSize = 10;
            this.ChangeInfoPanel.Location = new System.Drawing.Point(23, 143);
            this.ChangeInfoPanel.Name = "ChangeInfoPanel";
            this.ChangeInfoPanel.Size = new System.Drawing.Size(540, 166);
            this.ChangeInfoPanel.TabIndex = 2;
            this.ChangeInfoPanel.VerticalScrollbarBarColor = true;
            this.ChangeInfoPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ChangeInfoPanel.VerticalScrollbarSize = 10;
            // 
            // AcceptChanges
            // 
            this.AcceptChanges.ActiveControl = null;
            this.AcceptChanges.Location = new System.Drawing.Point(315, 96);
            this.AcceptChanges.Name = "AcceptChanges";
            this.AcceptChanges.Size = new System.Drawing.Size(190, 51);
            this.AcceptChanges.TabIndex = 40;
            this.AcceptChanges.Text = "Утвердить";
            this.AcceptChanges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AcceptChanges.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.AcceptChanges.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.AcceptChanges.UseSelectable = true;
            this.AcceptChanges.Click += new System.EventHandler(this.AcceptChanges_Click);
            // 
            // ChampFinishDate
            // 
            this.ChampFinishDate.Location = new System.Drawing.Point(315, 51);
            this.ChampFinishDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.ChampFinishDate.Name = "ChampFinishDate";
            this.ChampFinishDate.Size = new System.Drawing.Size(190, 30);
            this.ChampFinishDate.TabIndex = 36;
            // 
            // ChampStartDate
            // 
            this.ChampStartDate.Location = new System.Drawing.Point(315, 9);
            this.ChampStartDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.ChampStartDate.Name = "ChampStartDate";
            this.ChampStartDate.Size = new System.Drawing.Size(190, 30);
            this.ChampStartDate.TabIndex = 35;
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
            this.MoneyField.Location = new System.Drawing.Point(3, 96);
            this.MoneyField.MaxLength = 32767;
            this.MoneyField.Name = "MoneyField";
            this.MoneyField.PasswordChar = '\0';
            this.MoneyField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MoneyField.SelectedText = "";
            this.MoneyField.SelectionLength = 0;
            this.MoneyField.SelectionStart = 0;
            this.MoneyField.ShortcutsEnabled = true;
            this.MoneyField.Size = new System.Drawing.Size(282, 36);
            this.MoneyField.TabIndex = 34;
            this.MoneyField.Text = "Призовой фонд";
            this.MoneyField.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MoneyField.UseSelectable = true;
            this.MoneyField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MoneyField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddCityButton
            // 
            this.AddCityButton.Image = global::Information_System_for_eSport.Properties.Resources.add;
            this.AddCityButton.ImageSize = 20;
            this.AddCityButton.Location = new System.Drawing.Point(257, 51);
            this.AddCityButton.Name = "AddCityButton";
            this.AddCityButton.Size = new System.Drawing.Size(28, 30);
            this.AddCityButton.TabIndex = 21;
            this.AddCityButton.UseSelectable = true;
            // 
            // CityField
            // 
            this.CityField.BackColor = System.Drawing.SystemColors.MenuBar;
            this.CityField.DataSource = this.cityBindingSource;
            this.CityField.DisplayMember = "Name";
            this.CityField.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CityField.FormattingEnabled = true;
            this.CityField.ItemHeight = 24;
            this.CityField.Location = new System.Drawing.Point(3, 57);
            this.CityField.Name = "CityField";
            this.CityField.Size = new System.Drawing.Size(248, 30);
            this.CityField.TabIndex = 20;
            this.CityField.Tag = "Страна";
            this.CityField.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CityField.UseSelectable = true;
            this.CityField.ValueMember = "CityID";
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(DataModel.City);
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
            this.ChampNameField.Location = new System.Drawing.Point(3, 9);
            this.ChampNameField.MaxLength = 32767;
            this.ChampNameField.Name = "ChampNameField";
            this.ChampNameField.PasswordChar = '\0';
            this.ChampNameField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ChampNameField.SelectedText = "";
            this.ChampNameField.SelectionLength = 0;
            this.ChampNameField.SelectionStart = 0;
            this.ChampNameField.ShortcutsEnabled = true;
            this.ChampNameField.Size = new System.Drawing.Size(282, 36);
            this.ChampNameField.TabIndex = 2;
            this.ChampNameField.Text = "Название турнира";
            this.ChampNameField.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ChampNameField.UseSelectable = true;
            this.ChampNameField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ChampNameField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ChangePlacesPanel
            // 
            this.ChangePlacesPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ChangePlacesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChangePlacesPanel.Controls.Add(this.Prize8);
            this.ChangePlacesPanel.Controls.Add(this.Prize7);
            this.ChangePlacesPanel.Controls.Add(this.Prize6);
            this.ChangePlacesPanel.Controls.Add(this.Prize5);
            this.ChangePlacesPanel.Controls.Add(this.Prize4);
            this.ChangePlacesPanel.Controls.Add(this.Prize3);
            this.ChangePlacesPanel.Controls.Add(this.Prize2);
            this.ChangePlacesPanel.Controls.Add(this.Prize1);
            this.ChangePlacesPanel.Controls.Add(this.AcceptPrizes);
            this.ChangePlacesPanel.Controls.Add(this.metroLabel8);
            this.ChangePlacesPanel.Controls.Add(this.metroLabel7);
            this.ChangePlacesPanel.Controls.Add(this.metroLabel6);
            this.ChangePlacesPanel.Controls.Add(this.metroLabel5);
            this.ChangePlacesPanel.Controls.Add(this.metroLabel4);
            this.ChangePlacesPanel.Controls.Add(this.metroLabel3);
            this.ChangePlacesPanel.Controls.Add(this.metroLabel2);
            this.ChangePlacesPanel.Controls.Add(this.metroLabel1);
            this.ChangePlacesPanel.Controls.Add(this.Team8);
            this.ChangePlacesPanel.Controls.Add(this.Team7);
            this.ChangePlacesPanel.Controls.Add(this.Team6);
            this.ChangePlacesPanel.Controls.Add(this.Team5);
            this.ChangePlacesPanel.Controls.Add(this.Team4);
            this.ChangePlacesPanel.Controls.Add(this.Team3);
            this.ChangePlacesPanel.Controls.Add(this.Team2);
            this.ChangePlacesPanel.Controls.Add(this.metroLink2);
            this.ChangePlacesPanel.Controls.Add(this.Team1);
            this.ChangePlacesPanel.Enabled = false;
            this.ChangePlacesPanel.HorizontalScrollbarBarColor = true;
            this.ChangePlacesPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ChangePlacesPanel.HorizontalScrollbarSize = 10;
            this.ChangePlacesPanel.Location = new System.Drawing.Point(569, 143);
            this.ChangePlacesPanel.Name = "ChangePlacesPanel";
            this.ChangePlacesPanel.Size = new System.Drawing.Size(356, 472);
            this.ChangePlacesPanel.TabIndex = 3;
            this.ChangePlacesPanel.VerticalScrollbarBarColor = true;
            this.ChangePlacesPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ChangePlacesPanel.VerticalScrollbarSize = 10;
            // 
            // Prize8
            // 
            // 
            // 
            // 
            this.Prize8.CustomButton.Image = null;
            this.Prize8.CustomButton.Location = new System.Drawing.Point(116, 2);
            this.Prize8.CustomButton.Name = "";
            this.Prize8.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.Prize8.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Prize8.CustomButton.TabIndex = 1;
            this.Prize8.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Prize8.CustomButton.UseSelectable = true;
            this.Prize8.CustomButton.Visible = false;
            this.Prize8.Enabled = false;
            this.Prize8.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Prize8.Lines = new string[] {
        "Выигрыш"};
            this.Prize8.Location = new System.Drawing.Point(205, 354);
            this.Prize8.MaxLength = 32767;
            this.Prize8.Name = "Prize8";
            this.Prize8.PasswordChar = '\0';
            this.Prize8.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Prize8.SelectedText = "";
            this.Prize8.SelectionLength = 0;
            this.Prize8.SelectionStart = 0;
            this.Prize8.ShortcutsEnabled = true;
            this.Prize8.Size = new System.Drawing.Size(150, 36);
            this.Prize8.TabIndex = 46;
            this.Prize8.Text = "Выигрыш";
            this.Prize8.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Prize8.UseSelectable = true;
            this.Prize8.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Prize8.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Prize7
            // 
            // 
            // 
            // 
            this.Prize7.CustomButton.Image = null;
            this.Prize7.CustomButton.Location = new System.Drawing.Point(116, 2);
            this.Prize7.CustomButton.Name = "";
            this.Prize7.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.Prize7.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Prize7.CustomButton.TabIndex = 1;
            this.Prize7.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Prize7.CustomButton.UseSelectable = true;
            this.Prize7.CustomButton.Visible = false;
            this.Prize7.Enabled = false;
            this.Prize7.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Prize7.Lines = new string[] {
        "Выигрыш"};
            this.Prize7.Location = new System.Drawing.Point(205, 312);
            this.Prize7.MaxLength = 32767;
            this.Prize7.Name = "Prize7";
            this.Prize7.PasswordChar = '\0';
            this.Prize7.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Prize7.SelectedText = "";
            this.Prize7.SelectionLength = 0;
            this.Prize7.SelectionStart = 0;
            this.Prize7.ShortcutsEnabled = true;
            this.Prize7.Size = new System.Drawing.Size(150, 36);
            this.Prize7.TabIndex = 45;
            this.Prize7.Text = "Выигрыш";
            this.Prize7.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Prize7.UseSelectable = true;
            this.Prize7.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Prize7.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Prize6
            // 
            // 
            // 
            // 
            this.Prize6.CustomButton.Image = null;
            this.Prize6.CustomButton.Location = new System.Drawing.Point(116, 2);
            this.Prize6.CustomButton.Name = "";
            this.Prize6.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.Prize6.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Prize6.CustomButton.TabIndex = 1;
            this.Prize6.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Prize6.CustomButton.UseSelectable = true;
            this.Prize6.CustomButton.Visible = false;
            this.Prize6.Enabled = false;
            this.Prize6.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Prize6.Lines = new string[] {
        "Выигрыш"};
            this.Prize6.Location = new System.Drawing.Point(204, 270);
            this.Prize6.MaxLength = 32767;
            this.Prize6.Name = "Prize6";
            this.Prize6.PasswordChar = '\0';
            this.Prize6.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Prize6.SelectedText = "";
            this.Prize6.SelectionLength = 0;
            this.Prize6.SelectionStart = 0;
            this.Prize6.ShortcutsEnabled = true;
            this.Prize6.Size = new System.Drawing.Size(150, 36);
            this.Prize6.TabIndex = 44;
            this.Prize6.Text = "Выигрыш";
            this.Prize6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Prize6.UseSelectable = true;
            this.Prize6.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Prize6.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Prize5
            // 
            // 
            // 
            // 
            this.Prize5.CustomButton.Image = null;
            this.Prize5.CustomButton.Location = new System.Drawing.Point(116, 2);
            this.Prize5.CustomButton.Name = "";
            this.Prize5.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.Prize5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Prize5.CustomButton.TabIndex = 1;
            this.Prize5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Prize5.CustomButton.UseSelectable = true;
            this.Prize5.CustomButton.Visible = false;
            this.Prize5.Enabled = false;
            this.Prize5.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Prize5.Lines = new string[] {
        "Выигрыш"};
            this.Prize5.Location = new System.Drawing.Point(203, 228);
            this.Prize5.MaxLength = 32767;
            this.Prize5.Name = "Prize5";
            this.Prize5.PasswordChar = '\0';
            this.Prize5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Prize5.SelectedText = "";
            this.Prize5.SelectionLength = 0;
            this.Prize5.SelectionStart = 0;
            this.Prize5.ShortcutsEnabled = true;
            this.Prize5.Size = new System.Drawing.Size(150, 36);
            this.Prize5.TabIndex = 43;
            this.Prize5.Text = "Выигрыш";
            this.Prize5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Prize5.UseSelectable = true;
            this.Prize5.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Prize5.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Prize4
            // 
            // 
            // 
            // 
            this.Prize4.CustomButton.Image = null;
            this.Prize4.CustomButton.Location = new System.Drawing.Point(116, 2);
            this.Prize4.CustomButton.Name = "";
            this.Prize4.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.Prize4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Prize4.CustomButton.TabIndex = 1;
            this.Prize4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Prize4.CustomButton.UseSelectable = true;
            this.Prize4.CustomButton.Visible = false;
            this.Prize4.Enabled = false;
            this.Prize4.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Prize4.Lines = new string[] {
        "Выигрыш"};
            this.Prize4.Location = new System.Drawing.Point(203, 186);
            this.Prize4.MaxLength = 32767;
            this.Prize4.Name = "Prize4";
            this.Prize4.PasswordChar = '\0';
            this.Prize4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Prize4.SelectedText = "";
            this.Prize4.SelectionLength = 0;
            this.Prize4.SelectionStart = 0;
            this.Prize4.ShortcutsEnabled = true;
            this.Prize4.Size = new System.Drawing.Size(150, 36);
            this.Prize4.TabIndex = 42;
            this.Prize4.Text = "Выигрыш";
            this.Prize4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Prize4.UseSelectable = true;
            this.Prize4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Prize4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Prize3
            // 
            // 
            // 
            // 
            this.Prize3.CustomButton.Image = null;
            this.Prize3.CustomButton.Location = new System.Drawing.Point(116, 2);
            this.Prize3.CustomButton.Name = "";
            this.Prize3.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.Prize3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Prize3.CustomButton.TabIndex = 1;
            this.Prize3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Prize3.CustomButton.UseSelectable = true;
            this.Prize3.CustomButton.Visible = false;
            this.Prize3.Enabled = false;
            this.Prize3.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Prize3.Lines = new string[] {
        "Выигрыш"};
            this.Prize3.Location = new System.Drawing.Point(203, 144);
            this.Prize3.MaxLength = 32767;
            this.Prize3.Name = "Prize3";
            this.Prize3.PasswordChar = '\0';
            this.Prize3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Prize3.SelectedText = "";
            this.Prize3.SelectionLength = 0;
            this.Prize3.SelectionStart = 0;
            this.Prize3.ShortcutsEnabled = true;
            this.Prize3.Size = new System.Drawing.Size(150, 36);
            this.Prize3.TabIndex = 41;
            this.Prize3.Text = "Выигрыш";
            this.Prize3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Prize3.UseSelectable = true;
            this.Prize3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Prize3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Prize2
            // 
            // 
            // 
            // 
            this.Prize2.CustomButton.Image = null;
            this.Prize2.CustomButton.Location = new System.Drawing.Point(116, 2);
            this.Prize2.CustomButton.Name = "";
            this.Prize2.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.Prize2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Prize2.CustomButton.TabIndex = 1;
            this.Prize2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Prize2.CustomButton.UseSelectable = true;
            this.Prize2.CustomButton.Visible = false;
            this.Prize2.Enabled = false;
            this.Prize2.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Prize2.Lines = new string[] {
        "Выигрыш"};
            this.Prize2.Location = new System.Drawing.Point(203, 102);
            this.Prize2.MaxLength = 32767;
            this.Prize2.Name = "Prize2";
            this.Prize2.PasswordChar = '\0';
            this.Prize2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Prize2.SelectedText = "";
            this.Prize2.SelectionLength = 0;
            this.Prize2.SelectionStart = 0;
            this.Prize2.ShortcutsEnabled = true;
            this.Prize2.Size = new System.Drawing.Size(150, 36);
            this.Prize2.TabIndex = 40;
            this.Prize2.Text = "Выигрыш";
            this.Prize2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Prize2.UseSelectable = true;
            this.Prize2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Prize2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Prize1
            // 
            // 
            // 
            // 
            this.Prize1.CustomButton.Image = null;
            this.Prize1.CustomButton.Location = new System.Drawing.Point(116, 2);
            this.Prize1.CustomButton.Name = "";
            this.Prize1.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.Prize1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Prize1.CustomButton.TabIndex = 1;
            this.Prize1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Prize1.CustomButton.UseSelectable = true;
            this.Prize1.CustomButton.Visible = false;
            this.Prize1.Enabled = false;
            this.Prize1.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Prize1.Lines = new string[] {
        "Выигрыш"};
            this.Prize1.Location = new System.Drawing.Point(203, 60);
            this.Prize1.MaxLength = 32767;
            this.Prize1.Name = "Prize1";
            this.Prize1.PasswordChar = '\0';
            this.Prize1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Prize1.SelectedText = "";
            this.Prize1.SelectionLength = 0;
            this.Prize1.SelectionStart = 0;
            this.Prize1.ShortcutsEnabled = true;
            this.Prize1.Size = new System.Drawing.Size(150, 36);
            this.Prize1.TabIndex = 37;
            this.Prize1.Text = "Выигрыш";
            this.Prize1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Prize1.UseSelectable = true;
            this.Prize1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Prize1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AcceptPrizes
            // 
            this.AcceptPrizes.ActiveControl = null;
            this.AcceptPrizes.Location = new System.Drawing.Point(44, 405);
            this.AcceptPrizes.Name = "AcceptPrizes";
            this.AcceptPrizes.Size = new System.Drawing.Size(307, 50);
            this.AcceptPrizes.TabIndex = 39;
            this.AcceptPrizes.Text = "Утвердить";
            this.AcceptPrizes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AcceptPrizes.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.AcceptPrizes.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.AcceptPrizes.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(23, 364);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(17, 20);
            this.metroLabel8.TabIndex = 38;
            this.metroLabel8.Text = "8";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(23, 322);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(17, 20);
            this.metroLabel7.TabIndex = 37;
            this.metroLabel7.Text = "7";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(23, 280);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(17, 20);
            this.metroLabel6.TabIndex = 36;
            this.metroLabel6.Text = "6";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(23, 238);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(17, 20);
            this.metroLabel5.TabIndex = 35;
            this.metroLabel5.Text = "5";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(23, 196);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(17, 20);
            this.metroLabel4.TabIndex = 34;
            this.metroLabel4.Text = "4";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(23, 154);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(17, 20);
            this.metroLabel3.TabIndex = 33;
            this.metroLabel3.Text = "3";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(23, 112);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(17, 20);
            this.metroLabel2.TabIndex = 32;
            this.metroLabel2.Text = "2";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(17, 20);
            this.metroLabel1.TabIndex = 31;
            this.metroLabel1.Text = "1";
            // 
            // Team8
            // 
            this.Team8.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Team8.DataSource = this.participantBindingSource1;
            this.Team8.DisplayMember = "TeamName";
            this.Team8.Enabled = false;
            this.Team8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Team8.FormattingEnabled = true;
            this.Team8.ItemHeight = 24;
            this.Team8.Location = new System.Drawing.Point(49, 354);
            this.Team8.Name = "Team8";
            this.Team8.Size = new System.Drawing.Size(148, 30);
            this.Team8.TabIndex = 30;
            this.Team8.Tag = "Страна";
            this.Team8.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Team8.UseSelectable = true;
            this.Team8.ValueMember = "TeamID";
            // 
            // Team7
            // 
            this.Team7.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Team7.DataSource = this.participantBindingSource1;
            this.Team7.DisplayMember = "TeamName";
            this.Team7.Enabled = false;
            this.Team7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Team7.FormattingEnabled = true;
            this.Team7.ItemHeight = 24;
            this.Team7.Location = new System.Drawing.Point(49, 312);
            this.Team7.Name = "Team7";
            this.Team7.Size = new System.Drawing.Size(148, 30);
            this.Team7.TabIndex = 29;
            this.Team7.Tag = "Страна";
            this.Team7.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Team7.UseSelectable = true;
            this.Team7.ValueMember = "TeamID";
            // 
            // Team6
            // 
            this.Team6.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Team6.DataSource = this.participantBindingSource1;
            this.Team6.DisplayMember = "TeamName";
            this.Team6.Enabled = false;
            this.Team6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Team6.FormattingEnabled = true;
            this.Team6.ItemHeight = 24;
            this.Team6.Location = new System.Drawing.Point(49, 270);
            this.Team6.Name = "Team6";
            this.Team6.Size = new System.Drawing.Size(148, 30);
            this.Team6.TabIndex = 28;
            this.Team6.Tag = "Страна";
            this.Team6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Team6.UseSelectable = true;
            this.Team6.ValueMember = "TeamID";
            // 
            // Team5
            // 
            this.Team5.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Team5.DataSource = this.participantBindingSource1;
            this.Team5.DisplayMember = "TeamName";
            this.Team5.Enabled = false;
            this.Team5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Team5.FormattingEnabled = true;
            this.Team5.ItemHeight = 24;
            this.Team5.Location = new System.Drawing.Point(49, 228);
            this.Team5.Name = "Team5";
            this.Team5.Size = new System.Drawing.Size(148, 30);
            this.Team5.TabIndex = 27;
            this.Team5.Tag = "Страна";
            this.Team5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Team5.UseSelectable = true;
            this.Team5.ValueMember = "TeamID";
            // 
            // Team4
            // 
            this.Team4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Team4.DataSource = this.participantBindingSource1;
            this.Team4.DisplayMember = "TeamName";
            this.Team4.Enabled = false;
            this.Team4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Team4.FormattingEnabled = true;
            this.Team4.ItemHeight = 24;
            this.Team4.Location = new System.Drawing.Point(49, 186);
            this.Team4.Name = "Team4";
            this.Team4.Size = new System.Drawing.Size(148, 30);
            this.Team4.TabIndex = 26;
            this.Team4.Tag = "Страна";
            this.Team4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Team4.UseSelectable = true;
            this.Team4.ValueMember = "TeamID";
            // 
            // Team3
            // 
            this.Team3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Team3.DataSource = this.participantBindingSource1;
            this.Team3.DisplayMember = "TeamName";
            this.Team3.Enabled = false;
            this.Team3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Team3.FormattingEnabled = true;
            this.Team3.ItemHeight = 24;
            this.Team3.Location = new System.Drawing.Point(49, 144);
            this.Team3.Name = "Team3";
            this.Team3.Size = new System.Drawing.Size(148, 30);
            this.Team3.TabIndex = 25;
            this.Team3.Tag = "Страна";
            this.Team3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Team3.UseSelectable = true;
            this.Team3.ValueMember = "TeamID";
            // 
            // Team2
            // 
            this.Team2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Team2.DataSource = this.participantBindingSource1;
            this.Team2.DisplayMember = "TeamName";
            this.Team2.Enabled = false;
            this.Team2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Team2.FormattingEnabled = true;
            this.Team2.ItemHeight = 24;
            this.Team2.Location = new System.Drawing.Point(49, 102);
            this.Team2.Name = "Team2";
            this.Team2.Size = new System.Drawing.Size(148, 30);
            this.Team2.TabIndex = 24;
            this.Team2.Tag = "Страна";
            this.Team2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Team2.UseSelectable = true;
            this.Team2.ValueMember = "TeamID";
            // 
            // metroLink2
            // 
            this.metroLink2.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink2.Location = new System.Drawing.Point(46, 3);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(307, 45);
            this.metroLink2.TabIndex = 4;
            this.metroLink2.Text = "Распределение\r\nмест\r\n";
            this.metroLink2.UseSelectable = true;
            // 
            // Team1
            // 
            this.Team1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Team1.DataSource = this.participantBindingSource1;
            this.Team1.DisplayMember = "TeamName";
            this.Team1.Enabled = false;
            this.Team1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Team1.FormattingEnabled = true;
            this.Team1.ItemHeight = 24;
            this.Team1.Location = new System.Drawing.Point(49, 60);
            this.Team1.Name = "Team1";
            this.Team1.Size = new System.Drawing.Size(148, 30);
            this.Team1.TabIndex = 23;
            this.Team1.Tag = "Страна";
            this.Team1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Team1.UseSelectable = true;
            this.Team1.ValueMember = "TeamID";
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataSource = typeof(DataModel.Team);
            // 
            // AddMatchPanel
            // 
            this.AddMatchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddMatchPanel.Controls.Add(this.metroLabel13);
            this.AddMatchPanel.Controls.Add(this.metroLabel14);
            this.AddMatchPanel.Controls.Add(this.metroLabel12);
            this.AddMatchPanel.Controls.Add(this.metroLabel11);
            this.AddMatchPanel.Controls.Add(this.metroLabel10);
            this.AddMatchPanel.Controls.Add(this.Set5Box2);
            this.AddMatchPanel.Controls.Add(this.Set5Box1);
            this.AddMatchPanel.Controls.Add(this.Set4Box2);
            this.AddMatchPanel.Controls.Add(this.Set4Box1);
            this.AddMatchPanel.Controls.Add(this.Set3Box2);
            this.AddMatchPanel.Controls.Add(this.Set3Box1);
            this.AddMatchPanel.Controls.Add(this.Set2Box2);
            this.AddMatchPanel.Controls.Add(this.Set2Box1);
            this.AddMatchPanel.Controls.Add(this.Set1Box2);
            this.AddMatchPanel.Controls.Add(this.Map5Box);
            this.AddMatchPanel.Controls.Add(this.Map4Box);
            this.AddMatchPanel.Controls.Add(this.SetsCountBox);
            this.AddMatchPanel.Controls.Add(this.Map3Box);
            this.AddMatchPanel.Controls.Add(this.Map1Box);
            this.AddMatchPanel.Controls.Add(this.metroTile1);
            this.AddMatchPanel.Controls.Add(this.Set1Box1);
            this.AddMatchPanel.Controls.Add(this.Map2Box);
            this.AddMatchPanel.Controls.Add(this.TeamBox2);
            this.AddMatchPanel.Controls.Add(this.TeamBox1);
            this.AddMatchPanel.Enabled = false;
            this.AddMatchPanel.HorizontalScrollbarBarColor = true;
            this.AddMatchPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.AddMatchPanel.HorizontalScrollbarSize = 10;
            this.AddMatchPanel.Location = new System.Drawing.Point(23, 324);
            this.AddMatchPanel.Name = "AddMatchPanel";
            this.AddMatchPanel.Size = new System.Drawing.Size(540, 428);
            this.AddMatchPanel.TabIndex = 4;
            this.AddMatchPanel.VerticalScrollbarBarColor = true;
            this.AddMatchPanel.VerticalScrollbarHighlightOnWheel = false;
            this.AddMatchPanel.VerticalScrollbarSize = 10;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(236, 151);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(49, 20);
            this.metroLabel13.TabIndex = 78;
            this.metroLabel13.Text = "Карта";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(334, 86);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(122, 20);
            this.metroLabel14.TabIndex = 77;
            this.metroLabel14.Text = "Вторая команда";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(59, 86);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(125, 20);
            this.metroLabel12.TabIndex = 75;
            this.metroLabel12.Text = "Первая команда";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(6, 44);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(279, 20);
            this.metroLabel11.TabIndex = 74;
            this.metroLabel11.Text = "Выберите количество встречь в матче:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(199, 12);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(120, 20);
            this.metroLabel10.TabIndex = 6;
            this.metroLabel10.Text = "Добавить матч";
            // 
            // Set5Box2
            // 
            this.Set5Box2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Set5Box2.Enabled = false;
            this.Set5Box2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Set5Box2.FormattingEnabled = true;
            this.Set5Box2.ItemHeight = 24;
            this.Set5Box2.Location = new System.Drawing.Point(333, 329);
            this.Set5Box2.Name = "Set5Box2";
            this.Set5Box2.Size = new System.Drawing.Size(68, 30);
            this.Set5Box2.TabIndex = 73;
            this.Set5Box2.Tag = "Страна";
            this.Set5Box2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Set5Box2.UseSelectable = true;
            // 
            // Set5Box1
            // 
            this.Set5Box1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Set5Box1.Enabled = false;
            this.Set5Box1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Set5Box1.FormattingEnabled = true;
            this.Set5Box1.ItemHeight = 24;
            this.Set5Box1.Location = new System.Drawing.Point(116, 329);
            this.Set5Box1.Name = "Set5Box1";
            this.Set5Box1.Size = new System.Drawing.Size(68, 30);
            this.Set5Box1.TabIndex = 72;
            this.Set5Box1.Tag = "Страна";
            this.Set5Box1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Set5Box1.UseSelectable = true;
            // 
            // Set4Box2
            // 
            this.Set4Box2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Set4Box2.Enabled = false;
            this.Set4Box2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Set4Box2.FormattingEnabled = true;
            this.Set4Box2.ItemHeight = 24;
            this.Set4Box2.Location = new System.Drawing.Point(333, 293);
            this.Set4Box2.Name = "Set4Box2";
            this.Set4Box2.Size = new System.Drawing.Size(68, 30);
            this.Set4Box2.TabIndex = 71;
            this.Set4Box2.Tag = "Страна";
            this.Set4Box2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Set4Box2.UseSelectable = true;
            // 
            // Set4Box1
            // 
            this.Set4Box1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Set4Box1.Enabled = false;
            this.Set4Box1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Set4Box1.FormattingEnabled = true;
            this.Set4Box1.ItemHeight = 24;
            this.Set4Box1.Location = new System.Drawing.Point(116, 293);
            this.Set4Box1.Name = "Set4Box1";
            this.Set4Box1.Size = new System.Drawing.Size(68, 30);
            this.Set4Box1.TabIndex = 70;
            this.Set4Box1.Tag = "Страна";
            this.Set4Box1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Set4Box1.UseSelectable = true;
            // 
            // Set3Box2
            // 
            this.Set3Box2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Set3Box2.Enabled = false;
            this.Set3Box2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Set3Box2.FormattingEnabled = true;
            this.Set3Box2.ItemHeight = 24;
            this.Set3Box2.Location = new System.Drawing.Point(333, 257);
            this.Set3Box2.Name = "Set3Box2";
            this.Set3Box2.Size = new System.Drawing.Size(68, 30);
            this.Set3Box2.TabIndex = 69;
            this.Set3Box2.Tag = "Страна";
            this.Set3Box2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Set3Box2.UseSelectable = true;
            // 
            // Set3Box1
            // 
            this.Set3Box1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Set3Box1.Enabled = false;
            this.Set3Box1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Set3Box1.FormattingEnabled = true;
            this.Set3Box1.ItemHeight = 24;
            this.Set3Box1.Location = new System.Drawing.Point(116, 257);
            this.Set3Box1.Name = "Set3Box1";
            this.Set3Box1.Size = new System.Drawing.Size(68, 30);
            this.Set3Box1.TabIndex = 68;
            this.Set3Box1.Tag = "Страна";
            this.Set3Box1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Set3Box1.UseSelectable = true;
            // 
            // Set2Box2
            // 
            this.Set2Box2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Set2Box2.Enabled = false;
            this.Set2Box2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Set2Box2.FormattingEnabled = true;
            this.Set2Box2.ItemHeight = 24;
            this.Set2Box2.Location = new System.Drawing.Point(334, 221);
            this.Set2Box2.Name = "Set2Box2";
            this.Set2Box2.Size = new System.Drawing.Size(68, 30);
            this.Set2Box2.TabIndex = 67;
            this.Set2Box2.Tag = "Страна";
            this.Set2Box2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Set2Box2.UseSelectable = true;
            // 
            // Set2Box1
            // 
            this.Set2Box1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Set2Box1.Enabled = false;
            this.Set2Box1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Set2Box1.FormattingEnabled = true;
            this.Set2Box1.ItemHeight = 24;
            this.Set2Box1.Location = new System.Drawing.Point(116, 221);
            this.Set2Box1.Name = "Set2Box1";
            this.Set2Box1.Size = new System.Drawing.Size(68, 30);
            this.Set2Box1.TabIndex = 66;
            this.Set2Box1.Tag = "Страна";
            this.Set2Box1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Set2Box1.UseSelectable = true;
            // 
            // Set1Box2
            // 
            this.Set1Box2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Set1Box2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Set1Box2.FormattingEnabled = true;
            this.Set1Box2.ItemHeight = 24;
            this.Set1Box2.Location = new System.Drawing.Point(333, 183);
            this.Set1Box2.Name = "Set1Box2";
            this.Set1Box2.Size = new System.Drawing.Size(68, 30);
            this.Set1Box2.TabIndex = 65;
            this.Set1Box2.Tag = "Страна";
            this.Set1Box2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Set1Box2.UseSelectable = true;
            // 
            // Map5Box
            // 
            this.Map5Box.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Map5Box.DataSource = this.mapBindingSource;
            this.Map5Box.DisplayMember = "Name";
            this.Map5Box.Enabled = false;
            this.Map5Box.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Map5Box.FormattingEnabled = true;
            this.Map5Box.ItemHeight = 24;
            this.Map5Box.Location = new System.Drawing.Point(189, 330);
            this.Map5Box.Name = "Map5Box";
            this.Map5Box.Size = new System.Drawing.Size(138, 30);
            this.Map5Box.TabIndex = 64;
            this.Map5Box.Tag = "Страна";
            this.Map5Box.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Map5Box.UseSelectable = true;
            this.Map5Box.ValueMember = "MapID";
            // 
            // mapBindingSource
            // 
            this.mapBindingSource.DataSource = typeof(DataModel.Map);
            // 
            // Map4Box
            // 
            this.Map4Box.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Map4Box.DataSource = this.mapBindingSource;
            this.Map4Box.DisplayMember = "Name";
            this.Map4Box.Enabled = false;
            this.Map4Box.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Map4Box.FormattingEnabled = true;
            this.Map4Box.ItemHeight = 24;
            this.Map4Box.Location = new System.Drawing.Point(189, 294);
            this.Map4Box.Name = "Map4Box";
            this.Map4Box.Size = new System.Drawing.Size(138, 30);
            this.Map4Box.TabIndex = 63;
            this.Map4Box.Tag = "Страна";
            this.Map4Box.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Map4Box.UseSelectable = true;
            this.Map4Box.ValueMember = "MapID";
            // 
            // SetsCountBox
            // 
            this.SetsCountBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.SetsCountBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SetsCountBox.FormattingEnabled = true;
            this.SetsCountBox.ItemHeight = 24;
            this.SetsCountBox.Location = new System.Drawing.Point(334, 34);
            this.SetsCountBox.Name = "SetsCountBox";
            this.SetsCountBox.Size = new System.Drawing.Size(53, 30);
            this.SetsCountBox.TabIndex = 41;
            this.SetsCountBox.Tag = "Страна";
            this.SetsCountBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SetsCountBox.UseSelectable = true;
            this.SetsCountBox.SelectionChangeCommitted += new System.EventHandler(this.SetsCountBox_SelectionChangeCommitted);
            // 
            // Map3Box
            // 
            this.Map3Box.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Map3Box.DataSource = this.mapBindingSource;
            this.Map3Box.DisplayMember = "Name";
            this.Map3Box.Enabled = false;
            this.Map3Box.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Map3Box.FormattingEnabled = true;
            this.Map3Box.ItemHeight = 24;
            this.Map3Box.Location = new System.Drawing.Point(189, 257);
            this.Map3Box.Name = "Map3Box";
            this.Map3Box.Size = new System.Drawing.Size(138, 30);
            this.Map3Box.TabIndex = 57;
            this.Map3Box.Tag = "Страна";
            this.Map3Box.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Map3Box.UseSelectable = true;
            this.Map3Box.ValueMember = "MapID";
            // 
            // Map1Box
            // 
            this.Map1Box.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Map1Box.DataSource = this.mapBindingSource;
            this.Map1Box.DisplayMember = "Name";
            this.Map1Box.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Map1Box.FormattingEnabled = true;
            this.Map1Box.ItemHeight = 24;
            this.Map1Box.Location = new System.Drawing.Point(189, 183);
            this.Map1Box.Name = "Map1Box";
            this.Map1Box.Size = new System.Drawing.Size(138, 30);
            this.Map1Box.TabIndex = 56;
            this.Map1Box.Tag = "Страна";
            this.Map1Box.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Map1Box.UseSelectable = true;
            this.Map1Box.ValueMember = "MapID";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(29, 365);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(493, 45);
            this.metroTile1.TabIndex = 54;
            this.metroTile1.Text = "Добавить ";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // Set1Box1
            // 
            this.Set1Box1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Set1Box1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Set1Box1.FormattingEnabled = true;
            this.Set1Box1.ItemHeight = 24;
            this.Set1Box1.Location = new System.Drawing.Point(115, 183);
            this.Set1Box1.Name = "Set1Box1";
            this.Set1Box1.Size = new System.Drawing.Size(68, 30);
            this.Set1Box1.TabIndex = 52;
            this.Set1Box1.Tag = "Страна";
            this.Set1Box1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Set1Box1.UseSelectable = true;
            // 
            // Map2Box
            // 
            this.Map2Box.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Map2Box.DataSource = this.mapBindingSource;
            this.Map2Box.DisplayMember = "Name";
            this.Map2Box.Enabled = false;
            this.Map2Box.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Map2Box.FormattingEnabled = true;
            this.Map2Box.ItemHeight = 24;
            this.Map2Box.Location = new System.Drawing.Point(189, 221);
            this.Map2Box.Name = "Map2Box";
            this.Map2Box.Size = new System.Drawing.Size(138, 30);
            this.Map2Box.TabIndex = 49;
            this.Map2Box.Tag = "Страна";
            this.Map2Box.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Map2Box.UseSelectable = true;
            this.Map2Box.ValueMember = "MapID";
            // 
            // TeamBox2
            // 
            this.TeamBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TeamBox2.DataSource = this.participantBindingSource1;
            this.TeamBox2.DisplayMember = "TeamName";
            this.TeamBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TeamBox2.FormattingEnabled = true;
            this.TeamBox2.ItemHeight = 24;
            this.TeamBox2.Location = new System.Drawing.Point(276, 109);
            this.TeamBox2.Name = "TeamBox2";
            this.TeamBox2.Size = new System.Drawing.Size(246, 30);
            this.TeamBox2.TabIndex = 47;
            this.TeamBox2.Tag = "Страна";
            this.TeamBox2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TeamBox2.UseSelectable = true;
            this.TeamBox2.ValueMember = "TeamID";
            // 
            // participantBindingSource1
            // 
            this.participantBindingSource1.DataSource = typeof(DataModel.Participant);
            // 
            // TeamBox1
            // 
            this.TeamBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TeamBox1.DataSource = this.participantBindingSource1;
            this.TeamBox1.DisplayMember = "TeamName";
            this.TeamBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TeamBox1.FormattingEnabled = true;
            this.TeamBox1.ItemHeight = 24;
            this.TeamBox1.Location = new System.Drawing.Point(15, 109);
            this.TeamBox1.Name = "TeamBox1";
            this.TeamBox1.Size = new System.Drawing.Size(223, 30);
            this.TeamBox1.TabIndex = 47;
            this.TeamBox1.Tag = "Страна";
            this.TeamBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TeamBox1.UseSelectable = true;
            this.TeamBox1.ValueMember = "TeamID";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(27, 81);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(269, 20);
            this.metroLabel9.TabIndex = 5;
            this.metroLabel9.Text = "Выберите доступный вам чемпионат";
            // 
            // participantBindingSource
            // 
            this.participantBindingSource.DataSource = typeof(DataModel.Participant);
            // 
            // UpdateChamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 775);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.AddMatchPanel);
            this.Controls.Add(this.ChangePlacesPanel);
            this.Controls.Add(this.ChangeInfoPanel);
            this.Controls.Add(this.ChooseChampBox);
            this.Name = "UpdateChamp";
            this.Resizable = false;
            this.Text = "Изменить чемпионат";
            this.Load += new System.EventHandler(this.UpdateChamp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tournamentBindingSource)).EndInit();
            this.ChangeInfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            this.ChangePlacesPanel.ResumeLayout(false);
            this.ChangePlacesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            this.AddMatchPanel.ResumeLayout(false);
            this.AddMatchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox ChooseChampBox;
        private System.Windows.Forms.BindingSource tournamentBindingSource;
        private MetroFramework.Controls.MetroPanel ChangeInfoPanel;
        private MetroFramework.Controls.MetroTextBox ChampNameField;
        private MetroFramework.Controls.MetroComboBox CityField;
        private MetroFramework.Controls.MetroLink AddCityButton;
        private MetroFramework.Controls.MetroTextBox MoneyField;
        private MetroFramework.Controls.MetroDateTime ChampStartDate;
        private MetroFramework.Controls.MetroDateTime ChampFinishDate;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private MetroFramework.Controls.MetroPanel ChangePlacesPanel;
        private MetroFramework.Controls.MetroComboBox Team1;
        private MetroFramework.Controls.MetroComboBox Team8;
        private System.Windows.Forms.BindingSource teamBindingSource;
        private MetroFramework.Controls.MetroComboBox Team7;
        private MetroFramework.Controls.MetroComboBox Team6;
        private MetroFramework.Controls.MetroComboBox Team5;
        private MetroFramework.Controls.MetroComboBox Team4;
        private MetroFramework.Controls.MetroComboBox Team3;
        private MetroFramework.Controls.MetroComboBox Team2;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroTextBox Prize8;
        private MetroFramework.Controls.MetroTextBox Prize7;
        private MetroFramework.Controls.MetroTextBox Prize6;
        private MetroFramework.Controls.MetroTextBox Prize5;
        private MetroFramework.Controls.MetroTextBox Prize4;
        private MetroFramework.Controls.MetroTextBox Prize3;
        private MetroFramework.Controls.MetroTextBox Prize2;
        private MetroFramework.Controls.MetroTextBox Prize1;
        private MetroFramework.Controls.MetroTile AcceptPrizes;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile AcceptChanges;
        private MetroFramework.Controls.MetroPanel AddMatchPanel;
        private MetroFramework.Controls.MetroComboBox Set5Box2;
        private MetroFramework.Controls.MetroComboBox Set5Box1;
        private MetroFramework.Controls.MetroComboBox Set4Box2;
        private MetroFramework.Controls.MetroComboBox Set4Box1;
        private MetroFramework.Controls.MetroComboBox Set3Box2;
        private MetroFramework.Controls.MetroComboBox Set3Box1;
        private MetroFramework.Controls.MetroComboBox Set2Box2;
        private MetroFramework.Controls.MetroComboBox Set2Box1;
        private MetroFramework.Controls.MetroComboBox Set1Box2;
        private MetroFramework.Controls.MetroComboBox Map5Box;
        private System.Windows.Forms.BindingSource mapBindingSource;
        private MetroFramework.Controls.MetroComboBox Map4Box;
        private MetroFramework.Controls.MetroComboBox SetsCountBox;
        private MetroFramework.Controls.MetroComboBox Map3Box;
        private MetroFramework.Controls.MetroComboBox Map1Box;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroComboBox Set1Box1;
        private MetroFramework.Controls.MetroComboBox Map2Box;
        private MetroFramework.Controls.MetroComboBox TeamBox2;
        private MetroFramework.Controls.MetroComboBox TeamBox1;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.BindingSource participantBindingSource;
        private System.Windows.Forms.BindingSource participantBindingSource1;
    }
}