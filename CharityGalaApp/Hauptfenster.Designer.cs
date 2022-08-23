namespace CharityGalaApp
{
    partial class Hauptfenster
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbSpende = new System.Windows.Forms.TextBox();
            this.lblSpende = new System.Windows.Forms.Label();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.pbFortschrittsbalken = new System.Windows.Forms.ProgressBar();
            this.lbSpender = new System.Windows.Forms.ListBox();
            this.lblZiel = new System.Windows.Forms.Label();
            this.timerAktualisieren = new System.Windows.Forms.Timer(this.components);
            this.lblGesamtSumme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(31, 59);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(31, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(97, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name des Anrufers";
            // 
            // tbSpende
            // 
            this.tbSpende.Location = new System.Drawing.Point(31, 142);
            this.tbSpende.Name = "tbSpende";
            this.tbSpende.Size = new System.Drawing.Size(100, 20);
            this.tbSpende.TabIndex = 2;
            // 
            // lblSpende
            // 
            this.lblSpende.AutoSize = true;
            this.lblSpende.Location = new System.Drawing.Point(31, 111);
            this.lblSpende.Name = "lblSpende";
            this.lblSpende.Size = new System.Drawing.Size(82, 13);
            this.lblSpende.TabIndex = 3;
            this.lblSpende.Text = "Spendenbeitrag";
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(34, 226);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(75, 23);
            this.btnSpeichern.TabIndex = 4;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // pbFortschrittsbalken
            // 
            this.pbFortschrittsbalken.Location = new System.Drawing.Point(34, 295);
            this.pbFortschrittsbalken.Maximum = 10000;
            this.pbFortschrittsbalken.Name = "pbFortschrittsbalken";
            this.pbFortschrittsbalken.Size = new System.Drawing.Size(346, 23);
            this.pbFortschrittsbalken.TabIndex = 5;
            // 
            // lbSpender
            // 
            this.lbSpender.FormattingEnabled = true;
            this.lbSpender.Location = new System.Drawing.Point(199, 59);
            this.lbSpender.Name = "lbSpender";
            this.lbSpender.Size = new System.Drawing.Size(116, 69);
            this.lbSpender.TabIndex = 6;
            // 
            // lblZiel
            // 
            this.lblZiel.AutoSize = true;
            this.lblZiel.Location = new System.Drawing.Point(408, 305);
            this.lblZiel.Name = "lblZiel";
            this.lblZiel.Size = new System.Drawing.Size(66, 13);
            this.lblZiel.TabIndex = 7;
            this.lblZiel.Text = "Ziel: 10000€";
            // 
            // timerAktualisieren
            // 
            this.timerAktualisieren.Enabled = true;
            this.timerAktualisieren.Interval = 10000;
            this.timerAktualisieren.Tick += new System.EventHandler(this.timerAktualisieren_Tick);
            // 
            // lblGesamtSumme
            // 
            this.lblGesamtSumme.AutoSize = true;
            this.lblGesamtSumme.Location = new System.Drawing.Point(34, 325);
            this.lblGesamtSumme.Name = "lblGesamtSumme";
            this.lblGesamtSumme.Size = new System.Drawing.Size(109, 13);
            this.lblGesamtSumme.TabIndex = 8;
            this.lblGesamtSumme.Text = "Gesamtsumme: 0,00€";
            // 
            // Hauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGesamtSumme);
            this.Controls.Add(this.lblZiel);
            this.Controls.Add(this.lbSpender);
            this.Controls.Add(this.pbFortschrittsbalken);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.lblSpende);
            this.Controls.Add(this.tbSpende);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbName);
            this.Name = "Hauptfenster";
            this.Text = "Charity Gala App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Hauptfenster_FormClosed);
            this.Load += new System.EventHandler(this.Hauptfenster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbSpende;
        private System.Windows.Forms.Label lblSpende;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.ProgressBar pbFortschrittsbalken;
        private System.Windows.Forms.ListBox lbSpender;
        private System.Windows.Forms.Label lblZiel;
        private System.Windows.Forms.Timer timerAktualisieren;
        private System.Windows.Forms.Label lblGesamtSumme;
    }
}

