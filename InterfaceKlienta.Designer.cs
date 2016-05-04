namespace $safeprojectname$
{
    partial class InterfaceKlienta
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
            this.rezerwacje = new System.Windows.Forms.DataGridView();
            this.informacjeOKliencie = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.rezerwacje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informacjeOKliencie)).BeginInit();
            this.SuspendLayout();
            // 
            // rezerwacje
            // 
            this.rezerwacje.AllowUserToAddRows = false;
            this.rezerwacje.AllowUserToDeleteRows = false;
            this.rezerwacje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rezerwacje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rezerwacje.Location = new System.Drawing.Point(12, 83);
            this.rezerwacje.Name = "rezerwacje";
            this.rezerwacje.Size = new System.Drawing.Size(869, 184);
            this.rezerwacje.TabIndex = 10;
            // 
            // informacjeOKliencie
            // 
            this.informacjeOKliencie.AllowUserToAddRows = false;
            this.informacjeOKliencie.AllowUserToDeleteRows = false;
            this.informacjeOKliencie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.informacjeOKliencie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.informacjeOKliencie.Location = new System.Drawing.Point(12, 12);
            this.informacjeOKliencie.MultiSelect = false;
            this.informacjeOKliencie.Name = "informacjeOKliencie";
            this.informacjeOKliencie.ReadOnly = true;
            this.informacjeOKliencie.Size = new System.Drawing.Size(869, 65);
            this.informacjeOKliencie.TabIndex = 9;
            // 
            // InterfaceKlienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 400);
            this.ControlBox = false;
            this.Controls.Add(this.rezerwacje);
            this.Controls.Add(this.informacjeOKliencie);
            this.MinimizeBox = false;
            this.Name = "InterfaceKlienta";
            this.ShowIcon = false;
            this.Text = "InterfaceKlienta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InterfaceKlienta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rezerwacje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informacjeOKliencie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView rezerwacje;
        private System.Windows.Forms.DataGridView informacjeOKliencie;
    }
}