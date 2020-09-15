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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mantenedorDepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorDepartamento win1 = new MantenedorDepartamento();
            win1.Show();
        }

        private void mantenedorClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorCliente win1 = new MantenedorCliente();
            win1.Show();
        }

        private void mantenedorInventarioEInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorInventarioyMantencion win1 = new MantenedorInventarioyMantencion();
            win1.Show();
        }
    }
}
