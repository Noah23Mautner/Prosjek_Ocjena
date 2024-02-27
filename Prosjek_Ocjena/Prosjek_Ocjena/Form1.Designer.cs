namespace Prosjek_Ocjena
{
    partial class Form1
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
            this.txtUnosOcjena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.txtProsjekOcjena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUnosOcjena
            // 
            this.txtUnosOcjena.Location = new System.Drawing.Point(119, 34);
            this.txtUnosOcjena.Name = "txtUnosOcjena";
            this.txtUnosOcjena.Size = new System.Drawing.Size(189, 26);
            this.txtUnosOcjena.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ocjene";
           
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(45, 110);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(263, 43);
            this.btnUnesi.TabIndex = 2;
            this.btnUnesi.Text = "Unesi ocjene";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtProsjekOcjena
            // 
            this.txtProsjekOcjena.Location = new System.Drawing.Point(188, 208);
            this.txtProsjekOcjena.Name = "txtProsjekOcjena";
            this.txtProsjekOcjena.Size = new System.Drawing.Size(100, 26);
            this.txtProsjekOcjena.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prosjek je:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 273);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProsjekOcjena);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUnosOcjena);
            this.Name = "Form1";
            this.Text = "Prosjek Ocjek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUnosOcjena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.TextBox txtProsjekOcjena;
        private System.Windows.Forms.Label label2;
    }
}

