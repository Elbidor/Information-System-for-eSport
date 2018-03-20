using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataController;
using DataModel;
using System.IO;
using Microsoft.Office.Interop.Excel;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using Spire.Xls;
using Spire.Xls.Collections;
using Spire.Xls.Core;

namespace Information_System_for_eSport
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        MetroFramework.Controls.MetroGrid currentGrid = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentGrid = PlayerGrid;
            currentGrid.DataSource = Controller.GetPlayers();
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
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ChangeView(Program.currentPlayer == null);
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
                currentGrid.DataSource = Controller.GetPlayers();
                this.playersTableAdapter.Fill(this.cybersportDBDataSet2.Players);
            }
            else
            {
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
            switch (TabControl.SelectedTab.Name)
            {
                case "PlayerTab":
                    timer1.Start();
                    Player displayedPlayer = null;
                    foreach (DataGridViewRow row in currentGrid.SelectedRows)
                    {
                        displayedPlayer = Controller.FindPlayer((Guid)row.Cells[0].Value);
                    }
                    InformationPanel.Visible = true;
                    InformationPanel.Enabled = true;
                    InfoPanelNameField.Visible = true;
                    InfoPanelNicknameField.Visible = true;
                    InfoPanelSurnameField.Visible = true;
                    InfoPanelAgeField.Visible = true;
                    InfoPanelPlayedMapsField.Visible = true;
                    InfoPanelPlayedRoundsField.Visible = true;
                    InfoPanelCountryField.Visible = true;
                    InfoPanelCurrentTeam.Visible = true;
                    InfoPanelNameField.Text = displayedPlayer.Name;
                    InfoPanelNicknameField.Text = displayedPlayer.Nickname;
                    InfoPanelSurnameField.Text = displayedPlayer.Surname;
                    InfoPanelAgeField.Text = displayedPlayer.Age.ToString();
                    InfoPanelPlayedMapsField.Text = displayedPlayer.PlayedMaps.ToString();
                    InfoPanelPlayedRoundsField.Text = displayedPlayer.PlayedRounds.ToString();
                    InfoPanelCountryField.Text = displayedPlayer.CountryName;
                    InfoPanelCurrentTeam.Text = "***"; //Добавить связь с командами
                    break;
            }
        }

        /// <summary>
        /// Таймер для слайдера.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (InformationPanel.Width <= 402) InformationPanel.Width += 60;
            else timer1.Stop();
        }

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

                for (int i = 0; i < currentGrid.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < currentGrid.Columns.Count; j++)
                    {
                        if (currentGrid.Columns[j].Visible == true)
                        {
                            if (cellRowIndex == 1)
                            {
                                worksheet.Cells[cellRowIndex, cellColumnIndex] = currentGrid.Columns[j].HeaderText;
                            }
                            else
                            {
                                worksheet.Cells[cellRowIndex, cellColumnIndex] = currentGrid.Rows[i].Cells[j].Value.ToString();                                
                            }
                            cellColumnIndex++;
                        }
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;                }
                
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
    }
    
}
