
namespace Kviz
{
    partial class Brojevi_Objasnjenje
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
            this.pbxObjasnjenje = new System.Windows.Forms.PictureBox();
            this.btnSljedeci = new System.Windows.Forms.Button();
            this.lblObjasnjenje = new System.Windows.Forms.Label();
            this.btnPrethodni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxObjasnjenje)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxObjasnjenje
            // 
            this.pbxObjasnjenje.Location = new System.Drawing.Point(46, 129);
            this.pbxObjasnjenje.Name = "pbxObjasnjenje";
            this.pbxObjasnjenje.Size = new System.Drawing.Size(589, 500);
            this.pbxObjasnjenje.TabIndex = 0;
            this.pbxObjasnjenje.TabStop = false;
            // 
            // btnSljedeci
            // 
            this.btnSljedeci.Location = new System.Drawing.Point(523, 645);
            this.btnSljedeci.Name = "btnSljedeci";
            this.btnSljedeci.Size = new System.Drawing.Size(111, 38);
            this.btnSljedeci.TabIndex = 1;
            this.btnSljedeci.Text = "SLJEDEĆI";
            this.btnSljedeci.UseVisualStyleBackColor = true;
            this.btnSljedeci.Click += new System.EventHandler(this.btnSljedeci_Click);
            // 
            // lblObjasnjenje
            // 
            this.lblObjasnjenje.AutoSize = true;
            this.lblObjasnjenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjasnjenje.Location = new System.Drawing.Point(42, 25);
            this.lblObjasnjenje.Name = "lblObjasnjenje";
            this.lblObjasnjenje.Size = new System.Drawing.Size(44, 20);
            this.lblObjasnjenje.TabIndex = 2;
            this.lblObjasnjenje.Text = "label";
            // 
            // btnPrethodni
            // 
            this.btnPrethodni.Location = new System.Drawing.Point(46, 645);
            this.btnPrethodni.Name = "btnPrethodni";
            this.btnPrethodni.Size = new System.Drawing.Size(115, 38);
            this.btnPrethodni.TabIndex = 3;
            this.btnPrethodni.Text = "PRETHODNI";
            this.btnPrethodni.UseVisualStyleBackColor = true;
            this.btnPrethodni.Click += new System.EventHandler(this.btnPrethodni_Click);
            // 
            // Brojevi_Objasnjenje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 695);
            this.Controls.Add(this.btnPrethodni);
            this.Controls.Add(this.lblObjasnjenje);
            this.Controls.Add(this.btnSljedeci);
            this.Controls.Add(this.pbxObjasnjenje);
            this.Name = "Brojevi_Objasnjenje";
            this.Text = "Brojevi_Objasnjenje";
            this.Load += new System.EventHandler(this.Brojevi_Objasnjenje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxObjasnjenje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxObjasnjenje;
        private System.Windows.Forms.Button btnSljedeci;
        private System.Windows.Forms.Label lblObjasnjenje;
        private System.Windows.Forms.Button btnPrethodni;
    }
}