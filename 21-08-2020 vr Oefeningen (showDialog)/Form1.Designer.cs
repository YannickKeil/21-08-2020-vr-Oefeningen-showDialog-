namespace _21_08_2020_vr_Oefeningen__showDialog_
{
    partial class Form1
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
            this.lbRekeningen = new System.Windows.Forms.ListBox();
            this.btnNieuwRekening = new System.Windows.Forms.Button();
            this.btnOverschrijven = new System.Windows.Forms.Button();
            this.lRekeningNaam = new System.Windows.Forms.Label();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.lRekeningSaldo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbRekeningen
            // 
            this.lbRekeningen.FormattingEnabled = true;
            this.lbRekeningen.ItemHeight = 20;
            this.lbRekeningen.Location = new System.Drawing.Point(29, 46);
            this.lbRekeningen.Name = "lbRekeningen";
            this.lbRekeningen.Size = new System.Drawing.Size(203, 264);
            this.lbRekeningen.TabIndex = 0;
            this.lbRekeningen.SelectedIndexChanged += new System.EventHandler(this.lbRekeningen_SelectedIndexChanged);
            // 
            // btnNieuwRekening
            // 
            this.btnNieuwRekening.Location = new System.Drawing.Point(238, 46);
            this.btnNieuwRekening.Name = "btnNieuwRekening";
            this.btnNieuwRekening.Size = new System.Drawing.Size(147, 57);
            this.btnNieuwRekening.TabIndex = 1;
            this.btnNieuwRekening.Text = "Nieuwe rekening openen";
            this.btnNieuwRekening.UseVisualStyleBackColor = true;
            this.btnNieuwRekening.Click += new System.EventHandler(this.btnNieuwRekening_Click);
            // 
            // btnOverschrijven
            // 
            this.btnOverschrijven.Location = new System.Drawing.Point(238, 153);
            this.btnOverschrijven.Name = "btnOverschrijven";
            this.btnOverschrijven.Size = new System.Drawing.Size(147, 57);
            this.btnOverschrijven.TabIndex = 2;
            this.btnOverschrijven.Text = "Overschrijven";
            this.btnOverschrijven.UseVisualStyleBackColor = true;
            this.btnOverschrijven.Click += new System.EventHandler(this.btnOverschrijven_Click);
            // 
            // lRekeningNaam
            // 
            this.lRekeningNaam.AutoSize = true;
            this.lRekeningNaam.Location = new System.Drawing.Point(25, 355);
            this.lRekeningNaam.Name = "lRekeningNaam";
            this.lRekeningNaam.Size = new System.Drawing.Size(89, 20);
            this.lRekeningNaam.TabIndex = 3;
            this.lRekeningNaam.Text = "naam kaart";
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(238, 253);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(147, 57);
            this.btnVerwijderen.TabIndex = 4;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // lRekeningSaldo
            // 
            this.lRekeningSaldo.AutoSize = true;
            this.lRekeningSaldo.Location = new System.Drawing.Point(234, 355);
            this.lRekeningSaldo.Name = "lRekeningSaldo";
            this.lRekeningSaldo.Size = new System.Drawing.Size(47, 20);
            this.lRekeningSaldo.TabIndex = 5;
            this.lRekeningSaldo.Text = "saldo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 520);
            this.Controls.Add(this.lRekeningSaldo);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.lRekeningNaam);
            this.Controls.Add(this.btnOverschrijven);
            this.Controls.Add(this.btnNieuwRekening);
            this.Controls.Add(this.lbRekeningen);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbRekeningen;
        private System.Windows.Forms.Button btnNieuwRekening;
        private System.Windows.Forms.Button btnOverschrijven;
        private System.Windows.Forms.Label lRekeningNaam;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Label lRekeningSaldo;
    }
}

