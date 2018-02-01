using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImbSoft.Clases
{
    class Usuario
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Contrasenia { get; set; }

        public Usuario() 
        {
        }

        public Usuario(int id, string codigo, string nombre, string contrasenia) 
        {
            Id = id;
            Codigo = codigo;
            Nombre = nombre;
            Contrasenia = contrasenia;
        }
    }
}
