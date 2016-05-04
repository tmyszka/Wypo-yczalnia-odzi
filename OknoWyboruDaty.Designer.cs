namespace $safeprojectname$
{
    partial class OknoWyboruDaty
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
            this.kalendarz = new System.Windows.Forms.MonthCalendar();
            this.zatwierdz = new System.Windows.Forms.Button();
            this.anuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kalendarz
            // 
            this.kalendarz.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.kalendarz.Location = new System.Drawing.Point(13, 13);
            this.kalendarz.MaxSelectionCount = 1;
            this.kalendarz.MinDate = new System.DateTime(2015, 10, 24, 0, 0, 0, 0);
            this.kalendarz.Name = "kalendarz";
            this.kalendarz.TabIndex = 0;
            // 
            // zatwierdz
            // 
            this.zatwierdz.Location = new System.Drawing.Point(12, 227);
            this.zatwierdz.Name = "zatwierdz";
            this.zatwierdz.Size = new System.Drawing.Size(75, 23);
            this.zatwierdz.TabIndex = 1;
            this.zatwierdz.Text = "Zatwierdź";
            this.zatwierdz.UseVisualStyleBackColor = true;
            this.zatwierdz.Click += new System.EventHandler(this.zatwierdz_Click);
            // 
            // anuluj
            // 
            this.anuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.anuluj.Location = new System.Drawing.Point(147, 227);
            this.anuluj.Name = "anuluj";
            this.anuluj.Size = new System.Drawing.Size(75, 23);
            this.anuluj.TabIndex = 2;
            this.anuluj.Text = "Anuluj";
            this.anuluj.UseVisualStyleBackColor = true;
            this.anuluj.Click += new System.EventHandler(this.anuluj_Click);
            // 
            // OknoWyboruDaty
            // 
            this.AcceptButton = this.zatwierdz;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.anuluj;
            this.ClientSize = new System.Drawing.Size(234, 262);
            this.ControlBox = false;
            this.Controls.Add(this.anuluj);
            this.Controls.Add(this.zatwierdz);
            this.Controls.Add(this.kalendarz);
            this.MaximumSize = new System.Drawing.Size(500, 600);
            this.MinimumSize = new System.Drawing.Size(250, 300);
            this.Name = "OknoWyboruDaty";
            this.Text = "Wybierz Datę";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar kalendarz;
        private System.Windows.Forms.Button zatwierdz;
        private System.Windows.Forms.Button anuluj;
    }
}