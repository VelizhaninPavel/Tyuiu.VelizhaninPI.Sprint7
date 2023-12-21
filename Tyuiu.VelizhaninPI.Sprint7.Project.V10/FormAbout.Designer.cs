
namespace Tyuiu.VelizhaninPI.Sprint7.Project.V10
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_VPI = new System.Windows.Forms.PictureBox();
            this.labelAbout_VPI = new System.Windows.Forms.Label();
            this.buttonClose_VPI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_VPI)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_VPI
            // 
            this.pictureBoxAvatar_VPI.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_VPI.Image")));
            this.pictureBoxAvatar_VPI.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_VPI.Name = "pictureBoxAvatar_VPI";
            this.pictureBoxAvatar_VPI.Size = new System.Drawing.Size(281, 305);
            this.pictureBoxAvatar_VPI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_VPI.TabIndex = 0;
            this.pictureBoxAvatar_VPI.TabStop = false;
            // 
            // labelAbout_VPI
            // 
            this.labelAbout_VPI.AutoSize = true;
            this.labelAbout_VPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labelAbout_VPI.Location = new System.Drawing.Point(299, 12);
            this.labelAbout_VPI.Name = "labelAbout_VPI";
            this.labelAbout_VPI.Size = new System.Drawing.Size(250, 221);
            this.labelAbout_VPI.TabIndex = 1;
            this.labelAbout_VPI.Text = resources.GetString("labelAbout_VPI.Text");
            // 
            // buttonClose_VPI
            // 
            this.buttonClose_VPI.Location = new System.Drawing.Point(425, 316);
            this.buttonClose_VPI.Name = "buttonClose_VPI";
            this.buttonClose_VPI.Size = new System.Drawing.Size(124, 31);
            this.buttonClose_VPI.TabIndex = 2;
            this.buttonClose_VPI.Text = "Назад";
            this.buttonClose_VPI.UseVisualStyleBackColor = true;
            this.buttonClose_VPI.Click += new System.EventHandler(this.buttonClose_VPI_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 359);
            this.Controls.Add(this.buttonClose_VPI);
            this.Controls.Add(this.labelAbout_VPI);
            this.Controls.Add(this.pictureBoxAvatar_VPI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAbout";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_VPI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_VPI;
        private System.Windows.Forms.Label labelAbout_VPI;
        private System.Windows.Forms.Button buttonClose_VPI;
    }
}