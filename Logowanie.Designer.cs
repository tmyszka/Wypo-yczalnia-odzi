namespace $safeprojectname$
{
    partial class Logowanie
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
            this.komunikatZalogujJako = new System.Windows.Forms.Label();
            this.zalogujJako = new System.Windows.Forms.ComboBox();
            this.daneLogowaniaImie = new System.Windows.Forms.TextBox();
            this.daneLogowaniaNazwisko = new System.Windows.Forms.TextBox();
            this.daneLogowaniaHaslo = new System.Windows.Forms.TextBox();
            this.zaloguj = new System.Windows.Forms.Button();
            this.zakoncz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // komunikatZalogujJako
            // 
            this.komunikatZalogujJako.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.komunikatZalogujJako.AutoSize = true;
            this.komunikatZalogujJako.Location = new System.Drawing.Point(13, 13);
            this.komunikatZalogujJako.Name = "komunikatZalogujJako";
            this.komunikatZalogujJako.Size = new System.Drawing.Size(68, 13);
            this.komunikatZalogujJako.TabIndex = 0;
            this.komunikatZalogujJako.Text = "Zaloguj jako:";
            // 
            // zalogujJako
            // 
            this.zalogujJako.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zalogujJako.FormattingEnabled = true;
            this.zalogujJako.Items.AddRange(new object[] {
            "Klient",
            "Pracownik"});
            this.zalogujJako.Location = new System.Drawing.Point(88, 13);
            this.zalogujJako.Name = "zalogujJako";
            this.zalogujJako.Size = new System.Drawing.Size(132, 21);
            this.zalogujJako.TabIndex = 1;
            // 
            // daneLogowaniaImie
            // 
            this.daneLogowaniaImie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.daneLogowaniaImie.Location = new System.Drawing.Point(12, 40);
            this.daneLogowaniaImie.Name = "daneLogowaniaImie";
            this.daneLogowaniaImie.Size = new System.Drawing.Size(78, 20);
            this.daneLogowaniaImie.TabIndex = 2;
            this.daneLogowaniaImie.Text = "Imię";
            this.daneLogowaniaImie.Enter += new System.EventHandler(this.daneLogowaniaImie_Enter);
            this.daneLogowaniaImie.Leave += new System.EventHandler(this.daneLogowaniaImie_Leave);
            // 
            // daneLogowaniaNazwisko
            // 
            this.daneLogowaniaNazwisko.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.daneLogowaniaNazwisko.Location = new System.Drawing.Point(97, 40);
            this.daneLogowaniaNazwisko.Name = "daneLogowaniaNazwisko";
            this.daneLogowaniaNazwisko.Size = new System.Drawing.Size(123, 20);
            this.daneLogowaniaNazwisko.TabIndex = 3;
            this.daneLogowaniaNazwisko.Text = "Nazwisko";
            this.daneLogowaniaNazwisko.Enter += new System.EventHandler(this.daneLogowaniaNazwisko_Enter);
            this.daneLogowaniaNazwisko.Leave += new System.EventHandler(this.daneLogowaniaNazwisko_Leave);
            // 
            // daneLogowaniaHaslo
            // 
            this.daneLogowaniaHaslo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.daneLogowaniaHaslo.Location = new System.Drawing.Point(12, 66);
            this.daneLogowaniaHaslo.Name = "daneLogowaniaHaslo";
            this.daneLogowaniaHaslo.PasswordChar = '*';
            this.daneLogowaniaHaslo.Size = new System.Drawing.Size(207, 20);
            this.daneLogowaniaHaslo.TabIndex = 4;
            this.daneLogowaniaHaslo.Text = "Hasło";
            // 
            // zaloguj
            // 
            this.zaloguj.Location = new System.Drawing.Point(12, 93);
            this.zaloguj.Name = "zaloguj";
            this.zaloguj.Size = new System.Drawing.Size(129, 32);
            this.zaloguj.TabIndex = 5;
            this.zaloguj.Text = "Zaloguj";
            this.zaloguj.UseVisualStyleBackColor = true;
            this.zaloguj.Click += new System.EventHandler(this.zaloguj_Click);
            // 
            // zakoncz
            // 
            this.zakoncz.Location = new System.Drawing.Point(147, 93);
            this.zakoncz.Name = "zakoncz";
            this.zakoncz.Size = new System.Drawing.Size(73, 32);
            this.zakoncz.TabIndex = 6;
            this.zakoncz.Text = "Zakończ";
            this.zakoncz.UseVisualStyleBackColor = true;
            this.zakoncz.Click += new System.EventHandler(this.zakoncz_Click);
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 137);
            this.ControlBox = false;
            this.Controls.Add(this.zakoncz);
            this.Controls.Add(this.zaloguj);
            this.Controls.Add(this.daneLogowaniaHaslo);
            this.Controls.Add(this.daneLogowaniaNazwisko);
            this.Controls.Add(this.daneLogowaniaImie);
            this.Controls.Add(this.zalogujJako);
            this.Controls.Add(this.komunikatZalogujJako);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Logowanie";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label komunikatZalogujJako;
        private System.Windows.Forms.ComboBox zalogujJako;
        private System.Windows.Forms.TextBox daneLogowaniaImie;
        private System.Windows.Forms.TextBox daneLogowaniaNazwisko;
        private System.Windows.Forms.TextBox daneLogowaniaHaslo;
        private System.Windows.Forms.Button zaloguj;
        private System.Windows.Forms.Button zakoncz;
    }
}