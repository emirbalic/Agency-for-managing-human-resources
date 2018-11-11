namespace Agency.Admin
{
    partial class PregledStrukaForm
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
            this.StrukeGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StrukeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StrukeGrid
            // 
            this.StrukeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StrukeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StrukeGrid.EnableHeadersVisualStyles = false;
            this.StrukeGrid.Location = new System.Drawing.Point(0, 0);
            this.StrukeGrid.Name = "StrukeGrid";
            this.StrukeGrid.RowTemplate.Height = 24;
            this.StrukeGrid.Size = new System.Drawing.Size(238, 340);
            this.StrukeGrid.TabIndex = 0;
            // 
            // PregledStrukaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 340);
            this.Controls.Add(this.StrukeGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PregledStrukaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled struka";
            this.Load += new System.EventHandler(this.PregledStrukaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StrukeGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StrukeGrid;
    }
}