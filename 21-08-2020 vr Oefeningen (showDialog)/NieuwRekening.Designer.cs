namespace _21_08_2020_vr_Oefeningen__showDialog_
{
    partial class NieuwRekening
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
            this.cbKeuzeRekening = new System.Windows.Forms.ComboBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbKeuzeRekening
            // 
            this.cbKeuzeRekening.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbKeuzeRekening.FormattingEnabled = true;
            this.cbKeuzeRekening.Items.AddRange(new object[] {
            "Debitrekening",
            "Creditrekening",
            "Spaarrekening"});
            this.cbKeuzeRekening.Location = new System.Drawing.Point(120, 51);
            this.cbKeuzeRekening.Name = "cbKeuzeRekening";
            this.cbKeuzeRekening.Size = new System.Drawing.Size(201, 28);
            this.cbKeuzeRekening.TabIndex = 0;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(120, 124);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 39);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "ok";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(246, 124);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 39);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NieuwRekening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 250);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.cbKeuzeRekening);
            this.Name = "NieuwRekening";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NieuwRekening";
            this.Load += new System.EventHandler(this.NieuwRekening_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKeuzeRekening;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
    }
}