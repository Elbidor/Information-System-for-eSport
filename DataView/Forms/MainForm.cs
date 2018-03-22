using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataController;
using DataModel;
using System.IO;
using Spire.Doc;
using Spire.Doc.Fields;
using Spire.Xls;

namespace Information_System_for_eSport
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        bool comboCountryUsed = false;
        bool comboAgeUsed = false;
        bool comboRegionUsed = false;
        MetroFramework.Controls.MetroGrid currentGrid = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentGrid = PlayerGrid;
            currentGrid.DataSource = Controller.GetPlayers();
            PlayerGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            FilterCountry.DataSource = Controller.GetCountries();
            FilterTeamRegion.DataSource = Controller.GetRegions();
            for (int i = 1; i <= 100; i++)
            {
                string[] numbers = { i.ToString() };
                FilterAge.Items.AddRange(numbers);
            }
            FilterAge.SelectedIndex = 0;
            FilterRating.Maximum = Controller.GetPlayersMaxValues("rating");
            FilterPlayedMaps.Maximum = Controller.GetPlayersMaxValues("maps");
            FilterPlayedRounds.Maximum = Controller.GetPlayersMaxValues("rounds");
            TabControl.SelectedTab = PlayerTab;
        }

        private void Registation_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Owner = this;
            reg.Show();
            this.Enabled = false;
            this.Hide();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            Forms.Login log = new Forms.Login();
            log.Owner = this;
            log.Show();
            this.Enabled = false;
        }

        private void Form1_EnabledChanged(object sender, EventArgs e)
        {
            ChangeView(Program.currentPlayer != null);
            TabControl_SelectedIndexChanged(sender, e);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ChangeView(Program.currentPlayer == null);
            TabControl_SelectedIndexChanged(sender, e);
        }
        
        /// <summary>
        /// Смена состояния формы в зависимости от входа/выхода.
        /// </summary>
        /// <param name="isLogged"></param>
        private void ChangeView(bool isLogged)
        {
            if (isLogged)
            {
                EnterButton.Enabled = false;
                RegistrationButton.Enabled = false;
                EnterButton.Visible = false;
                RegistrationButton.Visible = false;
                ExitButton.Visible = true;
                ExitButton.Enabled = true;
                EditButton.Visible = true;
                EditButton.Enabled = true;
                DeleteButton.Enabled = true;
                DeleteButton.Visible = true;
                NicknameLabel.Visible = true;
                NicknameLabel.Text = Program.currentPlayer.Nickname;
                metroLabel1.Visible = false;
                currentGrid.DataSource = null;
            }
            else
            {
                if (Program.currentPlayer != null && (Program.currentPlayer.Role.Role1 == "Менеджер" || Program.currentPlayer.Role.Role1 == "Администратор"))
                {
                    CreateTeamButton.Enabled = false;
                    CreateTeamButton.Visible = false;
                }
                Program.currentPlayer = null;
                EnterButton.Enabled = true;
                RegistrationButton.Enabled = true;
                EnterButton.Visible = true;
                RegistrationButton.Visible = true;
                ExitButton.Visible = false;
                ExitButton.Enabled = false;
                NicknameLabel.Visible = false;
                NicknameLabel.Text = "";
                metroLabel1.Visible = true;
                EditButton.Visible = false;
                EditButton.Enabled = false;
                DeleteButton.Enabled = false;
                DeleteButton.Visible = false;
                currentGrid.DataSource = null;
                currentGrid.DataSource = Controller.GetPlayers();
                this.playersTableAdapter.Fill(this.cybersportDBDataSet2.Players);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Controller.DeletePlayer(Program.currentPlayer);
            Program.currentPlayer = null;
            Form1_EnabledChanged(sender, e);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Owner = this;
            reg.Show();
            this.Enabled = false;
            this.Hide();
        }

        /// <summary>
        /// Демонстрация информации о объекте в информационную панель.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayerGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (TabControl.SelectedTab.Text)
            {
                case "Игроки":
                    timer1.Start();
                    Player displayedPlayer = null;
                    foreach (DataGridViewRow row in currentGrid.SelectedRows)
                    {
                        displayedPlayer = Controller.FindPlayer((Guid)row.Cells[0].Value);
                    }
                    InformationPanel.Visible = true;
                    InformationPanel.Enabled = true;
                    InfoPanelHeadLabel.Text = "Информация об игроке";
                    InfoPanelLabelField1.Text = displayedPlayer.Name;
                    InfoPanelLabelField2.Text = displayedPlayer.Nickname;
                    InfoPanelLabelField3.Text = displayedPlayer.Surname;
                    InfoPanelLabelField4.Text = displayedPlayer.Age.ToString();
                    InfoPanelLabelField6.Text = displayedPlayer.PlayedMaps.ToString();
                    InfoPanelLabelField7.Text = displayedPlayer.PlayedRounds.ToString();
                    InfoPanelLabelField5.Text = displayedPlayer.CountryName;
                    InfoPanelLabelField8.Text = Controller.ReturnLatestTeam(displayedPlayer.PlayerID); 
                    InfoPanelLabel1.Text = "Имя:";
                    InfoPanelLabel2.Text = "Никнейм:";
                    InfoPanelLabel3.Text = "Фамилия:";
                    InfoPanelLabel4.Text = "Возраст:";
                    InfoPanelLabel5.Text = "Страна:";
                    InfoPanelLabel6.Text = "Сыграно карт:";
                    InfoPanelLabel7.Text = "Сыграно раундов:";
                    InfoPanelLabel8.Text = "Текущая команда:";
                    break;
                case "Команды":
                    timer1.Start();
                    Team displayedTeam = null;
                    foreach (DataGridViewRow row in currentGrid.SelectedRows)
                    {
                        displayedTeam = Controller.FindTeam((Guid)row.Cells[0].Value);
                    }
                    InformationPanel.Visible = true;
                    InformationPanel.Enabled = true;
                    InfoPanelHeadLabel.Text = "Информация о команде:";                    
                    InfoPanelLabel1.Text = "Имя:";
                    InfoPanelLabelField1.Text = displayedTeam.Name;                    
                    InfoPanelLabel2.Text = "Регион:";
                    InfoPanelLabelField2.Text = displayedTeam.RegionName;
                    InfoPanelLabel3.Text = "Побед:";
                    InfoPanelLabelField3.Text = displayedTeam.Wins.ToString();
                    InfoPanelLabel4.Text = "Ничьих:";
                    InfoPanelLabelField4.Text = displayedTeam.Draws.ToString();
                    InfoPanelLabel5.Text = "Поражений:";
                    InfoPanelLabelField5.Text = displayedTeam.Defeats.ToString();
                    InfoPanelLabel6.Text = "Выиграно денег:";
                    InfoPanelLabelField6.Text = displayedTeam.Money.ToString();
                    InfoPanelLabel7.Text = "Рейтинг:";
                    InfoPanelLabelField7.Text = displayedTeam.Rating.ToString();
                    InfoPanelLabel8.Text = "Менеджер:";
                    InfoPanelLabelField8.Text = Controller.ReturnNickname(displayedTeam.ManagerID);
                    break;

            }
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (InformationPanel.Width < 300) InformationPanel.Width += 60;
            else timer1.Stop();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (InformationPanel.Width > 10) InformationPanel.Width -= 60;
            else timer2.Stop();
        }

        #region Экспорт данных
        private void CreatePdfButton_Click(object sender, EventArgs e)
        {
            CreateFile(true, false);
        }
        
        private void CreateExcelButton_Click(object sender, EventArgs e)
        {
            CreateFile(false, false);
        }
        private void CreateWordButton_Click(object sender, EventArgs e)
        {
            CreateFile(false, true);
        }

        /// <summary>
        /// Создает файл Excel, который при необходимости конвертируется в другой формат.
        /// </summary>
        /// <param name="isPDF">Вариант сохранения в PDF</param>
        /// <param name="isWord">Вариант сохранения в Word</param>
        private void CreateFile(bool isPDF, bool isWord)
        {
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            SaveFileDialog saveDialog = new SaveFileDialog();
            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "ExportedFromDatGrid";
                int cellRowIndex = 1;
                int cellColumnIndex = 1;
                //Fill headers
                for (int j = 0; j < currentGrid.Columns.Count; j++)
                {
                    if (currentGrid.Columns[j].Visible == true)
                    {
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = currentGrid.Columns[j].HeaderText;
                        cellColumnIndex++;
                    }
                }
                cellColumnIndex = 1;
                cellRowIndex = 2;
                //Fill data
                for (int i = 0; i < currentGrid.Rows.Count; i++)
                {
                    for (int j = 0; j < currentGrid.Columns.Count; j++)
                    {
                        if (currentGrid.Columns[j].Visible == true)
                        {
                             worksheet.Cells[cellRowIndex, cellColumnIndex] = currentGrid.Rows[i].Cells[j].Value.ToString();                                
                             cellColumnIndex++;
                        }
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }                
                worksheet.Columns["A:D"].ColumnWidth = 15;
                worksheet.Columns["F:H"].ColumnWidth = 10;
                if (!isPDF)
                {
                    if(!isWord)
                    {
                        saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                        saveDialog.FilterIndex = 2;
                    }
                    else
                    {
                        saveDialog.Filter = "Word files (*.doc)|*.doc|All files (*.*)|*.*";
                        saveDialog.FilterIndex = 2;                        
                    }
                    if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        workbook.SaveAs(saveDialog.FileName);
                        MessageBox.Show("Export Successful");
                    }
                }
                else
                {
                    saveDialog.Filter = "PDF (*.pdf)|*.pdf|All files (*.*)|*.*";
                    saveDialog.FilterIndex = 2;
                    if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        workbook.SaveAs(saveDialog.FileName);
                        workbook.ExportAsFixedFormat(Microsoft.Office.Interop.Excel.XlFixedFormatType.xlTypePDF, saveDialog.FileName + ".pdf");
                        MessageBox.Show("Export Successful");
                    }
                }                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {               
                workbook.Close(0);  
                excel.Quit();
                excel = null;
                workbook = null;
                System.Diagnostics.Process[] process = System.Diagnostics.Process.GetProcessesByName("Excel");
                foreach (System.Diagnostics.Process p in process)
                {
                    if (!string.IsNullOrEmpty(p.ProcessName))
                    {
                        p.Kill();
                    }
                }
                if (isWord) CreateWordFile(saveDialog.FileName + ".xlsx");
                if (isPDF || isWord) File.Delete(saveDialog.FileName+".xlsx");
            }
        }

       /// <summary>
       /// Создает файл формата .doc
       /// </summary>
       /// <param name="path">Путь к Excel файлу, из которого берется таблица.</param>
        private void CreateWordFile (string path)
        {
            Spire.Xls.Workbook workbook = new Spire.Xls.Workbook();
            workbook.LoadFromFile(path);            
            Spire.Xls.Worksheet sheet = workbook.Worksheets[0];
            Document doc = new Document();
            Table table = doc.AddSection().AddTable(true);
            table.ResetCells(sheet.LastRow, sheet.LastColumn);
            for (int r = 1; r <= sheet.LastRow; r++)
            {
                for (int c = 1; c <= sheet.LastColumn; c++)
                {
                    CellRange xCell = sheet.Range[r, c];
                    TableCell wCell = table.Rows[r - 1].Cells[c - 1];                    
                    TextRange textRange = wCell.AddParagraph().AppendText(xCell.NumberText);
                }
            }
            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j = 0; j < table.Rows[i].Cells.Count; j++)
                {
                    table.Rows[i].Cells[j].Width = 100f;
                }
            }
            doc.SaveToFile("result.doc", Spire.Doc.FileFormat.Docx);
            System.Diagnostics.Process.Start("result.doc");
        }
        #endregion

        private void CloseInfoPanel_Click(object sender, EventArgs e)
        {
            timer2.Start();
            InformationPanel.Enabled = false;
            InformationPanel.Visible = false;
        }

        
        private void OnTextboxClick(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTextBox textBox = (MetroFramework.Controls.MetroTextBox)sender;
            textBox.SelectAll();
        }
            
        private void ResetButton_Click(object sender, EventArgs e)
        {
            PlayerGrid.DataSource = Controller.GetPlayers();
            FilterAge.SelectedIndex = 0;
            FilterCountry.SelectedIndex = 0;
            FilterName.Text = "";
            FilterNickname.Text = "";
            FilterSurname.Text = "";
            RatingLabel.Text = "0";
            MapsLabel.Text = "0";
            RoundsLabel.Text = "0";
            FilterRating.Value = 0;
            FilterPlayedMaps.Value = 0;
            FilterPlayedRounds.Value = 0;
            comboCountryUsed = false;
            comboAgeUsed = false;
        }

        #region Фильтрация
        private Dictionary<string, string> FillFilterDictionary()
        {
            Dictionary<string, string> filters = new Dictionary<string, string>();
            switch (TabControl.SelectedTab.Text)
            {
                case "Игроки":
                    
                    filters.Add($"{currentGrid.Columns[1].DataPropertyName}", FilterName.Text);
                    filters.Add($"{currentGrid.Columns[2].DataPropertyName}", FilterNickname.Text);
                    filters.Add($"{currentGrid.Columns[3].DataPropertyName}", FilterSurname.Text);
                    if (comboCountryUsed) filters.Add($"{currentGrid.Columns[5].DataPropertyName}", FilterCountry.Text);
                    if (comboAgeUsed) filters.Add($"{currentGrid.Columns[6].DataPropertyName}", FilterAge.SelectedItem.ToString());
                    filters.Add($"{currentGrid.Columns[7].DataPropertyName}", FilterRating.Value.ToString());
                    filters.Add($"{currentGrid.Columns[8].DataPropertyName}", FilterPlayedMaps.Value.ToString());
                    filters.Add($"{currentGrid.Columns[9].DataPropertyName}", FilterPlayedRounds.Value.ToString());
                    RatingLabel.Text = FilterRating.Value.ToString();
                    MapsLabel.Text = FilterPlayedMaps.Value.ToString();
                    RoundsLabel.Text = FilterPlayedRounds.Value.ToString();
                    break;
                case "Команды":
                    filters.Add($"{currentGrid.Columns[1].DataPropertyName}", FilterTeamName.Text);
                    if(comboRegionUsed) filters.Add($"{currentGrid.Columns[2].DataPropertyName}", FilterTeamRegion.Text);
                    filters.Add($"{currentGrid.Columns[3].DataPropertyName}", FilterTeamWins.Value.ToString());
                    filters.Add($"{currentGrid.Columns[4].DataPropertyName}", FilterTeamDraws.Value.ToString());
                    filters.Add($"{currentGrid.Columns[5].DataPropertyName}", FilterTeamDefeats.Value.ToString());
                    filters.Add($"{currentGrid.Columns[6].DataPropertyName}", FilterTeamMoney.Value.ToString());
                    filters.Add($"{currentGrid.Columns[7].DataPropertyName}", FilterTeamRating.Value.ToString());
                    TeamWinsLabel.Text = FilterTeamWins.Value.ToString();
                    TeamDrawsLabel.Text = FilterTeamDraws.Value.ToString();
                    TeamDefeatsLabel.Text = FilterTeamDefeats.Value.ToString();
                    TeamMoneyLabel.Text = FilterTeamMoney.Value.ToString();
                    TeamRatingLabel.Text = FilterTeamRating.Value.ToString();
                    break;
            }
            return filters;

        }

        private void FilterPlayersEvent(object sender, EventArgs e)
        {
            switch (TabControl.SelectedTab.Text)
            {
                case "Игроки":
                    currentGrid.DataSource = Controller.GetPlayers(FillFilterDictionary());
                    break;
                case "Команды":
                    currentGrid.DataSource = Controller.GetTeams(FillFilterDictionary());
                    break;
            }        
        }

        private void FilterRating_Scroll(object sender, ScrollEventArgs e)
        {
            switch (TabControl.SelectedTab.Text)
            {
                case "Игроки":
                    currentGrid.DataSource = Controller.GetPlayers(FillFilterDictionary());
                    break;
                case "Команды":
                    currentGrid.DataSource = Controller.GetTeams(FillFilterDictionary());
                    break;
            }
        }

        private void FilterCountry_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboCountryUsed = true;
            currentGrid.DataSource = Controller.GetPlayers(FillFilterDictionary());
        }

        private void FilterAge_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboAgeUsed = true;
            currentGrid.DataSource = Controller.GetPlayers(FillFilterDictionary());
        }
        private void FilterTeamRegion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboRegionUsed = true;
            currentGrid.DataSource = Controller.GetTeams(FillFilterDictionary());
        }
        #endregion


        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(TabControl.SelectedTab.Text)
            {
                case "Команды":
                    currentGrid = TeamGrid;
                    TeamGrid.DataSource = Controller.GetTeams();
                    TeamGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
                    TeamGrid.Refresh();
                    TeamGrid.Update();
                    CreateTeamButton.Enabled = false;
                    if (Program.currentPlayer != null && (Program.currentPlayer.Role.Role1 == "Менеджер" || Program.currentPlayer.Role.Role1 == "Администратор"))
                    {
                        CreateTeamButton.Visible = true;
                        if (Controller.IsAlreadyHasATeam(Program.currentPlayer.PlayerID))
                        {
                            CreateTeamButton.Enabled = false;
                        }
                        else CreateTeamButton.Enabled = true;
                    }
                    break;
                case "Игроки":
                    currentGrid = PlayerGrid;
                    currentGrid.DataSource = Controller.GetPlayers();
                    PlayerGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
                    CreateTeamButton.Enabled = false;
                    CreateTeamButton.Visible = false;
                    break;
                case "Чемпионаты":                    
                    break;
            }
        }

        private void CreateTeamButton_Click(object sender, EventArgs e)
        {
            CreateTeam ct = new CreateTeam();
            ct.Owner = this;
            ct.Show();
            this.Enabled = false;
            this.Hide();
        }

        private void ResetTeamButton_Click(object sender, EventArgs e)
        {
            TeamGrid.DataSource = Controller.GetTeams();
            FilterTeamRegion.SelectedIndex = 0;
            FilterTeamName.Text = "";
            TeamWinsLabel.Text = "0";
            TeamDrawsLabel.Text = "0";
            TeamDefeatsLabel.Text = "0";
            TeamMoneyLabel.Text = "0";
            TeamRatingLabel.Text = "0";
            FilterTeamRating.Value = 0;
            FilterTeamWins.Value = 0;
            FilterTeamDraws.Value = 0;
            FilterTeamDefeats.Value = 0;
            FilterTeamMoney.Value = 0;
            comboRegionUsed = false;
        }
    }
    
}
