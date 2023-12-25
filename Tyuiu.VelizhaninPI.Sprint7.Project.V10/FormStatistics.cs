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

        // Поиск по ID заказа
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

            if (StripTextBoxSearchID_VPI.Text.Length == 5)
            {
                for (int i = 0; i < dataGridViewStatistics_VPI.RowCount; i++)
                {
                    dataGridViewStatistics_VPI.Rows[i].Visible = true;
                }
                int cost = 0;
                chartStatistics_VPI.Titles.Clear();
                chartStatistics_VPI.Titles.Add("Стоимость заказа");
                chartStatistics_VPI.Series[0].Points.Clear();
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

                                string surname = dataGridViewStatistics_VPI.Rows[i].Cells[0].Value.ToString();
                                string firstname = dataGridViewStatistics_VPI.Rows[i].Cells[1].Value.ToString();
                                string otchestvo = dataGridViewStatistics_VPI.Rows[i].Cells[2].Value.ToString();
                                string phoneNumber = dataGridViewStatistics_VPI.Rows[i].Cells[6].Value.ToString();
                                string accountNumber = dataGridViewStatistics_VPI.Rows[i].Cells[3].Value.ToString();
                                string area = dataGridViewStatistics_VPI.Rows[i].Cells[4].Value.ToString();
                                string address = dataGridViewStatistics_VPI.Rows[i].Cells[5].Value.ToString();
                                string name = surname + " " + firstname + " " + otchestvo;
                                string date = dataGridViewStatistics_VPI.Rows[i].Cells[8].Value.ToString();
                                string product = dataGridViewStatistics_VPI.Rows[i].Cells[9].Value.ToString();
                                cost += Convert.ToInt32(dataGridViewStatistics_VPI.Rows[i].Cells[10].Value.ToString());

                                labelName_VPI.Text = name;
                                labelPhoneNumber_VPI.Text = phoneNumber;
                                labelAccountNumber_VPI.Text = accountNumber;
                                labelAddress_VPI.Text = "Район " + area + ", " + address;

                                labelNameConst_VPI.Visible = true;
                                labelPhoneNumberConst_VPI.Visible = true;
                                labelAccountNumberConst_VPI.Visible = true;
                                labelAddressConst_VPI.Visible = true;

                                textBoxOrderList_VPI.Visible = true;
                                labelOrderIDConst_VPI.Visible = true;
                                labelDateConst_VPI.Visible = true;
                                labelOrderListConst_VPI.Visible = true;
                                labelCostConst_VPI.Visible = true;
                                labelCost_VPI.Visible = true;

                                labelOrderIDConst_VPI.Text = "ID заказа:";
                                labelDateConst_VPI.Text = "Дата исполнения заказа:";
                                labelOrderListConst_VPI.Text = "Состав заказа:";
                                labelCostConst_VPI.Text = "Суммарная стоимость заказа:";


                                labelOrderID_VPI.Text = StripTextBoxSearchID_VPI.Text;
                                labelDate_VPI.Text = date;
                                textBoxOrderList_VPI.Text += product + ", ";
                                labelCost_VPI.Text = Convert.ToString(cost) + " руб.";

                                groupBoxStatistics_VPI.Text = "Данные заказа";


                                ////////////// ГРАФИК
                                chartStatistics_VPI.Visible = true;
                                int costNow = Convert.ToInt32(dataGridViewStatistics_VPI.Rows[i].Cells[10].Value.ToString());
                                string productWithCostNow = dataGridViewStatistics_VPI.Rows[i].Cells[9].Value.ToString() + Environment.NewLine + $"{costNow} руб.";
                                this.chartStatistics_VPI.Series[0].Points.AddXY(productWithCostNow, costNow);
                                break;
                            }
                    ToolStripMenuItemRemoveSearch_VPI.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("ID заказа должен состоять из 5 символов и начинаться с цифры. Удалите лишние символы и попробуйте ещё раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Поиск по номеру телефона
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

            if (StripTextBoxSearchNumber_VPI.Text.Length == 11 && StripTextBoxSearchNumber_VPI.Text.Substring(0, 1) != "+")
            {
                for (int i = 0; i < dataGridViewStatistics_VPI.RowCount; i++)
                {
                    dataGridViewStatistics_VPI.Rows[i].Visible = true;
                }
                int cost = 0;
                int idcount = 0;
                chartStatistics_VPI.Titles.Clear();
                chartStatistics_VPI.Titles.Add("Суммарная стоимость заказов");
                chartStatistics_VPI.Series[0].Points.Clear();
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

                                string surname = dataGridViewStatistics_VPI.Rows[i].Cells[0].Value.ToString();
                                string firstname = dataGridViewStatistics_VPI.Rows[i].Cells[1].Value.ToString();
                                string otchestvo = dataGridViewStatistics_VPI.Rows[i].Cells[2].Value.ToString();
                                string phoneNumber = dataGridViewStatistics_VPI.Rows[i].Cells[6].Value.ToString();
                                string accountNumber = dataGridViewStatistics_VPI.Rows[i].Cells[3].Value.ToString();
                                string area = dataGridViewStatistics_VPI.Rows[i].Cells[4].Value.ToString();
                                string address = dataGridViewStatistics_VPI.Rows[i].Cells[5].Value.ToString();
                                string name = surname + " " + firstname + " " + otchestvo;
                                string date = dataGridViewStatistics_VPI.Rows[i].Cells[8].Value.ToString();
                                string product = dataGridViewStatistics_VPI.Rows[i].Cells[9].Value.ToString();
                                string orderID = dataGridViewStatistics_VPI.Rows[i].Cells[7].Value.ToString();
                                if (dataGridViewStatistics_VPI.Rows[i].Cells[7].Value.ToString() != dataGridViewStatistics_VPI.Rows[i - 1].Cells[7].Value.ToString())
                                {
                                    idcount += 1;
                                }
                                cost += Convert.ToInt32(dataGridViewStatistics_VPI.Rows[i].Cells[10].Value.ToString());
                                labelName_VPI.Text = name;
                                labelPhoneNumber_VPI.Text = phoneNumber;
                                labelAccountNumber_VPI.Text = accountNumber;
                                labelAddress_VPI.Text = "Район " + area + ", " + address;

                                labelNameConst_VPI.Visible = true;
                                labelPhoneNumberConst_VPI.Visible = true;
                                labelAccountNumberConst_VPI.Visible = true;
                                labelAddressConst_VPI.Visible = true;

                                labelOrderIDConst_VPI.Visible = true;
                                labelDateConst_VPI.Visible = true;

                                labelOrderListConst_VPI.Visible = false;
                                labelCostConst_VPI.Visible = false;
                                textBoxOrderList_VPI.Visible = false;
                                labelCost_VPI.Visible = false
                                    ;
                                labelOrderIDConst_VPI.Text = "Количество заказов:";
                                labelDateConst_VPI.Text = "Суммарная стоимость заказов:";

                                labelOrderID_VPI.Text = Convert.ToString(idcount);
                                labelDate_VPI.Text = Convert.ToString(cost) + " руб.";

                                groupBoxStatistics_VPI.Text = "Данные заказчика";

                                ////////////// ГРАФИК
                                chartStatistics_VPI.Visible = true;
                                int costNow = Convert.ToInt32(dataGridViewStatistics_VPI.Rows[i].Cells[10].Value.ToString());
                                string productWithCostNow = dataGridViewStatistics_VPI.Rows[i].Cells[9].Value.ToString() + Environment.NewLine + $"{costNow} руб.";
                                this.chartStatistics_VPI.Series[0].Points.AddXY(productWithCostNow, costNow);
                                break;
                            }
                }
                ToolStripMenuItemRemoveSearch_VPI.Enabled = true;
            }
            else if (StripTextBoxSearchNumber_VPI.Text.Length != 11)
            {
                MessageBox.Show("Номер телефона должен состоять из 11 символов и начинаться с цифры '8'. Удалите лишние символы и попробуйте ещё раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (StripTextBoxSearchNumber_VPI.Text.Substring(0, 1) == "+")
            {
                MessageBox.Show("Запишите номер телефона, начиная с цифры '8', и попробуйте ещё раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Поиск по совпадениям
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

        // Отмена поиска
        private void ToolStripMenuItemSeacrhRemove_VPI_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewStatistics_VPI.RowCount; i++)
            {
                dataGridViewStatistics_VPI.Rows[i].Visible = true;
            }
            ToolStripMenuItemRemoveSearch_VPI.Enabled = false;
            labelNameConst_VPI.Visible = false;
            labelPhoneNumberConst_VPI.Visible = false;
            labelAccountNumberConst_VPI.Visible = false;
            labelAddressConst_VPI.Visible = false;

            labelName_VPI.Text = "";
            labelPhoneNumber_VPI.Text = "";
            labelAccountNumber_VPI.Text = "";
            labelAddress_VPI.Text = "";

            textBoxOrderList_VPI.Visible = false;
            labelOrderIDConst_VPI.Visible = false;
            labelDateConst_VPI.Visible = false;
            labelOrderListConst_VPI.Visible = false;
            labelCostConst_VPI.Visible = false;

            labelOrderID_VPI.Text = "";
            labelDate_VPI.Text = "";
            textBoxOrderList_VPI.Text = "";
            labelCost_VPI.Text = "";
                
            groupBoxStatistics_VPI.Text = "";

            chartStatistics_VPI.Titles.Clear();
            chartStatistics_VPI.Series[0].Points.Clear();
        }

        // Выход
        private void buttonExit_Click(object sender, EventArgs e)
        {
            var question = MessageBox.Show("Вы действительно хотите перейти на главную?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (question == DialogResult.Yes)
            {
                this.Close();
            }
            else if (question == DialogResult.No)
            {
            
            }
        }

    }
}
