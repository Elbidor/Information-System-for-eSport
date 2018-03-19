namespace Information_System_for_eSport.Forms
{
    partial class Login
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
            this.EnterButton = new MetroFramework.Controls.MetroTile();
            this.PasswordField = new MetroFramework.Controls.MetroTextBox();
            this.EmailField = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // EnterButton
            // 
            this.EnterButton.ActiveControl = null;
            this.EnterButton.Location = new System.Drawing.Point(23, 188);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(240, 59);
            this.EnterButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.EnterButton.TabIndex = 6;
            this.EnterButton.Text = "Готово!";
            this.EnterButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EnterButton.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.EnterButton.UseSelectable = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
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
            this.PasswordField.Location = new System.Drawing.Point(23, 129);
            this.PasswordField.MaxLength = 32767;
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '*';
            this.PasswordField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordField.SelectedText = "";
            this.PasswordField.SelectionLength = 0;
            this.PasswordField.SelectionStart = 0;
            this.PasswordField.ShortcutsEnabled = true;
            this.PasswordField.Size = new System.Drawing.Size(240, 36);
            this.PasswordField.TabIndex = 11;
            this.PasswordField.Text = "Ваш пароль";
            this.PasswordField.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasswordField.UseSelectable = true;
            this.PasswordField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PasswordField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PasswordField.Click += new System.EventHandler(this.OnTextboxClick);
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
            this.EmailField.Location = new System.Drawing.Point(23, 87);
            this.EmailField.MaxLength = 32767;
            this.EmailField.Name = "EmailField";
            this.EmailField.PasswordChar = '\0';
            this.EmailField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EmailField.SelectedText = "";
            this.EmailField.SelectionLength = 0;
            this.EmailField.SelectionStart = 0;
            this.EmailField.ShortcutsEnabled = true;
            this.EmailField.Size = new System.Drawing.Size(240, 36);
            this.EmailField.TabIndex = 10;
            this.EmailField.Text = "Ваш email";
            this.EmailField.Theme = MetroFramework.MetroThemeStyle.Light;
            this.EmailField.UseSelectable = true;
            this.EmailField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EmailField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.EmailField.Click += new System.EventHandler(this.OnTextboxClick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 270);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.EmailField);
            this.Controls.Add(this.EnterButton);
            this.Name = "Login";
            this.Resizable = false;
            this.Text = "Вход";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile EnterButton;
        private MetroFramework.Controls.MetroTextBox PasswordField;
        private MetroFramework.Controls.MetroTextBox EmailField;
    }
}