namespace Do_nauki_kolo
{
    partial class MymessageBox_Frm
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
            this.wiadomość_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wiadomość_lbl
            // 
            this.wiadomość_lbl.AutoSize = true;
            this.wiadomość_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wiadomość_lbl.Location = new System.Drawing.Point(1, 144);
            this.wiadomość_lbl.Name = "wiadomość_lbl";
            this.wiadomość_lbl.Size = new System.Drawing.Size(722, 108);
            this.wiadomość_lbl.TabIndex = 0;
            this.wiadomość_lbl.Text = "wracaj do nauki";
            // 
            // MymessageBox_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 411);
            this.Controls.Add(this.wiadomość_lbl);
            this.Name = "MymessageBox_Frm";
            this.Text = "Koniec";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.instrukcja_Frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wiadomość_lbl;
    }
}