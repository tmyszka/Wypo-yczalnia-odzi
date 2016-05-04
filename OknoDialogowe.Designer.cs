namespace $safeprojectname$
{
    partial class OknoDialogowe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ()
        {
            this.przyciskWyjscia = new System.Windows.Forms.Button();
            this.naglowek = new System.Windows.Forms.Label();
            this.tekstWpisywany = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // przyciskWyjscia
            // 
            this.przyciskWyjscia.Location = new System.Drawing.Point(145, 99);
            this.przyciskWyjscia.Name = "przyciskWyjscia";
            this.przyciskWyjscia.Size = new System.Drawing.Size(75, 23);
            this.przyciskWyjscia.TabIndex = 0;
            this.przyciskWyjscia.Text = "Ok";
            this.przyciskWyjscia.UseVisualStyleBackColor = true;
            this.przyciskWyjscia.Click += new System.EventHandler(this.przyciskWyjscia_Click);
            // 
            // naglowek
            // 
            this.naglowek.Location = new System.Drawing.Point(12, 9);
            this.naglowek.Name = "naglowek";
            this.naglowek.Size = new System.Drawing.Size(343, 61);
            this.naglowek.TabIndex = 1;
            this.naglowek.Text = "Tekst Okna";
            this.naglowek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tekstWpisywany
            // 
            this.tekstWpisywany.Location = new System.Drawing.Point(12, 73);
            this.tekstWpisywany.Name = "tekstWpisywany";
            this.tekstWpisywany.Size = new System.Drawing.Size(343, 20);
            this.tekstWpisywany.TabIndex = 2;
            // 
            // OknoDialogowe
            // 
            this.AcceptButton = this.przyciskWyjscia;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 133);
            this.Controls.Add(this.tekstWpisywany);
            this.Controls.Add(this.naglowek);
            this.Controls.Add(this.przyciskWyjscia);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(383, 171);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(383, 171);
            this.Name = "OknoDialogowe";
            this.Text = "OknoDialogowe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button przyciskWyjscia;
        private System.Windows.Forms.Label naglowek;
        private System.Windows.Forms.TextBox tekstWpisywany;
    }
}