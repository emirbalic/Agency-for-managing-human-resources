namespace Agency.Users
{
    partial class PretragaAdministracijaKorisnikaForm
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
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.imeIPrezimeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.korisniciGrid = new System.Windows.Forms.DataGridView();
            this.deaktivirajSubmit = new System.Windows.Forms.ToolStripButton();
            this.aktivirajSubmit = new System.Windows.Forms.ToolStripButton();
            this.izmjenaDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.licniMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusniMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.userInfoSubmit = new System.Windows.Forms.ToolStripButton();
            this.closeSubmit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deaktivirajSubmit,
            this.aktivirajSubmit,
            this.toolStripSeparator3,
            this.izmjenaDropDown,
            this.toolStripSeparator1,
            this.userInfoSubmit,
            this.closeSubmit,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(645, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // imeIPrezimeInput
            // 
            this.imeIPrezimeInput.Location = new System.Drawing.Point(12, 56);
            this.imeIPrezimeInput.Name = "imeIPrezimeInput";
            this.imeIPrezimeInput.Size = new System.Drawing.Size(370, 22);
            this.imeIPrezimeInput.TabIndex = 6;
            this.imeIPrezimeInput.TextChanged += new System.EventHandler(this.imeIPrezimeInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Unesite ime i prezime korisnika čije podatke želite ažurirati:";
            // 
            // korisniciGrid
            // 
            this.korisniciGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.korisniciGrid.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.korisniciGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.korisniciGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.korisniciGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.korisniciGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.korisniciGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.korisniciGrid.EnableHeadersVisualStyles = false;
            this.korisniciGrid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.korisniciGrid.Location = new System.Drawing.Point(0, 119);
            this.korisniciGrid.Name = "korisniciGrid";
            this.korisniciGrid.RowTemplate.Height = 24;
            this.korisniciGrid.Size = new System.Drawing.Size(645, 297);
            this.korisniciGrid.TabIndex = 4;
            this.korisniciGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.korisniciGrid_CellClick);
            // 
            // deaktivirajSubmit
            // 
            this.deaktivirajSubmit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deaktivirajSubmit.Image = global::Agency.Properties.Resources.StatusAnnotations_Blocked_32xLG;
            this.deaktivirajSubmit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deaktivirajSubmit.Name = "deaktivirajSubmit";
            this.deaktivirajSubmit.Size = new System.Drawing.Size(23, 22);
            this.deaktivirajSubmit.Text = "Deaktivacija korisnika";
            this.deaktivirajSubmit.Click += new System.EventHandler(this.deaktivirajSubmit_Click);
            // 
            // aktivirajSubmit
            // 
            this.aktivirajSubmit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aktivirajSubmit.Image = global::Agency.Properties.Resources.StatusAnnotations_Play_32xLG;
            this.aktivirajSubmit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aktivirajSubmit.Name = "aktivirajSubmit";
            this.aktivirajSubmit.Size = new System.Drawing.Size(23, 22);
            this.aktivirajSubmit.Text = "Aktivacija neaktivnih korisnika";
            this.aktivirajSubmit.Click += new System.EventHandler(this.aktivirajSubmit_Click);
            // 
            // izmjenaDropDown
            // 
            this.izmjenaDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.izmjenaDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licniMenu,
            this.statusniMenu});
            this.izmjenaDropDown.Image = global::Agency.Properties.Resources.user_32xLG;
            this.izmjenaDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.izmjenaDropDown.Name = "izmjenaDropDown";
            this.izmjenaDropDown.Size = new System.Drawing.Size(29, 22);
            this.izmjenaDropDown.Text = "Administracija podataka";
            // 
            // licniMenu
            // 
            this.licniMenu.Name = "licniMenu";
            this.licniMenu.Size = new System.Drawing.Size(317, 24);
            this.licniMenu.Text = "Izmjena &ličnih podataka";
            this.licniMenu.Click += new System.EventHandler(this.licniMenu_Click);
            // 
            // statusniMenu
            // 
            this.statusniMenu.Name = "statusniMenu";
            this.statusniMenu.Size = new System.Drawing.Size(317, 24);
            this.statusniMenu.Text = "Izmjena &pristupnih podataka i uloga";
            this.statusniMenu.Click += new System.EventHandler(this.statusniMenu_Click);
            // 
            // userInfoSubmit
            // 
            this.userInfoSubmit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userInfoSubmit.Image = global::Agency.Properties.Resources.StatusAnnotations_Help_and_inconclusive_32xLG;
            this.userInfoSubmit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.userInfoSubmit.Name = "userInfoSubmit";
            this.userInfoSubmit.Size = new System.Drawing.Size(23, 22);
            this.userInfoSubmit.Text = "Informacije o korisniku";
            this.userInfoSubmit.Click += new System.EventHandler(this.userInfoSubmit_Click);
            // 
            // closeSubmit
            // 
            this.closeSubmit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeSubmit.Image = global::Agency.Properties.Resources.StatusAnnotations_Complete_and_ok_32xLG;
            this.closeSubmit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeSubmit.Name = "closeSubmit";
            this.closeSubmit.Size = new System.Drawing.Size(23, 22);
            this.closeSubmit.Text = "Zatvori pretragu";
            this.closeSubmit.Click += new System.EventHandler(this.closeSubmit_Click);
            // 
            // PretragaAdministracijaKorisnikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 416);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.imeIPrezimeInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.korisniciGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PretragaAdministracijaKorisnikaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga i administracija korisnika";
            this.Load += new System.EventHandler(this.PretragaAdministracijaKorisnikaForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton deaktivirajSubmit;
        private System.Windows.Forms.ToolStripButton aktivirajSubmit;
        private System.Windows.Forms.ToolStripDropDownButton izmjenaDropDown;
        private System.Windows.Forms.ToolStripMenuItem licniMenu;
        private System.Windows.Forms.ToolStripMenuItem statusniMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton userInfoSubmit;
        private System.Windows.Forms.TextBox imeIPrezimeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView korisniciGrid;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton closeSubmit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}