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
    public partial class Form_Utvonal : Form
    {
        List<Vizsga_utvonal> utvonalak = new List<Vizsga_utvonal>();
        public int osszeg = 0;
        public int jutalompontdb = 0;
        public int jutalomossz = 0;
        public Form_Utvonal()
        {
            InitializeComponent();
        }

        private void Form_Utvonal_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].Name = "id";
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].Name = "turazoID";
            dataGridView1.Columns[1].HeaderText = "Turazoazonosító";
            dataGridView1.Columns[2].Name = "honnan";
            dataGridView1.Columns[2].HeaderText = "Honnan";
            dataGridView1.Columns[3].Name = "hova";
            dataGridView1.Columns[3].HeaderText = "Hova";
            dataGridView1.Columns[4].Name = "km";
            dataGridView1.Columns[4].HeaderText = "KM";

            try
            {
                Program.sql.CommandText = "SELECT `id`, `turazoID`, `honnan`, `hova`, `km` FROM `vizsga_utvonal` WHERE 1";
                using (MySqlDataReader dr=Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int uj_sorindex = dataGridView1.Rows.Add();
                        DataGridViewRow uj_sor = dataGridView1.Rows
                            [uj_sorindex];
                        uj_sor.Cells["id"].Value = dr.GetInt32("id");
                        uj_sor.Cells["turazoID"].Value = dr.GetInt32("turazoID");
                        uj_sor.Cells["honnan"].Value = dr.GetString("honnan");
                        uj_sor.Cells["hova"].Value = dr.GetString("hova");
                        uj_sor.Cells["km"].Value = dr.GetInt32("km");
                    }
                }
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                return;
            }
            Utvonalakfeltoltese();

            for (int i = 0; i < utvonalak.Count; i++)
            {
                osszeg += utvonalak[i].Km;
                if (utvonalak[i].Km>20)
                {
                    jutalompontdb = 1;
                }
                jutalomossz += jutalompontdb;
            }
            textBox1_Osszes.Text = osszeg.ToString();
            textBox2_Jutalom.Text = jutalomossz.ToString();
        }
       private void Utvonalakfeltoltese()
        {
            try
            {
                utvonalak.Clear();
                Program.sql.CommandText = "SELECT `id`, `turazoID`, `honnan`, `hova`, `km` FROM `vizsga_utvonal` WHERE 1";
                using (MySqlDataReader dr=Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        utvonalak.Add(new Vizsga_utvonal(dr.GetInt32("id"),dr.GetInt32("turazoID"), dr.GetString("honnan"), dr.GetString("hova"), dr.GetInt32("km")));
                    }
                }
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                return;
            }
            
        }
    }
}
