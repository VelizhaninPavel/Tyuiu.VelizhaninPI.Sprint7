
namespace Tyuiu.VelizhaninPI.Sprint7.Project.V10
{
    partial class FormStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridViewStatistics_VPI = new System.Windows.Forms.DataGridView();
            this.groupBoxStatistics_VPI = new System.Windows.Forms.GroupBox();
            this.chartStatistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StripMenuItemSearchID_VPI = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSearchID_VPI = new System.Windows.Forms.ToolStripMenuItem();
            this.StripTextBoxSearchID_VPI = new System.Windows.Forms.ToolStripTextBox();
            this.StripMenuItemSearchNumber_VPI = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSearchNumber_VPI = new System.Windows.Forms.ToolStripMenuItem();
            this.StripTextBoxSearchNumber_VPI = new System.Windows.Forms.ToolStripTextBox();
            this.StripMenuItemSearch_VPI = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSearch_VPI = new System.Windows.Forms.ToolStripMenuItem();
            this.StripTextBoxSearch_VPI = new System.Windows.Forms.ToolStripTextBox();
            this.StripMenuItemRemoveSearch_VPI = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRemoveSearch_VPI = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistics_VPI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistics)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStatistics_VPI
            // 
            this.dataGridViewStatistics_VPI.AllowUserToAddRows = false;
            this.dataGridViewStatistics_VPI.AllowUserToDeleteRows = false;
            this.dataGridViewStatistics_VPI.AllowUserToResizeRows = false;
            this.dataGridViewStatistics_VPI.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewStatistics_VPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatistics_VPI.Location = new System.Drawing.Point(13, 33);
            this.dataGridViewStatistics_VPI.Name = "dataGridViewStatistics_VPI";
            this.dataGridViewStatistics_VPI.RowHeadersVisible = false;
            this.dataGridViewStatistics_VPI.RowHeadersWidth = 51;
            this.dataGridViewStatistics_VPI.RowTemplate.Height = 24;
            this.dataGridViewStatistics_VPI.Size = new System.Drawing.Size(751, 401);
            this.dataGridViewStatistics_VPI.TabIndex = 0;
            // 
            // groupBoxStatistics_VPI
            // 
            this.groupBoxStatistics_VPI.Location = new System.Drawing.Point(13, 440);
            this.groupBoxStatistics_VPI.Name = "groupBoxStatistics_VPI";
            this.groupBoxStatistics_VPI.Size = new System.Drawing.Size(1157, 102);
            this.groupBoxStatistics_VPI.TabIndex = 2;
            this.groupBoxStatistics_VPI.TabStop = false;
            this.groupBoxStatistics_VPI.Text = "Данные";
            // 
            // chartStatistics
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStatistics.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStatistics.Legends.Add(legend1);
            this.chartStatistics.Location = new System.Drawing.Point(770, 33);
            this.chartStatistics.Name = "chartStatistics";
            this.chartStatistics.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartStatistics.Series.Add(series1);
            this.chartStatistics.Size = new System.Drawing.Size(400, 400);
            this.chartStatistics.TabIndex = 6;
            this.chartStatistics.Text = "chart1";
            this.chartStatistics.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuItemSearchID_VPI,
            this.StripTextBoxSearchID_VPI,
            this.StripMenuItemSearchNumber_VPI,
            this.StripTextBoxSearchNumber_VPI,
            this.StripMenuItemSearch_VPI,
            this.StripTextBoxSearch_VPI,
            this.StripMenuItemRemoveSearch_VPI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1191, 31);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // StripMenuItemSearchID_VPI
            // 
            this.StripMenuItemSearchID_VPI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSearchID_VPI});
            this.StripMenuItemSearchID_VPI.Name = "StripMenuItemSearchID_VPI";
            this.StripMenuItemSearchID_VPI.Size = new System.Drawing.Size(156, 27);
            this.StripMenuItemSearchID_VPI.Text = "Поиск по ID заказа";
            // 
            // ToolStripMenuItemSearchID_VPI
            // 
            this.ToolStripMenuItemSearchID_VPI.Name = "ToolStripMenuItemSearchID_VPI";
            this.ToolStripMenuItemSearchID_VPI.Size = new System.Drawing.Size(135, 26);
            this.ToolStripMenuItemSearchID_VPI.Text = "Найти";
            this.ToolStripMenuItemSearchID_VPI.Click += new System.EventHandler(this.ToolStripMenuItemSearchID_VPI_Click);
            // 
            // StripTextBoxSearchID_VPI
            // 
            this.StripTextBoxSearchID_VPI.BackColor = System.Drawing.Color.Gainsboro;
            this.StripTextBoxSearchID_VPI.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StripTextBoxSearchID_VPI.Name = "StripTextBoxSearchID_VPI";
            this.StripTextBoxSearchID_VPI.Size = new System.Drawing.Size(100, 27);
            // 
            // StripMenuItemSearchNumber_VPI
            // 
            this.StripMenuItemSearchNumber_VPI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSearchNumber_VPI});
            this.StripMenuItemSearchNumber_VPI.Name = "StripMenuItemSearchNumber_VPI";
            this.StripMenuItemSearchNumber_VPI.Size = new System.Drawing.Size(216, 27);
            this.StripMenuItemSearchNumber_VPI.Text = "Поиск по телефону клиента";
            // 
            // ToolStripMenuItemSearchNumber_VPI
            // 
            this.ToolStripMenuItemSearchNumber_VPI.Name = "ToolStripMenuItemSearchNumber_VPI";
            this.ToolStripMenuItemSearchNumber_VPI.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItemSearchNumber_VPI.Text = "Найти";
            this.ToolStripMenuItemSearchNumber_VPI.Click += new System.EventHandler(this.ToolStripMenuItemSearchNumber_VPI_Click);
            // 
            // StripTextBoxSearchNumber_VPI
            // 
            this.StripTextBoxSearchNumber_VPI.BackColor = System.Drawing.Color.Gainsboro;
            this.StripTextBoxSearchNumber_VPI.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StripTextBoxSearchNumber_VPI.Name = "StripTextBoxSearchNumber_VPI";
            this.StripTextBoxSearchNumber_VPI.Size = new System.Drawing.Size(140, 27);
            // 
            // StripMenuItemSearch_VPI
            // 
            this.StripMenuItemSearch_VPI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSearch_VPI});
            this.StripMenuItemSearch_VPI.Name = "StripMenuItemSearch_VPI";
            this.StripMenuItemSearch_VPI.Size = new System.Drawing.Size(186, 27);
            this.StripMenuItemSearch_VPI.Text = "Поиск по совпадениям";
            // 
            // ToolStripMenuItemSearch_VPI
            // 
            this.ToolStripMenuItemSearch_VPI.Name = "ToolStripMenuItemSearch_VPI";
            this.ToolStripMenuItemSearch_VPI.Size = new System.Drawing.Size(135, 26);
            this.ToolStripMenuItemSearch_VPI.Text = "Найти";
            this.ToolStripMenuItemSearch_VPI.Click += new System.EventHandler(this.ToolStripMenuItemSearch_VPI_Click);
            // 
            // StripTextBoxSearch_VPI
            // 
            this.StripTextBoxSearch_VPI.BackColor = System.Drawing.Color.Gainsboro;
            this.StripTextBoxSearch_VPI.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StripTextBoxSearch_VPI.Name = "StripTextBoxSearch_VPI";
            this.StripTextBoxSearch_VPI.Size = new System.Drawing.Size(100, 27);
            // 
            // StripMenuItemRemoveSearch_VPI
            // 
            this.StripMenuItemRemoveSearch_VPI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemRemoveSearch_VPI});
            this.StripMenuItemRemoveSearch_VPI.Name = "StripMenuItemRemoveSearch_VPI";
            this.StripMenuItemRemoveSearch_VPI.Size = new System.Drawing.Size(129, 27);
            this.StripMenuItemRemoveSearch_VPI.Text = "Отмена поиска";
            // 
            // ToolStripMenuItemRemoveSearch_VPI
            // 
            this.ToolStripMenuItemRemoveSearch_VPI.Name = "ToolStripMenuItemRemoveSearch_VPI";
            this.ToolStripMenuItemRemoveSearch_VPI.Size = new System.Drawing.Size(143, 26);
            this.ToolStripMenuItemRemoveSearch_VPI.Text = "отмена";
            this.ToolStripMenuItemRemoveSearch_VPI.Click += new System.EventHandler(this.ToolStripMenuItemSeacrhRemove_VPI_Click);
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 549);
            this.Controls.Add(this.chartStatistics);
            this.Controls.Add(this.groupBoxStatistics_VPI);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridViewStatistics_VPI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormStatistics";
            this.Text = "Статистика заказа";
            this.Load += new System.EventHandler(this.FormStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistics_VPI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistics)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStatistics_VPI;
        private System.Windows.Forms.GroupBox groupBoxStatistics_VPI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistics;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItemSearchID_VPI;
        private System.Windows.Forms.ToolStripTextBox StripTextBoxSearchID_VPI;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItemSearchNumber_VPI;
        private System.Windows.Forms.ToolStripTextBox StripTextBoxSearchNumber_VPI;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSearchID_VPI;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSearchNumber_VPI;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItemSearch_VPI;
        private System.Windows.Forms.ToolStripTextBox StripTextBoxSearch_VPI;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSearch_VPI;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItemRemoveSearch_VPI;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRemoveSearch_VPI;
    }
}