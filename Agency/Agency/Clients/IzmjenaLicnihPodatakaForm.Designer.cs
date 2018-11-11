namespace Agency.Clients
{
    partial class IzmjenaLicnihPodatakaForm
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
            this.snimiSubmit = new System.Windows.Forms.Button();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.telefonInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nazivReadOnly = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ulicaIBrojInput = new System.Windows.Forms.TextBox();
            this.lblUlica = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mjestaList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // odustaniSubmit
            // 
            this.odustaniSubmit.Location = new System.Drawing.Point(180, 226);
            this.odustaniSubmit.Name = "odustaniSubmit";
            this.odustaniSubmit.Size = new System.Drawing.Size(75, 33);
            this.odustaniSubmit.TabIndex = 18;
            this.odustaniSubmit.Text = "Odustani";
            this.odustaniSubmit.UseVisualStyleBackColor = true;
            this.odustaniSubmit.Click += new System.EventHandler(this.odustaniSubmit_Click);
            // 
            // snimiSubmit
            // 
            this.snimiSubmit.Location = new System.Drawing.Point(308, 226);
            this.snimiSubmit.Name = "snimiSubmit";
            this.snimiSubmit.Size = new System.Drawing.Size(75, 33);
            this.snimiSubmit.TabIndex = 17;
            this.snimiSubmit.Text = "Snimi";
            this.snimiSubmit.UseVisualStyleBackColor = true;
            this.snimiSubmit.Click += new System.EventHandler(this.snimiSubmit_Click);
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(180, 114);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(204, 22);
            this.emailInput.TabIndex = 16;
            // 
            // telefonInput
            // 
            this.telefonInput.Location = new System.Drawing.Point(181, 71);
            this.telefonInput.Name = "telefonInput";
            this.telefonInput.Size = new System.Drawing.Size(204, 22);
            this.telefonInput.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Telefon:";
            // 
            // nazivReadOnly
            // 
            this.nazivReadOnly.Location = new System.Drawing.Point(181, 31);
            this.nazivReadOnly.Name = "nazivReadOnly";
            this.nazivReadOnly.ReadOnly = true;
            this.nazivReadOnly.Size = new System.Drawing.Size(204, 22);
            this.nazivReadOnly.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Naziv (read only):";
            // 
            // ulicaIBrojInput
            // 
            this.ulicaIBrojInput.Location = new System.Drawing.Point(180, 153);
            this.ulicaIBrojInput.Name = "ulicaIBrojInput";
            this.ulicaIBrojInput.Size = new System.Drawing.Size(204, 22);
            this.ulicaIBrojInput.TabIndex = 20;
            // 
            // lblUlica
            // 
            this.lblUlica.AutoSize = true;
            this.lblUlica.Location = new System.Drawing.Point(101, 156);
            this.lblUlica.Name = "lblUlica";
            this.lblUlica.Size = new System.Drawing.Size(78, 17);
            this.lblUlica.TabIndex = 19;
            this.lblUlica.Text = "Ulica i broj:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Mjesto:";
            // 
            // mjestaList
            // 
            this.mjestaList.FormattingEnabled = true;
            this.mjestaList.Location = new System.Drawing.Point(181, 187);
            this.mjestaList.Name = "mjestaList";
            this.mjestaList.Size = new System.Drawing.Size(202, 24);
            this.mjestaList.TabIndex = 22;
            // 
            // IzmjenaLicnihPodatakaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 291);
            this.Controls.Add(this.mjestaList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ulicaIBrojInput);
            this.Controls.Add(this.lblUlica);
            this.Controls.Add(this.odustaniSubmit);
            this.Controls.Add(this.snimiSubmit);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.telefonInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nazivReadOnly);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IzmjenaLicnihPodatakaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izmjena licnih podataka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button odustaniSubmit;
        private System.Windows.Forms.Button snimiSubmit;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox telefonInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nazivReadOnly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ulicaIBrojInput;
        private System.Windows.Forms.Label lblUlica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox mjestaList;
    }
}