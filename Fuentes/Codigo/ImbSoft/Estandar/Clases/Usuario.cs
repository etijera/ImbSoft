using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estandar.Clases
{
    class Usuario
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string User { get; set; }
        public string Clave { get; set; }

        public TipoUsuario TipoUsuario { get; set; }

        public Usuario() 
        {
            TipoUsuario = new TipoUsuario();
        }

        public Usuario(int id, string codigo, string nombre, string usuario, string clave, TipoUsuario tipoUsuario) 
        {
            Id = id;
            Codigo = codigo;
            Nombre = nombre;
            User = usuario;
            Clave = clave;
            TipoUsuario = tipoUsuario;

        }
    }
}
