using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace vizsgatura
{
    public partial class Form_Turazofelvesz : Form
    {
        public Form_Turazofelvesz()
        {
            InitializeComponent();
        }

        private void button1_Rogzit_Click(object sender, EventArgs e)
        {
            string veteteknev=textBox2_vezeteknev.Text.ToString();
            string keresztnev=textBox3_keresztnev.Text.ToString();
            string varos=textBox4_varos.Text.ToString();
            string telefonsszam=textBox5_telefonszam.Text.ToString();
            if (String.IsNullOrEmpty(veteteknev))
            {
                MessageBox.Show("Nem töltötted ki!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(keresztnev))
            {
                MessageBox.Show("Nem töltötted ki!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(varos))
            {
                MessageBox.Show("Nem töltötted ki!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(telefonsszam))
            {
                MessageBox.Show("Nem töltötted ki!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Program.sql.CommandText = "INSERT INTO `vizsga_turazo`(`id`, `vezeteknev`, `keresztnev`, `varos`, `telefonszam`) VALUES (NULL,'"+veteteknev+"','"+keresztnev+"','"+varos+"','"+telefonsszam+"')";
                Program.sql.ExecuteNonQuery();
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                return;
            }
            MessageBox.Show("Sikeres rögzítés!");
            textBox2_vezeteknev.Text = "";
            textBox3_keresztnev.Text = "";
            textBox4_varos.Text = "";
            textBox5_telefonszam.Text = "";
            this.Hide();
            Program.form_turazo.Show();

        }
    }
}
