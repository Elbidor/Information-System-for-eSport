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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabControl = new MetroFramework.Controls.MetroTabControl();
            this.PlayerTab = new MetroFramework.Controls.MetroTabPage();
            this.PlayerGrid = new MetroFramework.Controls.MetroGrid();
            this.playersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cybersportDBDataSet2 = new Information_System_for_eSport.CybersportDBDataSet2();
            this.TeamTab = new MetroFramework.Controls.MetroTabPage();
            this.TournamentTab = new MetroFramework.Controls.MetroTabPage();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RegistrationButton = new MetroFramework.Controls.MetroTile();
            this.playersTableAdapter = new Information_System_for_eSport.CybersportDBDataSet2TableAdapters.PlayersTableAdapter();
            this.EnterButton = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.NicknameLabel = new MetroFramework.Controls.MetroLabel();
            this.ExitButton = new MetroFramework.Controls.MetroTile();
            this.EditButton = new MetroFramework.Controls.MetroTile();
            this.DeleteButton = new MetroFramework.Controls.MetroTile();
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
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabControl.SuspendLayout();
            this.PlayerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cybersportDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
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
            this.TabControl.Size = new System.Drawing.Size(1198, 523);
            this.TabControl.TabIndex = 0;
            this.TabControl.UseSelectable = true;
            // 
            // PlayerTab
            // 
            this.PlayerTab.Controls.Add(this.PlayerGrid);
            this.PlayerTab.HorizontalScrollbarBarColor = true;
            this.PlayerTab.HorizontalScrollbarHighlightOnWheel = false;
            this.PlayerTab.HorizontalScrollbarSize = 10;
            this.PlayerTab.Location = new System.Drawing.Point(4, 39);
            this.PlayerTab.Name = "PlayerTab";
            this.PlayerTab.Size = new System.Drawing.Size(1190, 480);
            this.PlayerTab.TabIndex = 0;
            this.PlayerTab.Text = "Игроки";
            this.PlayerTab.VerticalScrollbarBarColor = true;
            this.PlayerTab.VerticalScrollbarHighlightOnWheel = false;
            this.PlayerTab.VerticalScrollbarSize = 10;
            // 
            // PlayerGrid
            // 
            this.PlayerGrid.AllowUserToAddRows = false;
            this.PlayerGrid.AllowUserToDeleteRows = false;
            this.PlayerGrid.AllowUserToResizeColumns = false;
            this.PlayerGrid.AllowUserToResizeRows = false;
            this.PlayerGrid.AutoGenerateColumns = false;
            this.PlayerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.PlayerGrid.BackgroundColor = System.Drawing.Color.White;
            this.PlayerGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.PlayerGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PlayerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
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
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.PlayerGrid.DataSource = this.playersBindingSource1;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PlayerGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.PlayerGrid.EnableHeadersVisualStyles = false;
            this.PlayerGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PlayerGrid.GridColor = System.Drawing.Color.White;
            this.PlayerGrid.Location = new System.Drawing.Point(4, 81);
            this.PlayerGrid.Name = "PlayerGrid";
            this.PlayerGrid.ReadOnly = true;
            this.PlayerGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PlayerGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.PlayerGrid.RowHeadersVisible = false;
            this.PlayerGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PlayerGrid.RowTemplate.Height = 24;
            this.PlayerGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PlayerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PlayerGrid.Size = new System.Drawing.Size(1094, 317);
            this.PlayerGrid.Style = MetroFramework.MetroColorStyle.Lime;
            this.PlayerGrid.TabIndex = 4;
            // 
            // playersBindingSource1
            // 
            this.playersBindingSource1.DataMember = "Players";
            this.playersBindingSource1.DataSource = this.cybersportDBDataSet2;
            // 
            // cybersportDBDataSet2
            // 
            this.cybersportDBDataSet2.DataSetName = "CybersportDBDataSet2";
            this.cybersportDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TeamTab
            // 
            this.TeamTab.HorizontalScrollbarBarColor = true;
            this.TeamTab.HorizontalScrollbarHighlightOnWheel = false;
            this.TeamTab.HorizontalScrollbarSize = 10;
            this.TeamTab.Location = new System.Drawing.Point(4, 39);
            this.TeamTab.Name = "TeamTab";
            this.TeamTab.Size = new System.Drawing.Size(1016, 480);
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
            this.TournamentTab.Size = new System.Drawing.Size(1016, 480);
            this.TournamentTab.TabIndex = 2;
            this.TournamentTab.Text = "Чемпионаты";
            this.TournamentTab.VerticalScrollbarBarColor = true;
            this.TournamentTab.VerticalScrollbarHighlightOnWheel = false;
            this.TournamentTab.VerticalScrollbarSize = 10;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.cybersportDBDataSet2;
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.ActiveControl = null;
            this.RegistrationButton.Location = new System.Drawing.Point(1227, 213);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(218, 55);
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
            this.EnterButton.Location = new System.Drawing.Point(1227, 113);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(218, 55);
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
            this.metroLabel1.Location = new System.Drawing.Point(1315, 177);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 25);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "или";
            // 
            // NicknameLabel
            // 
            this.NicknameLabel.AutoSize = true;
            this.NicknameLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.NicknameLabel.Location = new System.Drawing.Point(1227, 90);
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
            this.ExitButton.Location = new System.Drawing.Point(1227, 235);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(218, 55);
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
            this.EditButton.Location = new System.Drawing.Point(1227, 113);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(218, 55);
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
            this.DeleteButton.Location = new System.Drawing.Point(1227, 174);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(218, 55);
            this.DeleteButton.Style = MetroFramework.MetroColorStyle.Red;
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Удалить профиль";
            this.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteButton.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.DeleteButton.UseSelectable = true;
            this.DeleteButton.Visible = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // playerIDDataGridViewTextBoxColumn
            // 
            this.playerIDDataGridViewTextBoxColumn.DataPropertyName = "PlayerID";
            this.playerIDDataGridViewTextBoxColumn.HeaderText = "PlayerID";
            this.playerIDDataGridViewTextBoxColumn.Name = "playerIDDataGridViewTextBoxColumn";
            this.playerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.playerIDDataGridViewTextBoxColumn.Visible = false;
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
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Visible = false;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1468, 534);
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
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.EnabledChanged += new System.EventHandler(this.Form1_EnabledChanged);
            this.TabControl.ResumeLayout(false);
            this.PlayerTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cybersportDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource playersBindingSource;
        private CybersportDBDataSet2TableAdapters.PlayersTableAdapter playersTableAdapter;
        private System.Windows.Forms.BindingSource playersBindingSource1;
        private MetroFramework.Controls.MetroTile EnterButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel NicknameLabel;
        private MetroFramework.Controls.MetroTile ExitButton;
        private MetroFramework.Controls.MetroTile EditButton;
        private MetroFramework.Controls.MetroTile DeleteButton;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    }
}

