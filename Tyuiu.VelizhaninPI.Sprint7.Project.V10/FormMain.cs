using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Tyuiu.VelizhaninPI.Sprint7.Project.V10.FormMainProject.Form1;
using Tyuiu.VelizhaninPI.Sprint7.Project.V10.Lib;
using System.IO;

namespace Tyuiu.VelizhaninPI.Sprint7.Project.V10
{
    public partial class FormMainProject : Form
    {
        public FormMainProject()
        {
            InitializeComponent();

            var attribute = DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE;
            var preference = DWM_WINDOW_CORNER_PREFERENCE.DWMWCP_ROUND;
            DwmSetWindowAttribute(this.Handle, attribute, ref preference, sizeof(uint));

            openFileDialogTask_VPI.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        class DoubleBufferedDataGridView : DataGridView
        {
            protected override bool DoubleBuffered { get => true; }
        }
        public partial class Form1 : Form
        {
            public enum
            DWMWINDOWATTRIBUTE
            {
                DWMWA_WINDOW_CORNER_PREFERENCE = 33
            }

            public enum
            DWM_WINDOW_CORNER_PREFERENCE
            {
                DWMWCP_DEFAULT = 0,
                DWMWCP_DONOTROUND = 1,
                DWMWCP_ROUND = 2,
                DWMWCP_ROUNDSMALL = 3
            }

            [DllImport("dwmapi.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
            internal static extern void
            DwmSetWindowAttribute
            (
            IntPtr hwnd, DWMWINDOWATTRIBUTE attribute, ref DWM_WINDOW_CORNER_PREFERENCE pvAttribute, uint cbAttribute);

        }
        public static string[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath, Encoding.GetEncoding(1251));

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            string[,] arrayValues = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = line_r[j];
                }
            }
            return arrayValues;
        }
        public static string[] LoadFromFileHeaders(string filePath)
        {
            string fileData = File.ReadAllText(filePath, Encoding.GetEncoding(1251));

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            columns = lines[0].Split(';').Length;

            string[] arrayHeaderValues = new string[columns];
            for (int i = 0; i < 1; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayHeaderValues[j] = line_r[j];
                }
            }
            return arrayHeaderValues;
        }


        private void toolStripMenuItemOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask_VPI.ShowDialog();
            openFilePath = openFileDialogTask_VPI.FileName;

