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
    public partial class Form_Turazo : Form
    {
        public Form_Turazo()
        {
            InitializeComponent();
        }

        private void Form_Turazo_Load(object sender, EventArgs e)
        {
            dataGridView1_Turazok.ColumnCount = 5;
            dataGridView1_Turazok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1_Turazok.Columns[0].Name = "id";
            dataGridView1_Turazok.Columns[0].HeaderText = "Azonosító";
            dataGridView1_Turazok.Columns[1].Name = "vezeteknev";
            dataGridView1_Turazok.Columns[1].HeaderText = "Vezetéknév";
            dataGridView1_Turazok.Columns[2].Name = "keresztnev";
            dataGridView1_Turazok.Columns[2].HeaderText = "Keresztnév";
            dataGridView1_Turazok.Columns[3].Name = "varos";
            dataGridView1_Turazok.Columns[3].HeaderText = "Város";
            dataGridView1_Turazok.Columns[4].Name = "telefonszam";
            dataGridView1_Turazok.Columns[4].HeaderText = "Telefonszám";
            try
            {
                Program.sql.CommandText = "SELECT `id`, `vezeteknev`, `keresztnev`, `varos`, `telefonszam` FROM `vizsga_turazo` WHERE 1";
                using (MySqlDataReader dr=Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int uj_indexe = dataGridView1_Turazok.Rows.Add();
                        DataGridViewRow uj_sor = dataGridView1_Turazok.Rows
                            [uj_indexe];
                        uj_sor.Cells["id"].Value = dr.GetInt32("id");
                        uj_sor.Cells["vezeteknev"].Value = dr.GetString("vezeteknev");
                        uj_sor.Cells["keresztnev"].Value = dr.GetString("keresztnev");
                        uj_sor.Cells["varos"].Value = dr.GetString("varos");
                        uj_sor.Cells["telefonszam"].Value = dr.GetString("telefonszam");
                    }
                }
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                return;
            }
        }

        private void button1_Felvetel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form_turazofelvesz.Show();
        }

        private void button2_Adatokfrissites_Click(object sender, EventArgs e)
        {
            dataGridView1_Turazok.ColumnCount = 5;
            dataGridView1_Turazok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1_Turazok.Columns[0].Name = "id";
            dataGridView1_Turazok.Columns[0].HeaderText = "Azonosító";
            dataGridView1_Turazok.Columns[1].Name = "vezeteknev";
            dataGridView1_Turazok.Columns[1].HeaderText = "Vezetéknév";
            dataGridView1_Turazok.Columns[2].Name = "keresztnev";
            dataGridView1_Turazok.Columns[2].HeaderText = "Keresztnév";
            dataGridView1_Turazok.Columns[3].Name = "varos";
            dataGridView1_Turazok.Columns[3].HeaderText = "Város";
            dataGridView1_Turazok.Columns[4].Name = "telefonszam";
            dataGridView1_Turazok.Columns[4].HeaderText = "Telefonszám";
            try
            {
                Program.sql.CommandText = "SELECT `id`, `vezeteknev`, `keresztnev`, `varos`, `telefonszam` FROM `vizsga_turazo` WHERE 1";
                using (MySqlDataReader dr = Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int uj_indexe = dataGridView1_Turazok.Rows.Add();
                        DataGridViewRow uj_sor = dataGridView1_Turazok.Rows
                            [uj_indexe];
                        uj_sor.Cells["id"].Value = dr.GetInt32("id");
                        uj_sor.Cells["vezeteknev"].Value = dr.GetString("vezeteknev");
                        uj_sor.Cells["keresztnev"].Value = dr.GetString("keresztnev");
                        uj_sor.Cells["varos"].Value = dr.GetString("varos");
                        uj_sor.Cells["telefonszam"].Value = dr.GetString("telefonszam");
                    }
                }
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                return;
            }
        }

        private void dataGridView1_Turazok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            Program.form_utvonal.Show();
        }
    }
}
