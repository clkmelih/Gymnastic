namespace WindowsFormsApp9
{
    partial class ProgramFormu
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
            this.MiniklerGrubu = new System.Windows.Forms.ListBox();
            this.lstCocuklar = new System.Windows.Forms.ListBox();
            this.lstGenclik = new System.Windows.Forms.ListBox();
            this.lstYetişkinler = new System.Windows.Forms.ListBox();
            this.lstGencler = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MiniklerGrubu
            // 
            this.MiniklerGrubu.FormattingEnabled = true;
            this.MiniklerGrubu.Location = new System.Drawing.Point(33, 26);
            this.MiniklerGrubu.Name = "MiniklerGrubu";
            this.MiniklerGrubu.Size = new System.Drawing.Size(389, 225);
            this.MiniklerGrubu.TabIndex = 0;
            // 
            // lstCocuklar
            // 
            this.lstCocuklar.FormattingEnabled = true;
            this.lstCocuklar.Location = new System.Drawing.Point(454, 26);
            this.lstCocuklar.Name = "lstCocuklar";
            this.lstCocuklar.Size = new System.Drawing.Size(389, 225);
            this.lstCocuklar.TabIndex = 1;
            this.lstCocuklar.SelectedIndexChanged += new System.EventHandler(this.lstCocuklar_SelectedIndexChanged);
            // 
            // lstGenclik
            // 
            this.lstGenclik.FormattingEnabled = true;
            this.lstGenclik.Location = new System.Drawing.Point(33, 275);
            this.lstGenclik.Name = "lstGenclik";
            this.lstGenclik.Size = new System.Drawing.Size(389, 225);
            this.lstGenclik.TabIndex = 2;
            // 
            // lstYetişkinler
            // 
            this.lstYetişkinler.FormattingEnabled = true;
            this.lstYetişkinler.Location = new System.Drawing.Point(873, 275);
            this.lstYetişkinler.Name = "lstYetişkinler";
            this.lstYetişkinler.Size = new System.Drawing.Size(389, 225);
            this.lstYetişkinler.TabIndex = 3;
            // 
            // lstGencler
            // 
            this.lstGencler.FormattingEnabled = true;
            this.lstGencler.Location = new System.Drawing.Point(873, 26);
            this.lstGencler.Name = "lstGencler";
            this.lstGencler.Size = new System.Drawing.Size(389, 225);
            this.lstGencler.TabIndex = 4;
            this.lstGencler.SelectedIndexChanged += new System.EventHandler(this.lstGencler_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(454, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(389, 225);
            this.dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(30, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Minikler Grubu ( 3-6)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(451, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Çocuklar Grubu (7-10)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(870, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gençler Grubu (11-14)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(30, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gençlik Grubu (15-18)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(870, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Yetişkinler Grubu (18+)";
            // 
            // ProgramFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 537);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lstGencler);
            this.Controls.Add(this.lstYetişkinler);
            this.Controls.Add(this.lstGenclik);
            this.Controls.Add(this.lstCocuklar);
            this.Controls.Add(this.MiniklerGrubu);
            this.Name = "ProgramFormu";
            this.Text = "Program";
            this.Load += new System.EventHandler(this.ProgramFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MiniklerGrubu;
        private System.Windows.Forms.ListBox lstCocuklar;
        private System.Windows.Forms.ListBox lstGenclik;
        private System.Windows.Forms.ListBox lstYetişkinler;
        private System.Windows.Forms.ListBox lstGencler;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}