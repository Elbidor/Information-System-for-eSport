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
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        bool comboCountryUsed = false;
        bool comboAgeUsed = false;
        bool comboRegionUsed = false;
        bool teamsAreOpend = false;
        bool comboCityUsed = false;
        bool startDateUsed = false;
        bool finishtDateUsed = false;
        Player displayedPlayer = null;
        MetroFramework.Controls.MetroGrid currentGrid = null;
        public MainForm()
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
            FilterChampCity.DataSource = Controller.GetCities();
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

        #region Аутентификация
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
        #endregion

        #region Изменения на форме
        private void Form1_EnabledChanged(object sender, EventArgs e)
        {
            ChangeView(Program.currentPlayer != null);
            TabControl_SelectedIndexChanged(sender, e);
        }

        private void OnTextboxClick(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTextBox textBox = (MetroFramework.Controls.MetroTextBox)sender;
            textBox.SelectAll();
        }

        // <summary>
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
                    DeleteTeamButton.Enabled = false;
                    DeleteTeamButton.Visible = false;
                    ChangeTeamButton.Enabled = false;
                    ChangeTeamButton.Visible = false;
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

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TabControl.SelectedTab.Text)
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
                    DeleteTeamButton.Enabled = false;
                    DeleteTeamButton.Visible = false;
                    ChangeTeamButton.Enabled = false;
                    ChangeTeamButton.Visible = false;
                    CreateChamp.Enabled = false;
                    CreateChamp.Visible = false;
                    DeleteChamp.Enabled = false;
                    DeleteChamp.Visible = false;
                    UpdateChamp.Enabled = false;
                    UpdateChamp.Visible = false;
                    break;
                case "Чемпионаты":
                    currentGrid = TournamentGrid;
                    TournamentGrid.DataSource = Controller.GetTournaments();
                    TournamentGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
                    TournamentGrid.Refresh();
                    TournamentGrid.Update();
                    CreateChamp.Enabled = false;
                    if (Program.currentPlayer != null && (Program.currentPlayer.Role.Role1 == "Организатор" || Program.currentPlayer.Role.Role1 == "Администратор"))
                    {
                        CreateChamp.Visible = true;
                        CreateChamp.Enabled = true;
                        DeleteChamp.Enabled = true;
                        DeleteChamp.Visible = true;
                        UpdateChamp.Enabled = true;
                        UpdateChamp.Visible = true;
                    }
                    break;
            }
        }
        #endregion

        #region Контролы игрока
        private void ExitButton_Click(object sender, EventArgs e)
        {
            ChangeView(Program.currentPlayer == null);
            TabControl_SelectedIndexChanged(sender, e);
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
        #endregion
        
        #region Информационная панель
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
                    careerGrid.Height = 0;
                    timer1.Start();
                    foreach (DataGridViewRow row in currentGrid.SelectedRows)
                    {
                        displayedPlayer = Controller.FindPlayer((Guid)row.Cells[0].Value);
                    }
                    InformationPanel.Visible = true;
                    InformationPanel.Enabled = true;
                    InfoPanelHeadLabel.Text = "Информация об игроке";
                    InfoPanelLabelField1.Text = displayedPlayer.Name;
                    InfoPanelLabelField1.Location = new System.Drawing.Point(53,58);
                    InfoPanelLabelField2.Text = displayedPlayer.Nickname;
                    InfoPanelLabelField2.Location = new System.Drawing.Point(97, 88);
                    InfoPanelLabelField3.Text = displayedPlayer.Surname;
                    InfoPanelLabelField3.Location = new System.Drawing.Point(95, 118);
                    InfoPanelLabelField4.Text = displayedPlayer.Age.ToString();
                    InfoPanelLabelField4.Location = new System.Drawing.Point(86, 148);
                    InfoPanelLabelField6.Text = displayedPlayer.PlayedMaps.ToString();
                    InfoPanelLabelField6.Location = new System.Drawing.Point(131, 208);
                    InfoPanelLabelField7.Text = displayedPlayer.PlayedRounds.ToString();
                    InfoPanelLabelField7.Location = new System.Drawing.Point(165, 238);
                    InfoPanelLabelField5.Text = displayedPlayer.CountryName;
                    InfoPanelLabelField5.Location = new System.Drawing.Point(80, 178);
                    InfoPanelLabelField8.Text = Controller.ReturnLatestTeam(displayedPlayer.PlayerID);
                    InfoPanelLabelField8.Location = new System.Drawing.Point(165, 268);
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
                        displayedTeam = Controller.FindTeamByID((Guid)row.Cells[0].Value);
                    }
                    InformationPanel.Visible = true;
                    InformationPanel.Enabled = true;
                    InfoPanelHeadLabel.Text = "Информация о команде:";                    
                    InfoPanelLabel1.Text = "Имя:";
                    InfoPanelLabelField1.Text = displayedTeam.Name;
                    InfoPanelLabel2.Text = "Регион:";
                    InfoPanelLabelField2.Text = displayedTeam.RegionName;
                    InfoPanelLabelField2.Location = new System.Drawing.Point(83, 88);
                    InfoPanelLabel3.Text = "Побед:";
                    InfoPanelLabelField3.Text = displayedTeam.Wins.ToString();
                    InfoPanelLabelField3.Location = new System.Drawing.Point(80, 118);
                    InfoPanelLabel4.Text = "Ничьих:";
                    InfoPanelLabelField4.Text = displayedTeam.Draws.ToString();
                    InfoPanelLabelField4.Location = new System.Drawing.Point(76, 148);
                    InfoPanelLabel5.Text = "Поражений:";
                    InfoPanelLabelField5.Text = displayedTeam.Defeats.ToString();
                    InfoPanelLabelField5.Location = new System.Drawing.Point(110, 178);
                    InfoPanelLabel6.Text = "Выиграно денег:";
                    InfoPanelLabelField6.Text = displayedTeam.Money.ToString();
                    InfoPanelLabelField6.Location = new System.Drawing.Point(145, 208);
                    InfoPanelLabel7.Text = "Рейтинг:";
                    InfoPanelLabelField7.Text = displayedTeam.Rating.ToString();
                    InfoPanelLabelField7.Location = new System.Drawing.Point(95, 238);
                    InfoPanelLabel8.Text = "Менеджер:";
                    InfoPanelLabelField8.Text = Controller.ReturnNickname(displayedTeam.ManagerID);
                    InfoPanelLabelField8.Location = new System.Drawing.Point(106, 268);
                    break;
                case "Чемпионаты":                    
                    break;

            }
        }

        private void CloseInfoPanel_Click(object sender, EventArgs e)
        {
            timer2.Start();
            InformationPanel.Enabled = false;
            InformationPanel.Visible = false;
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
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (careerGrid.Height < 298) careerGrid.Height += 100;
            else timer3.Stop();
        }
        private void CareerInfo_Click(object sender, EventArgs e)
        {
            switch (TabControl.SelectedTab.Text)
            {
                case "Игроки":
                    if (!teamsAreOpend)
                    {
                        timer3.Start();
                        careerGrid.DataSource = Controller.GetCareer(displayedPlayer.PlayerID);
                        teamsAreOpend = true;
                    }
                    else
                    {
                        careerGrid.Height = 0;
                        teamsAreOpend = false;
                    }
                    break;
                case "Команды":
                    timer3.Start();
                    break;
            }
        }
        
        #endregion

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
                    if (comboRegionUsed) filters.Add($"{currentGrid.Columns[2].DataPropertyName}", FilterTeamRegion.Text);
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
                case "Чемпионаты":
                    filters.Add($"{currentGrid.Columns[1].DataPropertyName}", FilterChampName.Text);
                    if (comboCityUsed) filters.Add($"{currentGrid.Columns[2].DataPropertyName}", FilterChampCity.SelectedValue.ToString());
                    filters.Add($"{currentGrid.Columns[4].DataPropertyName}", FilterTeamsCount.Value.ToString());
                    if (startDateUsed) filters.Add($"{currentGrid.Columns[5].DataPropertyName}", FilterStartTime.Value.ToString());
                    if (finishtDateUsed) filters.Add($"{currentGrid.Columns[6].DataPropertyName}", FilterFinishTime.Value.ToString());
                    filters.Add($"{currentGrid.Columns[7].DataPropertyName}", FilterChampPrize.Value.ToString());                    
                    FilterTeamsCountLabel.Text = FilterTeamsCount.Value.ToString();
                    FilterPrizeLabel.Text = FilterChampPrize.Value.ToString();                    
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
                case "Чемпионаты":
                    currentGrid.DataSource = Controller.GetTournaments(FillFilterDictionary());
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
                case "Чемпионаты":
                    currentGrid.DataSource = Controller.GetTournaments(FillFilterDictionary());
                    break;
            }
        }

        private void FilterStartTime_ValueChanged(object sender, EventArgs e)
        {
            startDateUsed = true;
            currentGrid.DataSource = Controller.GetTournaments(FillFilterDictionary());
        }

        private void FilterFinishTime_ValueChanged(object sender, EventArgs e)
        {
            finishtDateUsed = true;
            currentGrid.DataSource = Controller.GetTournaments(FillFilterDictionary());
        }
        private void FilterCountry_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboCountryUsed = true;
            currentGrid.DataSource = Controller.GetPlayers(FillFilterDictionary());
        }
        private void FilterChampCity_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboCityUsed = true;
            currentGrid.DataSource = Controller.GetTournaments(FillFilterDictionary());
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
        private void metroLink7_Click(object sender, EventArgs e)
        {
            TournamentGrid.DataSource = Controller.GetTournaments();
            FilterChampName.Text = "";
            FilterChampCity.SelectedIndex = 0;
            FilterStartTime.Value = DateTime.Today;
            FilterFinishTime.Value = DateTime.Today;
            FilterTeamsCount.Value = 0;
            FilterChampPrize.Value = 0;
            FilterTeamsCountLabel.Text = "0";
            FilterPrizeLabel.Text = "0";
            comboCityUsed = false;
            finishtDateUsed = false;
            startDateUsed = false;
        }

        #endregion

        #region Контролы менеджера
        private void CreateTeamButton_Click(object sender, EventArgs e)
        {
            CreateTeam ct = new CreateTeam();
            ct.Owner = this;
            ct.Show();
            this.Enabled = false;
            this.Hide();
        }
        private void ChangeTeamButton_Click(object sender, EventArgs e)
        {
            CreateTeam ct = new CreateTeam();
            ct.Owner = this;
            ct.Show();
            this.Enabled = false;
            this.Hide();
        }
        private void DeleteTeamButton_Click(object sender, EventArgs e)
        {
            Controller.DeleteTeam(Program.currentPlayer.PlayerID);
            DeleteTeamButton.Enabled = false;
            CreateTeamButton.Enabled = true;
            ChangeTeamButton.Enabled = true;
        }


        #endregion

        private void CreateChamp_Click(object sender, EventArgs e)
        {
            CreateChamp ct = new CreateChamp();
            ct.Owner = this;
            ct.Show();
            this.Enabled = false;
            this.Hide();
            UpdateChamp.Enabled = true;
            DeleteChamp.Enabled = true;
        }

        private void DeleteChamp_Click(object sender, EventArgs e)
        {
            Controller.DeleteTeam(Program.currentPlayer.PlayerID);

        }

        private void UpdateChamp_Click(object sender, EventArgs e)
        {
            UpdateChamp ct = new UpdateChamp();
            ct.Owner = this;
            ct.Show();
            this.Enabled = false;
            this.Hide();
        }
    }

}
