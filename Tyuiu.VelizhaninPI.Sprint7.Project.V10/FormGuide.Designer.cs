
namespace Tyuiu.VelizhaninPI.Sprint7.Project.V10
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            this.textBoxGuide = new System.Windows.Forms.TextBox();
            this.panelGuide = new System.Windows.Forms.Panel();
            this.panelButton = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelGuide.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxGuide
            // 
            this.textBoxGuide.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxGuide.Location = new System.Drawing.Point(3, 0);
            this.textBoxGuide.Multiline = true;
            this.textBoxGuide.Name = "textBoxGuide";
            this.textBoxGuide.ReadOnly = true;
            this.textBoxGuide.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxGuide.Size = new System.Drawing.Size(897, 402);
            this.textBoxGuide.TabIndex = 0;
            this.textBoxGuide.Text = resources.GetString("textBoxGuide.Text");
            // 
            // panelGuide
            // 
            this.panelGuide.Controls.Add(this.textBoxGuide);
            this.panelGuide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGuide.Location = new System.Drawing.Point(0, 0);
            this.panelGuide.Name = "panelGuide";
            this.panelGuide.Size = new System.Drawing.Size(900, 453);
            this.panelGuide.TabIndex = 0;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.buttonExit);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 402);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(900, 51);
            this.panelButton.TabIndex = 1;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(748, 9);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(140, 30);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 453);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.panelGuide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormGuide";
            this.Text = "Руководство пользователя";
            this.panelGuide.ResumeLayout(false);
            this.panelGuide.PerformLayout();
            this.panelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGuide;
        private System.Windows.Forms.Panel panelGuide;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button buttonExit;
    }
}