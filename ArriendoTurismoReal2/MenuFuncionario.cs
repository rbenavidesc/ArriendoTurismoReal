using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArriendoTurismoReal2
{
    public partial class MenuFuncionario : Form
    {
        public MenuFuncionario()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckIn win1 = new CheckIn();
            win1.Show();
        }
    }
}
