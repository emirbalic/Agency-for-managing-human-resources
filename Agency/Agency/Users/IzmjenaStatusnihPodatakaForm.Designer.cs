namespace Agency.Users
{
    partial class IzmjenaStatusnihPodatakaForm
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
            this.sacuvajSubmit = new System.Windows.Forms.Button();
            this.statusCheckBox = new System.Windows.Forms.CheckBox();
            this.ulogeList = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lozinkaInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.korisnickoImeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // odustaniSubmit
            // 
            this.odustaniSubmit.Location = new System.Drawing.Point(147, 268);
            this.odustaniSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.odustaniSubmit.Name = "odustaniSubmit";
            this.odustaniSubmit.Size = new System.Drawing.Size(94, 33);
            this.odustaniSubmit.TabIndex = 21;
            this.odustaniSubmit.Text = "Odustani";
            this.odustaniSubmit.UseVisualStyleBackColor = true;
            this.odustaniSubmit.Click += new System.EventHandler(this.odustaniSubmit_Click);
            // 
            // sacuvajSubmit
            // 
            this.sacuvajSubmit.Location = new System.Drawing.Point(258, 268);
            this.sacuvajSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sacuvajSubmit.Name = "sacuvajSubmit";
            this.sacuvajSubmit.Size = new System.Drawing.Size(94, 33);
            this.sacuvajSubmit.TabIndex = 23;
            this.sacuvajSubmit.Text = "Sačuvaj";
            this.sacuvajSubmit.UseVisualStyleBackColor = true;
            this.sacuvajSubmit.Click += new System.EventHandler(this.sacuvajSubmit_Click);
            // 
            // statusCheckBox
            // 
            this.statusCheckBox.AutoSize = true;
            this.statusCheckBox.Location = new System.Drawing.Point(147, 221);
            this.statusCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusCheckBox.Name = "statusCheckBox";
            this.statusCheckBox.Size = new System.Drawing.Size(76, 21);
            this.statusCheckBox.TabIndex = 20;
            this.statusCheckBox.Text = "Aktivan";
            this.statusCheckBox.UseVisualStyleBackColor = true;
            // 
            // ulogeList
            // 
            this.ulogeList.FormattingEnabled = true;
            this.ulogeList.Location = new System.Drawing.Point(147, 136);
            this.ulogeList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ulogeList.Name = "ulogeList";
            this.ulogeList.Size = new System.Drawing.Size(206, 55);
            this.ulogeList.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "ULoge:";
            // 
            // lozinkaInput
            // 
            this.lozinkaInput.Location = new System.Drawing.Point(147, 92);
            this.lozinkaInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lozinkaInput.Name = "lozinkaInput";
            this.lozinkaInput.PasswordChar = '*';
            this.lozinkaInput.Size = new System.Drawing.Size(206, 22);
            this.lozinkaInput.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Lozinka";
            // 
            // korisnickoImeInput
            // 
            this.korisnickoImeInput.Location = new System.Drawing.Point(147, 52);
            this.korisnickoImeInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.korisnickoImeInput.Name = "korisnickoImeInput";
            this.korisnickoImeInput.ReadOnly = true;
            this.korisnickoImeInput.Size = new System.Drawing.Size(206, 22);
            this.korisnickoImeInput.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Korisničko ime:";
            // 
            // IzmjenaStatusnihPodatakaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 350);
            this.Controls.Add(this.odustaniSubmit);
            this.Controls.Add(this.sacuvajSubmit);
            this.Controls.Add(this.statusCheckBox);
            this.Controls.Add(this.ulogeList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lozinkaInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.korisnickoImeInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IzmjenaStatusnihPodatakaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izmjena pristupnih podataka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button odustaniSubmit;
        private System.Windows.Forms.Button sacuvajSubmit;
        private System.Windows.Forms.CheckBox statusCheckBox;
        private System.Windows.Forms.CheckedListBox ulogeList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lozinkaInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox korisnickoImeInput;
        private System.Windows.Forms.Label label1;
    }
}