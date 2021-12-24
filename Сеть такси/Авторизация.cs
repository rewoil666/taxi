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
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
        }

        private void Авторизация_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            login.Text = "Login";
            login.ForeColor = Color.Gray;
            Password.Text = "Password";
            Password.ForeColor = Color.Gray;
        }

        private void login_TextChanged(object sender, EventArgs e)
        {
            //login.Text = null;
            //login.ForeColor = Color.Black;
            //Password.Text = null;
            //Password.ForeColor = Color.Black;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String login1 = login.Text;
            String Password2 = Password.Text;


            DB db = new DB();


            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `сотрудники` WHERE `Логин` = 123 AND `Пароль` = 123", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login1;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = Password2;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            //MessageBox.Show("passUser")
            if (table.Rows.Count > 0)
            {
                this.Hide();
                сотрудники RegFormcs = new сотрудники();
                RegFormcs.Show();
            }
            else
                MessageBox.Show("No");
        }
    }
}
