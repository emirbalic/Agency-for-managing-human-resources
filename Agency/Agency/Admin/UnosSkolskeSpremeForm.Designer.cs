namespace Agency.Admin
{
    partial class UnosSkolskeSpremeForm
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
            this.skolskaSpremaText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // odustaniSubmit
            // 
            this.odustaniSubmit.Location = new System.Drawing.Point(230, 86);
            this.odustaniSubmit.Name = "odustaniSubmit";
            this.odustaniSubmit.Size = new System.Drawing.Size(75, 29);
            this.odustaniSubmit.TabIndex = 11;
            this.odustaniSubmit.Text = "Odustani";
            this.odustaniSubmit.UseVisualStyleBackColor = true;
            this.odustaniSubmit.Click += new System.EventHandler(this.odustaniSubmit_Click);
            // 
            // spasiSubmit
            // 
            this.spasiSubmit.Location = new System.Drawing.Point(320, 86);
            this.spasiSubmit.Name = "spasiSubmit";
            this.spasiSubmit.Size = new System.Drawing.Size(75, 29);
            this.spasiSubmit.TabIndex = 10;
            this.spasiSubmit.Text = "Spasi";
            this.spasiSubmit.UseVisualStyleBackColor = true;
            this.spasiSubmit.Click += new System.EventHandler(this.spasiSubmit_Click);
            // 
            // skolskaSpremaText
            // 
            this.skolskaSpremaText.Location = new System.Drawing.Point(230, 38);
            this.skolskaSpremaText.Name = "skolskaSpremaText";
            this.skolskaSpremaText.Size = new System.Drawing.Size(165, 22);
            this.skolskaSpremaText.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Unesite novu stručnu spremu:";
            // 
            // UnosSkolskeSpremeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 183);
            this.Controls.Add(this.odustaniSubmit);
            this.Controls.Add(this.spasiSubmit);
            this.Controls.Add(this.skolskaSpremaText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UnosSkolskeSpremeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos stručne spreme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button odustaniSubmit;
        private System.Windows.Forms.Button spasiSubmit;
        private System.Windows.Forms.TextBox skolskaSpremaText;
        private System.Windows.Forms.Label label1;
    }
}