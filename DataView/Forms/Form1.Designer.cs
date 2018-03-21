namespace Information_System_for_eSport
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabControl = new MetroFramework.Controls.MetroTabControl();
            this.PlayerTab = new MetroFramework.Controls.MetroTabPage();
            this.RoundsLabel = new MetroFramework.Controls.MetroLabel();
            this.MapsLabel = new MetroFramework.Controls.MetroLabel();
            this.RatingLabel = new MetroFramework.Controls.MetroLabel();
            this.ResetButton = new MetroFramework.Controls.MetroLink();
            this.FilterAge = new MetroFramework.Controls.MetroComboBox();
            this.FilterPlayedRounds = new MetroFramework.Controls.MetroTrackBar();
            this.FilterPlayedMaps = new MetroFramework.Controls.MetroTrackBar();
            this.FilterRating = new MetroFramework.Controls.MetroTrackBar();
            this.FilterCountry = new MetroFramework.Controls.MetroComboBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FilterSurname = new MetroFramework.Controls.MetroTextBox();
            this.FilterNickname = new MetroFramework.Controls.MetroTextBox();
            this.FilterName = new MetroFramework.Controls.MetroTextBox();
            this.CreateExcelButton = new MetroFramework.Controls.MetroLink();
            this.CreateWordButton = new MetroFramework.Controls.MetroLink();
            this.CreatePdfButton = new MetroFramework.Controls.MetroLink();
            this.PlayerGrid = new MetroFramework.Controls.MetroGrid();
            this.playerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nicknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playedMapsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playedRoundsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playersInTeamsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TeamTab = new MetroFramework.Controls.MetroTabPage();
            this.TournamentTab = new MetroFramework.Controls.MetroTabPage();
            this.cybersportDBDataSet2 = new Information_System_for_eSport.CybersportDBDataSet2();
            this.RegistrationButton = new MetroFramework.Controls.MetroTile();
            this.playersTableAdapter = new Information_System_for_eSport.CybersportDBDataSet2TableAdapters.PlayersTableAdapter();
            this.EnterButton = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.NicknameLabel = new MetroFramework.Controls.MetroLabel();
            this.ExitButton = new MetroFramework.Controls.MetroTile();
            this.EditButton = new MetroFramework.Controls.MetroTile();
            this.DeleteButton = new MetroFramework.Controls.MetroTile();
            this.InformationPanel = new MetroFramework.Controls.MetroPanel();
            this.CareerInfo = new MetroFramework.Controls.MetroLink();
            this.CloseInfoPanel = new MetroFramework.Controls.MetroLink();
            this.InfoPanelCurrentTeamField = new MetroFramework.Controls.MetroLabel();
            this.InfoPanelPlayedRoundsField = new MetroFramework.Controls.MetroLabel();
            this.InfoPanelPlayedMapsField = new MetroFramework.Controls.MetroLabel();
            this.InfoPanelCountryField = new MetroFramework.Controls.MetroLabel();
            this.InfoPanelAgeField = new MetroFramework.Controls.MetroLabel();
            this.InfoPanelSurnameField = new MetroFramework.Controls.MetroLabel();
            this.InfoPanelNicknameField = new MetroFramework.Controls.MetroLabel();
            this.InfoPanelNameField = new MetroFramework.Controls.MetroLabel();
            this.InfoPanelCurrentTeam = new MetroFramework.Controls.MetroLabel();
            this.InfoPanelPlayedRounds = new MetroFramework.Controls.MetroLabel();
            this.InfoPanelPlayedMaps = new MetroFramework.Controls.MetroLabel();
            this.InfoPanelCountry = new MetroFramework.Controls.MetroLabel();
            this.InfoPanelAge = new MetroFramework.Controls.MetroLabel();
            this.InfoPanelSurname = new MetroFramework.Controls.MetroLabel();
            this.InfoPanelNickname = new MetroFramework.Controls.MetroLabel();
            this.InfoPanelName = new MetroFramework.Controls.MetroLabel();
            this.InfoPanelHeadLabel = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.citiesTableAdapter = new Information_System_for_eSport.CybersportDBDataSet2TableAdapters.CitiesTableAdapter();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.TabControl.SuspendLayout();
            this.PlayerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cybersportDBDataSet2)).BeginInit();
            this.InformationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabControl.Controls.Add(this.PlayerTab);
            this.TabControl.Controls.Add(this.TeamTab);
            this.TabControl.Controls.Add(this.TournamentTab);
            this.TabControl.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.TabControl.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.TabControl.ItemSize = new System.Drawing.Size(57, 35);
            this.TabControl.Location = new System.Drawing.Point(23, 74);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(811, 419);
            this.TabControl.TabIndex = 0;
            this.TabControl.UseSelectable = true;
            // 
            // PlayerTab
            // 
            this.PlayerTab.Controls.Add(this.RoundsLabel);
            this.PlayerTab.Controls.Add(this.MapsLabel);
            this.PlayerTab.Controls.Add(this.RatingLabel);
            this.PlayerTab.Controls.Add(this.ResetButton);
            this.PlayerTab.Controls.Add(this.FilterAge);
            this.PlayerTab.Controls.Add(this.FilterPlayedRounds);
            this.PlayerTab.Controls.Add(this.FilterPlayedMaps);
            this.PlayerTab.Controls.Add(this.FilterRating);
            this.PlayerTab.Controls.Add(this.FilterCountry);
            this.PlayerTab.Controls.Add(this.FilterSurname);
            this.PlayerTab.Controls.Add(this.FilterNickname);
            this.PlayerTab.Controls.Add(this.FilterName);
            this.PlayerTab.Controls.Add(this.CreateExcelButton);
            this.PlayerTab.Controls.Add(this.CreateWordButton);
            this.PlayerTab.Controls.Add(this.CreatePdfButton);
            this.PlayerTab.Controls.Add(this.PlayerGrid);
            this.PlayerTab.HorizontalScrollbarBarColor = true;
            this.PlayerTab.HorizontalScrollbarHighlightOnWheel = false;
            this.PlayerTab.HorizontalScrollbarSize = 10;
            this.PlayerTab.Location = new System.Drawing.Point(4, 39);
            this.PlayerTab.Name = "PlayerTab";
            this.PlayerTab.Size = new System.Drawing.Size(803, 376);
            this.PlayerTab.TabIndex = 0;
            this.PlayerTab.Text = "Игроки";
            this.PlayerTab.VerticalScrollbarBarColor = true;
            this.PlayerTab.VerticalScrollbarHighlightOnWheel = false;
            this.PlayerTab.VerticalScrollbarSize = 10;
            // 
            // RoundsLabel
            // 
            this.RoundsLabel.AutoSize = true;
            this.RoundsLabel.Location = new System.Drawing.Point(355, 50);
            this.RoundsLabel.Name = "RoundsLabel";
            this.RoundsLabel.Size = new System.Drawing.Size(17, 20);
            this.RoundsLabel.TabIndex = 18;
            this.RoundsLabel.Text = "0";
            // 
            // MapsLabel
            // 
            this.MapsLabel.AutoSize = true;
            this.MapsLabel.Location = new System.Drawing.Point(177, 50);
            this.MapsLabel.Name = "MapsLabel";
            this.MapsLabel.Size = new System.Drawing.Size(17, 20);
            this.MapsLabel.TabIndex = 17;
            this.MapsLabel.Text = "0";
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(0, 50);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(17, 20);
            this.RatingLabel.TabIndex = 16;
            this.RatingLabel.Text = "0";
            // 
            // ResetButton
            // 
            this.ResetButton.Image = global::Information_System_for_eSport.Properties.Resources.loading__1_;
            this.ResetButton.ImageSize = 25;
            this.ResetButton.Location = new System.Drawing.Point(520, 13);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(40, 31);
            this.ResetButton.TabIndex = 15;
            this.ResetButton.UseSelectable = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // FilterAge
            // 
            this.FilterAge.FormattingEnabled = true;
            this.FilterAge.ItemHeight = 24;
            this.FilterAge.Location = new System.Drawing.Point(459, 14);
            this.FilterAge.Name = "FilterAge";
            this.FilterAge.Size = new System.Drawing.Size(54, 30);
            this.FilterAge.TabIndex = 14;
            this.FilterAge.UseSelectable = true;
            this.FilterAge.SelectionChangeCommitted += new System.EventHandler(this.FilterAge_SelectionChangeCommitted);
            // 
            // FilterPlayedRounds
            // 
            this.FilterPlayedRounds.BackColor = System.Drawing.Color.Transparent;
            this.FilterPlayedRounds.Location = new System.Drawing.Point(385, 50);
            this.FilterPlayedRounds.Maximum = 100000;
            this.FilterPlayedRounds.Name = "FilterPlayedRounds";
            this.FilterPlayedRounds.Size = new System.Drawing.Size(175, 23);
            this.FilterPlayedRounds.Style = MetroFramework.MetroColorStyle.Blue;
            this.FilterPlayedRounds.TabIndex = 13;
            this.FilterPlayedRounds.Text = "metroTrackBar3";
            this.FilterPlayedRounds.Value = 0;
            this.FilterPlayedRounds.Scroll += new System.Windows.Forms.ScrollEventHandler(this.FilterRating_Scroll);
            // 
            // FilterPlayedMaps
            // 
            this.FilterPlayedMaps.BackColor = System.Drawing.Color.Transparent;
            this.FilterPlayedMaps.Location = new System.Drawing.Point(213, 50);
            this.FilterPlayedMaps.Maximum = 10000;
            this.FilterPlayedMaps.Name = "FilterPlayedMaps";
            this.FilterPlayedMaps.Size = new System.Drawing.Size(136, 23);
            this.FilterPlayedMaps.SmallChange = 10;
            this.FilterPlayedMaps.Style = MetroFramework.MetroColorStyle.Teal;
            this.FilterPlayedMaps.TabIndex = 12;
            this.FilterPlayedMaps.Text = "metroTrackBar2";
            this.FilterPlayedMaps.Value = 0;
            this.FilterPlayedMaps.Scroll += new System.Windows.Forms.ScrollEventHandler(this.FilterRating_Scroll);
            // 
            // FilterRating
            // 
            this.FilterRating.BackColor = System.Drawing.Color.Transparent;
            this.FilterRating.Location = new System.Drawing.Point(33, 50);
            this.FilterRating.Maximum = 3000;
            this.FilterRating.Name = "FilterRating";
            this.FilterRating.Size = new System.Drawing.Size(138, 23);
            this.FilterRating.SmallChange = 10;
            this.FilterRating.Style = MetroFramework.MetroColorStyle.Red;
            this.FilterRating.TabIndex = 11;
            this.FilterRating.Text = "metroTrackBar1";
            this.FilterRating.Value = 1;
            this.FilterRating.Scroll += new System.Windows.Forms.ScrollEventHandler(this.FilterRating_Scroll);
            // 
            // FilterCountry
            // 
            this.FilterCountry.DataSource = this.countryBindingSource;
            this.FilterCountry.DisplayMember = "Country1";
            this.FilterCountry.FormattingEnabled = true;
            this.FilterCountry.ItemHeight = 24;
            this.FilterCountry.Location = new System.Drawing.Point(345, 14);
            this.FilterCountry.Name = "FilterCountry";
            this.FilterCountry.Size = new System.Drawing.Size(108, 30);
            this.FilterCountry.TabIndex = 11;
            this.FilterCountry.UseSelectable = true;
            this.FilterCountry.ValueMember = "CountryID";
            this.FilterCountry.SelectionChangeCommitted += new System.EventHandler(this.FilterCountry_SelectionChangeCommitted);
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataSource = typeof(DataModel.Country);
            // 
            // FilterSurname
            // 
            // 
            // 
            // 
            this.FilterSurname.CustomButton.Image = null;
            this.FilterSurname.CustomButton.Location = new System.Drawing.Point(87, 2);
            this.FilterSurname.CustomButton.Name = "";
            this.FilterSurname.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.FilterSurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FilterSurname.CustomButton.TabIndex = 1;
            this.FilterSurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FilterSurname.CustomButton.UseSelectable = true;
            this.FilterSurname.CustomButton.Visible = false;
            this.FilterSurname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.FilterSurname.Lines = new string[0];
            this.FilterSurname.Location = new System.Drawing.Point(224, 14);
            this.FilterSurname.MaxLength = 32767;
            this.FilterSurname.Name = "FilterSurname";
            this.FilterSurname.PasswordChar = '\0';
            this.FilterSurname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FilterSurname.SelectedText = "";
            this.FilterSurname.SelectionLength = 0;
            this.FilterSurname.SelectionStart = 0;
            this.FilterSurname.ShortcutsEnabled = true;
            this.FilterSurname.Size = new System.Drawing.Size(115, 30);
            this.FilterSurname.TabIndex = 10;
            this.FilterSurname.UseSelectable = true;
            this.FilterSurname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FilterSurname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.FilterSurname.TextChanged += new System.EventHandler(this.FilterPlayersEvent);
            this.FilterSurname.Click += new System.EventHandler(this.OnTextboxClick);
            // 
            // FilterNickname
            // 
            // 
            // 
            // 
            this.FilterNickname.CustomButton.Image = null;
            this.FilterNickname.CustomButton.Location = new System.Drawing.Point(88, 2);
            this.FilterNickname.CustomButton.Name = "";
            this.FilterNickname.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.FilterNickname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FilterNickname.CustomButton.TabIndex = 1;
            this.FilterNickname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FilterNickname.CustomButton.UseSelectable = true;
            this.FilterNickname.CustomButton.Visible = false;
            this.FilterNickname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.FilterNickname.Lines = new string[0];
            this.FilterNickname.Location = new System.Drawing.Point(102, 14);
            this.FilterNickname.MaxLength = 32767;
            this.FilterNickname.Name = "FilterNickname";
            this.FilterNickname.PasswordChar = '\0';
            this.FilterNickname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FilterNickname.SelectedText = "";
            this.FilterNickname.SelectionLength = 0;
            this.FilterNickname.SelectionStart = 0;
            this.FilterNickname.ShortcutsEnabled = true;
            this.FilterNickname.Size = new System.Drawing.Size(116, 30);
            this.FilterNickname.TabIndex = 9;
            this.FilterNickname.UseSelectable = true;
            this.FilterNickname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FilterNickname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.FilterNickname.TextChanged += new System.EventHandler(this.FilterPlayersEvent);
            this.FilterNickname.Click += new System.EventHandler(this.OnTextboxClick);
            // 
            // FilterName
            // 
            // 
            // 
            // 
            this.FilterName.CustomButton.Image = null;
            this.FilterName.CustomButton.Location = new System.Drawing.Point(72, 2);
            this.FilterName.CustomButton.Name = "";
            this.FilterName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.FilterName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FilterName.CustomButton.TabIndex = 1;
            this.FilterName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FilterName.CustomButton.UseSelectable = true;
            this.FilterName.CustomButton.Visible = false;
            this.FilterName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.FilterName.Lines = new string[0];
            this.FilterName.Location = new System.Drawing.Point(0, 14);
            this.FilterName.MaxLength = 32767;
            this.FilterName.Name = "FilterName";
            this.FilterName.PasswordChar = '\0';
            this.FilterName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FilterName.SelectedText = "";
            this.FilterName.SelectionLength = 0;
            this.FilterName.SelectionStart = 0;
            this.FilterName.ShortcutsEnabled = true;
            this.FilterName.Size = new System.Drawing.Size(100, 30);
            this.FilterName.TabIndex = 8;
            this.FilterName.UseSelectable = true;
            this.FilterName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FilterName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.FilterName.TextChanged += new System.EventHandler(this.FilterPlayersEvent);
            this.FilterName.Click += new System.EventHandler(this.OnTextboxClick);
            // 
            // CreateExcelButton
            // 
            this.CreateExcelButton.Image = global::Information_System_for_eSport.Properties.Resources._001_xls;
            this.CreateExcelButton.ImageSize = 60;
            this.CreateExcelButton.Location = new System.Drawing.Point(728, 3);
            this.CreateExcelButton.Name = "CreateExcelButton";
            this.CreateExcelButton.Size = new System.Drawing.Size(75, 72);
            this.CreateExcelButton.TabIndex = 7;
            this.CreateExcelButton.UseSelectable = true;
            this.CreateExcelButton.Click += new System.EventHandler(this.CreateExcelButton_Click);
            // 
            // CreateWordButton
            // 
            this.CreateWordButton.Image = global::Information_System_for_eSport.Properties.Resources._003_doc;
            this.CreateWordButton.ImageSize = 60;
            this.CreateWordButton.Location = new System.Drawing.Point(647, 3);
            this.CreateWordButton.Name = "CreateWordButton";
            this.CreateWordButton.Size = new System.Drawing.Size(75, 72);
            this.CreateWordButton.TabIndex = 6;
            this.CreateWordButton.UseSelectable = true;
            this.CreateWordButton.Click += new System.EventHandler(this.CreateWordButton_Click);
            // 
            // CreatePdfButton
            // 
            this.CreatePdfButton.Image = global::Information_System_for_eSport.Properties.Resources._002_pdf;
            this.CreatePdfButton.ImageSize = 60;
            this.CreatePdfButton.Location = new System.Drawing.Point(566, 3);
            this.CreatePdfButton.Name = "CreatePdfButton";
            this.CreatePdfButton.Size = new System.Drawing.Size(75, 72);
            this.CreatePdfButton.TabIndex = 5;
            this.CreatePdfButton.UseSelectable = true;
            this.CreatePdfButton.Click += new System.EventHandler(this.CreatePdfButton_Click);
            // 
            // PlayerGrid
            // 
            this.PlayerGrid.AllowUserToAddRows = false;
            this.PlayerGrid.AllowUserToDeleteRows = false;
            this.PlayerGrid.AllowUserToResizeColumns = false;
            this.PlayerGrid.AllowUserToResizeRows = false;
            this.PlayerGrid.AutoGenerateColumns = false;
            this.PlayerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.PlayerGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PlayerGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayerGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.PlayerGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PlayerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.PlayerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.nicknameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.countryIDDataGridViewTextBoxColumn,
            this.countryNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.playedMapsDataGridViewTextBoxColumn,
            this.playedRoundsDataGridViewTextBoxColumn,
            this.roleIDDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.playersInTeamsDataGridViewTextBoxColumn});
            this.PlayerGrid.DataSource = this.playerBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PlayerGrid.DefaultCellStyle = dataGridViewCellStyle14;
            this.PlayerGrid.EnableHeadersVisualStyles = false;
            this.PlayerGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PlayerGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PlayerGrid.Location = new System.Drawing.Point(4, 81);
            this.PlayerGrid.MultiSelect = false;
            this.PlayerGrid.Name = "PlayerGrid";
            this.PlayerGrid.ReadOnly = true;
            this.PlayerGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PlayerGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.PlayerGrid.RowHeadersVisible = false;
            this.PlayerGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PlayerGrid.RowTemplate.Height = 24;
            this.PlayerGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PlayerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PlayerGrid.Size = new System.Drawing.Size(1001, 299);
            this.PlayerGrid.Style = MetroFramework.MetroColorStyle.Lime;
            this.PlayerGrid.TabIndex = 4;
            this.PlayerGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PlayerGrid_CellContentDoubleClick);
            // 
            // playerIDDataGridViewTextBoxColumn
            // 
            this.playerIDDataGridViewTextBoxColumn.DataPropertyName = "PlayerID";
            this.playerIDDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.playerIDDataGridViewTextBoxColumn.Name = "playerIDDataGridViewTextBoxColumn";
            this.playerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.playerIDDataGridViewTextBoxColumn.Visible = false;
            this.playerIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 80;
            // 
            // nicknameDataGridViewTextBoxColumn
            // 
            this.nicknameDataGridViewTextBoxColumn.DataPropertyName = "Nickname";
            this.nicknameDataGridViewTextBoxColumn.HeaderText = "Никнейм";
            this.nicknameDataGridViewTextBoxColumn.Name = "nicknameDataGridViewTextBoxColumn";
            this.nicknameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nicknameDataGridViewTextBoxColumn.Width = 126;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.surnameDataGridViewTextBoxColumn.Width = 126;
            // 
            // countryIDDataGridViewTextBoxColumn
            // 
            this.countryIDDataGridViewTextBoxColumn.DataPropertyName = "CountryID";
            this.countryIDDataGridViewTextBoxColumn.HeaderText = "CountryID";
            this.countryIDDataGridViewTextBoxColumn.Name = "countryIDDataGridViewTextBoxColumn";
            this.countryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.countryIDDataGridViewTextBoxColumn.Visible = false;
            this.countryIDDataGridViewTextBoxColumn.Width = 133;
            // 
            // countryNameDataGridViewTextBoxColumn
            // 
            this.countryNameDataGridViewTextBoxColumn.DataPropertyName = "CountryName";
            this.countryNameDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.countryNameDataGridViewTextBoxColumn.Name = "countryNameDataGridViewTextBoxColumn";
            this.countryNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.countryNameDataGridViewTextBoxColumn.Width = 104;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Возраст";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            this.ageDataGridViewTextBoxColumn.Width = 112;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Рейтинг";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.ReadOnly = true;
            this.ratingDataGridViewTextBoxColumn.Width = 113;
            // 
            // playedMapsDataGridViewTextBoxColumn
            // 
            this.playedMapsDataGridViewTextBoxColumn.DataPropertyName = "PlayedMaps";
            this.playedMapsDataGridViewTextBoxColumn.HeaderText = "Сыграно карт";
            this.playedMapsDataGridViewTextBoxColumn.Name = "playedMapsDataGridViewTextBoxColumn";
            this.playedMapsDataGridViewTextBoxColumn.ReadOnly = true;
            this.playedMapsDataGridViewTextBoxColumn.Width = 152;
            // 
            // playedRoundsDataGridViewTextBoxColumn
            // 
            this.playedRoundsDataGridViewTextBoxColumn.DataPropertyName = "PlayedRounds";
            this.playedRoundsDataGridViewTextBoxColumn.HeaderText = "Сыграно раундов";
            this.playedRoundsDataGridViewTextBoxColumn.Name = "playedRoundsDataGridViewTextBoxColumn";
            this.playedRoundsDataGridViewTextBoxColumn.ReadOnly = true;
            this.playedRoundsDataGridViewTextBoxColumn.Width = 186;
            // 
            // roleIDDataGridViewTextBoxColumn
            // 
            this.roleIDDataGridViewTextBoxColumn.DataPropertyName = "RoleID";
            this.roleIDDataGridViewTextBoxColumn.HeaderText = "RoleID";
            this.roleIDDataGridViewTextBoxColumn.Name = "roleIDDataGridViewTextBoxColumn";
            this.roleIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleIDDataGridViewTextBoxColumn.Visible = false;
            this.roleIDDataGridViewTextBoxColumn.Width = 98;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            this.passwordDataGridViewTextBoxColumn.Width = 124;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Visible = false;
            this.emailDataGridViewTextBoxColumn.Width = 86;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            this.countryDataGridViewTextBoxColumn.Visible = false;
            this.countryDataGridViewTextBoxColumn.Width = 113;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleDataGridViewTextBoxColumn.Visible = false;
            this.roleDataGridViewTextBoxColumn.Width = 78;
            // 
            // playersInTeamsDataGridViewTextBoxColumn
            // 
            this.playersInTeamsDataGridViewTextBoxColumn.DataPropertyName = "PlayersInTeams";
            this.playersInTeamsDataGridViewTextBoxColumn.HeaderText = "PlayersInTeams";
            this.playersInTeamsDataGridViewTextBoxColumn.Name = "playersInTeamsDataGridViewTextBoxColumn";
            this.playersInTeamsDataGridViewTextBoxColumn.ReadOnly = true;
            this.playersInTeamsDataGridViewTextBoxColumn.Visible = false;
            this.playersInTeamsDataGridViewTextBoxColumn.Width = 174;
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(DataModel.Player);
            // 
            // TeamTab
            // 
            this.TeamTab.HorizontalScrollbarBarColor = true;
            this.TeamTab.HorizontalScrollbarHighlightOnWheel = false;
            this.TeamTab.HorizontalScrollbarSize = 10;
            this.TeamTab.Location = new System.Drawing.Point(4, 39);
            this.TeamTab.Name = "TeamTab";
            this.TeamTab.Size = new System.Drawing.Size(803, 376);
            this.TeamTab.TabIndex = 1;
            this.TeamTab.Text = "Команды";
            this.TeamTab.VerticalScrollbarBarColor = true;
            this.TeamTab.VerticalScrollbarHighlightOnWheel = false;
            this.TeamTab.VerticalScrollbarSize = 10;
            // 
            // TournamentTab
            // 
            this.TournamentTab.HorizontalScrollbarBarColor = true;
            this.TournamentTab.HorizontalScrollbarHighlightOnWheel = false;
            this.TournamentTab.HorizontalScrollbarSize = 10;
            this.TournamentTab.Location = new System.Drawing.Point(4, 39);
            this.TournamentTab.Name = "TournamentTab";
            this.TournamentTab.Size = new System.Drawing.Size(803, 376);
            this.TournamentTab.TabIndex = 2;
            this.TournamentTab.Text = "Чемпионаты";
            this.TournamentTab.VerticalScrollbarBarColor = true;
            this.TournamentTab.VerticalScrollbarHighlightOnWheel = false;
            this.TournamentTab.VerticalScrollbarSize = 10;
            // 
            // cybersportDBDataSet2
            // 
            this.cybersportDBDataSet2.DataSetName = "CybersportDBDataSet2";
            this.cybersportDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.ActiveControl = null;
            this.RegistrationButton.Location = new System.Drawing.Point(863, 209);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(275, 55);
            this.RegistrationButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.RegistrationButton.TabIndex = 3;
            this.RegistrationButton.Text = "Зарегистрироваться";
            this.RegistrationButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegistrationButton.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.RegistrationButton.UseSelectable = true;
            this.RegistrationButton.Click += new System.EventHandler(this.Registation_Click);
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // EnterButton
            // 
            this.EnterButton.ActiveControl = null;
            this.EnterButton.Location = new System.Drawing.Point(863, 117);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(275, 55);
            this.EnterButton.Style = MetroFramework.MetroColorStyle.Green;
            this.EnterButton.TabIndex = 4;
            this.EnterButton.Text = "Войти";
            this.EnterButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EnterButton.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.EnterButton.UseSelectable = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(984, 177);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 25);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "или";
            // 
            // NicknameLabel
            // 
            this.NicknameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NicknameLabel.AutoSize = true;
            this.NicknameLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.NicknameLabel.Location = new System.Drawing.Point(727, 80);
            this.NicknameLabel.Name = "NicknameLabel";
            this.NicknameLabel.Size = new System.Drawing.Size(98, 20);
            this.NicknameLabel.TabIndex = 6;
            this.NicknameLabel.Text = "metroLabel2";
            this.NicknameLabel.Visible = false;
            // 
            // ExitButton
            // 
            this.ExitButton.ActiveControl = null;
            this.ExitButton.Enabled = false;
            this.ExitButton.Location = new System.Drawing.Point(863, 233);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(275, 55);
            this.ExitButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Выход";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitButton.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.ExitButton.UseSelectable = true;
            this.ExitButton.Visible = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.ActiveControl = null;
            this.EditButton.Enabled = false;
            this.EditButton.Location = new System.Drawing.Point(863, 117);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(275, 55);
            this.EditButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.EditButton.TabIndex = 8;
            this.EditButton.Text = "Изменить профиль";
            this.EditButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditButton.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.EditButton.UseSelectable = true;
            this.EditButton.Visible = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.ActiveControl = null;
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(863, 175);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(275, 55);
            this.DeleteButton.Style = MetroFramework.MetroColorStyle.Red;
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Удалить профиль";
            this.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteButton.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.DeleteButton.UseSelectable = true;
            this.DeleteButton.Visible = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // InformationPanel
            // 
            this.InformationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InformationPanel.Controls.Add(this.CareerInfo);
            this.InformationPanel.Controls.Add(this.CloseInfoPanel);
            this.InformationPanel.Controls.Add(this.InfoPanelCurrentTeamField);
            this.InformationPanel.Controls.Add(this.InfoPanelPlayedRoundsField);
            this.InformationPanel.Controls.Add(this.InfoPanelPlayedMapsField);
            this.InformationPanel.Controls.Add(this.InfoPanelCountryField);
            this.InformationPanel.Controls.Add(this.InfoPanelAgeField);
            this.InformationPanel.Controls.Add(this.InfoPanelSurnameField);
            this.InformationPanel.Controls.Add(this.InfoPanelNicknameField);
            this.InformationPanel.Controls.Add(this.InfoPanelNameField);
            this.InformationPanel.Controls.Add(this.InfoPanelCurrentTeam);
            this.InformationPanel.Controls.Add(this.InfoPanelPlayedRounds);
            this.InformationPanel.Controls.Add(this.InfoPanelPlayedMaps);
            this.InformationPanel.Controls.Add(this.InfoPanelCountry);
            this.InformationPanel.Controls.Add(this.InfoPanelAge);
            this.InformationPanel.Controls.Add(this.InfoPanelSurname);
            this.InformationPanel.Controls.Add(this.InfoPanelNickname);
            this.InformationPanel.Controls.Add(this.InfoPanelName);
            this.InformationPanel.Controls.Add(this.InfoPanelHeadLabel);
            this.InformationPanel.Enabled = false;
            this.InformationPanel.HorizontalScrollbarBarColor = true;
            this.InformationPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.InformationPanel.HorizontalScrollbarSize = 10;
            this.InformationPanel.Location = new System.Drawing.Point(840, 113);
            this.InformationPanel.Name = "InformationPanel";
            this.InformationPanel.Size = new System.Drawing.Size(10, 380);
            this.InformationPanel.TabIndex = 10;
            this.InformationPanel.VerticalScrollbarBarColor = true;
            this.InformationPanel.VerticalScrollbarHighlightOnWheel = false;
            this.InformationPanel.VerticalScrollbarSize = 10;
            this.InformationPanel.Visible = false;
            // 
            // CareerInfo
            // 
            this.CareerInfo.Image = global::Information_System_for_eSport.Properties.Resources.group;
            this.CareerInfo.ImageSize = 50;
            this.CareerInfo.Location = new System.Drawing.Point(19, 293);
            this.CareerInfo.Name = "CareerInfo";
            this.CareerInfo.Size = new System.Drawing.Size(101, 86);
            this.CareerInfo.TabIndex = 20;
            this.CareerInfo.UseSelectable = true;
            // 
            // CloseInfoPanel
            // 
            this.CloseInfoPanel.Image = global::Information_System_for_eSport.Properties.Resources.previous;
            this.CloseInfoPanel.ImageSize = 30;
            this.CloseInfoPanel.Location = new System.Drawing.Point(232, -5);
            this.CloseInfoPanel.Name = "CloseInfoPanel";
            this.CloseInfoPanel.Size = new System.Drawing.Size(55, 60);
            this.CloseInfoPanel.TabIndex = 19;
            this.CloseInfoPanel.UseSelectable = true;
            this.CloseInfoPanel.Click += new System.EventHandler(this.CloseInfoPanel_Click);
            // 
            // InfoPanelCurrentTeamField
            // 
            this.InfoPanelCurrentTeamField.AutoSize = true;
            this.InfoPanelCurrentTeamField.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.InfoPanelCurrentTeamField.Location = new System.Drawing.Point(176, 265);
            this.InfoPanelCurrentTeamField.Name = "InfoPanelCurrentTeamField";
            this.InfoPanelCurrentTeamField.Size = new System.Drawing.Size(50, 25);
            this.InfoPanelCurrentTeamField.TabIndex = 18;
            this.InfoPanelCurrentTeamField.Text = "Имя:";
            this.InfoPanelCurrentTeamField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoPanelCurrentTeamField.Visible = false;
            // 
            // InfoPanelPlayedRoundsField
            // 
            this.InfoPanelPlayedRoundsField.AutoSize = true;
            this.InfoPanelPlayedRoundsField.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.InfoPanelPlayedRoundsField.Location = new System.Drawing.Point(178, 234);
            this.InfoPanelPlayedRoundsField.Name = "InfoPanelPlayedRoundsField";
            this.InfoPanelPlayedRoundsField.Size = new System.Drawing.Size(50, 25);
            this.InfoPanelPlayedRoundsField.TabIndex = 17;
            this.InfoPanelPlayedRoundsField.Text = "Имя:";
            this.InfoPanelPlayedRoundsField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoPanelPlayedRoundsField.Visible = false;
            // 
            // InfoPanelPlayedMapsField
            // 
            this.InfoPanelPlayedMapsField.AutoSize = true;
            this.InfoPanelPlayedMapsField.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.InfoPanelPlayedMapsField.Location = new System.Drawing.Point(143, 204);
            this.InfoPanelPlayedMapsField.Name = "InfoPanelPlayedMapsField";
            this.InfoPanelPlayedMapsField.Size = new System.Drawing.Size(50, 25);
            this.InfoPanelPlayedMapsField.TabIndex = 16;
            this.InfoPanelPlayedMapsField.Text = "Имя:";
            this.InfoPanelPlayedMapsField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoPanelPlayedMapsField.Visible = false;
            // 
            // InfoPanelCountryField
            // 
            this.InfoPanelCountryField.AutoSize = true;
            this.InfoPanelCountryField.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.InfoPanelCountryField.Location = new System.Drawing.Point(91, 174);
            this.InfoPanelCountryField.Name = "InfoPanelCountryField";
            this.InfoPanelCountryField.Size = new System.Drawing.Size(50, 25);
            this.InfoPanelCountryField.TabIndex = 15;
            this.InfoPanelCountryField.Text = "Имя:";
            this.InfoPanelCountryField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoPanelCountryField.Visible = false;
            // 
            // InfoPanelAgeField
            // 
            this.InfoPanelAgeField.AutoSize = true;
            this.InfoPanelAgeField.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.InfoPanelAgeField.Location = new System.Drawing.Point(98, 146);
            this.InfoPanelAgeField.Name = "InfoPanelAgeField";
            this.InfoPanelAgeField.Size = new System.Drawing.Size(50, 25);
            this.InfoPanelAgeField.TabIndex = 14;
            this.InfoPanelAgeField.Text = "Имя:";
            this.InfoPanelAgeField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoPanelAgeField.Visible = false;
            // 
            // InfoPanelSurnameField
            // 
            this.InfoPanelSurnameField.AutoSize = true;
            this.InfoPanelSurnameField.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.InfoPanelSurnameField.Location = new System.Drawing.Point(106, 116);
            this.InfoPanelSurnameField.Name = "InfoPanelSurnameField";
            this.InfoPanelSurnameField.Size = new System.Drawing.Size(50, 25);
            this.InfoPanelSurnameField.TabIndex = 13;
            this.InfoPanelSurnameField.Text = "Имя:";
            this.InfoPanelSurnameField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoPanelSurnameField.Visible = false;
            // 
            // InfoPanelNicknameField
            // 
            this.InfoPanelNicknameField.AutoSize = true;
            this.InfoPanelNicknameField.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.InfoPanelNicknameField.Location = new System.Drawing.Point(106, 88);
            this.InfoPanelNicknameField.Name = "InfoPanelNicknameField";
            this.InfoPanelNicknameField.Size = new System.Drawing.Size(50, 25);
            this.InfoPanelNicknameField.TabIndex = 12;
            this.InfoPanelNicknameField.Text = "Имя:";
            this.InfoPanelNicknameField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoPanelNicknameField.Visible = false;
            // 
            // InfoPanelNameField
            // 
            this.InfoPanelNameField.AutoSize = true;
            this.InfoPanelNameField.Cursor = System.Windows.Forms.Cursors.Default;
            this.InfoPanelNameField.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.InfoPanelNameField.Location = new System.Drawing.Point(70, 58);
            this.InfoPanelNameField.Name = "InfoPanelNameField";
            this.InfoPanelNameField.Size = new System.Drawing.Size(50, 25);
            this.InfoPanelNameField.TabIndex = 11;
            this.InfoPanelNameField.Text = "Имя:";
            this.InfoPanelNameField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoPanelNameField.Visible = false;
            // 
            // InfoPanelCurrentTeam
            // 
            this.InfoPanelCurrentTeam.AutoSize = true;
            this.InfoPanelCurrentTeam.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.InfoPanelCurrentTeam.Location = new System.Drawing.Point(11, 265);
            this.InfoPanelCurrentTeam.Name = "InfoPanelCurrentTeam";
            this.InfoPanelCurrentTeam.Size = new System.Drawing.Size(159, 25);
            this.InfoPanelCurrentTeam.TabIndex = 10;
            this.InfoPanelCurrentTeam.Text = "Текущая команда:";
            this.InfoPanelCurrentTeam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InfoPanelPlayedRounds
            // 
            this.InfoPanelPlayedRounds.AutoSize = true;
            this.InfoPanelPlayedRounds.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.InfoPanelPlayedRounds.Location = new System.Drawing.Point(11, 234);
            this.InfoPanelPlayedRounds.Name = "InfoPanelPlayedRounds";
            this.InfoPanelPlayedRounds.Size = new System.Drawing.Size(161, 25);
            this.InfoPanelPlayedRounds.TabIndex = 9;
            this.InfoPanelPlayedRounds.Text = "Сыграно раундов:";
            this.InfoPanelPlayedRounds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InfoPanelPlayedMaps
            // 
            this.InfoPanelPlayedMaps.AutoSize = true;
            this.InfoPanelPlayedMaps.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.InfoPanelPlayedMaps.Location = new System.Drawing.Point(11, 204);
            this.InfoPanelPlayedMaps.Name = "InfoPanelPlayedMaps";
            this.InfoPanelPlayedMaps.Size = new System.Drawing.Size(126, 25);
            this.InfoPanelPlayedMaps.TabIndex = 8;
            this.InfoPanelPlayedMaps.Text = "Сыграно карт:";
            this.InfoPanelPlayedMaps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InfoPanelCountry
            // 
            this.InfoPanelCountry.AutoSize = true;
            this.InfoPanelCountry.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.InfoPanelCountry.Location = new System.Drawing.Point(11, 174);
            this.InfoPanelCountry.Name = "InfoPanelCountry";
            this.InfoPanelCountry.Size = new System.Drawing.Size(74, 25);
            this.InfoPanelCountry.TabIndex = 7;
            this.InfoPanelCountry.Text = "Страна:";
            this.InfoPanelCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InfoPanelAge
            // 
            this.InfoPanelAge.AutoSize = true;
            this.InfoPanelAge.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.InfoPanelAge.Location = new System.Drawing.Point(11, 146);
            this.InfoPanelAge.Name = "InfoPanelAge";
            this.InfoPanelAge.Size = new System.Drawing.Size(81, 25);
            this.InfoPanelAge.TabIndex = 6;
            this.InfoPanelAge.Text = "Возраст:";
            this.InfoPanelAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InfoPanelSurname
            // 
            this.InfoPanelSurname.AutoSize = true;
            this.InfoPanelSurname.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.InfoPanelSurname.Location = new System.Drawing.Point(11, 116);
            this.InfoPanelSurname.Name = "InfoPanelSurname";
            this.InfoPanelSurname.Size = new System.Drawing.Size(89, 25);
            this.InfoPanelSurname.TabIndex = 5;
            this.InfoPanelSurname.Text = "Фамилия:";
            this.InfoPanelSurname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InfoPanelNickname
            // 
            this.InfoPanelNickname.AutoSize = true;
            this.InfoPanelNickname.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.InfoPanelNickname.Location = new System.Drawing.Point(11, 88);
            this.InfoPanelNickname.Name = "InfoPanelNickname";
            this.InfoPanelNickname.Size = new System.Drawing.Size(89, 25);
            this.InfoPanelNickname.TabIndex = 4;
            this.InfoPanelNickname.Text = "Никнейм:";
            this.InfoPanelNickname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InfoPanelName
            // 
            this.InfoPanelName.AutoSize = true;
            this.InfoPanelName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.InfoPanelName.Location = new System.Drawing.Point(11, 58);
            this.InfoPanelName.Name = "InfoPanelName";
            this.InfoPanelName.Size = new System.Drawing.Size(50, 25);
            this.InfoPanelName.TabIndex = 3;
            this.InfoPanelName.Text = "Имя:";
            this.InfoPanelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InfoPanelHeadLabel
            // 
            this.InfoPanelHeadLabel.AutoSize = true;
            this.InfoPanelHeadLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.InfoPanelHeadLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.InfoPanelHeadLabel.Location = new System.Drawing.Point(8, 12);
            this.InfoPanelHeadLabel.Name = "InfoPanelHeadLabel";
            this.InfoPanelHeadLabel.Size = new System.Drawing.Size(218, 25);
            this.InfoPanelHeadLabel.TabIndex = 2;
            this.InfoPanelHeadLabel.Text = "Информация об игроке";
            this.InfoPanelHeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // citiesTableAdapter
            // 
            this.citiesTableAdapter.ClearBeforeFill = true;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1138, 506);
            this.Controls.Add(this.InformationPanel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.NicknameLabel);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.RegistrationButton);
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Cybersport Information System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.EnabledChanged += new System.EventHandler(this.Form1_EnabledChanged);
            this.TabControl.ResumeLayout(false);
            this.PlayerTab.ResumeLayout(false);
            this.PlayerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cybersportDBDataSet2)).EndInit();
            this.InformationPanel.ResumeLayout(false);
            this.InformationPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TabControl;
        private MetroFramework.Controls.MetroTabPage PlayerTab;
        private MetroFramework.Controls.MetroTabPage TeamTab;
        private MetroFramework.Controls.MetroTabPage TournamentTab;
        private MetroFramework.Controls.MetroTile RegistrationButton;
        private MetroFramework.Controls.MetroGrid PlayerGrid;
        private CybersportDBDataSet2 cybersportDBDataSet2;
        private CybersportDBDataSet2TableAdapters.PlayersTableAdapter playersTableAdapter;
        private MetroFramework.Controls.MetroTile EnterButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel NicknameLabel;
        private MetroFramework.Controls.MetroTile ExitButton;
        private MetroFramework.Controls.MetroTile EditButton;
        private MetroFramework.Controls.MetroTile DeleteButton;
        private MetroFramework.Controls.MetroPanel InformationPanel;
        private MetroFramework.Controls.MetroLabel InfoPanelCountry;
        private MetroFramework.Controls.MetroLabel InfoPanelAge;
        private MetroFramework.Controls.MetroLabel InfoPanelSurname;
        private MetroFramework.Controls.MetroLabel InfoPanelNickname;
        private MetroFramework.Controls.MetroLabel InfoPanelName;
        private MetroFramework.Controls.MetroLabel InfoPanelHeadLabel;
        private MetroFramework.Controls.MetroLabel InfoPanelCurrentTeam;
        private MetroFramework.Controls.MetroLabel InfoPanelPlayedRounds;
        private MetroFramework.Controls.MetroLabel InfoPanelPlayedMaps;
        private MetroFramework.Controls.MetroLabel InfoPanelCurrentTeamField;
        private MetroFramework.Controls.MetroLabel InfoPanelPlayedRoundsField;
        private MetroFramework.Controls.MetroLabel InfoPanelPlayedMapsField;
        private MetroFramework.Controls.MetroLabel InfoPanelCountryField;
        private MetroFramework.Controls.MetroLabel InfoPanelAgeField;
        private MetroFramework.Controls.MetroLabel InfoPanelSurnameField;
        private MetroFramework.Controls.MetroLabel InfoPanelNicknameField;
        private MetroFramework.Controls.MetroLabel InfoPanelNameField;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLink CreateExcelButton;
        private MetroFramework.Controls.MetroLink CreateWordButton;
        private MetroFramework.Controls.MetroLink CreatePdfButton;
        private CybersportDBDataSet2TableAdapters.CitiesTableAdapter citiesTableAdapter;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playedMapsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playedRoundsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playersInTeamsDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroLink CloseInfoPanel;
        private MetroFramework.Controls.MetroLink CareerInfo;
        private System.Windows.Forms.Timer timer2;
        private MetroFramework.Controls.MetroComboBox FilterCountry;
        private MetroFramework.Controls.MetroTextBox FilterSurname;
        private MetroFramework.Controls.MetroTextBox FilterNickname;
        private MetroFramework.Controls.MetroTextBox FilterName;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private MetroFramework.Controls.MetroTrackBar FilterRating;
        private MetroFramework.Controls.MetroTrackBar FilterPlayedRounds;
        private MetroFramework.Controls.MetroTrackBar FilterPlayedMaps;
        private MetroFramework.Controls.MetroComboBox FilterAge;
        private MetroFramework.Controls.MetroLink ResetButton;
        private MetroFramework.Controls.MetroLabel RatingLabel;
        private MetroFramework.Controls.MetroLabel RoundsLabel;
        private MetroFramework.Controls.MetroLabel MapsLabel;
    }
}

