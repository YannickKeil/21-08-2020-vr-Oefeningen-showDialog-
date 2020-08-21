namespace _21_08_2020_vr_Oefeningen__showDialog_
{
    partial class Overschrijving
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
            this.tbKeuzeRekening = new System.Windows.Forms.TextBox();
            this.nudKeuzeBedrag = new System.Windows.Forms.NumericUpDown();
            this.btnOverschrijven = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbKeuzeRekening = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudKeuzeBedrag)).BeginInit();
            this.SuspendLayout();
            // 
            // tbKeuzeRekening
            // 
            this.tbKeuzeRekening.Location = new System.Drawing.Point(34, 94);
            this.tbKeuzeRekening.Name = "tbKeuzeRekening";
            this.tbKeuzeRekening.Size = new System.Drawing.Size(312, 26);
            this.tbKeuzeRekening.TabIndex = 0;
            this.tbKeuzeRekening.Visible = false;
            // 
            // nudKeuzeBedrag
            // 
            this.nudKeuzeBedrag.DecimalPlaces = 1;
            this.nudKeuzeBedrag.Location = new System.Drawing.Point(392, 49);
            this.nudKeuzeBedrag.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.nudKeuzeBedrag.Name = "nudKeuzeBedrag";
            this.nudKeuzeBedrag.Size = new System.Drawing.Size(120, 26);
            this.nudKeuzeBedrag.TabIndex = 1;
            this.nudKeuzeBedrag.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // btnOverschrijven
            // 
            this.btnOverschrijven.Location = new System.Drawing.Point(34, 126);
            this.btnOverschrijven.Name = "btnOverschrijven";
            this.btnOverschrijven.Size = new System.Drawing.Size(120, 32);
            this.btnOverschrijven.TabIndex = 2;
            this.btnOverschrijven.Text = "Schrijf Over";
            this.btnOverschrijven.UseVisualStyleBackColor = true;
            this.btnOverschrijven.Click += new System.EventHandler(this.btnOverschrijven_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(343, 126);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 32);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "rekeningnummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "bedrag";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // mtbKeuzeRekening
            // 
            this.mtbKeuzeRekening.Location = new System.Drawing.Point(34, 49);
            this.mtbKeuzeRekening.Mask = "BE00 0000 0000 0000";
            this.mtbKeuzeRekening.Name = "mtbKeuzeRekening";
            this.mtbKeuzeRekening.Size = new System.Drawing.Size(312, 26);
            this.mtbKeuzeRekening.TabIndex = 6;
            // 
            // Overschrijving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 264);
            this.Controls.Add(this.mtbKeuzeRekening);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOverschrijven);
            this.Controls.Add(this.nudKeuzeBedrag);
            this.Controls.Add(this.tbKeuzeRekening);
            this.Name = "Overschrijving";
            this.Text = "Overschrijving";
            this.Load += new System.EventHandler(this.Overschrijving_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudKeuzeBedrag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKeuzeRekening;
        private System.Windows.Forms.NumericUpDown nudKeuzeBedrag;
        private System.Windows.Forms.Button btnOverschrijven;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbKeuzeRekening;
    }
}