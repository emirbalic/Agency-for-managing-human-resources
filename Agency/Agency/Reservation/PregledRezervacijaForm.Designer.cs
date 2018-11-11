namespace Agency.Reservation
{
    partial class PregledRezervacijaForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.otkaziSubmit = new System.Windows.Forms.ToolStripButton();
            this.zatvoriSubmit = new System.Windows.Forms.ToolStripButton();
            this.rezervacijeGrid = new System.Windows.Forms.DataGridView();
            this.radniciList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otkaziSubmit,
            this.zatvoriSubmit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(548, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // otkaziSubmit
            // 
            this.otkaziSubmit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.otkaziSubmit.Image = global::Agency.Properties.Resources.StatusAnnotations_Blocked_32xLG;
            this.otkaziSubmit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.otkaziSubmit.Name = "otkaziSubmit";
            this.otkaziSubmit.Size = new System.Drawing.Size(23, 22);
            this.otkaziSubmit.Text = "Otkažite selektiranu rezervaciju";
            this.otkaziSubmit.Click += new System.EventHandler(this.otkaziSubmit_Click);
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
            // rezervacijeGrid
            // 
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
            this.rezervacijeGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rezervacijeGrid.EnableHeadersVisualStyles = false;
            this.rezervacijeGrid.Location = new System.Drawing.Point(0, 130);
            this.rezervacijeGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rezervacijeGrid.Name = "rezervacijeGrid";
            this.rezervacijeGrid.RowTemplate.Height = 28;
            this.rezervacijeGrid.Size = new System.Drawing.Size(548, 200);
            this.rezervacijeGrid.TabIndex = 12;
            // 
            // radniciList
            // 
            this.radniciList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.radniciList.FormattingEnabled = true;
            this.radniciList.Location = new System.Drawing.Point(28, 54);
            this.radniciList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radniciList.Name = "radniciList";
            this.radniciList.Size = new System.Drawing.Size(235, 24);
            this.radniciList.TabIndex = 11;
            this.radniciList.SelectedIndexChanged += new System.EventHandler(this.radniciList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Izlistajte sve rezervacije za radnika:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "U listi ispod izaberite rezervaciju koju želite otkazati:";
            // 
            // PregledRezervacijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 330);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.rezervacijeGrid);
            this.Controls.Add(this.radniciList);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PregledRezervacijaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled svih rezervacija";
            this.Load += new System.EventHandler(this.PregledRezervacijaForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton zatvoriSubmit;
        private System.Windows.Forms.DataGridView rezervacijeGrid;
        private System.Windows.Forms.ComboBox radniciList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton otkaziSubmit;
        private System.Windows.Forms.Label label2;
    }
}