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
    public partial class Zvonok : Form
    {
        public Zvonok()
        {
            InitializeComponent();
        }

        private void back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Glav RegFormcs = new Glav();
            RegFormcs.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