            string[,] arrayValues = new string[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewDataBase_VPI.ColumnCount = columns;
            dataGridViewDataBase_VPI.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewDataBase_VPI.Columns[i].Width = 75;

            }
            dataGridViewDataBase_VPI.Columns[9].Width = 90;
            dataGridViewDataBase_VPI.Columns[5].Width = 89;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewDataBase_VPI.Rows[r].Cells[c].Value = arrayValues[r, c];
                    if (r == 0)
                    {
                        dataGridViewDataBase_VPI.Columns[c].HeaderText = arrayValues[0, c];
                    }
                }
            }
            dataGridViewDataBase_VPI.Rows.RemoveAt(0);

            textBoxSearch_VPI.Enabled = true;
            buttonDeleteRow_VPI.Enabled = true;
            toolStripMenuItemSaveFile_VPI.Enabled = true;
            ToolStripMenuItemSaveFile_csv_VPI.Enabled = true;
            buttonAddRow_VPI.Enabled = true;
            buttonRowUpDown_VPI.Enabled = true;
            radioButtonRowDown_VPI.Enabled = true;
            radioButtonRowUp_VPI.Enabled = true;
            buttonSearch_VPI.Enabled = true;
            StripMenuItemStatistics_VPI.Enabled = true;
        }

        private void ToolStripMenuItemSaveFile_csv_VPI_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_VPI.FileName = "OutPutFileSprint7.csv";
            saveFileDialogTask_VPI.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.";
            saveFileDialogTask_VPI.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask_VPI.ShowDialog();

            string path = saveFileDialogTask_VPI.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewDataBase_VPI.RowCount;
            int columns = dataGridViewDataBase_VPI.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewDataBase_VPI.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewDataBase_VPI.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine, Encoding.GetEncoding(1251));
                str = "";
            }
        }

        private void StripMenuItemAbout_VPI_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void StripMenuItemGuide_VPI_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }

        private void buttonDeleteRow_VPI_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell thisCell in dataGridViewDataBase_VPI.SelectedCells)
            {
                if (thisCell.Selected)
                {
                    var question = MessageBox.Show("Вы действительно хотите удалить выделенную строку?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (question == DialogResult.Yes)
                    {
                        dataGridViewDataBase_VPI.Rows.RemoveAt(thisCell.RowIndex);
                    }
                    else if (question == DialogResult.No)
                    {
                        break;
                    }
                }
                /*else if (thisCell.Selected == false)
                {
                    MessageBox.Show("Сначала выделите строку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            }
        }

        private void buttonAddRow_VPI_Click(object sender, EventArgs e)
        {
            /*FormOrder formOrder = new FormOrder();
            formOrder.Show();
            dataGridViewDataBase_VPI.Rows.Insert(dataGridViewDataBase_VPI.SelectedCells[0].OwningColumn.Index + 1);
            dataGridViewDataBase_VPI.Rows[dataGridViewDataBase_VPI.SelectedCells[0].OwningColumn.Index + 1].Cells[0].Value = OrderData.textBoxOrder0;
            dataGridViewDataBase_VPI.Rows[dataGridViewDataBase_VPI.SelectedCells[0].OwningColumn.Index + 1].Cells[1].Value = OrderData.textBoxOrder1;
            dataGridViewDataBase_VPI.Rows[dataGridViewDataBase_VPI.SelectedCells[0].OwningColumn.Index + 1].Cells[2].Value = OrderData.textBoxOrder2;
            dataGridViewDataBase_VPI.Rows[dataGridViewDataBase_VPI.SelectedCells[0].OwningColumn.Index + 1].Cells[3].Value = OrderData.textBoxOrder3;
            dataGridViewDataBase_VPI.Rows[dataGridViewDataBase_VPI.SelectedCells[0].OwningColumn.Index + 1].Cells[4].Value = OrderData.textBoxOrder4;
            dataGridViewDataBase_VPI.Rows[dataGridViewDataBase_VPI.SelectedCells[0].OwningColumn.Index + 1].Cells[5].Value = OrderData.textBoxOrder5;
            dataGridViewDataBase_VPI.Rows[dataGridViewDataBase_VPI.SelectedCells[0].OwningColumn.Index + 1].Cells[6].Value = OrderData.textBoxOrder6;
            dataGridViewDataBase_VPI.Rows[dataGridViewDataBase_VPI.SelectedCells[0].OwningColumn.Index + 1].Cells[7].Value = OrderData.textBoxOrder7;
            dataGridViewDataBase_VPI.Rows[dataGridViewDataBase_VPI.SelectedCells[0].OwningColumn.Index + 1].Cells[8].Value = OrderData.textBoxOrder8;
            dataGridViewDataBase_VPI.Rows[dataGridViewDataBase_VPI.SelectedCells[0].OwningColumn.Index + 1].Cells[9].Value = OrderData.textBoxOrder9;
            dataGridViewDataBase_VPI.Rows[dataGridViewDataBase_VPI.SelectedCells[0].OwningColumn.Index + 1].Cells[10].Value = OrderData.textBoxOrder10;*/
            foreach (DataGridViewCell thisCell in dataGridViewDataBase_VPI.SelectedCells)
            {
                if (thisCell.Selected)
                {
                    dataGridViewDataBase_VPI.Rows.Insert(thisCell.RowIndex + 1);

                }
            }
        }

        private void buttonRowUpDown_VPI_Click(object sender, EventArgs e)
        {
            if (radioButtonRowUp_VPI.Checked == true)
            {
                try
                {
                    int totalRows = dataGridViewDataBase_VPI.Rows.Count;
                    // get index of the row for the selected cell
                    int rowIndex = dataGridViewDataBase_VPI.SelectedCells[0].OwningRow.Index;
                    if (rowIndex == 0)
                        return;
                    // get index of the column for the selected cell
                    int colIndex = dataGridViewDataBase_VPI.SelectedCells[0].OwningColumn.Index;
                    DataGridViewRow selectedRow = dataGridViewDataBase_VPI.Rows[rowIndex];
                    dataGridViewDataBase_VPI.Rows.Remove(selectedRow);
                    dataGridViewDataBase_VPI.Rows.Insert(rowIndex - 1, selectedRow);
                    dataGridViewDataBase_VPI.ClearSelection();
                    dataGridViewDataBase_VPI.Rows[rowIndex - 1].Cells[colIndex].Selected = true;
                }
                catch { }
            }

            if (radioButtonRowDown_VPI.Checked == true)
            {
                try
                {
                    int totalRows = dataGridViewDataBase_VPI.Rows.Count;
                    // get index of the row for the selected cell
                    int rowIndex = dataGridViewDataBase_VPI.SelectedCells[0].OwningRow.Index;
                    if (rowIndex == totalRows - 1)
                        return;
                    // get index of the column for the selected cell
                    int colIndex = dataGridViewDataBase_VPI.SelectedCells[0].OwningColumn.Index;
                    DataGridViewRow selectedRow = dataGridViewDataBase_VPI.Rows[rowIndex];
                    dataGridViewDataBase_VPI.Rows.Remove(selectedRow);
                    dataGridViewDataBase_VPI.Rows.Insert(rowIndex + 1, selectedRow);
                    dataGridViewDataBase_VPI.ClearSelection();
                    dataGridViewDataBase_VPI.Rows[rowIndex + 1].Cells[colIndex].Selected = true;
                }
                catch { }
            }

            if (radioButtonRowDown_VPI.Checked == false && radioButtonRowUp_VPI.Checked == false)
            {
                MessageBox.Show("Сначала выберите направление перемещения строки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch_VPI.Text != "")
            {
                for (int i = 0; i < dataGridViewDataBase_VPI.RowCount; i++)
                {
                    dataGridViewDataBase_VPI.Rows[i].Visible = true;
                }
                for (int i = 0; i < dataGridViewDataBase_VPI.RowCount; i++)
                {
                    dataGridViewDataBase_VPI.Rows[i].Selected = false;
                    dataGridViewDataBase_VPI.Rows[i].Visible = false;
                    for (int j = 0; j < dataGridViewDataBase_VPI.ColumnCount; j++)
                        if (dataGridViewDataBase_VPI.Rows[i].Cells[j].Value != null)
                            if (dataGridViewDataBase_VPI.Rows[i].Cells[j].Value.ToString().Contains(textBoxSearch_VPI.Text))
                            {
                                dataGridViewDataBase_VPI.Rows[i].Selected = true;
                                dataGridViewDataBase_VPI.Rows[i].Visible = true;
                                break;
                            }
                }
                buttonSearchRemove_VPI.Enabled = true;
            }
            else
            {
                MessageBox.Show("Сначала введите текст.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearchBack_VPI_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewDataBase_VPI.RowCount; i++)
            {
                dataGridViewDataBase_VPI.Rows[i].Visible = true;
            }
                buttonSearchRemove_VPI.Enabled = false;
        }
        private void StripMenuItemStatistics_VPI_Click(object sender, EventArgs e)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\dataGridViewDataBase_VPI_copy.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewDataBase_VPI.RowCount;
            int columns = dataGridViewDataBase_VPI.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewDataBase_VPI.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewDataBase_VPI.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine, Encoding.GetEncoding(1251));
                str = "";
            }
            string[] arrayHeaderValues = new string[columns];
            OrderData.arrayHeaderValues = LoadFromFileHeaders(openFilePath);
            FormStatistics formStatistics = new FormStatistics();
            formStatistics.Show();
        }
    }
}