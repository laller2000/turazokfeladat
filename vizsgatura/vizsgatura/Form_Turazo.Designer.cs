
namespace vizsgatura
{
    partial class Form_Turazo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1_Turazok = new System.Windows.Forms.DataGridView();
            this.button1_Felvetel = new System.Windows.Forms.Button();
            this.button2_Adatokfrissites = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Turazok)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Természetjárók nyilvántartása";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "A nyilvántartásban szereplő turázók adatai:\r\n";
            // 
            // dataGridView1_Turazok
            // 
            this.dataGridView1_Turazok.AllowUserToAddRows = false;
            this.dataGridView1_Turazok.AllowUserToDeleteRows = false;
            this.dataGridView1_Turazok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Turazok.Location = new System.Drawing.Point(37, 143);
            this.dataGridView1_Turazok.Name = "dataGridView1_Turazok";
            this.dataGridView1_Turazok.ReadOnly = true;
            this.dataGridView1_Turazok.RowHeadersWidth = 51;
            this.dataGridView1_Turazok.RowTemplate.Height = 24;
            this.dataGridView1_Turazok.Size = new System.Drawing.Size(724, 202);
            this.dataGridView1_Turazok.TabIndex = 2;
            this.dataGridView1_Turazok.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_Turazok_CellContentClick);
            // 
            // button1_Felvetel
            // 
            this.button1_Felvetel.Location = new System.Drawing.Point(86, 391);
            this.button1_Felvetel.Name = "button1_Felvetel";
            this.button1_Felvetel.Size = new System.Drawing.Size(206, 23);
            this.button1_Felvetel.TabIndex = 3;
            this.button1_Felvetel.Text = "Új személy felvétele";
            this.button1_Felvetel.UseVisualStyleBackColor = true;
            this.button1_Felvetel.Click += new System.EventHandler(this.button1_Felvetel_Click);
            // 
            // button2_Adatokfrissites
            // 
            this.button2_Adatokfrissites.Location = new System.Drawing.Point(489, 391);
            this.button2_Adatokfrissites.Name = "button2_Adatokfrissites";
            this.button2_Adatokfrissites.Size = new System.Drawing.Size(223, 23);
            this.button2_Adatokfrissites.TabIndex = 4;
            this.button2_Adatokfrissites.Text = "Adatok frissítése";
            this.button2_Adatokfrissites.UseVisualStyleBackColor = true;
            this.button2_Adatokfrissites.Click += new System.EventHandler(this.button2_Adatokfrissites_Click);
            // 
            // Form_Turazo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2_Adatokfrissites);
            this.Controls.Add(this.button1_Felvetel);
            this.Controls.Add(this.dataGridView1_Turazok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Turazo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Turazo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Turazok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1_Turazok;
        private System.Windows.Forms.Button button1_Felvetel;
        private System.Windows.Forms.Button button2_Adatokfrissites;
    }
}

