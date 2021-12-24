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
    public partial class Glav : Form
    {
        public Glav()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zakaz RegFormcs = new Zakaz();
            RegFormcs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zvonok RegFormcs = new Zvonok();
            RegFormcs.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Авторизация RegFormcs = new Авторизация();
            RegFormcs.Show();
        }
    }
}
