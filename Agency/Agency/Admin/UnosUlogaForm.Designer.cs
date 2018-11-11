namespace Agency.Admin
{
    partial class UnosUlogaForm
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
            this.ulogaText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // odustaniSubmit
            // 
            this.odustaniSubmit.Location = new System.Drawing.Point(198, 91);
            this.odustaniSubmit.Name = "odustaniSubmit";
            this.odustaniSubmit.Size = new System.Drawing.Size(75, 29);
            this.odustaniSubmit.TabIndex = 10;
            this.odustaniSubmit.Text = "Odustani";
            this.odustaniSubmit.UseVisualStyleBackColor = true;
            this.odustaniSubmit.Click += new System.EventHandler(this.odustaniSubmit_Click);
            // 
            // spasiSubmit
            // 
            this.spasiSubmit.Location = new System.Drawing.Point(297, 91);
            this.spasiSubmit.Name = "spasiSubmit";
            this.spasiSubmit.Size = new System.Drawing.Size(75, 29);
            this.spasiSubmit.TabIndex = 9;
            this.spasiSubmit.Text = "Spasi";
            this.spasiSubmit.UseVisualStyleBackColor = true;
            this.spasiSubmit.Click += new System.EventHandler(this.spasiSubmit_Click);
            // 
            // ulogaText
            // 
            this.ulogaText.Location = new System.Drawing.Point(198, 45);
            this.ulogaText.Name = "ulogaText";
            this.ulogaText.Size = new System.Drawing.Size(174, 22);
            this.ulogaText.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Unesite novu ulogu:";
            // 
            // UnosUlogaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 183);
            this.Controls.Add(this.odustaniSubmit);
            this.Controls.Add(this.spasiSubmit);
            this.Controls.Add(this.ulogaText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UnosUlogaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos uloga ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button odustaniSubmit;
        private System.Windows.Forms.Button spasiSubmit;
        private System.Windows.Forms.TextBox ulogaText;
        private System.Windows.Forms.Label label1;
    }
}