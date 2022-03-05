
namespace vizsgatura
{
    partial class Form_Utvonal
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1_Osszes = new System.Windows.Forms.TextBox();
            this.textBox2_Jutalom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "A kiválasztott turázó kirándulásai";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(79, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(681, 196);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "A turázó összes megtett km-t:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Jutalompontok összege:";
            // 
            // textBox1_Osszes
            // 
            this.textBox1_Osszes.Location = new System.Drawing.Point(597, 354);
            this.textBox1_Osszes.Name = "textBox1_Osszes";
            this.textBox1_Osszes.Size = new System.Drawing.Size(100, 22);
            this.textBox1_Osszes.TabIndex = 4;
            // 
            // textBox2_Jutalom
            // 
            this.textBox2_Jutalom.Location = new System.Drawing.Point(597, 398);
            this.textBox2_Jutalom.Name = "textBox2_Jutalom";
            this.textBox2_Jutalom.Size = new System.Drawing.Size(100, 22);
            this.textBox2_Jutalom.TabIndex = 5;
            // 
            // Form_Utvonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2_Jutalom);
            this.Controls.Add(this.textBox1_Osszes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form_Utvonal";
            this.Text = "Form_Utvonal";
            this.Load += new System.EventHandler(this.Form_Utvonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1_Osszes;
        private System.Windows.Forms.TextBox textBox2_Jutalom;
    }
}