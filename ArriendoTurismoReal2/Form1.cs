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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();
            Usuario usu2 = new Usuario();
            List<Usuario> listaUsuarios = new List<Usuario>();
            usu.Email1 = "admin@gmail.com";
            usu.Contrasena1 = "123";
            usu.Perfil1 = "admin";
            listaUsuarios.Add(usu);

            usu2.Email1 = "fun@gmail.com";
            usu2.Contrasena1 = "123";
            usu2.Perfil1 = "funcionario";
            listaUsuarios.Add(usu2);

            string email = textBoxEmail.Text;
            string password = passwordBox1.Text;

            if (textBoxEmail.Text.Length == 0)
            {
                MessageBox.Show("Ingrese un email.");
                textBoxEmail.Focus();
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                MessageBox.Show("Ingrese un email valido.");
                textBoxEmail.Select(0, textBoxEmail.Text.Length);
                textBoxEmail.Focus();
            }
            else
            {

                foreach (Usuario lista in listaUsuarios)
                {
                    if (lista.Email1 == email && lista.Contrasena1 == password)
                    {
                        if (lista.Perfil1 == "admin")
                        {
                            MenuAdmin win1 = new MenuAdmin();
                            win1.Show();
                        }
                        else if (lista.Perfil1 == "funcionario")
                        {
                            MenuFuncionario win2 = new MenuFuncionario();
                            win2.Show();
                        }
                    }
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register win1 = new Register();
            win1.Show();
        }
    }
}
