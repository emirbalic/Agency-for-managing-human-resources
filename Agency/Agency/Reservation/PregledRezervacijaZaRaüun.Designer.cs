namespace Agency.Reservation
{
    partial class PregledRezervacijaZaRačun
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ispostaviRacunSubmit = new System.Windows.Forms.ToolStripButton();
            this.zatvoriSubmit = new System.Windows.Forms.ToolStripButton();
            this.racunGrid = new System.Windows.Forms.DataGridView();
            this.radniciList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racunGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ispostaviRacunSubmit,
            this.zatvoriSubmit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(569, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ispostaviRacunSubmit
            // 
            this.ispostaviRacunSubmit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ispostaviRacunSubmit.Image = global::Agency.Properties.Resources.folder_Open_32xLG;
            this.ispostaviRacunSubmit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ispostaviRacunSubmit.Name = "ispostaviRacunSubmit";
            this.ispostaviRacunSubmit.Size = new System.Drawing.Size(23, 22);
            this.ispostaviRacunSubmit.Text = "Prikaži račun";
            this.ispostaviRacunSubmit.Click += new System.EventHandler(this.ispostaviRacunSubmit_Click);
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
            // racunGrid
            // 
            this.racunGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.racunGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.racunGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.racunGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.racunGrid.EnableHeadersVisualStyles = false;
            this.racunGrid.Location = new System.Drawing.Point(0, 113);
            this.racunGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.racunGrid.Name = "racunGrid";
            this.racunGrid.RowTemplate.Height = 28;
            this.racunGrid.Size = new System.Drawing.Size(569, 214);
            this.racunGrid.TabIndex = 8;
            // 
            // radniciList
            // 
            this.radniciList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.radniciList.FormattingEnabled = true;
            this.radniciList.Location = new System.Drawing.Point(278, 52);
            this.radniciList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radniciList.Name = "radniciList";
            this.radniciList.Size = new System.Drawing.Size(235, 24);
            this.radniciList.TabIndex = 7;
            this.radniciList.SelectedIndexChanged += new System.EventHandler(this.radniciList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Izlistajte sve rezervacije za radnika:";
            // 
            // PregledRezervacijaZaRačun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 327);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.racunGrid);
            this.Controls.Add(this.radniciList);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PregledRezervacijaZaRačun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled rezervacija za pripremu računa";
            this.Load += new System.EventHandler(this.PregledRezervacijaZaRačun_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racunGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ispostaviRacunSubmit;
        private System.Windows.Forms.DataGridView racunGrid;
        private System.Windows.Forms.ComboBox radniciList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton zatvoriSubmit;
    }
}