namespace Agency.Workers
{
    partial class IzmjenaOsnovnihPodatakaForm
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
            this.odustaniSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imeIPrezimeReadOnly = new System.Windows.Forms.TextBox();
            this.snimiSubmit = new System.Windows.Forms.Button();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.telefonInput = new System.Windows.Forms.MaskedTextBox();
            this.cijenaPoSatuInput = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // odustaniSubmit
            // 
            this.odustaniSubmit.Location = new System.Drawing.Point(50, 248);
            this.odustaniSubmit.Name = "odustaniSubmit";
            this.odustaniSubmit.Size = new System.Drawing.Size(75, 29);
            this.odustaniSubmit.TabIndex = 0;
            this.odustaniSubmit.Text = "Odustani";
            this.odustaniSubmit.UseVisualStyleBackColor = true;
            this.odustaniSubmit.Click += new System.EventHandler(this.odustaniSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime i prezime:";
            // 
            // imeIPrezimeReadOnly
            // 
            this.imeIPrezimeReadOnly.Location = new System.Drawing.Point(50, 62);
            this.imeIPrezimeReadOnly.Name = "imeIPrezimeReadOnly";
            this.imeIPrezimeReadOnly.ReadOnly = true;
            this.imeIPrezimeReadOnly.Size = new System.Drawing.Size(210, 22);
            this.imeIPrezimeReadOnly.TabIndex = 2;
            // 
            // snimiSubmit
            // 
            this.snimiSubmit.Location = new System.Drawing.Point(185, 248);
            this.snimiSubmit.Name = "snimiSubmit";
            this.snimiSubmit.Size = new System.Drawing.Size(75, 29);
            this.snimiSubmit.TabIndex = 3;
            this.snimiSubmit.Text = "Sačuvaj";
            this.snimiSubmit.UseVisualStyleBackColor = true;
            this.snimiSubmit.Click += new System.EventHandler(this.snimiSubmit_Click);
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(112, 107);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(148, 22);
            this.emailInput.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cijena KM/h";
            // 
            // telefonInput
            // 
            this.telefonInput.Location = new System.Drawing.Point(160, 155);
            this.telefonInput.Mask = "(999) 000-000";
            this.telefonInput.Name = "telefonInput";
            this.telefonInput.Size = new System.Drawing.Size(100, 22);
            this.telefonInput.TabIndex = 9;
            // 
            // cijenaPoSatuInput
            // 
            this.cijenaPoSatuInput.Location = new System.Drawing.Point(160, 194);
            this.cijenaPoSatuInput.Mask = "000.00";
            this.cijenaPoSatuInput.Name = "cijenaPoSatuInput";
            this.cijenaPoSatuInput.Size = new System.Drawing.Size(100, 22);
            this.cijenaPoSatuInput.TabIndex = 10;
            // 
            // IzmjenaOsnovnihPodatakaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 318);
            this.Controls.Add(this.cijenaPoSatuInput);
            this.Controls.Add(this.telefonInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.snimiSubmit);
            this.Controls.Add(this.imeIPrezimeReadOnly);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odustaniSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IzmjenaOsnovnihPodatakaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izmjena osnovnih podataka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button odustaniSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imeIPrezimeReadOnly;
        private System.Windows.Forms.Button snimiSubmit;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox telefonInput;
        private System.Windows.Forms.MaskedTextBox cijenaPoSatuInput;
    }
}