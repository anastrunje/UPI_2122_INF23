
namespace Kviz
{
    partial class Brojevi
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
            this.pbxPitanje = new System.Windows.Forms.PictureBox();
            this.lblPitanje = new System.Windows.Forms.Label();
            this.lblBrojzadatka = new System.Windows.Forms.Label();
            this.rbtPrvi = new System.Windows.Forms.RadioButton();
            this.rbtDrugi = new System.Windows.Forms.RadioButton();
            this.rbtTreci = new System.Windows.Forms.RadioButton();
            this.rbtCetvrti = new System.Windows.Forms.RadioButton();
            this.btnSljedece = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblBodovi = new System.Windows.Forms.Label();
            this.btnProvjeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPitanje)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxPitanje
            // 
            this.pbxPitanje.Location = new System.Drawing.Point(74, 10);
            this.pbxPitanje.Margin = new System.Windows.Forms.Padding(2);
            this.pbxPitanje.Name = "pbxPitanje";
            this.pbxPitanje.Size = new System.Drawing.Size(277, 165);
            this.pbxPitanje.TabIndex = 11;
            this.pbxPitanje.TabStop = false;
            // 
            // lblPitanje
            // 
            this.lblPitanje.AutoSize = true;
            this.lblPitanje.Location = new System.Drawing.Point(71, 199);
            this.lblPitanje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPitanje.Name = "lblPitanje";
            this.lblPitanje.Size = new System.Drawing.Size(39, 13);
            this.lblPitanje.TabIndex = 10;
            this.lblPitanje.Text = "Pitanje";
            // 
            // lblBrojzadatka
            // 
            this.lblBrojzadatka.AutoSize = true;
            this.lblBrojzadatka.Location = new System.Drawing.Point(9, 20);
            this.lblBrojzadatka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrojzadatka.Name = "lblBrojzadatka";
            this.lblBrojzadatka.Size = new System.Drawing.Size(35, 13);
            this.lblBrojzadatka.TabIndex = 12;
            this.lblBrojzadatka.Text = "label2";
            // 
            // rbtPrvi
            // 
            this.rbtPrvi.AutoSize = true;
            this.rbtPrvi.Location = new System.Drawing.Point(74, 233);
            this.rbtPrvi.Margin = new System.Windows.Forms.Padding(2);
            this.rbtPrvi.Name = "rbtPrvi";
            this.rbtPrvi.Size = new System.Drawing.Size(55, 17);
            this.rbtPrvi.TabIndex = 13;
            this.rbtPrvi.TabStop = true;
            this.rbtPrvi.Text = "rbtPrvi";
            this.rbtPrvi.UseVisualStyleBackColor = true;
            // 
            // rbtDrugi
            // 
            this.rbtDrugi.AutoSize = true;
            this.rbtDrugi.Location = new System.Drawing.Point(237, 233);
            this.rbtDrugi.Margin = new System.Windows.Forms.Padding(2);
            this.rbtDrugi.Name = "rbtDrugi";
            this.rbtDrugi.Size = new System.Drawing.Size(62, 17);
            this.rbtDrugi.TabIndex = 14;
            this.rbtDrugi.TabStop = true;
            this.rbtDrugi.Text = "rbtDrugi";
            this.rbtDrugi.UseVisualStyleBackColor = true;
            // 
            // rbtTreci
            // 
            this.rbtTreci.AutoSize = true;
            this.rbtTreci.Location = new System.Drawing.Point(74, 278);
            this.rbtTreci.Margin = new System.Windows.Forms.Padding(2);
            this.rbtTreci.Name = "rbtTreci";
            this.rbtTreci.Size = new System.Drawing.Size(61, 17);
            this.rbtTreci.TabIndex = 15;
            this.rbtTreci.TabStop = true;
            this.rbtTreci.Text = "rbtTreci";
            this.rbtTreci.UseVisualStyleBackColor = true;
            // 
            // rbtCetvrti
            // 
            this.rbtCetvrti.AutoSize = true;
            this.rbtCetvrti.Location = new System.Drawing.Point(237, 278);
            this.rbtCetvrti.Margin = new System.Windows.Forms.Padding(2);
            this.rbtCetvrti.Name = "rbtCetvrti";
            this.rbtCetvrti.Size = new System.Drawing.Size(67, 17);
            this.rbtCetvrti.TabIndex = 16;
            this.rbtCetvrti.TabStop = true;
            this.rbtCetvrti.Text = "rbtCetvrti";
            this.rbtCetvrti.UseVisualStyleBackColor = true;
            // 
            // btnSljedece
            // 
            this.btnSljedece.Location = new System.Drawing.Point(248, 314);
            this.btnSljedece.Margin = new System.Windows.Forms.Padding(2);
            this.btnSljedece.Name = "btnSljedece";
            this.btnSljedece.Size = new System.Drawing.Size(70, 22);
            this.btnSljedece.TabIndex = 17;
            this.btnSljedece.Text = "SLJEDEĆE";
            this.btnSljedece.UseVisualStyleBackColor = true;
            this.btnSljedece.Click += new System.EventHandler(this.btnSljedece_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(74, 314);
            this.btnIzlaz.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(67, 22);
            this.btnIzlaz.TabIndex = 18;
            this.btnIzlaz.Text = "IZLAZ";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // lblBodovi
            // 
            this.lblBodovi.AutoSize = true;
            this.lblBodovi.Location = new System.Drawing.Point(9, 53);
            this.lblBodovi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBodovi.Name = "lblBodovi";
            this.lblBodovi.Size = new System.Drawing.Size(35, 13);
            this.lblBodovi.TabIndex = 19;
            this.lblBodovi.Text = "label2";
            // 
            // btnProvjeri
            // 
            this.btnProvjeri.Location = new System.Drawing.Point(155, 314);
            this.btnProvjeri.Margin = new System.Windows.Forms.Padding(2);
            this.btnProvjeri.Name = "btnProvjeri";
            this.btnProvjeri.Size = new System.Drawing.Size(74, 22);
            this.btnProvjeri.TabIndex = 20;
            this.btnProvjeri.Text = "PROVJERI";
            this.btnProvjeri.UseVisualStyleBackColor = true;
            this.btnProvjeri.Click += new System.EventHandler(this.btnProvjeri_Click);
            // 
            // Brojevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 362);
            this.Controls.Add(this.btnProvjeri);
            this.Controls.Add(this.lblBodovi);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnSljedece);
            this.Controls.Add(this.rbtCetvrti);
            this.Controls.Add(this.rbtTreci);
            this.Controls.Add(this.rbtDrugi);
            this.Controls.Add(this.rbtPrvi);
            this.Controls.Add(this.lblBrojzadatka);
            this.Controls.Add(this.pbxPitanje);
            this.Controls.Add(this.lblPitanje);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Brojevi";
            this.Text = "Pitanja";
            this.Load += new System.EventHandler(this.Brojevi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPitanje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxPitanje;
        private System.Windows.Forms.Label lblPitanje;
        private System.Windows.Forms.Label lblBrojzadatka;
        private System.Windows.Forms.RadioButton rbtPrvi;
        private System.Windows.Forms.RadioButton rbtDrugi;
        private System.Windows.Forms.RadioButton rbtTreci;
        private System.Windows.Forms.RadioButton rbtCetvrti;
        private System.Windows.Forms.Button btnSljedece;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblBodovi;
        private System.Windows.Forms.Button btnProvjeri;
    }
}