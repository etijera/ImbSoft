using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estandar.Clases
{
    class Cliente
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public Tercero Tercero { get; set; }
        public string CuentaCliente { get; set; }
        public string Banco { get; set; }
        public bool GranContribuyente { get; set; }
        public bool AutoReteFuente { get; set; }
        public bool AutoReteIca { get; set; }
        public bool AplicarIca { get; set; }

        public Cliente() 
        {
            Tercero = new Tercero();
        }


        public Cliente(int id, string codigo, Tercero tercero, string cuentaCliente, string banco, bool granContribuyente, bool autoReteFuente, bool autoReteIca, bool aplicarIca) 
        {
            Id = id;
            Codigo = codigo;
            Tercero = tercero;
            CuentaCliente = cuentaCliente;
            Banco = banco;
            GranContribuyente = granContribuyente;
            AutoReteFuente = autoReteFuente;
            AutoReteIca = autoReteIca;
            AplicarIca = aplicarIca;

        }
    }
}
