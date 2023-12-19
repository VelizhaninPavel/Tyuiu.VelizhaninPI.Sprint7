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
            saveFileDialogTask_VPI.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

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

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewDataBase_VPI.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            textBoxSearch_VPI.Enabled = true;
            buttonDeleteRow_VPI.Enabled = true;
            toolStripMenuItemSaveFile_VPI.Enabled = true;
            ToolStripMenuItemSaveFile_csv_VPI.Enabled = true;
            ToolStripMenuItemSaveFile_xlsx_VPI.Enabled = true;
        }

        private void ToolStripMenuItemSaveFile_xlsx_VPI_Click(object sender, EventArgs e)
        {

        }
    }
}