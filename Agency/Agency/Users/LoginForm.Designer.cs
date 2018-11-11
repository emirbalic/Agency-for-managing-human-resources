namespace Agency.Users
{
    partial class LoginForm
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
            this.prijavaSubmit = new System.Windows.Forms.Button();
            this.lozinkaInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.korisnickoImeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.odustaniSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prijavaSubmit
            // 
            this.prijavaSubmit.Location = new System.Drawing.Point(235, 115);
            this.prijavaSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prijavaSubmit.Name = "prijavaSubmit";
            this.prijavaSubmit.Size = new System.Drawing.Size(76, 26);
            this.prijavaSubmit.TabIndex = 3;
            this.prijavaSubmit.Text = "Prijava";
            this.prijavaSubmit.UseVisualStyleBackColor = true;
            this.prijavaSubmit.Click += new System.EventHandler(this.prijavaSubmit_Click);
            this.prijavaSubmit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.prijavaSubmit_KeyDown);
            // 
            // lozinkaInput
            // 
            this.lozinkaInput.Location = new System.Drawing.Point(140, 70);
            this.lozinkaInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lozinkaInput.Name = "lozinkaInput";
            this.lozinkaInput.PasswordChar = '*';
            this.lozinkaInput.Size = new System.Drawing.Size(170, 22);
            this.lozinkaInput.TabIndex = 1;
            this.lozinkaInput.Text = "larisa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Lozinka:";
            // 
            // korisnickoImeInput
            // 
            this.korisnickoImeInput.Location = new System.Drawing.Point(140, 37);
            this.korisnickoImeInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.korisnickoImeInput.Name = "korisnickoImeInput";
            this.korisnickoImeInput.Size = new System.Drawing.Size(170, 22);
            this.korisnickoImeInput.TabIndex = 0;
            this.korisnickoImeInput.Text = "larisa";
            this.korisnickoImeInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.korisnickoImeInput_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Korisničko ime:";
            // 
            // odustaniSubmit
            // 
            this.odustaniSubmit.Location = new System.Drawing.Point(140, 115);
            this.odustaniSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.odustaniSubmit.Name = "odustaniSubmit";
            this.odustaniSubmit.Size = new System.Drawing.Size(77, 26);
            this.odustaniSubmit.TabIndex = 2;
            this.odustaniSubmit.Text = "Odustani";
            this.odustaniSubmit.UseVisualStyleBackColor = true;
            this.odustaniSubmit.Click += new System.EventHandler(this.odustaniSubmit_Click);
            this.odustaniSubmit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.odustaniSubmit_KeyDown);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 181);
            this.Controls.Add(this.prijavaSubmit);
            this.Controls.Add(this.lozinkaInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.korisnickoImeInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odustaniSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava na sistem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prijavaSubmit;
        private System.Windows.Forms.TextBox lozinkaInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox korisnickoImeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button odustaniSubmit;
    }
}