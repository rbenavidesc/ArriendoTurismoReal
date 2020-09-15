using Clases;
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
    public partial class MantenedorCliente : Form
    {
        public MantenedorCliente()
        {
            InitializeComponent();

            List<Cliente> listadoCLientes = new List<Cliente>();

            Cliente cli1 = new Cliente();
            Cliente cli2 = new Cliente();
            Cliente cli3 = new Cliente();

            cli1.Rut = "19";
            cli1.Nombre = "Juan";
            cli1.Apellido = "Perez";
            cli1.Email1 = "juan@gmail.com";
            cli1.Contrasena1 = "123";
            listadoCLientes.Add(cli1);

            cli1.Rut = "29";
            cli1.Nombre = "Pedro";
            cli1.Apellido = "Farias";
            cli1.Email1 = "pedro@gmail.com";
            cli1.Contrasena1 = "123";
            listadoCLientes.Add(cli2);

            cli1.Rut = "32";
            cli1.Nombre = "Diego";
            cli1.Apellido = "Cornejo";
            cli1.Email1 = "diedo@gmail.com";
            cli1.Contrasena1 = "123";
            listadoCLientes.Add(cli3);


            listBox1.Items.Add(listadoCLientes);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
