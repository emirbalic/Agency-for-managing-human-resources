namespace Agency.Clients
{
    partial class RacunInsertAndInfoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.klijentiList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stavkeZaRacunGrid = new System.Windows.Forms.DataGridView();
            this.odabirRezervacijeLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.napraviRacunSubmit = new System.Windows.Forms.ToolStripButton();
            this.zatvoriSubmit = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeZaRacunGrid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // klijentiList
            // 
            this.klijentiList.FormattingEnabled = true;
            this.klijentiList.Location = new System.Drawing.Point(23, 72);
            this.klijentiList.Name = "klijentiList";
            this.klijentiList.Size = new System.Drawing.Size(221, 24);
            this.klijentiList.TabIndex = 0;
            this.klijentiList.SelectedIndexChanged += new System.EventHandler(this.klijentiList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izaberite klijenta kojem želite napraviti račun:";
            // 
            // stavkeZaRacunGrid
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.stavkeZaRacunGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.stavkeZaRacunGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stavkeZaRacunGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stavkeZaRacunGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.stavkeZaRacunGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stavkeZaRacunGrid.EnableHeadersVisualStyles = false;
            this.stavkeZaRacunGrid.Location = new System.Drawing.Point(1, 141);
            this.stavkeZaRacunGrid.Name = "stavkeZaRacunGrid";
            this.stavkeZaRacunGrid.RowTemplate.Height = 24;
            this.stavkeZaRacunGrid.Size = new System.Drawing.Size(630, 248);
            this.stavkeZaRacunGrid.TabIndex = 2;
            // 
            // odabirRezervacijeLabel
            // 
            this.odabirRezervacijeLabel.AutoSize = true;
            this.odabirRezervacijeLabel.Location = new System.Drawing.Point(32, 115);
            this.odabirRezervacijeLabel.Name = "odabirRezervacijeLabel";
            this.odabirRezervacijeLabel.Size = new System.Drawing.Size(0, 17);
            this.odabirRezervacijeLabel.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.napraviRacunSubmit,
            this.zatvoriSubmit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(631, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Izaberite datum za koji želite napraviti račun:";
            // 
            // napraviRacunSubmit
            // 
            this.napraviRacunSubmit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.napraviRacunSubmit.Image = global::Agency.Properties.Resources.Calculator_32xLG;
            this.napraviRacunSubmit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.napraviRacunSubmit.Name = "napraviRacunSubmit";
            this.napraviRacunSubmit.Size = new System.Drawing.Size(23, 22);
            this.napraviRacunSubmit.Text = "Napravite račun";
            this.napraviRacunSubmit.Click += new System.EventHandler(this.napraviRacunSubmit_Click);
            // 
            // zatvoriSubmit
            // 
            this.zatvoriSubmit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zatvoriSubmit.Image = global::Agency.Properties.Resources.StatusAnnotations_Complete_and_ok_32xLG;
            this.zatvoriSubmit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zatvoriSubmit.Name = "zatvoriSubmit";
            this.zatvoriSubmit.Size = new System.Drawing.Size(23, 22);
            this.zatvoriSubmit.Text = "Zatvori";
            this.zatvoriSubmit.Click += new System.EventHandler(this.zatvoriSubmit_Click);
            // 
            // RacunInsertAndInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 386);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.odabirRezervacijeLabel);
            this.Controls.Add(this.stavkeZaRacunGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.klijentiList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RacunInsertAndInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga klijenata za upis računa";
            this.Load += new System.EventHandler(this.RacunInsertAndInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stavkeZaRacunGrid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox klijentiList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView stavkeZaRacunGrid;
        private System.Windows.Forms.Label odabirRezervacijeLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton napraviRacunSubmit;
        private System.Windows.Forms.ToolStripButton zatvoriSubmit;
        private System.Windows.Forms.Label label2;
    }
}