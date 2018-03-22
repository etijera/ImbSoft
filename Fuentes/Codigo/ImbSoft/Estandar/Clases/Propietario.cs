using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estandar.Clases
{
    class Propietario
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public Tercero Tercero { get; set; }
        public string CuentaPropietario { get; set; }
        public string CuentaCliente { get; set; }
        public string Banco { get; set; }
        public bool GranContribuyente { get; set; }
        public bool AutoReteFuente { get; set; }
        public bool AutoReteIca { get; set; }
        public bool AplicarIca { get; set; }
        public string NombreRepLegal { get; set; }
        public string CedulaRepLegal { get; set; }
        public string Contacto { get; set; }
        public string CargoRepLegal { get; set; }

        public Propietario() 
        {
            Tercero = new Tercero();
        }

        public Propietario( int id, string codigo, Tercero tercero, string cuentaPropietario, string cuentaCliente, string banco, bool granContribuyente, bool autoReteFuente,
                            bool autoReteIca, bool aplicarIca, string nombreRepLegal, string cedulaRepLegal, string contacto, string cargoRepLegal) 
        {
            Id = id;
            Codigo = codigo;
            Tercero = tercero;
            CuentaPropietario = cuentaPropietario;
            CuentaCliente = cuentaCliente;
            Banco = banco;
            GranContribuyente = granContribuyente;
            AutoReteFuente = autoReteFuente;
            AutoReteIca = autoReteIca;
            AplicarIca = aplicarIca;
            NombreRepLegal = nombreRepLegal;
            CedulaRepLegal = cedulaRepLegal;
            Contacto = contacto;
            CargoRepLegal = cargoRepLegal;

        }
    }
}
