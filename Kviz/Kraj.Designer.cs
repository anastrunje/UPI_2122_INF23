
namespace Kviz
{
    partial class Kraj
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
            this.lblBod = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnRang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBod
            // 
            this.lblBod.AutoSize = true;
            this.lblBod.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBod.Location = new System.Drawing.Point(145, 146);
            this.lblBod.Name = "lblBod";
            this.lblBod.Size = new System.Drawing.Size(119, 39);
            this.lblBod.TabIndex = 0;
            this.lblBod.Text = "lblBod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Čestitamo! Osvojili ste: ";
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(90, 249);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(106, 47);
            this.btnIzlaz.TabIndex = 2;
            this.btnIzlaz.Text = "IZLAZ";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnRang
            // 
            this.btnRang.Location = new System.Drawing.Point(277, 249);
            this.btnRang.Name = "btnRang";
            this.btnRang.Size = new System.Drawing.Size(106, 47);
            this.btnRang.TabIndex = 3;
            this.btnRang.Text = "RANG LISTA";
            this.btnRang.UseVisualStyleBackColor = true;
            this.btnRang.Click += new System.EventHandler(this.btnRang_Click);
            // 
            // Kraj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 323);
            this.Controls.Add(this.btnRang);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBod);
            this.Name = "Kraj";
            this.Text = "Kraj";
            this.Load += new System.EventHandler(this.Kraj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnRang;
    }
}