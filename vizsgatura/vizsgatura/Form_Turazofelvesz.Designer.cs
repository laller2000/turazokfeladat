
namespace vizsgatura
{
    partial class Form_Turazofelvesz
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1_Rogzit = new System.Windows.Forms.Button();
            this.textBox2_vezeteknev = new System.Windows.Forms.TextBox();
            this.textBox3_keresztnev = new System.Windows.Forms.TextBox();
            this.textBox4_varos = new System.Windows.Forms.TextBox();
            this.textBox5_telefonszam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "vezetknev:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "keresztnev:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "varos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "telefonszam:";
            // 
            // button1_Rogzit
            // 
            this.button1_Rogzit.Location = new System.Drawing.Point(361, 385);
            this.button1_Rogzit.Name = "button1_Rogzit";
            this.button1_Rogzit.Size = new System.Drawing.Size(93, 41);
            this.button1_Rogzit.TabIndex = 5;
            this.button1_Rogzit.Text = "Rögzít";
            this.button1_Rogzit.UseVisualStyleBackColor = true;
            this.button1_Rogzit.Click += new System.EventHandler(this.button1_Rogzit_Click);
            // 
            // textBox2_vezeteknev
            // 
            this.textBox2_vezeteknev.Location = new System.Drawing.Point(321, 106);
            this.textBox2_vezeteknev.Name = "textBox2_vezeteknev";
            this.textBox2_vezeteknev.Size = new System.Drawing.Size(234, 22);
            this.textBox2_vezeteknev.TabIndex = 7;
            // 
            // textBox3_keresztnev
            // 
            this.textBox3_keresztnev.Location = new System.Drawing.Point(321, 182);
            this.textBox3_keresztnev.Name = "textBox3_keresztnev";
            this.textBox3_keresztnev.Size = new System.Drawing.Size(234, 22);
            this.textBox3_keresztnev.TabIndex = 8;
            // 
            // textBox4_varos
            // 
            this.textBox4_varos.Location = new System.Drawing.Point(321, 244);
            this.textBox4_varos.Name = "textBox4_varos";
            this.textBox4_varos.Size = new System.Drawing.Size(234, 22);
            this.textBox4_varos.TabIndex = 9;
            // 
            // textBox5_telefonszam
            // 
            this.textBox5_telefonszam.Location = new System.Drawing.Point(321, 289);
            this.textBox5_telefonszam.Name = "textBox5_telefonszam";
            this.textBox5_telefonszam.Size = new System.Drawing.Size(234, 22);
            this.textBox5_telefonszam.TabIndex = 10;
            // 
            // Form_Turazofelvesz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox5_telefonszam);
            this.Controls.Add(this.textBox4_varos);
            this.Controls.Add(this.textBox3_keresztnev);
            this.Controls.Add(this.textBox2_vezeteknev);
            this.Controls.Add(this.button1_Rogzit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form_Turazofelvesz";
            this.Text = "Form_Turazofelvesz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1_Rogzit;
        private System.Windows.Forms.TextBox textBox2_vezeteknev;
        private System.Windows.Forms.TextBox textBox3_keresztnev;
        private System.Windows.Forms.TextBox textBox4_varos;
        private System.Windows.Forms.TextBox textBox5_telefonszam;
    }
}