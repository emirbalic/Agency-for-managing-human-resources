namespace Agency.Workers
{
    partial class NoviRadnikForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.imeInput = new System.Windows.Forms.TextBox();
            this.gradList = new System.Windows.Forms.ComboBox();
            this.prezimeInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.jmbgInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ulicaIBrojInput = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.strucnaSpremaList = new System.Windows.Forms.ComboBox();
            this.strukaList = new System.Windows.Forms.ComboBox();
            this.odustaniSubmit = new System.Windows.Forms.Button();
            this.snimiSubmit = new System.Windows.Forms.Button();
            this.telefonInput = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cijenaInput = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // imeInput
            // 
            this.imeInput.Location = new System.Drawing.Point(137, 30);
            this.imeInput.Name = "imeInput";
            this.imeInput.Size = new System.Drawing.Size(183, 22);
            this.imeInput.TabIndex = 0;
            this.imeInput.Validating += new System.ComponentModel.CancelEventHandler(this.imeInput_Validating);
            // 
            // gradList
            // 
            this.gradList.FormattingEnabled = true;
            this.gradList.Location = new System.Drawing.Point(137, 315);
            this.gradList.Name = "gradList";
            this.gradList.Size = new System.Drawing.Size(183, 24);
            this.gradList.TabIndex = 7;
            this.gradList.Validating += new System.ComponentModel.CancelEventHandler(this.gradList_Validating);
            // 
            // prezimeInput
            // 
            this.prezimeInput.Location = new System.Drawing.Point(137, 71);
            this.prezimeInput.Name = "prezimeInput";
            this.prezimeInput.Size = new System.Drawing.Size(183, 22);
            this.prezimeInput.TabIndex = 1;
            this.prezimeInput.Validating += new System.ComponentModel.CancelEventHandler(this.prezimeInput_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prezime:";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(137, 157);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(183, 22);
            this.emailInput.TabIndex = 3;
            this.emailInput.Validating += new System.ComponentModel.CancelEventHandler(this.emailInput_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email:";
            // 
            // jmbgInput
            // 
            this.jmbgInput.Location = new System.Drawing.Point(137, 117);
            this.jmbgInput.Name = "jmbgInput";
            this.jmbgInput.Size = new System.Drawing.Size(183, 22);
            this.jmbgInput.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "JMBG:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cijena KM/h";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefon:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Grad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 395);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Stručna sprema:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 358);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Struka:";
            // 
            // ulicaIBrojInput
            // 
            this.ulicaIBrojInput.Location = new System.Drawing.Point(137, 277);
            this.ulicaIBrojInput.Name = "ulicaIBrojInput";
            this.ulicaIBrojInput.Size = new System.Drawing.Size(183, 22);
            this.ulicaIBrojInput.TabIndex = 6;
            this.ulicaIBrojInput.Validating += new System.ComponentModel.CancelEventHandler(this.ulicaIBrojInput_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "Ulica i broj:";
            // 
            // strucnaSpremaList
            // 
            this.strucnaSpremaList.FormattingEnabled = true;
            this.strucnaSpremaList.Location = new System.Drawing.Point(137, 393);
            this.strucnaSpremaList.Name = "strucnaSpremaList";
            this.strucnaSpremaList.Size = new System.Drawing.Size(183, 24);
            this.strucnaSpremaList.TabIndex = 9;
            this.strucnaSpremaList.Validating += new System.ComponentModel.CancelEventHandler(this.strucnaSpremaList_Validating);
            // 
            // strukaList
            // 
            this.strukaList.FormattingEnabled = true;
            this.strukaList.Location = new System.Drawing.Point(137, 356);
            this.strukaList.Name = "strukaList";
            this.strukaList.Size = new System.Drawing.Size(183, 24);
            this.strukaList.TabIndex = 8;
            this.strukaList.Validating += new System.ComponentModel.CancelEventHandler(this.strukaList_Validating);
            // 
            // odustaniSubmit
            // 
            this.odustaniSubmit.Location = new System.Drawing.Point(137, 437);
            this.odustaniSubmit.Name = "odustaniSubmit";
            this.odustaniSubmit.Size = new System.Drawing.Size(80, 40);
            this.odustaniSubmit.TabIndex = 10;
            this.odustaniSubmit.Text = "Odustani";
            this.odustaniSubmit.UseVisualStyleBackColor = true;
            this.odustaniSubmit.Click += new System.EventHandler(this.odustaniSubmit_Click);
            // 
            // snimiSubmit
            // 
            this.snimiSubmit.Location = new System.Drawing.Point(240, 437);
            this.snimiSubmit.Name = "snimiSubmit";
            this.snimiSubmit.Size = new System.Drawing.Size(80, 40);
            this.snimiSubmit.TabIndex = 11;
            this.snimiSubmit.Text = "Sačuvaj";
            this.snimiSubmit.UseVisualStyleBackColor = true;
            this.snimiSubmit.Click += new System.EventHandler(this.snimiSubmit_Click);
            // 
            // telefonInput
            // 
            this.telefonInput.Location = new System.Drawing.Point(137, 199);
            this.telefonInput.Mask = "(999) 000-000";
            this.telefonInput.Name = "telefonInput";
            this.telefonInput.Size = new System.Drawing.Size(183, 22);
            this.telefonInput.TabIndex = 4;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cijenaInput
            // 
            this.cijenaInput.Location = new System.Drawing.Point(137, 239);
            this.cijenaInput.Mask = "000.00";
            this.cijenaInput.Name = "cijenaInput";
            this.cijenaInput.Size = new System.Drawing.Size(183, 22);
            this.cijenaInput.TabIndex = 5;
            // 
            // NoviRadnikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 504);
            this.Controls.Add(this.cijenaInput);
            this.Controls.Add(this.telefonInput);
            this.Controls.Add(this.snimiSubmit);
            this.Controls.Add(this.odustaniSubmit);
            this.Controls.Add(this.strukaList);
            this.Controls.Add(this.strucnaSpremaList);
            this.Controls.Add(this.ulicaIBrojInput);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.jmbgInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prezimeInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gradList);
            this.Controls.Add(this.imeInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NoviRadnikForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos novog radnika:";
            this.Load += new System.EventHandler(this.NoviRadnikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imeInput;
        private System.Windows.Forms.ComboBox gradList;
        private System.Windows.Forms.TextBox prezimeInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox jmbgInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ulicaIBrojInput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox strucnaSpremaList;
        private System.Windows.Forms.ComboBox strukaList;
        private System.Windows.Forms.Button odustaniSubmit;
        private System.Windows.Forms.Button snimiSubmit;
        private System.Windows.Forms.MaskedTextBox telefonInput;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.MaskedTextBox cijenaInput;
    }
}