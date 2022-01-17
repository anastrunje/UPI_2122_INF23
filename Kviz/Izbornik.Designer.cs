
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
            this.btnOdigrani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnObjasnjenja
            // 
            this.btnObjasnjenja.Location = new System.Drawing.Point(85, 55);
            this.btnObjasnjenja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObjasnjenja.Name = "btnObjasnjenja";
            this.btnObjasnjenja.Size = new System.Drawing.Size(131, 48);
            this.btnObjasnjenja.TabIndex = 0;
            this.btnObjasnjenja.Text = "OBJAŠNJENJA GRADIVA";
            this.btnObjasnjenja.UseVisualStyleBackColor = true;
            this.btnObjasnjenja.Click += new System.EventHandler(this.btnObjasnjenja_Click);
            // 
            // btnPokreni
            // 
            this.btnPokreni.Location = new System.Drawing.Point(85, 274);
            this.btnPokreni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(131, 48);
            this.btnPokreni.TabIndex = 1;
            this.btnPokreni.Text = "POKRENI KVIZ";
            this.btnPokreni.UseVisualStyleBackColor = true;
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click);
            // 
            // btnBodovi
            // 
            this.btnBodovi.Location = new System.Drawing.Point(85, 201);
            this.btnBodovi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBodovi.Name = "btnBodovi";
            this.btnBodovi.Size = new System.Drawing.Size(131, 48);
            this.btnBodovi.TabIndex = 2;
            this.btnBodovi.Text = "BODOVNO STANJE";
            this.btnBodovi.UseVisualStyleBackColor = true;
            // 
            // btnOdigrani
            // 
            this.btnOdigrani.Location = new System.Drawing.Point(85, 127);
            this.btnOdigrani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdigrani.Name = "btnOdigrani";
            this.btnOdigrani.Size = new System.Drawing.Size(131, 48);
            this.btnOdigrani.TabIndex = 3;
            this.btnOdigrani.Text = "ODIGRANI KVIZOVI";
            this.btnOdigrani.UseVisualStyleBackColor = true;
            // 
            // Izbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 386);
            this.Controls.Add(this.btnOdigrani);
            this.Controls.Add(this.btnBodovi);
            this.Controls.Add(this.btnPokreni);
            this.Controls.Add(this.btnObjasnjenja);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Izbornik";
            this.Text = "Izbornik";
            this.Load += new System.EventHandler(this.Izbornik_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnObjasnjenja;
        private System.Windows.Forms.Button btnPokreni;
        private System.Windows.Forms.Button btnBodovi;
        private System.Windows.Forms.Button btnOdigrani;
    }
}