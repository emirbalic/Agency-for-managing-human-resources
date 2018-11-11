namespace Agency.Workers
{
    partial class PretragaAdministracijaRadnika
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
            this.imeIPrezimeInput = new System.Windows.Forms.TextBox();
            this.radniciGrid = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.deaktivirajSubmit = new System.Windows.Forms.ToolStripButton();
            this.reaktivnirajSubmit = new System.Windows.Forms.ToolStripButton();
            this.licniSubmit = new System.Windows.Forms.ToolStripButton();
            this.infoSubmit = new System.Windows.Forms.ToolStripButton();
            this.zatvoriSubmit = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.radniciGrid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite ime i prezime radnika:";
            // 
            // imeIPrezimeInput
            // 
            this.imeIPrezimeInput.Location = new System.Drawing.Point(49, 63);
            this.imeIPrezimeInput.Name = "imeIPrezimeInput";
            this.imeIPrezimeInput.Size = new System.Drawing.Size(201, 22);
            this.imeIPrezimeInput.TabIndex = 1;
            this.imeIPrezimeInput.TextChanged += new System.EventHandler(this.imeIPrezimeInput_TextChanged);
            // 
            // radniciGrid
            // 
            this.radniciGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radniciGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.radniciGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.radniciGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.radniciGrid.EnableHeadersVisualStyles = false;
            this.radniciGrid.Location = new System.Drawing.Point(0, 107);
            this.radniciGrid.Name = "radniciGrid";
            this.radniciGrid.RowTemplate.Height = 24;
            this.radniciGrid.Size = new System.Drawing.Size(629, 255);
            this.radniciGrid.TabIndex = 2;
            this.radniciGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.radniciGrid_CellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deaktivirajSubmit,
            this.reaktivnirajSubmit,
            this.licniSubmit,
            this.infoSubmit,
            this.zatvoriSubmit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(628, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // deaktivirajSubmit
            // 
            this.deaktivirajSubmit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deaktivirajSubmit.Image = global::Agency.Properties.Resources.StatusAnnotations_Blocked_32xLG;
            this.deaktivirajSubmit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deaktivirajSubmit.Name = "deaktivirajSubmit";
            this.deaktivirajSubmit.Size = new System.Drawing.Size(23, 22);
            this.deaktivirajSubmit.Text = "Deaktivacija radnika na sistemu";
            this.deaktivirajSubmit.Click += new System.EventHandler(this.deaktivirajSubmit_Click);
            // 
            // reaktivnirajSubmit
            // 
            this.reaktivnirajSubmit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reaktivnirajSubmit.Image = global::Agency.Properties.Resources.StatusAnnotations_Play_32xLG;
            this.reaktivnirajSubmit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reaktivnirajSubmit.Name = "reaktivnirajSubmit";
            this.reaktivnirajSubmit.Size = new System.Drawing.Size(23, 22);
            this.reaktivnirajSubmit.Text = "Aktivacija radnika na sistemu";
            this.reaktivnirajSubmit.Click += new System.EventHandler(this.reaktivnirajSubmit_Click);
            // 
            // licniSubmit
            // 
            this.licniSubmit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.licniSubmit.Image = global::Agency.Properties.Resources.user_32xLG;
            this.licniSubmit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.licniSubmit.Name = "licniSubmit";
            this.licniSubmit.Size = new System.Drawing.Size(23, 22);
            this.licniSubmit.Text = "Izmjena osnovnih ličnih podataka ";
            this.licniSubmit.Click += new System.EventHandler(this.licniSubmit_Click);
            // 
            // infoSubmit
            // 
            this.infoSubmit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.infoSubmit.Image = global::Agency.Properties.Resources.StatusAnnotations_Help_and_inconclusive_32xLG;
            this.infoSubmit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.infoSubmit.Name = "infoSubmit";
            this.infoSubmit.Size = new System.Drawing.Size(23, 22);
            this.infoSubmit.Text = "Detaljne informacije o radniku";
            this.infoSubmit.Click += new System.EventHandler(this.infoSubmit_Click);
            // 
            // zatvoriSubmit
            // 
            this.zatvoriSubmit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zatvoriSubmit.Image = global::Agency.Properties.Resources.StatusAnnotations_Complete_and_ok_32xLG;
            this.zatvoriSubmit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zatvoriSubmit.Name = "zatvoriSubmit";
            this.zatvoriSubmit.Size = new System.Drawing.Size(23, 22);
            this.zatvoriSubmit.Text = "Zatvori ";
            this.zatvoriSubmit.Click += new System.EventHandler(this.zatvoriSubmit_Click);
            // 
            // PretragaAdministracijaRadnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(628, 358);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.radniciGrid);
            this.Controls.Add(this.imeIPrezimeInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PretragaAdministracijaRadnika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga i administracija radnika";
            this.Load += new System.EventHandler(this.PretragaAdministracijaRadnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radniciGrid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imeIPrezimeInput;
        private System.Windows.Forms.DataGridView radniciGrid;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton deaktivirajSubmit;
        private System.Windows.Forms.ToolStripButton reaktivnirajSubmit;
        private System.Windows.Forms.ToolStripButton licniSubmit;
        private System.Windows.Forms.ToolStripButton infoSubmit;
        private System.Windows.Forms.ToolStripButton zatvoriSubmit;
    }
}