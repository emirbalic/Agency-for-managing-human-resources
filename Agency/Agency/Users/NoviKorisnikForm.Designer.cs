namespace Agency.Users
{
    partial class NoviKorisnikForm
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
            this.mjestaList = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ulicaIBrojInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.odustaniSubmit = new System.Windows.Forms.Button();
            this.ulogeList = new System.Windows.Forms.CheckedListBox();
            this.telefonInput = new System.Windows.Forms.MaskedTextBox();
            this.dodajSubmit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.prezimeInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.korisnickoImeInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lozinkaInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // mjestaList
            // 
            this.mjestaList.FormattingEnabled = true;
            this.mjestaList.Location = new System.Drawing.Point(125, 227);
            this.mjestaList.Name = "mjestaList";
            this.mjestaList.Size = new System.Drawing.Size(197, 24);
            this.mjestaList.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 68;
            this.label8.Text = "Mjesto:";
            // 
            // ulicaIBrojInput
            // 
            this.ulicaIBrojInput.Location = new System.Drawing.Point(125, 190);
            this.ulicaIBrojInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ulicaIBrojInput.Name = "ulicaIBrojInput";
            this.ulicaIBrojInput.Size = new System.Drawing.Size(197, 22);
            this.ulicaIBrojInput.TabIndex = 5;
            this.ulicaIBrojInput.Validating += new System.ComponentModel.CancelEventHandler(this.ulicaIBrojInput_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 67;
            this.label9.Text = "Ulica i broj:";
            // 
            // odustaniSubmit
            // 
            this.odustaniSubmit.Location = new System.Drawing.Point(126, 399);
            this.odustaniSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.odustaniSubmit.Name = "odustaniSubmit";
            this.odustaniSubmit.Size = new System.Drawing.Size(84, 42);
            this.odustaniSubmit.TabIndex = 10;
            this.odustaniSubmit.Text = "Odustani";
            this.odustaniSubmit.UseVisualStyleBackColor = true;
            this.odustaniSubmit.Click += new System.EventHandler(this.odustaniSubmit_Click_1);
            // 
            // ulogeList
            // 
            this.ulogeList.FormattingEnabled = true;
            this.ulogeList.Location = new System.Drawing.Point(125, 327);
            this.ulogeList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ulogeList.Name = "ulogeList";
            this.ulogeList.Size = new System.Drawing.Size(197, 55);
            this.ulogeList.TabIndex = 9;
            // 
            // telefonInput
            // 
            this.telefonInput.Location = new System.Drawing.Point(126, 154);
            this.telefonInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telefonInput.Mask = "(999) 000-000";
            this.telefonInput.Name = "telefonInput";
            this.telefonInput.Size = new System.Drawing.Size(197, 22);
            this.telefonInput.TabIndex = 4;
            // 
            // dodajSubmit
            // 
            this.dodajSubmit.Location = new System.Drawing.Point(237, 399);
            this.dodajSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dodajSubmit.Name = "dodajSubmit";
            this.dodajSubmit.Size = new System.Drawing.Size(85, 42);
            this.dodajSubmit.TabIndex = 11;
            this.dodajSubmit.Text = "Dodaj";
            this.dodajSubmit.UseVisualStyleBackColor = true;
            this.dodajSubmit.Click += new System.EventHandler(this.dodajSubmit_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 65;
            this.label7.Text = "Uloge:";
            // 
            // prezimeInput
            // 
            this.prezimeInput.Location = new System.Drawing.Point(125, 75);
            this.prezimeInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prezimeInput.Name = "prezimeInput";
            this.prezimeInput.Size = new System.Drawing.Size(197, 22);
            this.prezimeInput.TabIndex = 2;
            this.prezimeInput.Validating += new System.ComponentModel.CancelEventHandler(this.prezimeInput_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 64;
            this.label6.Text = "Prezime:";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(125, 116);
            this.emailInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(197, 22);
            this.emailInput.TabIndex = 3;
            this.emailInput.Validating += new System.ComponentModel.CancelEventHandler(this.emailInput_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 63;
            this.label5.Text = "E-mail:";
            // 
            // korisnickoImeInput
            // 
            this.korisnickoImeInput.Location = new System.Drawing.Point(125, 258);
            this.korisnickoImeInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.korisnickoImeInput.Name = "korisnickoImeInput";
            this.korisnickoImeInput.Size = new System.Drawing.Size(197, 22);
            this.korisnickoImeInput.TabIndex = 7;
            this.korisnickoImeInput.Validating += new System.ComponentModel.CancelEventHandler(this.korisnickoImeInput_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 60;
            this.label4.Text = "Korisničko ime:";
            // 
            // lozinkaInput
            // 
            this.lozinkaInput.Location = new System.Drawing.Point(125, 293);
            this.lozinkaInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lozinkaInput.Name = "lozinkaInput";
            this.lozinkaInput.PasswordChar = '*';
            this.lozinkaInput.Size = new System.Drawing.Size(197, 22);
            this.lozinkaInput.TabIndex = 8;
            this.lozinkaInput.Validating += new System.ComponentModel.CancelEventHandler(this.lozinkaInput_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Lozinka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Telefon:";
            // 
            // imeInput
            // 
            this.imeInput.Location = new System.Drawing.Point(125, 38);
            this.imeInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imeInput.Name = "imeInput";
            this.imeInput.Size = new System.Drawing.Size(197, 22);
            this.imeInput.TabIndex = 1;
            this.imeInput.Validating += new System.ComponentModel.CancelEventHandler(this.imeInput_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "Ime:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // NoviKorisnikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 475);
            this.Controls.Add(this.mjestaList);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ulicaIBrojInput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.odustaniSubmit);
            this.Controls.Add(this.ulogeList);
            this.Controls.Add(this.telefonInput);
            this.Controls.Add(this.dodajSubmit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.prezimeInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.korisnickoImeInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lozinkaInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imeInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NoviKorisnikForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos novog korisnika";
            this.Load += new System.EventHandler(this.NoviKorisnikForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox mjestaList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ulicaIBrojInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button odustaniSubmit;
        private System.Windows.Forms.CheckedListBox ulogeList;
        private System.Windows.Forms.MaskedTextBox telefonInput;
        private System.Windows.Forms.Button dodajSubmit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox prezimeInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox korisnickoImeInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lozinkaInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox imeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}