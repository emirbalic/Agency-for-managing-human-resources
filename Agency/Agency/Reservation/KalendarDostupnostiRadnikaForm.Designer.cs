namespace Agency.Reservation
{
    partial class KalendarDostupnostiRadnikaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.rezervacijeGrid = new System.Windows.Forms.DataGridView();
            this.potvrdiSubmit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.izadjiRadio = new System.Windows.Forms.RadioButton();
            this.ponoviPretraguRadio = new System.Windows.Forms.RadioButton();
            this.rezervirajRadio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prezimeText = new System.Windows.Forms.TextBox();
            this.imeText = new System.Windows.Forms.TextBox();
            this.zatvoriSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Postojeće rezervacije:";
            // 
            // rezervacijeGrid
            // 
            this.rezervacijeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rezervacijeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.rezervacijeGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rezervacijeGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.rezervacijeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rezervacijeGrid.EnableHeadersVisualStyles = false;
            this.rezervacijeGrid.Location = new System.Drawing.Point(0, 195);
            this.rezervacijeGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rezervacijeGrid.Name = "rezervacijeGrid";
            this.rezervacijeGrid.RowTemplate.Height = 28;
            this.rezervacijeGrid.Size = new System.Drawing.Size(673, 202);
            this.rezervacijeGrid.TabIndex = 24;
            // 
            // potvrdiSubmit
            // 
            this.potvrdiSubmit.Location = new System.Drawing.Point(308, 480);
            this.potvrdiSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.potvrdiSubmit.Name = "potvrdiSubmit";
            this.potvrdiSubmit.Size = new System.Drawing.Size(112, 37);
            this.potvrdiSubmit.TabIndex = 5;
            this.potvrdiSubmit.Text = "Izaberi";
            this.potvrdiSubmit.UseVisualStyleBackColor = true;
            this.potvrdiSubmit.Click += new System.EventHandler(this.potvrdiSubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Šta želite sa ovim radnikom?";
            // 
            // izadjiRadio
            // 
            this.izadjiRadio.AutoSize = true;
            this.izadjiRadio.Location = new System.Drawing.Point(107, 513);
            this.izadjiRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.izadjiRadio.Name = "izadjiRadio";
            this.izadjiRadio.Size = new System.Drawing.Size(129, 21);
            this.izadjiRadio.TabIndex = 4;
            this.izadjiRadio.TabStop = true;
            this.izadjiRadio.Text = "Izaći iz pretrage";
            this.izadjiRadio.UseVisualStyleBackColor = true;
            // 
            // ponoviPretraguRadio
            // 
            this.ponoviPretraguRadio.AutoSize = true;
            this.ponoviPretraguRadio.Location = new System.Drawing.Point(107, 488);
            this.ponoviPretraguRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ponoviPretraguRadio.Name = "ponoviPretraguRadio";
            this.ponoviPretraguRadio.Size = new System.Drawing.Size(137, 21);
            this.ponoviPretraguRadio.TabIndex = 3;
            this.ponoviPretraguRadio.TabStop = true;
            this.ponoviPretraguRadio.Text = "Ponoviti pretragu";
            this.ponoviPretraguRadio.UseVisualStyleBackColor = true;
            // 
            // rezervirajRadio
            // 
            this.rezervirajRadio.AutoSize = true;
            this.rezervirajRadio.Location = new System.Drawing.Point(107, 464);
            this.rezervirajRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rezervirajRadio.Name = "rezervirajRadio";
            this.rezervirajRadio.Size = new System.Drawing.Size(158, 21);
            this.rezervirajRadio.TabIndex = 2;
            this.rezervirajRadio.TabStop = true;
            this.rezervirajRadio.Text = "Napraviti rezervaciju";
            this.rezervirajRadio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Prezime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Podaci o odabranom radniku:";
            // 
            // prezimeText
            // 
            this.prezimeText.Location = new System.Drawing.Point(342, 85);
            this.prezimeText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prezimeText.Name = "prezimeText";
            this.prezimeText.ReadOnly = true;
            this.prezimeText.Size = new System.Drawing.Size(132, 22);
            this.prezimeText.TabIndex = 15;
            // 
            // imeText
            // 
            this.imeText.Location = new System.Drawing.Point(107, 85);
            this.imeText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imeText.Name = "imeText";
            this.imeText.ReadOnly = true;
            this.imeText.Size = new System.Drawing.Size(130, 22);
            this.imeText.TabIndex = 14;
            this.imeText.TabStop = false;
            // 
            // zatvoriSubmit
            // 
            this.zatvoriSubmit.Location = new System.Drawing.Point(449, 480);
            this.zatvoriSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zatvoriSubmit.Name = "zatvoriSubmit";
            this.zatvoriSubmit.Size = new System.Drawing.Size(112, 37);
            this.zatvoriSubmit.TabIndex = 26;
            this.zatvoriSubmit.Text = "Zatvori";
            this.zatvoriSubmit.UseVisualStyleBackColor = true;
            this.zatvoriSubmit.Click += new System.EventHandler(this.zatvoriSubmit_Click);
            // 
            // KalendarDostupnostiRadnikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 578);
            this.Controls.Add(this.zatvoriSubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rezervacijeGrid);
            this.Controls.Add(this.potvrdiSubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.izadjiRadio);
            this.Controls.Add(this.ponoviPretraguRadio);
            this.Controls.Add(this.rezervirajRadio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prezimeText);
            this.Controls.Add(this.imeText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KalendarDostupnostiRadnikaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalendar dostupnosti radnika";
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView rezervacijeGrid;
        private System.Windows.Forms.Button potvrdiSubmit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton izadjiRadio;
        private System.Windows.Forms.RadioButton ponoviPretraguRadio;
        private System.Windows.Forms.RadioButton rezervirajRadio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prezimeText;
        private System.Windows.Forms.TextBox imeText;
        private System.Windows.Forms.Button zatvoriSubmit;
    }
}