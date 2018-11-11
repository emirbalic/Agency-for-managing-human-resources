namespace Agency.Clients
{
    partial class RacunZaKlijentaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nazivKlijentaList = new System.Windows.Forms.ComboBox();
            this.rezervacijeDatagrid = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.osnovniRacunPrikaz = new System.Windows.Forms.ToolStripButton();
            this.detaljniRacunPrikaz = new System.Windows.Forms.ToolStripButton();
            this.zatvoriSubmit = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeDatagrid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izaberite klijenta:";
            // 
            // nazivKlijentaList
            // 
            this.nazivKlijentaList.FormattingEnabled = true;
            this.nazivKlijentaList.Location = new System.Drawing.Point(32, 61);
            this.nazivKlijentaList.Name = "nazivKlijentaList";
            this.nazivKlijentaList.Size = new System.Drawing.Size(185, 24);
            this.nazivKlijentaList.TabIndex = 3;
            this.nazivKlijentaList.SelectedIndexChanged += new System.EventHandler(this.nazivKlijentaList_SelectedIndexChanged);
            // 
            // rezervacijeDatagrid
            // 
            this.rezervacijeDatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rezervacijeDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.rezervacijeDatagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rezervacijeDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.rezervacijeDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rezervacijeDatagrid.EnableHeadersVisualStyles = false;
            this.rezervacijeDatagrid.Location = new System.Drawing.Point(3, 139);
            this.rezervacijeDatagrid.Name = "rezervacijeDatagrid";
            this.rezervacijeDatagrid.RowTemplate.Height = 24;
            this.rezervacijeDatagrid.Size = new System.Drawing.Size(720, 204);
            this.rezervacijeDatagrid.TabIndex = 6;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osnovniRacunPrikaz,
            this.detaljniRacunPrikaz,
            this.zatvoriSubmit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(723, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // osnovniRacunPrikaz
            // 
            this.osnovniRacunPrikaz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.osnovniRacunPrikaz.Image = global::Agency.Properties.Resources.Calculator_16xLG;
            this.osnovniRacunPrikaz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.osnovniRacunPrikaz.Name = "osnovniRacunPrikaz";
            this.osnovniRacunPrikaz.Size = new System.Drawing.Size(23, 22);
            this.osnovniRacunPrikaz.Text = "Prikaz osnovnog računa";
            this.osnovniRacunPrikaz.Click += new System.EventHandler(this.osnovniRacunPrikaz_Click);
            // 
            // detaljniRacunPrikaz
            // 
            this.detaljniRacunPrikaz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.detaljniRacunPrikaz.Image = global::Agency.Properties.Resources.Calculator_32xLG;
            this.detaljniRacunPrikaz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.detaljniRacunPrikaz.Name = "detaljniRacunPrikaz";
            this.detaljniRacunPrikaz.Size = new System.Drawing.Size(23, 22);
            this.detaljniRacunPrikaz.Text = "Prikaz detaljnog računa";
            this.detaljniRacunPrikaz.Click += new System.EventHandler(this.detaljniRacunPrikaz_Click);
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
            // RacunZaKlijentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 343);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.rezervacijeDatagrid);
            this.Controls.Add(this.nazivKlijentaList);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RacunZaKlijentaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prikaz računa";
            this.Load += new System.EventHandler(this.RacunZaKlijentaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeDatagrid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox nazivKlijentaList;
        private System.Windows.Forms.DataGridView rezervacijeDatagrid;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton osnovniRacunPrikaz;
        private System.Windows.Forms.ToolStripButton detaljniRacunPrikaz;
        private System.Windows.Forms.ToolStripButton zatvoriSubmit;
    }
}