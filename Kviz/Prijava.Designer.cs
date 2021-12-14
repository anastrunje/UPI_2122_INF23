
namespace Kviz
{
    partial class FormaPrijava
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.korisnickoImeTxt = new System.Windows.Forms.TextBox();
            this.lozinkaTxt = new System.Windows.Forms.TextBox();
            this.prijavaBtn = new System.Windows.Forms.Button();
            this.izlazBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite korisničko ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unesite lozinku:";
            // 
            // korisnickoImeTxt
            // 
            this.korisnickoImeTxt.Location = new System.Drawing.Point(182, 36);
            this.korisnickoImeTxt.Name = "korisnickoImeTxt";
            this.korisnickoImeTxt.Size = new System.Drawing.Size(175, 22);
            this.korisnickoImeTxt.TabIndex = 2;
            // 
            // lozinkaTxt
            // 
            this.lozinkaTxt.Location = new System.Drawing.Point(182, 93);
            this.lozinkaTxt.Name = "lozinkaTxt";
            this.lozinkaTxt.Size = new System.Drawing.Size(175, 22);
            this.lozinkaTxt.TabIndex = 3;
            // 
            // prijavaBtn
            // 
            this.prijavaBtn.Location = new System.Drawing.Point(182, 138);
            this.prijavaBtn.Name = "prijavaBtn";
            this.prijavaBtn.Size = new System.Drawing.Size(82, 32);
            this.prijavaBtn.TabIndex = 4;
            this.prijavaBtn.Text = "PRIJAVA";
            this.prijavaBtn.UseVisualStyleBackColor = true;
            this.prijavaBtn.Click += new System.EventHandler(this.prijavaBtn_Click);
            // 
            // izlazBtn
            // 
            this.izlazBtn.Location = new System.Drawing.Point(270, 138);
            this.izlazBtn.Name = "izlazBtn";
            this.izlazBtn.Size = new System.Drawing.Size(87, 30);
            this.izlazBtn.TabIndex = 5;
            this.izlazBtn.Text = "IZLAZ";
            this.izlazBtn.UseVisualStyleBackColor = true;
            // 
            // FormaPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 221);
            this.Controls.Add(this.izlazBtn);
            this.Controls.Add(this.prijavaBtn);
            this.Controls.Add(this.lozinkaTxt);
            this.Controls.Add(this.korisnickoImeTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormaPrijava";
            this.Text = "FormaPrijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox korisnickoImeTxt;
        private System.Windows.Forms.TextBox lozinkaTxt;
        private System.Windows.Forms.Button prijavaBtn;
        private System.Windows.Forms.Button izlazBtn;
    }
}

