using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Cliente
    {
        string rut;
        string nombre;
        string apellido;
        string Email;
        string Contrasena;

        public string Email1 { get => Email; set => Email = value; }
        public string Contrasena1 { get => Contrasena; set => Contrasena = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Rut { get => rut; set => rut = value; }
    }
}
