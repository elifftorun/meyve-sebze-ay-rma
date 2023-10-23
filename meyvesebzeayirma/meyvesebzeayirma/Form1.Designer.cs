namespace meyvesebzeayirma
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
            this.lstTumu = new System.Windows.Forms.ListBox();
            this.lstMeyve = new System.Windows.Forms.ListBox();
            this.lstSebze = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAyır = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTumu
            // 
            this.lstTumu.FormattingEnabled = true;
            this.lstTumu.Items.AddRange(new object[] {
            "Domates",
            "Patates",
            "Biber",
            "Patlıcan",
            "Çilek",
            "Muz",
            "Soğan",
            "Mandalina",
            "Portakal",
            "Lahana",
            "Brokoli",
            "Havuç",
            "Armut",
            "Ayva",
            "Elma"});
            this.lstTumu.Location = new System.Drawing.Point(23, 45);
            this.lstTumu.Name = "lstTumu";
            this.lstTumu.Size = new System.Drawing.Size(177, 212);
            this.lstTumu.TabIndex = 0;
            // 
            // lstMeyve
            // 
            this.lstMeyve.FormattingEnabled = true;
            this.lstMeyve.Location = new System.Drawing.Point(231, 43);
            this.lstMeyve.Name = "lstMeyve";
            this.lstMeyve.Size = new System.Drawing.Size(171, 212);
            this.lstMeyve.TabIndex = 1;
            // 
            // lstSebze
            // 
            this.lstSebze.FormattingEnabled = true;
            this.lstSebze.Location = new System.Drawing.Point(442, 42);
            this.lstSebze.Name = "lstSebze";
            this.lstSebze.Size = new System.Drawing.Size(181, 212);
            this.lstSebze.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(83, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "tümü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(285, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "meyve";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(502, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "sebze";
            // 
            // btnAyır
            // 
            this.btnAyır.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyır.Location = new System.Drawing.Point(23, 269);
            this.btnAyır.Name = "btnAyır";
            this.btnAyır.Size = new System.Drawing.Size(596, 49);
            this.btnAyır.TabIndex = 6;
            this.btnAyır.Text = "Ayır";
            this.btnAyır.UseVisualStyleBackColor = true;
            this.btnAyır.Click += new System.EventHandler(this.btnAyır_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 330);
            this.Controls.Add(this.btnAyır);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSebze);
            this.Controls.Add(this.lstMeyve);
            this.Controls.Add(this.lstTumu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTumu;
        private System.Windows.Forms.ListBox lstMeyve;
        private System.Windows.Forms.ListBox lstSebze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAyır;
    }
}

