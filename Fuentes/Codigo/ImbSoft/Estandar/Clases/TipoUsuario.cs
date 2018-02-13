using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estandar.Clases
{
    class TipoUsuario
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public bool PoderAdicionar { get; set; }
        public bool PoderEliminar { get; set; }
        public bool PoderEditar { get; set; }
        public bool PoderImprimir { get; set; }
        public bool PoderGuardar { get; set; }
        public bool PoderExportar { get; set; }

        public TipoUsuario() 
        {
        }

        public TipoUsuario(int id, string codigo, string nombre, bool poderAdicionar, bool poderEliminar, bool poderEditar, bool poderImprimir, bool poderGuardar, bool poderExportar) 
        {
            Id = id;
            Codigo = codigo;
            Nombre = nombre;
            PoderAdicionar = poderAdicionar;
            PoderEliminar = poderEliminar;
            PoderEditar = poderEditar;
            PoderImprimir = poderImprimir;
            PoderGuardar = poderGuardar;
            PoderExportar = poderExportar;
        }
    }
}
