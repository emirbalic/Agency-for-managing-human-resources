namespace Agency.Clients
{
    partial class RacunZaKlijentaMaliPrikazForm
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
            this.klijentText = new System.Windows.Forms.TextBox();
            this.iznosText = new System.Windows.Forms.TextBox();
            this.datumText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv firme:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Iznos:";
            // 
            // klijentText
            // 
            this.klijentText.Location = new System.Drawing.Point(263, 45);
            this.klijentText.Name = "klijentText";
            this.klijentText.ReadOnly = true;
            this.klijentText.Size = new System.Drawing.Size(158, 22);
            this.klijentText.TabIndex = 2;
            // 
            // iznosText
            // 
            this.iznosText.Location = new System.Drawing.Point(263, 77);
            this.iznosText.Name = "iznosText";
            this.iznosText.ReadOnly = true;
            this.iznosText.Size = new System.Drawing.Size(158, 22);
            this.iznosText.TabIndex = 3;
            // 
            // datumText
            // 
            this.datumText.Location = new System.Drawing.Point(263, 115);
            this.datumText.Name = "datumText";
            this.datumText.ReadOnly = true;
            this.datumText.Size = new System.Drawing.Size(158, 22);
            this.datumText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Datum ispostave računa:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Zatvori";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RacunZaKlijentaMaliPrikazForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 228);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datumText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iznosText);
            this.Controls.Add(this.klijentText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RacunZaKlijentaMaliPrikazForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prikaz osnovnog računa";
            this.Load += new System.EventHandler(this.RacunZaKlijentaPrikazForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox klijentText;
        private System.Windows.Forms.TextBox iznosText;
        private System.Windows.Forms.TextBox datumText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;

    }
}