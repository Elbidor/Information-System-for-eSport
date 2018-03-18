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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabControl = new MetroFramework.Controls.MetroTabControl();
            this.PlayerTab = new MetroFramework.Controls.MetroTabPage();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.playerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nicknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playedMapsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playedRoundsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cybersportDBDataSet = new Information_System_for_eSport.CybersportDBDataSet();
            this.TeamTab = new MetroFramework.Controls.MetroTabPage();
            this.TournamentTab = new MetroFramework.Controls.MetroTabPage();
            this.playersTableAdapter = new Information_System_for_eSport.CybersportDBDataSetTableAdapters.PlayersTableAdapter();
            this.TabControl.SuspendLayout();
            this.PlayerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cybersportDBDataSet)).BeginInit();
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
            this.TabControl.Size = new System.Drawing.Size(1322, 491);
            this.TabControl.TabIndex = 0;
            this.TabControl.UseSelectable = true;
            // 
            // PlayerTab
            // 
            this.PlayerTab.Controls.Add(this.metroTile1);
            this.PlayerTab.Controls.Add(this.metroGrid1);
            this.PlayerTab.HorizontalScrollbarBarColor = true;
            this.PlayerTab.HorizontalScrollbarHighlightOnWheel = false;
            this.PlayerTab.HorizontalScrollbarSize = 10;
            this.PlayerTab.Location = new System.Drawing.Point(4, 39);
            this.PlayerTab.Name = "PlayerTab";
            this.PlayerTab.Size = new System.Drawing.Size(1314, 448);
            this.PlayerTab.TabIndex = 0;
            this.PlayerTab.Text = "Игроки";
            this.PlayerTab.VerticalScrollbarBarColor = true;
            this.PlayerTab.VerticalScrollbarHighlightOnWheel = false;
            this.PlayerTab.VerticalScrollbarSize = 10;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(4, 33);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(75, 23);
            this.metroTile1.TabIndex = 3;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.Registation_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.nicknameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.countryIDDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.playedMapsDataGridViewTextBoxColumn,
            this.playedRoundsDataGridViewTextBoxColumn,
            this.roleIDDataGridViewTextBoxColumn,
            this.emalDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.playersBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(4, 79);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(1243, 150);
            this.metroGrid1.TabIndex = 2;
            // 
            // playerIDDataGridViewTextBoxColumn
            // 
            this.playerIDDataGridViewTextBoxColumn.DataPropertyName = "PlayerID";
            this.playerIDDataGridViewTextBoxColumn.HeaderText = "PlayerID";
            this.playerIDDataGridViewTextBoxColumn.Name = "playerIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // nicknameDataGridViewTextBoxColumn
            // 
            this.nicknameDataGridViewTextBoxColumn.DataPropertyName = "Nickname";
            this.nicknameDataGridViewTextBoxColumn.HeaderText = "Nickname";
            this.nicknameDataGridViewTextBoxColumn.Name = "nicknameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // countryIDDataGridViewTextBoxColumn
            // 
            this.countryIDDataGridViewTextBoxColumn.DataPropertyName = "CountryID";
            this.countryIDDataGridViewTextBoxColumn.HeaderText = "CountryID";
            this.countryIDDataGridViewTextBoxColumn.Name = "countryIDDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            // 
            // playedMapsDataGridViewTextBoxColumn
            // 
            this.playedMapsDataGridViewTextBoxColumn.DataPropertyName = "PlayedMaps";
            this.playedMapsDataGridViewTextBoxColumn.HeaderText = "PlayedMaps";
            this.playedMapsDataGridViewTextBoxColumn.Name = "playedMapsDataGridViewTextBoxColumn";
            // 
            // playedRoundsDataGridViewTextBoxColumn
            // 
            this.playedRoundsDataGridViewTextBoxColumn.DataPropertyName = "PlayedRounds";
            this.playedRoundsDataGridViewTextBoxColumn.HeaderText = "PlayedRounds";
            this.playedRoundsDataGridViewTextBoxColumn.Name = "playedRoundsDataGridViewTextBoxColumn";
            // 
            // roleIDDataGridViewTextBoxColumn
            // 
            this.roleIDDataGridViewTextBoxColumn.DataPropertyName = "RoleID";
            this.roleIDDataGridViewTextBoxColumn.HeaderText = "RoleID";
            this.roleIDDataGridViewTextBoxColumn.Name = "roleIDDataGridViewTextBoxColumn";
            // 
            // emalDataGridViewTextBoxColumn
            // 
            this.emalDataGridViewTextBoxColumn.DataPropertyName = "Emal";
            this.emalDataGridViewTextBoxColumn.HeaderText = "Emal";
            this.emalDataGridViewTextBoxColumn.Name = "emalDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.cybersportDBDataSet;
            // 
            // cybersportDBDataSet
            // 
            this.cybersportDBDataSet.DataSetName = "CybersportDBDataSet";
            this.cybersportDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TeamTab
            // 
            this.TeamTab.HorizontalScrollbarBarColor = true;
            this.TeamTab.HorizontalScrollbarHighlightOnWheel = false;
            this.TeamTab.HorizontalScrollbarSize = 10;
            this.TeamTab.Location = new System.Drawing.Point(4, 39);
            this.TeamTab.Name = "TeamTab";
            this.TeamTab.Size = new System.Drawing.Size(1314, 448);
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
            this.TournamentTab.Size = new System.Drawing.Size(1314, 448);
            this.TournamentTab.TabIndex = 2;
            this.TournamentTab.Text = "Чемпионаты";
            this.TournamentTab.VerticalScrollbarBarColor = true;
            this.TournamentTab.VerticalScrollbarHighlightOnWheel = false;
            this.TournamentTab.VerticalScrollbarSize = 10;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 588);
            this.Controls.Add(this.TabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl.ResumeLayout(false);
            this.PlayerTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cybersportDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TabControl;
        private MetroFramework.Controls.MetroTabPage PlayerTab;
        private MetroFramework.Controls.MetroTabPage TeamTab;
        private MetroFramework.Controls.MetroTabPage TournamentTab;
        private CybersportDBDataSet cybersportDBDataSet;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private CybersportDBDataSetTableAdapters.PlayersTableAdapter playersTableAdapter;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playedMapsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playedRoundsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}

