using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tyuiu.VelizhaninPI.Sprint7.Project.V10
{
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }

        static int rows;
        static int columns;
        DataTable dtSales = new DataTable();
        string filterField = "Country";
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

            private void FormStatistics_Load(object sender, EventArgs e)
        {

            string path = $@"{Directory.GetCurrentDirectory()}\dataGridViewDataBase_VPI_copy.csv";

            string[,] arrayValues = new string[rows, columns];
            string[] arrayHeaderValues = new string[columns];
            arrayValues = LoadFromFileData(path);
            arrayHeaderValues = OrderData.arrayHeaderValues;

            dataGridViewStatistics_VPI.ColumnCount = columns;
            dataGridViewStatistics_VPI.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewStatistics_VPI.Columns[i].Width = 60;

            }
            dataGridViewStatistics_VPI.Columns[9].Width = 90;
            dataGridViewStatistics_VPI.Columns[5].Width = 89;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewStatistics_VPI.Rows[r].Cells[c].Value = arrayValues[r, c];
                    if (r == 0)
                    {
                        dataGridViewStatistics_VPI.Columns[c].HeaderText = arrayHeaderValues[c];
                    }
                }
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void ToolStripMenuItemSearchID_VPI_Click(object sender, EventArgs e)
        {
            int index = -1;

            foreach (DataGridViewColumn col in dataGridViewStatistics_VPI.Columns)
            {
                if (col.HeaderText == "ID заказа")
                {
                    index = col.Index;
                    break;
                }
            }

            if (StripTextBoxSearchID_VPI.Text.Length <= 5)
            {
                for (int i = 0; i < dataGridViewStatistics_VPI.RowCount; i++)
                {
                    dataGridViewStatistics_VPI.Rows[i].Visible = true;
                }
                for (int i = 0; i < dataGridViewStatistics_VPI.RowCount; i++)
                {
                    dataGridViewStatistics_VPI.Rows[i].Selected = false;
                    dataGridViewStatistics_VPI.Rows[i].Visible = false;
                    for (int j = index; j <= index; j++)
                        if (dataGridViewStatistics_VPI.Rows[i].Cells[j].Value != null)
                            if (dataGridViewStatistics_VPI.Rows[i].Cells[j].Value.ToString().Contains(StripTextBoxSearchID_VPI.Text))
                            {
                                dataGridViewStatistics_VPI.Rows[i].Selected = true;
                                dataGridViewStatistics_VPI.Rows[i].Visible = true;
                                break;
                            }
                }
                ToolStripMenuItemRemoveSearch_VPI.Enabled = true;
            }
            else if (StripTextBoxSearchNumber_VPI.Text.Length > 5)
            {
                MessageBox.Show("ID заказа должен состоять из 5 символов и начинаться с цифры. Удалите лишние символы и попробуйте ещё раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToolStripMenuItemSearchNumber_VPI_Click(object sender, EventArgs e)
        {
            int index = -1;

            foreach (DataGridViewColumn col in dataGridViewStatistics_VPI.Columns)
            {
                if (col.HeaderText == "Телефон")
                {
                    index = col.Index;
                    break;
                }
            }

            if (StripTextBoxSearchNumber_VPI.Text.Length <= 11 && StripTextBoxSearchNumber_VPI.Text.Substring(0, 1) != "+")
            {
                for (int i = 0; i < dataGridViewStatistics_VPI.RowCount; i++)
                {
                    dataGridViewStatistics_VPI.Rows[i].Visible = true;
                }
                for (int i = 0; i < dataGridViewStatistics_VPI.RowCount; i++)
                {
                    dataGridViewStatistics_VPI.Rows[i].Selected = false;
                    dataGridViewStatistics_VPI.Rows[i].Visible = false;
                    for (int j = index; j <= index; j++)
                        if (dataGridViewStatistics_VPI.Rows[i].Cells[j].Value != null)
                            if (dataGridViewStatistics_VPI.Rows[i].Cells[j].Value.ToString().Contains(StripTextBoxSearchNumber_VPI.Text))
                            {
                                dataGridViewStatistics_VPI.Rows[i].Selected = true;
                                dataGridViewStatistics_VPI.Rows[i].Visible = true;
                                break;
                            }
                }
                ToolStripMenuItemRemoveSearch_VPI.Enabled = true;
            }
            else if (StripTextBoxSearchNumber_VPI.Text.Length > 11)
            {
                MessageBox.Show("Номер телефона должен состоять из 11 символов и начинаться с цифры '8'. Удалите лишние символы и попробуйте ещё раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (StripTextBoxSearchNumber_VPI.Text.Substring(0, 1) == "+")
            {
                MessageBox.Show("Запишите номер телефона, начиная с цифры '8', и попробуйте ещё раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToolStripMenuItemSearch_VPI_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewStatistics_VPI.RowCount; i++)
            {
                dataGridViewStatistics_VPI.Rows[i].Visible = true;
            }
            for (int i = 0; i < dataGridViewStatistics_VPI.RowCount; i++)
            {
                dataGridViewStatistics_VPI.Rows[i].Selected = false;
                dataGridViewStatistics_VPI.Rows[i].Visible = false;
                for (int j = 0; j < dataGridViewStatistics_VPI.ColumnCount; j++)
                    if (dataGridViewStatistics_VPI.Rows[i].Cells[j].Value != null)
                        if (dataGridViewStatistics_VPI.Rows[i].Cells[j].Value.ToString().Contains(StripTextBoxSearch_VPI.Text))
                        {
                            dataGridViewStatistics_VPI.Rows[i].Selected = true;
                            dataGridViewStatistics_VPI.Rows[i].Visible = true;
                            break;
                        }
            }
            ToolStripMenuItemRemoveSearch_VPI.Enabled = true;
        }
        private void ToolStripMenuItemSeacrhRemove_VPI_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewStatistics_VPI.RowCount; i++)
            {
                dataGridViewStatistics_VPI.Rows[i].Visible = true;
            }
            ToolStripMenuItemRemoveSearch_VPI.Enabled = false;
        }
    }
}
