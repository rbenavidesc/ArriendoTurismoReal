using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Usuario
    {
        string nombre;
        string apellido;
        string Email;
        string Contrasena;
        string Perfil;

        public string Email1 { get => Email; set => Email = value; }
        public string Contrasena1 { get => Contrasena; set => Contrasena = value; }
        public string Perfil1 { get => Perfil; set => Perfil = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
    }
}
