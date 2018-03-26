namespace Information_System_for_eSport
{
    partial class CreateTeam
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
            this.TeamNameField = new MetroFramework.Controls.MetroTextBox();
            this.RegionBox = new MetroFramework.Controls.MetroComboBox();
            this.regionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AcceptButton = new MetroFramework.Controls.MetroLink();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.FirstPlayerBox = new MetroFramework.Controls.MetroComboBox();
            this.playersInTeamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SecondPlayerBox = new MetroFramework.Controls.MetroComboBox();
            this.ThirdPlayerBox = new MetroFramework.Controls.MetroComboBox();
            this.FourthPlayerBox = new MetroFramework.Controls.MetroComboBox();
            this.FifthPlayerBox = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersInTeamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TeamNameField
            // 
            // 
            // 
            // 
            this.TeamNameField.CustomButton.Image = null;
            this.TeamNameField.CustomButton.Location = new System.Drawing.Point(206, 2);
            this.TeamNameField.CustomButton.Name = "";
            this.TeamNameField.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.TeamNameField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TeamNameField.CustomButton.TabIndex = 1;
            this.TeamNameField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TeamNameField.CustomButton.UseSelectable = true;
            this.TeamNameField.CustomButton.Visible = false;
            this.TeamNameField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TeamNameField.Lines = new string[] {
        "Название команды"};
            this.TeamNameField.Location = new System.Drawing.Point(23, 72);
            this.TeamNameField.MaxLength = 32767;
            this.TeamNameField.Name = "TeamNameField";
            this.TeamNameField.PasswordChar = '\0';
            this.TeamNameField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TeamNameField.SelectedText = "";
            this.TeamNameField.SelectionLength = 0;
            this.TeamNameField.SelectionStart = 0;
            this.TeamNameField.ShortcutsEnabled = true;
            this.TeamNameField.Size = new System.Drawing.Size(240, 36);
            this.TeamNameField.TabIndex = 1;
            this.TeamNameField.Text = "Название команды";
            this.TeamNameField.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TeamNameField.UseSelectable = true;
            this.TeamNameField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TeamNameField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TeamNameField.Click += new System.EventHandler(this.OnTextboxClick);
            // 
            // RegionBox
            // 
            this.RegionBox.DataSource = this.regionBindingSource;
            this.RegionBox.DisplayMember = "Name";
            this.RegionBox.FormattingEnabled = true;
            this.RegionBox.ItemHeight = 24;
            this.RegionBox.Location = new System.Drawing.Point(23, 114);
            this.RegionBox.Name = "RegionBox";
            this.RegionBox.Size = new System.Drawing.Size(240, 30);
            this.RegionBox.TabIndex = 2;
            this.RegionBox.UseSelectable = true;
            this.RegionBox.ValueMember = "RegionID";
            // 
            // regionBindingSource
            // 
            this.regionBindingSource.DataSource = typeof(DataModel.Region);
            // 
            // AcceptButton
            // 
            this.AcceptButton.Image = global::Information_System_for_eSport.Properties.Resources.security;
            this.AcceptButton.ImageSize = 85;
            this.AcceptButton.Location = new System.Drawing.Point(246, 232);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(118, 129);
            this.AcceptButton.TabIndex = 18;
            this.AcceptButton.UseSelectable = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 158);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(161, 25);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Выберите игроков";
            // 
            // FirstPlayerBox
            // 
            this.FirstPlayerBox.DataSource = this.playersInTeamBindingSource;
            this.FirstPlayerBox.DisplayMember = "PlayerNickName";
            this.FirstPlayerBox.FormattingEnabled = true;
            this.FirstPlayerBox.ItemHeight = 24;
            this.FirstPlayerBox.Location = new System.Drawing.Point(23, 186);
            this.FirstPlayerBox.Name = "FirstPlayerBox";
            this.FirstPlayerBox.Size = new System.Drawing.Size(161, 30);
            this.FirstPlayerBox.TabIndex = 20;
            this.FirstPlayerBox.UseSelectable = true;
            this.FirstPlayerBox.ValueMember = "PlayerID";
            // 
            // playersInTeamBindingSource
            // 
            this.playersInTeamBindingSource.DataSource = typeof(DataModel.PlayersInTeam);
            // 
            // playerBindingSource1
            // 
            this.playerBindingSource1.DataSource = typeof(DataModel.Player);
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(DataModel.Player);
            // 
            // SecondPlayerBox
            // 
            this.SecondPlayerBox.DataSource = this.playersInTeamBindingSource;
            this.SecondPlayerBox.DisplayMember = "PlayerNickName";
            this.SecondPlayerBox.FormattingEnabled = true;
            this.SecondPlayerBox.ItemHeight = 24;
            this.SecondPlayerBox.Location = new System.Drawing.Point(23, 222);
            this.SecondPlayerBox.Name = "SecondPlayerBox";
            this.SecondPlayerBox.Size = new System.Drawing.Size(161, 30);
            this.SecondPlayerBox.TabIndex = 21;
            this.SecondPlayerBox.UseSelectable = true;
            this.SecondPlayerBox.ValueMember = "PlayerID";
            // 
            // ThirdPlayerBox
            // 
            this.ThirdPlayerBox.DataSource = this.playersInTeamBindingSource;
            this.ThirdPlayerBox.DisplayMember = "PlayerNickName";
            this.ThirdPlayerBox.FormattingEnabled = true;
            this.ThirdPlayerBox.ItemHeight = 24;
            this.ThirdPlayerBox.Location = new System.Drawing.Point(23, 258);
            this.ThirdPlayerBox.Name = "ThirdPlayerBox";
            this.ThirdPlayerBox.Size = new System.Drawing.Size(161, 30);
            this.ThirdPlayerBox.TabIndex = 22;
            this.ThirdPlayerBox.UseSelectable = true;
            this.ThirdPlayerBox.ValueMember = "PlayerID";
            // 
            // FourthPlayerBox
            // 
            this.FourthPlayerBox.DataSource = this.playersInTeamBindingSource;
            this.FourthPlayerBox.DisplayMember = "PlayerNickName";
            this.FourthPlayerBox.FormattingEnabled = true;
            this.FourthPlayerBox.ItemHeight = 24;
            this.FourthPlayerBox.Location = new System.Drawing.Point(23, 294);
            this.FourthPlayerBox.Name = "FourthPlayerBox";
            this.FourthPlayerBox.Size = new System.Drawing.Size(161, 30);
            this.FourthPlayerBox.TabIndex = 23;
            this.FourthPlayerBox.UseSelectable = true;
            this.FourthPlayerBox.ValueMember = "PlayerID";
            // 
            // FifthPlayerBox
            // 
            this.FifthPlayerBox.DataSource = this.playersInTeamBindingSource;
            this.FifthPlayerBox.DisplayMember = "PlayerNickName";
            this.FifthPlayerBox.FormattingEnabled = true;
            this.FifthPlayerBox.ItemHeight = 24;
            this.FifthPlayerBox.Location = new System.Drawing.Point(23, 330);
            this.FifthPlayerBox.Name = "FifthPlayerBox";
            this.FifthPlayerBox.Size = new System.Drawing.Size(161, 30);
            this.FifthPlayerBox.TabIndex = 24;
            this.FifthPlayerBox.UseSelectable = true;
            this.FifthPlayerBox.ValueMember = "PlayerID";
            // 
            // CreateTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 384);
            this.Controls.Add(this.FifthPlayerBox);
            this.Controls.Add(this.FourthPlayerBox);
            this.Controls.Add(this.ThirdPlayerBox);
            this.Controls.Add(this.SecondPlayerBox);
            this.Controls.Add(this.FirstPlayerBox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.RegionBox);
            this.Controls.Add(this.TeamNameField);
            this.Name = "CreateTeam";
            this.Text = "Создать команду";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateTeam_FormClosed);
            this.Load += new System.EventHandler(this.CreateTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersInTeamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox TeamNameField;
        private MetroFramework.Controls.MetroComboBox RegionBox;
        private System.Windows.Forms.BindingSource regionBindingSource;
        private new MetroFramework.Controls.MetroLink AcceptButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox FirstPlayerBox;
        private System.Windows.Forms.BindingSource playerBindingSource1;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.BindingSource playersInTeamBindingSource;
        private MetroFramework.Controls.MetroComboBox SecondPlayerBox;
        private MetroFramework.Controls.MetroComboBox ThirdPlayerBox;
        private MetroFramework.Controls.MetroComboBox FourthPlayerBox;
        private MetroFramework.Controls.MetroComboBox FifthPlayerBox;
    }
}