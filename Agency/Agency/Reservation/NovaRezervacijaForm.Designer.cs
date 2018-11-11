namespace Agency.Reservation
{
    partial class NovaRezervacijaForm
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
            this.nazivFirmeList = new System.Windows.Forms.ComboBox();
            this.brojRadnihSati = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prezimeText = new System.Windows.Forms.TextBox();
            this.imeText = new System.Windows.Forms.TextBox();
            this.rezervirajSubmit = new System.Windows.Forms.Button();
            this.nazadSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.krajDateTime = new System.Windows.Forms.DateTimePicker();
            this.pocetakDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // nazivFirmeList
            // 
            this.nazivFirmeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nazivFirmeList.FormattingEnabled = true;
            this.nazivFirmeList.Location = new System.Drawing.Point(48, 252);
            this.nazivFirmeList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nazivFirmeList.Name = "nazivFirmeList";
            this.nazivFirmeList.Size = new System.Drawing.Size(383, 24);
            this.nazivFirmeList.TabIndex = 27;
            this.nazivFirmeList.Validating += new System.ComponentModel.CancelEventHandler(this.nazivFirmeList_Validating);
            // 
            // brojRadnihSati
            // 
            this.brojRadnihSati.Location = new System.Drawing.Point(173, 304);
            this.brojRadnihSati.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brojRadnihSati.Name = "brojRadnihSati";
            this.brojRadnihSati.ReadOnly = true;
            this.brojRadnihSati.Size = new System.Drawing.Size(50, 22);
            this.brojRadnihSati.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Broj radnih sati:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Rezervacija je na ime klijenta:";
            // 
            // prezimeText
            // 
            this.prezimeText.Location = new System.Drawing.Point(230, 87);
            this.prezimeText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prezimeText.Name = "prezimeText";
            this.prezimeText.ReadOnly = true;
            this.prezimeText.Size = new System.Drawing.Size(148, 22);
            this.prezimeText.TabIndex = 23;
            // 
            // imeText
            // 
            this.imeText.Location = new System.Drawing.Point(48, 87);
            this.imeText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imeText.Name = "imeText";
            this.imeText.ReadOnly = true;
            this.imeText.Size = new System.Drawing.Size(136, 22);
            this.imeText.TabIndex = 22;
            // 
            // rezervirajSubmit
            // 
            this.rezervirajSubmit.Location = new System.Drawing.Point(252, 390);
            this.rezervirajSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rezervirajSubmit.Name = "rezervirajSubmit";
            this.rezervirajSubmit.Size = new System.Drawing.Size(178, 31);
            this.rezervirajSubmit.TabIndex = 21;
            this.rezervirajSubmit.Text = "Napravi rezervaciju";
            this.rezervirajSubmit.UseVisualStyleBackColor = true;
            this.rezervirajSubmit.Click += new System.EventHandler(this.rezervirajSubmit_Click);
            // 
            // nazadSubmit
            // 
            this.nazadSubmit.Location = new System.Drawing.Point(34, 390);
            this.nazadSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nazadSubmit.Name = "nazadSubmit";
            this.nazadSubmit.Size = new System.Drawing.Size(178, 31);
            this.nazadSubmit.TabIndex = 20;
            this.nazadSubmit.Text = "Nazad na kalendar";
            this.nazadSubmit.UseVisualStyleBackColor = true;
            this.nazadSubmit.Click += new System.EventHandler(this.nazadSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Do:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Odaberite period za koji želite napraviti rezervaciju za radnika:";
            // 
            // krajDateTime
            // 
            this.krajDateTime.Location = new System.Drawing.Point(263, 158);
            this.krajDateTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.krajDateTime.Name = "krajDateTime";
            this.krajDateTime.Size = new System.Drawing.Size(178, 22);
            this.krajDateTime.TabIndex = 16;
            // 
            // pocetakDateTime
            // 
            this.pocetakDateTime.Location = new System.Drawing.Point(45, 158);
            this.pocetakDateTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pocetakDateTime.Name = "pocetakDateTime";
            this.pocetakDateTime.Size = new System.Drawing.Size(178, 22);
            this.pocetakDateTime.TabIndex = 15;
            // 
            // NovaRezervacijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 478);
            this.Controls.Add(this.nazivFirmeList);
            this.Controls.Add(this.brojRadnihSati);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prezimeText);
            this.Controls.Add(this.imeText);
            this.Controls.Add(this.rezervirajSubmit);
            this.Controls.Add(this.nazadSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.krajDateTime);
            this.Controls.Add(this.pocetakDateTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NovaRezervacijaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova rezervacija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox nazivFirmeList;
        private System.Windows.Forms.TextBox brojRadnihSati;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox prezimeText;
        private System.Windows.Forms.TextBox imeText;
        private System.Windows.Forms.Button rezervirajSubmit;
        private System.Windows.Forms.Button nazadSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker krajDateTime;
        private System.Windows.Forms.DateTimePicker pocetakDateTime;
    }
}