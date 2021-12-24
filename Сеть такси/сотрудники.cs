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
    public partial class сотрудники : Form
    {
        public сотрудники()
        {
            InitializeComponent();
            LoadData();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close(); this.Close();
        }

        private void сотрудники_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void LoadData()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT сотрудники.id_сотрудника AS ID, сотрудники.Фамилия AS Фамилия, сотрудники.Имя AS Имя, сотрудники.Отчество AS Отчество, сотрудники.Дата_приёма_на_работу AS Дата_приёма_на_работу, сотрудники.Дата_увольнения AS Дата_увольнения, сотрудники.Номер_телефона AS Номер_телефона, сотрудники.Номер_договора AS Номер_договора, роль.id_роли AS Роль FROM сотрудники, роль WHERE сотрудники.id_роли = роль.id_роли", db.getConnection());

            adapter.SelectCommand = command;

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "сотрудники");

            dataGridView1.DataSource = dataSet.Tables["сотрудники"];
            dataGridView1.AutoResizeColumns();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Glav RegFormcs = new Glav();
            RegFormcs.Show();
        }

        private void Обновление_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT сотрудники.id_сотрудника AS ID, сотрудники.Фамилия AS Фамилия, сотрудники.Имя AS Имя, сотрудники.Отчество AS Отчество, сотрудники.Дата_приёма_на_работу AS Дата_приёма_на_работу, сотрудники.Дата_увольнения AS Дата_увольнения, сотрудники.Номер_телефона AS Номер_телефона, сотрудники.Номер_договора AS Номер_договора, роль.id_роли AS Роль FROM сотрудники, роль WHERE сотрудники.id_роли = роль.id_роли", db.getConnection());
                adapter.SelectCommand = command;
                //int n = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                string id_сотрудника = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string Фамилия = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string Имя = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string Отчество = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                string Дата_приёма_на_работу = dataGridView1.CurrentRow.Cells[4].Value.ToString();


                if (Дата_приёма_на_работу != "")
                {
                    Дата_приёма_на_работу = DateTime.Parse(Дата_приёма_на_работу).ToString("yyyyMMdd");
                    //date_buy.ToShortDateString();
                }
                else
                {
                    Дата_приёма_на_работу = null;
                }

                //MessageBox.Show(idtechtable);


                string Дата_увольнения = dataGridView1.CurrentRow.Cells[5].Value.ToString();


                if (Дата_увольнения != "")
                {
                    Дата_увольнения = DateTime.Parse(Дата_увольнения).ToString("yyyyMMdd");
                    //date_buy.ToShortDateString();
                }
                else
                {
                    Дата_увольнения = null;
                }

                string Номер_телефона = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                string Номер_договора = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                string id_роли = dataGridView1.CurrentRow.Cells[8].Value.ToString();

                MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                MySqlCommand command1 = new MySqlCommand("UPDATE `сотрудники` SET `Фамилия` =  @1U ,  `Имя` = @2U  , `Отчество` = @3U, `Дата_приёма_на_работу` = @4U, `Дата_увольнения` =@5U, `Номер_телефона` = @6U, `Номер_договора` = @7U, `id_роли` = @8U  WHERE `id_сотрудника` = @0U", db.getConnection());
                command1.Parameters.Add("@0U", MySqlDbType.VarChar).Value = id_сотрудника;
                command1.Parameters.Add("@1U", MySqlDbType.VarChar).Value = Фамилия;
                command1.Parameters.Add("@2U", MySqlDbType.VarChar).Value = Имя;
                command1.Parameters.Add("@3U", MySqlDbType.VarChar).Value = Отчество;
                command1.Parameters.Add("@4U", MySqlDbType.VarChar).Value = Дата_приёма_на_работу;
                command1.Parameters.Add("@5U", MySqlDbType.VarChar).Value = Дата_увольнения;
                command1.Parameters.Add("@6U", MySqlDbType.VarChar).Value = Номер_телефона;
                command1.Parameters.Add("@7U", MySqlDbType.VarChar).Value = Номер_договора;
                command1.Parameters.Add("@8U", MySqlDbType.VarChar).Value = id_роли;

                adapter1.SelectCommand = command1;


                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "сотрудники");

                adapter1.Fill(dataSet, "сотрудники");
                dataSet.Tables["сотрудники"].Clear();
                adapter.Fill(dataSet, "сотрудники");
                DataRow dr = dataSet.Tables[0].NewRow();
                dataSet.Tables[0].Rows.Add(dr);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dataSet.Tables["сотрудники"];
                dataGridView1.AutoResizeColumns();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Удаление_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT сотрудники.id_сотрудника AS ID, сотрудники.Фамилия AS Фамилия, сотрудники.Имя AS Имя, сотрудники.Отчество AS Отчество, сотрудники.Дата_приёма_на_работу AS Дата_приёма_на_работу, сотрудники.Дата_увольнения AS Дата_увольнения, сотрудники.Номер_телефона AS Номер_телефона, сотрудники.Номер_договора AS Номер_договора, роль.id_роли AS Роль FROM сотрудники, роль WHERE сотрудники.id_роли = роль.id_роли", db.getConnection());
                adapter.SelectCommand = command;

                string id_сотрудника = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                MySqlCommand command1 = new MySqlCommand("DELETE FROM `сотрудники` WHERE `id_сотрудника` = @lU", db.getConnection());
                command1.Parameters.Add("@lU", MySqlDbType.VarChar).Value = id_сотрудника;



                DataTable table = new DataTable();
                adapter1.SelectCommand = command1;
                adapter1.Fill(table);


                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "сотрудники");
                adapter1.Fill(dataSet, "сотрудники");
                dataSet.Tables["сотрудники"].Clear();
                adapter.Fill(dataSet, "сотрудники");
                DataRow dr = dataSet.Tables[0].NewRow();
                dataSet.Tables[0].Rows.Add(dr);
                dataGridView1.DataSource = dataSet.Tables["сотрудники"];
                dataGridView1.AutoResizeColumns();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Добавление_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT сотрудники.id_сотрудника AS ID, сотрудники.Фамилия AS Фамилия, сотрудники.Имя AS Имя, сотрудники.Отчество AS Отчество, сотрудники.Дата_приёма_на_работу AS Дата_приёма_на_работу, сотрудники.Дата_увольнения AS Дата_увольнения, сотрудники.Номер_телефона AS Номер_телефона, сотрудники.Номер_договора AS Номер_договора, роль.id_роли AS Роль FROM сотрудники, роль WHERE сотрудники.id_роли = роль.id_роли", db.getConnection());


                adapter.SelectCommand = command;
  

                // -------DataTable создается чтобы выбранную в combobox строку связать с параметром id


                //int n = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                string id_сотрудника = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string Фамилия = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string Имя = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string Отчество = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                string Дата_приёма_на_работу = dataGridView1.CurrentRow.Cells[4].Value.ToString();


                if (Дата_приёма_на_работу != "")
                {
                    Дата_приёма_на_работу = DateTime.Parse(Дата_приёма_на_работу).ToString("yyyyMMdd");
                    //date_buy.ToShortDateString();
                }
                else
                {
                    Дата_приёма_на_работу = null;
                }

                //MessageBox.Show(idtechtable);


                string Дата_увольнения = dataGridView1.CurrentRow.Cells[5].Value.ToString();


                if (Дата_увольнения != "")
                {
                    Дата_увольнения = DateTime.Parse(Дата_увольнения).ToString("yyyyMMdd");
                    //date_buy.ToShortDateString();
                }
                else
                {
                    Дата_увольнения = null;
                }

                string Номер_телефона = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                string Номер_договора = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                string id_роли = dataGridView1.CurrentRow.Cells[8].Value.ToString();


                MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                MySqlCommand command1 = new MySqlCommand("insert `сотрудники` (`Фамилия`, `Имя`, `Отчество`, `Дата_приёма_на_работу`, `Дата_увольнения`, `Номер_телефона`, `Номер_договора`, `id_роли`) VALUES (@1U, @2U, @3U, @4U, @5U, @6U, @7U, @8U)", db.getConnection());
                command1.Parameters.Add("@0U", MySqlDbType.VarChar).Value = id_сотрудника;
                command1.Parameters.Add("@1U", MySqlDbType.VarChar).Value = Фамилия;
                command1.Parameters.Add("@2U", MySqlDbType.VarChar).Value = Имя;
                command1.Parameters.Add("@3U", MySqlDbType.VarChar).Value = Отчество;
                command1.Parameters.Add("@4U", MySqlDbType.VarChar).Value = Дата_приёма_на_работу;
                command1.Parameters.Add("@5U", MySqlDbType.VarChar).Value = Дата_увольнения;
                command1.Parameters.Add("@6U", MySqlDbType.VarChar).Value = Номер_телефона;
                command1.Parameters.Add("@7U", MySqlDbType.VarChar).Value = Номер_договора;
                command1.Parameters.Add("@8U", MySqlDbType.VarChar).Value = id_роли;
             

                adapter1.SelectCommand = command1;


                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "сотрудники");

                adapter1.Fill(dataSet, "сотрудники");
                dataSet.Tables["сотрудники"].Clear();
                adapter.Fill(dataSet, "сотрудники");
                DataRow dr = dataSet.Tables[0].NewRow();
                dataSet.Tables[0].Rows.Add(dr);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dataSet.Tables["сотрудники"];
                dataGridView1.AutoResizeColumns();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
