namespace Agency.Admin
{
    partial class UnosStrukeForm
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
            this.strukaText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // odustaniSubmit
            // 
            this.odustaniSubmit.Location = new System.Drawing.Point(197, 92);
            this.odustaniSubmit.Name = "odustaniSubmit";
            this.odustaniSubmit.Size = new System.Drawing.Size(75, 29);
            this.odustaniSubmit.TabIndex = 10;
            this.odustaniSubmit.Text = "Odustani";
            this.odustaniSubmit.UseVisualStyleBackColor = true;
            this.odustaniSubmit.Click += new System.EventHandler(this.odustaniSubmit_Click);
            // 
            // spasiSubmit
            // 
            this.spasiSubmit.Location = new System.Drawing.Point(296, 92);
            this.spasiSubmit.Name = "spasiSubmit";
            this.spasiSubmit.Size = new System.Drawing.Size(75, 29);
            this.spasiSubmit.TabIndex = 9;
            this.spasiSubmit.Text = "Spasi";
            this.spasiSubmit.UseVisualStyleBackColor = true;
            this.spasiSubmit.Click += new System.EventHandler(this.spasiSubmit_Click);
            // 
            // strukaText
            // 
            this.strukaText.Location = new System.Drawing.Point(197, 44);
            this.strukaText.Name = "strukaText";
            this.strukaText.Size = new System.Drawing.Size(174, 22);
            this.strukaText.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Unesite novu struku:";
            // 
            // UnosStrukeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 183);
            this.Controls.Add(this.odustaniSubmit);
            this.Controls.Add(this.spasiSubmit);
            this.Controls.Add(this.strukaText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UnosStrukeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos struke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button odustaniSubmit;
        private System.Windows.Forms.Button spasiSubmit;
        private System.Windows.Forms.TextBox strukaText;
        private System.Windows.Forms.Label label1;
    }
}