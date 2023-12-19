
namespace Tyuiu.VelizhaninPI.Sprint7.Project.V10
{
    partial class FormMainProject
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
            this.panelMain_VPI = new System.Windows.Forms.Panel();
            this.buttonDeleteRow_VPI = new System.Windows.Forms.Button();
            this.textBoxSearch_VPI = new System.Windows.Forms.TextBox();
            this.dataGridViewDataBase_VPI = new System.Windows.Forms.DataGridView();
            this.labelSearch_VPI = new System.Windows.Forms.Label();
            this.menuStripButtons_VPI = new System.Windows.Forms.MenuStrip();
            this.StripMenuItemFile_VPI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpenFile_VPI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveFile_VPI = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSaveFile_csv_VPI = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSaveFile_xlsx_VPI = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItemStatistics_VPI = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItemGuide_VPI = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItemAbout_VPI = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogTask_VPI = new System.Windows.Forms.OpenFileDialog();
            this.toolTipTask_VPI = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogTask_VPI = new System.Windows.Forms.SaveFileDialog();
            this.panelMain_VPI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBase_VPI)).BeginInit();
            this.menuStripButtons_VPI.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain_VPI
            // 
            this.panelMain_VPI.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelMain_VPI.Controls.Add(this.buttonDeleteRow_VPI);
            this.panelMain_VPI.Controls.Add(this.textBoxSearch_VPI);
            this.panelMain_VPI.Controls.Add(this.dataGridViewDataBase_VPI);
            this.panelMain_VPI.Controls.Add(this.labelSearch_VPI);
            this.panelMain_VPI.Location = new System.Drawing.Point(12, 31);
            this.panelMain_VPI.Name = "panelMain_VPI";
            this.panelMain_VPI.Size = new System.Drawing.Size(1203, 570);
            this.panelMain_VPI.TabIndex = 0;
            // 
            // buttonDeleteRow_VPI
            // 
            this.buttonDeleteRow_VPI.Enabled = false;
            this.buttonDeleteRow_VPI.Location = new System.Drawing.Point(1031, 498);
            this.buttonDeleteRow_VPI.Name = "buttonDeleteRow_VPI";
            this.buttonDeleteRow_VPI.Size = new System.Drawing.Size(152, 38);
            this.buttonDeleteRow_VPI.TabIndex = 4;
            this.buttonDeleteRow_VPI.Text = "Удалить строку";
            this.buttonDeleteRow_VPI.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch_VPI
            // 
            this.textBoxSearch_VPI.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxSearch_VPI.Enabled = false;
            this.textBoxSearch_VPI.Location = new System.Drawing.Point(70, 498);
            this.textBoxSearch_VPI.Name = "textBoxSearch_VPI";
            this.textBoxSearch_VPI.Size = new System.Drawing.Size(553, 22);
            this.textBoxSearch_VPI.TabIndex = 3;
            // 
            // dataGridViewDataBase_VPI
            // 
            this.dataGridViewDataBase_VPI.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewDataBase_VPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataBase_VPI.ColumnHeadersVisible = false;
            this.dataGridViewDataBase_VPI.Location = new System.Drawing.Point(15, 16);
            this.dataGridViewDataBase_VPI.Name = "dataGridViewDataBase_VPI";
            this.dataGridViewDataBase_VPI.RowHeadersVisible = false;
            this.dataGridViewDataBase_VPI.RowHeadersWidth = 51;
            this.dataGridViewDataBase_VPI.RowTemplate.Height = 24;
            this.dataGridViewDataBase_VPI.Size = new System.Drawing.Size(1168, 476);
            this.dataGridViewDataBase_VPI.TabIndex = 0;
            // 
            // labelSearch_VPI
            // 
            this.labelSearch_VPI.AutoSize = true;
            this.labelSearch_VPI.Location = new System.Drawing.Point(12, 498);
            this.labelSearch_VPI.Name = "labelSearch_VPI";
            this.labelSearch_VPI.Size = new System.Drawing.Size(52, 17);
            this.labelSearch_VPI.TabIndex = 2;
            this.labelSearch_VPI.Text = "Поиск:";
            // 
            // menuStripButtons_VPI
            // 
            this.menuStripButtons_VPI.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripButtons_VPI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuItemFile_VPI,
            this.StripMenuItemStatistics_VPI,
            this.StripMenuItemGuide_VPI,
            this.StripMenuItemAbout_VPI});
            this.menuStripButtons_VPI.Location = new System.Drawing.Point(0, 0);
            this.menuStripButtons_VPI.Name = "menuStripButtons_VPI";
            this.menuStripButtons_VPI.Size = new System.Drawing.Size(1227, 28);
            this.menuStripButtons_VPI.TabIndex = 1;
            this.menuStripButtons_VPI.Text = "menuStrip1";
            // 
            // StripMenuItemFile_VPI
            // 
            this.StripMenuItemFile_VPI.BackColor = System.Drawing.Color.Transparent;
            this.StripMenuItemFile_VPI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpenFile_VPI,
            this.toolStripMenuItemSaveFile_VPI});
            this.StripMenuItemFile_VPI.Name = "StripMenuItemFile_VPI";
            this.StripMenuItemFile_VPI.Size = new System.Drawing.Size(59, 24);
            this.StripMenuItemFile_VPI.Text = "Файл";
            // 
            // toolStripMenuItemOpenFile_VPI
            // 
            this.toolStripMenuItemOpenFile_VPI.Name = "toolStripMenuItemOpenFile_VPI";
            this.toolStripMenuItemOpenFile_VPI.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItemOpenFile_VPI.Text = "Открыть файл";
            this.toolStripMenuItemOpenFile_VPI.Click += new System.EventHandler(this.toolStripMenuItemOpenFile_Click);
            // 
            // toolStripMenuItemSaveFile_VPI
            // 
            this.toolStripMenuItemSaveFile_VPI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSaveFile_csv_VPI,
            this.ToolStripMenuItemSaveFile_xlsx_VPI});
            this.toolStripMenuItemSaveFile_VPI.Enabled = false;
            this.toolStripMenuItemSaveFile_VPI.Name = "toolStripMenuItemSaveFile_VPI";
            this.toolStripMenuItemSaveFile_VPI.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItemSaveFile_VPI.Text = "Сохранить файл";
            // 
            // ToolStripMenuItemSaveFile_csv_VPI
            // 
            this.ToolStripMenuItemSaveFile_csv_VPI.Enabled = false;
            this.ToolStripMenuItemSaveFile_csv_VPI.Name = "ToolStripMenuItemSaveFile_csv_VPI";
            this.ToolStripMenuItemSaveFile_csv_VPI.Size = new System.Drawing.Size(193, 26);
            this.ToolStripMenuItemSaveFile_csv_VPI.Text = "в формате csv";
            // 
            // ToolStripMenuItemSaveFile_xlsx_VPI
            // 
            this.ToolStripMenuItemSaveFile_xlsx_VPI.Enabled = false;
            this.ToolStripMenuItemSaveFile_xlsx_VPI.Name = "ToolStripMenuItemSaveFile_xlsx_VPI";
            this.ToolStripMenuItemSaveFile_xlsx_VPI.Size = new System.Drawing.Size(193, 26);
            this.ToolStripMenuItemSaveFile_xlsx_VPI.Text = "в формате xlsx";
            this.ToolStripMenuItemSaveFile_xlsx_VPI.Click += new System.EventHandler(this.ToolStripMenuItemSaveFile_xlsx_VPI_Click);
            // 
            // StripMenuItemStatistics_VPI
            // 
            this.StripMenuItemStatistics_VPI.Name = "StripMenuItemStatistics_VPI";
            this.StripMenuItemStatistics_VPI.Size = new System.Drawing.Size(98, 24);
            this.StripMenuItemStatistics_VPI.Text = "Статистика";
            // 
            // StripMenuItemGuide_VPI
            // 
            this.StripMenuItemGuide_VPI.Name = "StripMenuItemGuide_VPI";
            this.StripMenuItemGuide_VPI.Size = new System.Drawing.Size(209, 24);
            this.StripMenuItemGuide_VPI.Text = "Руководство пользователя";
            // 
            // StripMenuItemAbout_VPI
            // 
            this.StripMenuItemAbout_VPI.Name = "StripMenuItemAbout_VPI";
            this.StripMenuItemAbout_VPI.Size = new System.Drawing.Size(118, 24);
            this.StripMenuItemAbout_VPI.Text = "О программе";
            // 
            // openFileDialogTask_VPI
            // 
            this.openFileDialogTask_VPI.FileName = "openFileDialog1";
            // 
            // FormMainProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 613);
            this.Controls.Add(this.panelMain_VPI);
            this.Controls.Add(this.menuStripButtons_VPI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripButtons_VPI;
            this.MaximizeBox = false;
            this.Name = "FormMainProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталог заказов";
            this.panelMain_VPI.ResumeLayout(false);
            this.panelMain_VPI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBase_VPI)).EndInit();
            this.menuStripButtons_VPI.ResumeLayout(false);
            this.menuStripButtons_VPI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain_VPI;
        private System.Windows.Forms.MenuStrip menuStripButtons_VPI;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItemFile_VPI;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenFile_VPI;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveFile_VPI;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItemStatistics_VPI;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItemGuide_VPI;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItemAbout_VPI;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSaveFile_csv_VPI;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSaveFile_xlsx_VPI;
        private System.Windows.Forms.Label labelSearch_VPI;
        private System.Windows.Forms.TextBox textBoxSearch_VPI;
        private System.Windows.Forms.Button buttonDeleteRow_VPI;
        private System.Windows.Forms.DataGridView dataGridViewDataBase_VPI;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_VPI;
        private System.Windows.Forms.ToolTip toolTipTask_VPI;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTask_VPI;
    }
}

