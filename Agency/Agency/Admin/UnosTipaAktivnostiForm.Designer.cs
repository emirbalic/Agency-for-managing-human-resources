namespace Agency.Admin
{
    partial class UnosTipaAktivnostiForm
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
            this.odustaniSubmit = new System.Windows.Forms.Button();
            this.spasiSubmit = new System.Windows.Forms.Button();
            this.tipAktivnostiText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // odustaniSubmit
            // 
            this.odustaniSubmit.Location = new System.Drawing.Point(221, 85);
            this.odustaniSubmit.Name = "odustaniSubmit";
            this.odustaniSubmit.Size = new System.Drawing.Size(75, 29);
            this.odustaniSubmit.TabIndex = 14;
            this.odustaniSubmit.Text = "Odustani";
            this.odustaniSubmit.UseVisualStyleBackColor = true;
            this.odustaniSubmit.Click += new System.EventHandler(this.odustaniSubmit_Click);
            // 
            // spasiSubmit
            // 
            this.spasiSubmit.Location = new System.Drawing.Point(311, 85);
            this.spasiSubmit.Name = "spasiSubmit";
            this.spasiSubmit.Size = new System.Drawing.Size(75, 29);
            this.spasiSubmit.TabIndex = 13;
            this.spasiSubmit.Text = "Spasi";
            this.spasiSubmit.UseVisualStyleBackColor = true;
            this.spasiSubmit.Click += new System.EventHandler(this.spasiSubmit_Click);
            // 
            // tipAktivnostiText
            // 
            this.tipAktivnostiText.Location = new System.Drawing.Point(221, 37);
            this.tipAktivnostiText.Name = "tipAktivnostiText";
            this.tipAktivnostiText.Size = new System.Drawing.Size(165, 22);
            this.tipAktivnostiText.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Unesite novi tip aktivnosti:";
            // 
            // UnosTipaAktivnostiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 183);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odustaniSubmit);
            this.Controls.Add(this.spasiSubmit);
            this.Controls.Add(this.tipAktivnostiText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UnosTipaAktivnostiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos tipa aktivnosti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button odustaniSubmit;
        private System.Windows.Forms.Button spasiSubmit;
        private System.Windows.Forms.TextBox tipAktivnostiText;
        private System.Windows.Forms.Label label1;
    }
}