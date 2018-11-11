namespace Agency.Clients
{
    partial class NoviKlijentForm
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
            this.tipAktivnostiList = new System.Windows.Forms.ComboBox();
            this.mjestaList = new System.Windows.Forms.ComboBox();
            this.dodajSubmit = new System.Windows.Forms.Button();
            this.odustaniSubmit = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lozinkaInput = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.korisnickoImeInput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ulicaBrojInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nazivInput = new System.Windows.Forms.TextBox();
            this.telefonInput = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tipAktivnostiList
            // 
            this.tipAktivnostiList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipAktivnostiList.FormattingEnabled = true;
            this.tipAktivnostiList.Location = new System.Drawing.Point(167, 222);
            this.tipAktivnostiList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipAktivnostiList.Name = "tipAktivnostiList";
            this.tipAktivnostiList.Size = new System.Drawing.Size(194, 24);
            this.tipAktivnostiList.TabIndex = 67;
            this.tipAktivnostiList.Validating += new System.ComponentModel.CancelEventHandler(this.tipAktivnostiList_Validating);
            // 
            // mjestaList
            // 
            this.mjestaList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mjestaList.FormattingEnabled = true;
            this.mjestaList.Location = new System.Drawing.Point(167, 176);
            this.mjestaList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mjestaList.Name = "mjestaList";
            this.mjestaList.Size = new System.Drawing.Size(194, 24);
            this.mjestaList.TabIndex = 66;
            this.mjestaList.Validating += new System.ComponentModel.CancelEventHandler(this.mjestaList_Validating);
            // 
            // dodajSubmit
            // 
            this.dodajSubmit.Location = new System.Drawing.Point(282, 364);
            this.dodajSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dodajSubmit.Name = "dodajSubmit";
            this.dodajSubmit.Size = new System.Drawing.Size(80, 35);
            this.dodajSubmit.TabIndex = 65;
            this.dodajSubmit.Text = "Dodaj";
            this.dodajSubmit.UseVisualStyleBackColor = true;
            this.dodajSubmit.Click += new System.EventHandler(this.dodajSubmit_Click);
            // 
            // odustaniSubmit
            // 
            this.odustaniSubmit.Location = new System.Drawing.Point(167, 364);
            this.odustaniSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.odustaniSubmit.Name = "odustaniSubmit";
            this.odustaniSubmit.Size = new System.Drawing.Size(80, 35);
            this.odustaniSubmit.TabIndex = 64;
            this.odustaniSubmit.Text = "Odustani";
            this.odustaniSubmit.UseVisualStyleBackColor = true;
            this.odustaniSubmit.Click += new System.EventHandler(this.odustaniSubmit_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(80, 312);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 17);
            this.label12.TabIndex = 63;
            this.label12.Text = "Lozinka:";
            // 
            // lozinkaInput
            // 
            this.lozinkaInput.Location = new System.Drawing.Point(168, 309);
            this.lozinkaInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lozinkaInput.Name = "lozinkaInput";
            this.lozinkaInput.PasswordChar = '*';
            this.lozinkaInput.Size = new System.Drawing.Size(194, 22);
            this.lozinkaInput.TabIndex = 62;
            this.lozinkaInput.Validating += new System.ComponentModel.CancelEventHandler(this.lozinkaInput_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 17);
            this.label11.TabIndex = 61;
            this.label11.Text = "Korisničko ime";
            // 
            // korisnickoImeInput
            // 
            this.korisnickoImeInput.Location = new System.Drawing.Point(168, 266);
            this.korisnickoImeInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.korisnickoImeInput.Name = "korisnickoImeInput";
            this.korisnickoImeInput.Size = new System.Drawing.Size(194, 22);
            this.korisnickoImeInput.TabIndex = 60;
            this.korisnickoImeInput.Validating += new System.ComponentModel.CancelEventHandler(this.korisnickoImeInput_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 59;
            this.label10.Text = "Tip aktivnosti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 58;
            this.label7.Text = "Mjesto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 57;
            this.label4.Text = "Ulica i broj:";
            // 
            // ulicaBrojInput
            // 
            this.ulicaBrojInput.Location = new System.Drawing.Point(167, 137);
            this.ulicaBrojInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ulicaBrojInput.Name = "ulicaBrojInput";
            this.ulicaBrojInput.Size = new System.Drawing.Size(194, 22);
            this.ulicaBrojInput.TabIndex = 56;
            this.ulicaBrojInput.Validating += new System.ComponentModel.CancelEventHandler(this.ulicaBrojInput_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 55;
            this.label3.Text = "E-mail:";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(167, 102);
            this.emailInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(194, 22);
            this.emailInput.TabIndex = 54;
            this.emailInput.Validating += new System.ComponentModel.CancelEventHandler(this.emailInput_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "Telefon:";
            // 
            // nazivInput
            // 
            this.nazivInput.Location = new System.Drawing.Point(167, 34);
            this.nazivInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nazivInput.Name = "nazivInput";
            this.nazivInput.Size = new System.Drawing.Size(194, 22);
            this.nazivInput.TabIndex = 51;
            this.nazivInput.Validating += new System.ComponentModel.CancelEventHandler(this.nazivInput_Validating);
            // 
            // telefonInput
            // 
            this.telefonInput.Location = new System.Drawing.Point(167, 67);
            this.telefonInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telefonInput.Mask = "(999) 000-000";
            this.telefonInput.Name = "telefonInput";
            this.telefonInput.Size = new System.Drawing.Size(194, 22);
            this.telefonInput.TabIndex = 52;
            this.telefonInput.Validating += new System.ComponentModel.CancelEventHandler(this.telefonInput_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Naziv firme:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // NoviKlijentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 435);
            this.Controls.Add(this.tipAktivnostiList);
            this.Controls.Add(this.mjestaList);
            this.Controls.Add(this.dodajSubmit);
            this.Controls.Add(this.odustaniSubmit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lozinkaInput);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.korisnickoImeInput);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ulicaBrojInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nazivInput);
            this.Controls.Add(this.telefonInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NoviKlijentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos podataka o klijentu";
            this.Load += new System.EventHandler(this.NoviKlijentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tipAktivnostiList;
        private System.Windows.Forms.ComboBox mjestaList;
        private System.Windows.Forms.Button dodajSubmit;
        private System.Windows.Forms.Button odustaniSubmit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox lozinkaInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox korisnickoImeInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ulicaBrojInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nazivInput;
        private System.Windows.Forms.MaskedTextBox telefonInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}