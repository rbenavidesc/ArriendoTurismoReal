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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

            cboPerfil.Items.Add(new KeyValuePair<string, string>("Administrador", "admin"));
            cboPerfil.Items.Add(new KeyValuePair<string, string>("Funcionario", "funcionario"));
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

        }
    }
}
