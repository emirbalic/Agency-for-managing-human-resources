namespace Agency.Reservation
{
    partial class PretragaPoStruciForm
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
            this.RadniciGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.strukaList = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.provjeraDostupnostiSubmit = new System.Windows.Forms.ToolStripButton();
            this.zatvoriSubmit = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.RadniciGrid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RadniciGrid
            // 
            this.RadniciGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadniciGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.RadniciGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RadniciGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.RadniciGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RadniciGrid.EnableHeadersVisualStyles = false;
            this.RadniciGrid.Location = new System.Drawing.Point(1, 87);
            this.RadniciGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadniciGrid.Name = "RadniciGrid";
            this.RadniciGrid.ReadOnly = true;
            this.RadniciGrid.RowTemplate.Height = 28;
            this.RadniciGrid.Size = new System.Drawing.Size(666, 280);
            this.RadniciGrid.TabIndex = 5;
            this.RadniciGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RadniciGrid_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Izaberite struku za koju pravite pretragu:";
            // 
            // strukaList
            // 
            this.strukaList.FormattingEnabled = true;
            this.strukaList.Location = new System.Drawing.Point(53, 50);
            this.strukaList.Name = "strukaList";
            this.strukaList.Size = new System.Drawing.Size(197, 24);
            this.strukaList.TabIndex = 6;
            this.strukaList.SelectedIndexChanged += new System.EventHandler(this.strukaList_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.provjeraDostupnostiSubmit,
            this.zatvoriSubmit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(667, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // provjeraDostupnostiSubmit
            // 
            this.provjeraDostupnostiSubmit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.provjeraDostupnostiSubmit.Image = global::Agency.Properties.Resources.StatusAnnotations_Help_and_inconclusive_32xLG;
            this.provjeraDostupnostiSubmit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.provjeraDostupnostiSubmit.Name = "provjeraDostupnostiSubmit";
            this.provjeraDostupnostiSubmit.Size = new System.Drawing.Size(23, 22);
            this.provjeraDostupnostiSubmit.Text = "Provjeri dostupnost radnika";
            this.provjeraDostupnostiSubmit.Click += new System.EventHandler(this.provjeraDostupnostiSubmit_Click);
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
            // PretragaPoStruciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 364);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.strukaList);
            this.Controls.Add(this.RadniciGrid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PretragaPoStruciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga po struci";
            ((System.ComponentModel.ISupportInitialize)(this.RadniciGrid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RadniciGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox strukaList;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton provjeraDostupnostiSubmit;
        private System.Windows.Forms.ToolStripButton zatvoriSubmit;
    }
}