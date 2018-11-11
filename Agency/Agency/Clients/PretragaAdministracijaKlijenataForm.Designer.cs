namespace Agency.Clients
{
    partial class PretragaAdministracijaKlijenataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PretragaAdministracijaKlijenataForm));
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.klijentiGrid = new System.Windows.Forms.DataGridView();
            this.imeIPrezimeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.korisnickiMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pristupMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.infoOKlijentu = new System.Windows.Forms.ToolStripButton();
            this.izadjiSubmit = new System.Windows.Forms.ToolStripButton();
            this.flowLayoutPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klijentiGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.toolStrip1);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(704, 24);
            this.flowLayoutPanel.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.infoOKlijentu,
            this.izadjiSubmit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(118, 24);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "Administracija podataka";
            // 
            // klijentiGrid
            // 
            this.klijentiGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.klijentiGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.klijentiGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.klijentiGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.klijentiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.klijentiGrid.EnableHeadersVisualStyles = false;
            this.klijentiGrid.Location = new System.Drawing.Point(0, 102);
            this.klijentiGrid.Name = "klijentiGrid";
            this.klijentiGrid.RowTemplate.Height = 24;
            this.klijentiGrid.Size = new System.Drawing.Size(704, 328);
            this.klijentiGrid.TabIndex = 6;
            this.klijentiGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.klijentiGrid_CellClick);
            // 
            // imeIPrezimeInput
            // 
            this.imeIPrezimeInput.Location = new System.Drawing.Point(12, 52);
            this.imeIPrezimeInput.Name = "imeIPrezimeInput";
            this.imeIPrezimeInput.Size = new System.Drawing.Size(192, 22);
            this.imeIPrezimeInput.TabIndex = 5;
            this.imeIPrezimeInput.TextChanged += new System.EventHandler(this.imeIPrezimeInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Unesite ime i prezime klijenta:";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisnickiMenu,
            this.pristupMenu});
            this.toolStripDropDownButton1.Image = global::Agency.Properties.Resources.folder_Open_32xLG;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 21);
            this.toolStripDropDownButton1.Text = "Administracija podataka o klijentu";
            // 
            // korisnickiMenu
            // 
            this.korisnickiMenu.Name = "korisnickiMenu";
            this.korisnickiMenu.Size = new System.Drawing.Size(281, 24);
            this.korisnickiMenu.Text = "Promjena &korisničkih podataka";
            this.korisnickiMenu.Click += new System.EventHandler(this.korisnickiMenu_Click);
            // 
            // pristupMenu
            // 
            this.pristupMenu.Name = "pristupMenu";
            this.pristupMenu.Size = new System.Drawing.Size(281, 24);
            this.pristupMenu.Text = "Promjena &pristupnih podataka";
            this.pristupMenu.Click += new System.EventHandler(this.pristupMenu_Click);
            // 
            // infoOKlijentu
            // 
            this.infoOKlijentu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.infoOKlijentu.Image = global::Agency.Properties.Resources.StatusAnnotations_Help_and_inconclusive_32xLG;
            this.infoOKlijentu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.infoOKlijentu.Name = "infoOKlijentu";
            this.infoOKlijentu.Size = new System.Drawing.Size(23, 21);
            this.infoOKlijentu.Text = "Informacije o klijentu";
            this.infoOKlijentu.Click += new System.EventHandler(this.infoOKlijentu_Click);
            // 
            // izadjiSubmit
            // 
            this.izadjiSubmit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.izadjiSubmit.Image = ((System.Drawing.Image)(resources.GetObject("izadjiSubmit.Image")));
            this.izadjiSubmit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.izadjiSubmit.Name = "izadjiSubmit";
            this.izadjiSubmit.Size = new System.Drawing.Size(23, 21);
            this.izadjiSubmit.Text = "Zatvori pretragu";
            this.izadjiSubmit.Click += new System.EventHandler(this.izadjiSubmit_Click);
            // 
            // PretragaAdministracijaKlijenataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 430);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.klijentiGrid);
            this.Controls.Add(this.imeIPrezimeInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PretragaAdministracijaKlijenataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga i administracija klijenata";
            this.Load += new System.EventHandler(this.PretragaAdministracijaKlijenataForm_Load);
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klijentiGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem korisnickiMenu;
        private System.Windows.Forms.ToolStripMenuItem pristupMenu;
        private System.Windows.Forms.DataGridView klijentiGrid;
        private System.Windows.Forms.TextBox imeIPrezimeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton infoOKlijentu;
        private System.Windows.Forms.ToolStripButton izadjiSubmit;
    }
}