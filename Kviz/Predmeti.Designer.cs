
namespace Kviz
{
    partial class Predmeti
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
            this.btnMat = new System.Windows.Forms.Button();
            this.btnHrv = new System.Windows.Forms.Button();
            this.btnEng = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMat
            // 
            this.btnMat.Location = new System.Drawing.Point(79, 46);
            this.btnMat.Margin = new System.Windows.Forms.Padding(2);
            this.btnMat.Name = "btnMat";
            this.btnMat.Size = new System.Drawing.Size(118, 53);
            this.btnMat.TabIndex = 0;
            this.btnMat.Text = "MATEMATIKA";
            this.btnMat.UseVisualStyleBackColor = true;
            this.btnMat.Click += new System.EventHandler(this.btnMat_Click);
            // 
            // btnHrv
            // 
            this.btnHrv.Location = new System.Drawing.Point(79, 123);
            this.btnHrv.Margin = new System.Windows.Forms.Padding(2);
            this.btnHrv.Name = "btnHrv";
            this.btnHrv.Size = new System.Drawing.Size(118, 53);
            this.btnHrv.TabIndex = 1;
            this.btnHrv.Text = "HRVATSKI JEZIK";
            this.btnHrv.UseVisualStyleBackColor = true;
            // 
            // btnEng
            // 
            this.btnEng.Location = new System.Drawing.Point(79, 200);
            this.btnEng.Margin = new System.Windows.Forms.Padding(2);
            this.btnEng.Name = "btnEng";
            this.btnEng.Size = new System.Drawing.Size(118, 53);
            this.btnEng.TabIndex = 2;
            this.btnEng.Text = "ENGLESKI JEZIK";
            this.btnEng.UseVisualStyleBackColor = true;
            // 
            // Predmeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 299);
            this.Controls.Add(this.btnEng);
            this.Controls.Add(this.btnHrv);
            this.Controls.Add(this.btnMat);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Predmeti";
            this.Text = "Predmeti";
            this.Load += new System.EventHandler(this.Predmeti_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMat;
        private System.Windows.Forms.Button btnHrv;
        private System.Windows.Forms.Button btnEng;
    }
}