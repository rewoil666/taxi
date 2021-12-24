using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сеть_такси
{
    public partial class Zakaz : Form
    {
        public Zakaz()
        {
            InitializeComponent();
        }

        private void Zakaz_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            otkuda.Text = "Откуда";
            otkuda.ForeColor = Color.Gray;
            kuda.Text = "Куда";
            kuda.ForeColor = Color.Gray;

            MySqlDataAdapter adapterP = new MySqlDataAdapter();

            MySqlCommand commandP = new MySqlCommand("SELECT Название_вида_услуги  FROM вид_услуги", db.getConnection());
            adapterP.SelectCommand = commandP;

            DataSet dataSetP = new DataSet();

            adapterP.Fill(dataSetP, "вид_услуги");

            for (int i = 0; i < dataSetP.Tables["вид_услуги"].Rows.Count; i++)
            {
                comboBox1.Items.Add(dataSetP.Tables["вид_услуги"].Rows[i]["Название_вида_услуги"]);
            }
        }

        private void otkuda_Enter(object sender, EventArgs e)
        {
            otkuda.Text = null;
            otkuda.ForeColor = Color.Black;
            kuda.Text = null;
            kuda.ForeColor = Color.Black;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Glav RegFormcs = new Glav();
            RegFormcs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Конечный_заказ RegFormcs = new Конечный_заказ();
            RegFormcs.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
