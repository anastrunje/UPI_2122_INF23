
namespace Kviz
{
    partial class Izbornik
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
            this.btnObjasnjenja = new System.Windows.Forms.Button();
            this.btnPokreni = new System.Windows.Forms.Button();
            this.btnBodovi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnObjasnjenja
            // 
            this.btnObjasnjenja.Location = new System.Drawing.Point(64, 45);
            this.btnObjasnjenja.Margin = new System.Windows.Forms.Padding(2);
            this.btnObjasnjenja.Name = "btnObjasnjenja";
            this.btnObjasnjenja.Size = new System.Drawing.Size(98, 39);
            this.btnObjasnjenja.TabIndex = 0;
            this.btnObjasnjenja.Text = "OBJAŠNJENJA GRADIVA";
            this.btnObjasnjenja.UseVisualStyleBackColor = true;
            this.btnObjasnjenja.Click += new System.EventHandler(this.btnObjasnjenja_Click);
            // 
            // btnPokreni
            // 
            this.btnPokreni.Location = new System.Drawing.Point(64, 223);
            this.btnPokreni.Margin = new System.Windows.Forms.Padding(2);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(98, 39);
            this.btnPokreni.TabIndex = 1;
            this.btnPokreni.Text = "POKRENI KVIZ";
            this.btnPokreni.UseVisualStyleBackColor = true;
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click);
            // 
            // btnBodovi
            // 
            this.btnBodovi.Location = new System.Drawing.Point(64, 130);
            this.btnBodovi.Margin = new System.Windows.Forms.Padding(2);
            this.btnBodovi.Name = "btnBodovi";
            this.btnBodovi.Size = new System.Drawing.Size(98, 39);
            this.btnBodovi.TabIndex = 2;
            this.btnBodovi.Text = "BODOVNO STANJE";
            this.btnBodovi.UseVisualStyleBackColor = true;
            this.btnBodovi.Click += new System.EventHandler(this.btnBodovi_Click);
            // 
            // Izbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 314);
            this.Controls.Add(this.btnBodovi);
            this.Controls.Add(this.btnPokreni);
            this.Controls.Add(this.btnObjasnjenja);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Izbornik";
            this.Text = "Izbornik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnObjasnjenja;
        private System.Windows.Forms.Button btnPokreni;
        private System.Windows.Forms.Button btnBodovi;
    }
}