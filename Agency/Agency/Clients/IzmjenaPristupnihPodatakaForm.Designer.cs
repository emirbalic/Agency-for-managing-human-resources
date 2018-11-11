namespace Agency.Clients
{
    partial class IzmjenaPristupnihPodatakaForm
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
            this.nazivReadOnly = new System.Windows.Forms.TextBox();
            this.korisnickoImeInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lozinkaInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.odustaniSubmit = new System.Windows.Forms.Button();
            this.snimiSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // nazivReadOnly
            // 
            this.nazivReadOnly.Location = new System.Drawing.Point(144, 38);
            this.nazivReadOnly.Name = "nazivReadOnly";
            this.nazivReadOnly.Size = new System.Drawing.Size(195, 22);
            this.nazivReadOnly.TabIndex = 0;
            // 
            // korisnickoImeInput
            // 
            this.korisnickoImeInput.Location = new System.Drawing.Point(144, 77);
            this.korisnickoImeInput.Name = "korisnickoImeInput";
            this.korisnickoImeInput.Size = new System.Drawing.Size(195, 22);
            this.korisnickoImeInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Korisničko ime:";
            // 
            // lozinkaInput
            // 
            this.lozinkaInput.Location = new System.Drawing.Point(144, 116);
            this.lozinkaInput.Name = "lozinkaInput";
            this.lozinkaInput.PasswordChar = '*';
            this.lozinkaInput.Size = new System.Drawing.Size(195, 22);
            this.lozinkaInput.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lozinka:";
            // 
            // odustaniSubmit
            // 
            this.odustaniSubmit.Location = new System.Drawing.Point(144, 162);
            this.odustaniSubmit.Name = "odustaniSubmit";
            this.odustaniSubmit.Size = new System.Drawing.Size(75, 28);
            this.odustaniSubmit.TabIndex = 3;
            this.odustaniSubmit.Text = "Odustani";
            this.odustaniSubmit.UseVisualStyleBackColor = true;
            this.odustaniSubmit.Click += new System.EventHandler(this.odustaniSubmit_Click);
            // 
            // snimiSubmit
            // 
            this.snimiSubmit.Location = new System.Drawing.Point(264, 162);
            this.snimiSubmit.Name = "snimiSubmit";
            this.snimiSubmit.Size = new System.Drawing.Size(75, 28);
            this.snimiSubmit.TabIndex = 4;
            this.snimiSubmit.Text = "Sačuvaj";
            this.snimiSubmit.UseVisualStyleBackColor = true;
            this.snimiSubmit.Click += new System.EventHandler(this.snimiSubmit_Click);
            // 
            // IzmjenaPristupnihPodatakaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 229);
            this.Controls.Add(this.snimiSubmit);
            this.Controls.Add(this.odustaniSubmit);
            this.Controls.Add(this.lozinkaInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.korisnickoImeInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nazivReadOnly);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IzmjenaPristupnihPodatakaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izmjena pristupnih podataka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nazivReadOnly;
        private System.Windows.Forms.TextBox korisnickoImeInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lozinkaInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button odustaniSubmit;
        private System.Windows.Forms.Button snimiSubmit;
    }
}