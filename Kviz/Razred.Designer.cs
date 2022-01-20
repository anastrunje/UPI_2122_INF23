
namespace Kviz
{
    partial class Razred
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
            this.btnPrvi = new System.Windows.Forms.Button();
            this.btnCetvrti = new System.Windows.Forms.Button();
            this.btnTreci = new System.Windows.Forms.Button();
            this.btnDrugi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrvi
            // 
            this.btnPrvi.Location = new System.Drawing.Point(78, 43);
            this.btnPrvi.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrvi.Name = "btnPrvi";
            this.btnPrvi.Size = new System.Drawing.Size(102, 46);
            this.btnPrvi.TabIndex = 0;
            this.btnPrvi.Text = "1.RAZRED";
            this.btnPrvi.UseVisualStyleBackColor = true;
            this.btnPrvi.Click += new System.EventHandler(this.btnPrvi_Click);
            // 
            // btnCetvrti
            // 
            this.btnCetvrti.Location = new System.Drawing.Point(78, 256);
            this.btnCetvrti.Margin = new System.Windows.Forms.Padding(2);
            this.btnCetvrti.Name = "btnCetvrti";
            this.btnCetvrti.Size = new System.Drawing.Size(102, 46);
            this.btnCetvrti.TabIndex = 1;
            this.btnCetvrti.Text = "4.RAZRED";
            this.btnCetvrti.UseVisualStyleBackColor = true;
            // 
            // btnTreci
            // 
            this.btnTreci.Location = new System.Drawing.Point(78, 186);
            this.btnTreci.Margin = new System.Windows.Forms.Padding(2);
            this.btnTreci.Name = "btnTreci";
            this.btnTreci.Size = new System.Drawing.Size(102, 46);
            this.btnTreci.TabIndex = 2;
            this.btnTreci.Text = "3.RAZRED";
            this.btnTreci.UseVisualStyleBackColor = true;
            // 
            // btnDrugi
            // 
            this.btnDrugi.Location = new System.Drawing.Point(78, 113);
            this.btnDrugi.Margin = new System.Windows.Forms.Padding(2);
            this.btnDrugi.Name = "btnDrugi";
            this.btnDrugi.Size = new System.Drawing.Size(102, 46);
            this.btnDrugi.TabIndex = 3;
            this.btnDrugi.Text = "2.RAZRED";
            this.btnDrugi.UseVisualStyleBackColor = true;
            // 
            // Razred
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 347);
            this.Controls.Add(this.btnDrugi);
            this.Controls.Add(this.btnTreci);
            this.Controls.Add(this.btnCetvrti);
            this.Controls.Add(this.btnPrvi);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Razred";
            this.Text = "Razred";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrvi;
        private System.Windows.Forms.Button btnCetvrti;
        private System.Windows.Forms.Button btnTreci;
        private System.Windows.Forms.Button btnDrugi;
    }
}