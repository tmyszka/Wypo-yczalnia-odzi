namespace $safeprojectname$
{
    partial class InterfacePracownika
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
            this.listaLodzi = new System.Windows.Forms.ComboBox();
            this.informacjeOLodzi = new System.Windows.Forms.DataGridView();
           
            this.listaKlientow = new System.Windows.Forms.ComboBox();
          
            this.informacjeOKliencie = new System.Windows.Forms.DataGridView();
            this.rezerwacje = new System.Windows.Forms.DataGridView();
            this.dodajRezerwacje = new System.Windows.Forms.Button();
            this.zmianaRezerwacji = new System.Windows.Forms.Button();
            this.usunRezerwacje = new System.Windows.Forms.Button();
            this.zakonczRezerwacje = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.informacjeOLodzi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informacjeOKliencie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezerwacje)).BeginInit();
            this.SuspendLayout();
            // 
            // listaLodzi
            // 
            this.listaLodzi.FormattingEnabled = true;
            this.listaLodzi.Location = new System.Drawing.Point(13, 13);
            this.listaLodzi.Name = "listaLodzi";
            this.listaLodzi.Size = new System.Drawing.Size(148, 21);
            this.listaLodzi.TabIndex = 0;
            this.listaLodzi.SelectedIndexChanged += new System.EventHandler(this.listaLodzi_SelectedIndexChanged);
            // 
            // informacjeOLodzi
            // 
            this.informacjeOLodzi.AllowUserToAddRows = false;
            this.informacjeOLodzi.AllowUserToDeleteRows = false;
            this.informacjeOLodzi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.informacjeOLodzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.informacjeOLodzi.Location = new System.Drawing.Point(168, 13);
            this.informacjeOLodzi.MultiSelect = false;
            this.informacjeOLodzi.Name = "informacjeOLodzi";
            this.informacjeOLodzi.ReadOnly = true;
            this.informacjeOLodzi.Size = new System.Drawing.Size(721, 65);
            this.informacjeOLodzi.TabIndex = 1;
         
            // 
            // listaKlientow
            // 
            this.listaKlientow.FormattingEnabled = true;
            this.listaKlientow.Location = new System.Drawing.Point(12, 96);
            this.listaKlientow.Name = "listaKlientow";
            this.listaKlientow.Size = new System.Drawing.Size(149, 21);
            this.listaKlientow.TabIndex = 6;
         
            // 
            // informacjeOKliencie
            // 
            this.informacjeOKliencie.AllowUserToAddRows = false;
            this.informacjeOKliencie.AllowUserToDeleteRows = false;
            this.informacjeOKliencie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.informacjeOKliencie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.informacjeOKliencie.Location = new System.Drawing.Point(168, 96);
            this.informacjeOKliencie.MultiSelect = false;
            this.informacjeOKliencie.Name = "informacjeOKliencie";
            this.informacjeOKliencie.ReadOnly = true;
            this.informacjeOKliencie.Size = new System.Drawing.Size(721, 65);
            this.informacjeOKliencie.TabIndex = 7;
            // 
            // rezerwacje
            // 
            this.rezerwacje.AllowUserToAddRows = false;
            this.rezerwacje.AllowUserToDeleteRows = false;
            this.rezerwacje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rezerwacje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rezerwacje.Location = new System.Drawing.Point(12, 173);
            this.rezerwacje.Name = "rezerwacje";
            this.rezerwacje.ReadOnly = true;
            this.rezerwacje.Size = new System.Drawing.Size(877, 198);
            this.rezerwacje.TabIndex = 8;
            // 
            // dodajRezerwacje
            // 
            this.dodajRezerwacje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dodajRezerwacje.Location = new System.Drawing.Point(630, 429);
            this.dodajRezerwacje.Name = "dodajRezerwacje";
            this.dodajRezerwacje.Size = new System.Drawing.Size(123, 35);
            this.dodajRezerwacje.TabIndex = 9;
            this.dodajRezerwacje.Text = "Dodaj Rezerwację";
            this.dodajRezerwacje.UseVisualStyleBackColor = true;
            this.dodajRezerwacje.Click += new System.EventHandler(this.dodajRezerwacje_Click);
            // 
            // zmianaRezerwacji
            // 
            this.zmianaRezerwacji.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.zmianaRezerwacji.Location = new System.Drawing.Point(759, 429);
            this.zmianaRezerwacji.Name = "zmianaRezerwacji";
            this.zmianaRezerwacji.Size = new System.Drawing.Size(123, 35);
            this.zmianaRezerwacji.TabIndex = 10;
            this.zmianaRezerwacji.Text = "Zmiana Rezerwacji";
            this.zmianaRezerwacji.UseVisualStyleBackColor = true;
            this.zmianaRezerwacji.Click += new System.EventHandler(this.zmianaRezerwacji_Click);
            // 
            // usunRezerwacje
            // 
            this.usunRezerwacje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.usunRezerwacje.Location = new System.Drawing.Point(759, 388);
            this.usunRezerwacje.Name = "usunRezerwacje";
            this.usunRezerwacje.Size = new System.Drawing.Size(123, 35);
            this.usunRezerwacje.TabIndex = 11;
            this.usunRezerwacje.Text = "Usuń Rezerwację";
            this.usunRezerwacje.UseVisualStyleBackColor = true;
            this.usunRezerwacje.Click += new System.EventHandler(this.usunRezerwacje_Click);
            // 
            // zakonczRezerwacje
            // 
            this.zakonczRezerwacje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.zakonczRezerwacje.Location = new System.Drawing.Point(630, 388);
            this.zakonczRezerwacje.Name = "zakonczRezerwacje";
            this.zakonczRezerwacje.Size = new System.Drawing.Size(123, 35);
            this.zakonczRezerwacje.TabIndex = 13;
            this.zakonczRezerwacje.Text = "Zakończ Rezerwację";
            this.zakonczRezerwacje.UseVisualStyleBackColor = true;
            this.zakonczRezerwacje.Click += new System.EventHandler(this.zakonczRezerwacje_Click);
        
            // 
            // InterfacePracownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 477);
            this.ControlBox = false;

            this.Controls.Add(this.zakonczRezerwacje);
            this.Controls.Add(this.rezerwacje);

            this.Controls.Add(this.usunRezerwacje);
            this.Controls.Add(this.zmianaRezerwacji);
            this.Controls.Add(this.dodajRezerwacje);
            this.Controls.Add(this.informacjeOKliencie);
            this.Controls.Add(this.listaKlientow);
            this.Controls.Add(this.informacjeOLodzi);
            this.Controls.Add(this.listaLodzi);
            this.MinimizeBox = false;
            this.Name = "InterfacePracownika";
            this.ShowIcon = false;
            this.Text = "InterfacePracownika";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InterfacePracownika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.informacjeOLodzi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informacjeOKliencie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezerwacje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox listaLodzi;
        private System.Windows.Forms.DataGridView informacjeOLodzi;
        private System.Windows.Forms.Button dodajPracownika;
        private System.Windows.Forms.Button dodajKlienta;
        private System.Windows.Forms.Button usunPracownika;
        private System.Windows.Forms.Button usunKlienta;
        private System.Windows.Forms.ComboBox listaKlientow;
        private System.Windows.Forms.DataGridView informacjeOKliencie;
        private System.Windows.Forms.DataGridView rezerwacje;
        private System.Windows.Forms.Button dodajRezerwacje;
        private System.Windows.Forms.Button zmianaRezerwacji;
        private System.Windows.Forms.Button usunRezerwacje;
        private System.Windows.Forms.Button listaPracownikow;
        private System.Windows.Forms.Button zakonczRezerwacje;
        private System.Windows.Forms.Button edytujKlienta;
        private System.Windows.Forms.Button edytujPracownika;
    }
}