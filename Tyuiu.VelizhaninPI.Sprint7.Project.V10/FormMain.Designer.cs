
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
            this.buttonRowUpDown_VPI = new System.Windows.Forms.Button();
            this.radioButtonRowDown_VPI = new System.Windows.Forms.RadioButton();
            this.radioButtonRowUp_VPI = new System.Windows.Forms.RadioButton();
            this.buttonAddRow_VPI = new System.Windows.Forms.Button();
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
            this.panelMain_VPI.Controls.Add(this.buttonRowUpDown_VPI);
            this.panelMain_VPI.Controls.Add(this.radioButtonRowDown_VPI);
            this.panelMain_VPI.Controls.Add(this.radioButtonRowUp_VPI);
            this.panelMain_VPI.Controls.Add(this.buttonAddRow_VPI);
            this.panelMain_VPI.Controls.Add(this.buttonDeleteRow_VPI);
            this.panelMain_VPI.Controls.Add(this.textBoxSearch_VPI);
            this.panelMain_VPI.Controls.Add(this.dataGridViewDataBase_VPI);
            this.panelMain_VPI.Controls.Add(this.labelSearch_VPI);
            this.panelMain_VPI.Location = new System.Drawing.Point(12, 31);
            this.panelMain_VPI.Name = "panelMain_VPI";
            this.panelMain_VPI.Size = new System.Drawing.Size(1203, 570);
            this.panelMain_VPI.TabIndex = 0;
            // 
            // buttonRowUpDown_VPI
            // 
            this.buttonRowUpDown_VPI.Enabled = false;
            this.buttonRowUpDown_VPI.Location = new System.Drawing.Point(1044, 498);
            this.buttonRowUpDown_VPI.Name = "buttonRowUpDown_VPI";
            this.buttonRowUpDown_VPI.Size = new System.Drawing.Size(139, 30);
            this.buttonRowUpDown_VPI.TabIndex = 8;
            this.buttonRowUpDown_VPI.Text = "Переместить";
            this.buttonRowUpDown_VPI.UseVisualStyleBackColor = true;
            this.buttonRowUpDown_VPI.Click += new System.EventHandler(this.buttonRowUpDown_VPI_Click);
            // 
            // radioButtonRowDown_VPI
            // 
            this.radioButtonRowDown_VPI.AutoSize = true;
            this.radioButtonRowDown_VPI.Enabled = false;
            this.radioButtonRowDown_VPI.Location = new System.Drawing.Point(1124, 539);
            this.radioButtonRowDown_VPI.Name = "radioButtonRowDown_VPI";
            this.radioButtonRowDown_VPI.Size = new System.Drawing.Size(59, 21);
            this.radioButtonRowDown_VPI.TabIndex = 7;
            this.radioButtonRowDown_VPI.TabStop = true;
            this.radioButtonRowDown_VPI.Text = "вниз";
            this.radioButtonRowDown_VPI.UseVisualStyleBackColor = true;
            // 
            // radioButtonRowUp_VPI
            // 
            this.radioButtonRowUp_VPI.AutoSize = true;
            this.radioButtonRowUp_VPI.Enabled = false;
            this.radioButtonRowUp_VPI.Location = new System.Drawing.Point(1044, 539);
            this.radioButtonRowUp_VPI.Name = "radioButtonRowUp_VPI";
            this.radioButtonRowUp_VPI.Size = new System.Drawing.Size(65, 21);
            this.radioButtonRowUp_VPI.TabIndex = 6;
            this.radioButtonRowUp_VPI.TabStop = true;
            this.radioButtonRowUp_VPI.Text = "вверх";
            this.radioButtonRowUp_VPI.UseVisualStyleBackColor = true;
            // 
            // buttonAddRow_VPI
            // 
            this.buttonAddRow_VPI.Enabled = false;
            this.buttonAddRow_VPI.Location = new System.Drawing.Point(728, 498);
            this.buttonAddRow_VPI.Name = "buttonAddRow_VPI";
            this.buttonAddRow_VPI.Size = new System.Drawing.Size(152, 30);
            this.buttonAddRow_VPI.TabIndex = 5;
            this.buttonAddRow_VPI.Text = "Добавить строку";
            this.buttonAddRow_VPI.UseVisualStyleBackColor = true;
            this.buttonAddRow_VPI.Click += new System.EventHandler(this.buttonAddRow_VPI_Click);
            // 
            // buttonDeleteRow_VPI
            // 
            this.buttonDeleteRow_VPI.Enabled = false;
            this.buttonDeleteRow_VPI.Location = new System.Drawing.Point(886, 498);
            this.buttonDeleteRow_VPI.Name = "buttonDeleteRow_VPI";
            this.buttonDeleteRow_VPI.Size = new System.Drawing.Size(152, 30);
            this.buttonDeleteRow_VPI.TabIndex = 4;
            this.buttonDeleteRow_VPI.Text = "Удалить строку";
            this.buttonDeleteRow_VPI.UseVisualStyleBackColor = true;
            this.buttonDeleteRow_VPI.Click += new System.EventHandler(this.buttonDeleteRow_VPI_Click);
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
            this.dataGridViewDataBase_VPI.AllowUserToAddRows = false;
            this.dataGridViewDataBase_VPI.AllowUserToDeleteRows = false;
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
            this.labelSearch_VPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labelSearch_VPI.Location = new System.Drawing.Point(12, 501);
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
            this.menuStripButtons_VPI.Size = new System.Drawing.Size(1227, 30);
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
            this.toolStripMenuItemOpenFile_VPI.Size = new System.Drawing.Size(205, 26);
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
            this.toolStripMenuItemSaveFile_VPI.Size = new System.Drawing.Size(205, 26);
            this.toolStripMenuItemSaveFile_VPI.Text = "Сохранить файл";
            // 
            // ToolStripMenuItemSaveFile_csv_VPI
            // 
            this.ToolStripMenuItemSaveFile_csv_VPI.Enabled = false;
            this.ToolStripMenuItemSaveFile_csv_VPI.Name = "ToolStripMenuItemSaveFile_csv_VPI";
            this.ToolStripMenuItemSaveFile_csv_VPI.Size = new System.Drawing.Size(193, 26);
            this.ToolStripMenuItemSaveFile_csv_VPI.Text = "в формате csv";
            this.ToolStripMenuItemSaveFile_csv_VPI.Click += new System.EventHandler(this.ToolStripMenuItemSaveFile_csv_VPI_Click);
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
            this.StripMenuItemGuide_VPI.Click += new System.EventHandler(this.StripMenuItemGuide_VPI_Click);
            // 
            // StripMenuItemAbout_VPI
            // 
            this.StripMenuItemAbout_VPI.Name = "StripMenuItemAbout_VPI";
            this.StripMenuItemAbout_VPI.Size = new System.Drawing.Size(118, 24);
            this.StripMenuItemAbout_VPI.Text = "О программе";
            this.StripMenuItemAbout_VPI.Click += new System.EventHandler(this.StripMenuItemAbout_VPI_Click);
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
        private System.Windows.Forms.Button buttonAddRow_VPI;
        private System.Windows.Forms.Button buttonRowUpDown_VPI;
        private System.Windows.Forms.RadioButton radioButtonRowDown_VPI;
        private System.Windows.Forms.RadioButton radioButtonRowUp_VPI;
    }
}

