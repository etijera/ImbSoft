using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estandar.Clases
{
    class Tercero
    {

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string DocumentoIdentidad { get; set; }
        public string DigitoVerificacion { get; set; }
        public string TipoIdentificacion { get; set; }
        public string RazonSocial { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public string Zona { get; set; }
        public bool Regimen { get; set; }
        public string NumeroCuenta { get; set; }
        public string TipoCuenta { get; set; }
        public string TipoPersona { get; set; }
        public string Banco { get; set; }
        public bool EsPropietario { get; set; }
        public bool EsInquilino { get; set; }

        public Tercero() 
        {            
        }

        public Tercero(int id, string codigo, string documentoIdentidad, string digitoVerificacion, string tipoIdentificacion, string razonSocial, string primerNombre,
                     string segundoNombre, string primerApellido, string segundoApellido, string direccion, string telefono, string email, string pais, string ciudad,
                     string zona, bool regimen, string numeroCuenta, string tipoCuenta, string tipoPersona, string banco, bool esPropietario, bool esInquilino) 
        {
            Id = id;
            Codigo = codigo;
            DocumentoIdentidad = documentoIdentidad;
            DigitoVerificacion = digitoVerificacion;
            TipoIdentificacion = tipoIdentificacion;
            RazonSocial = razonSocial;
            PrimerNombre = primerNombre;
            SegundoNombre = segundoNombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            Pais = pais;
            Ciudad = ciudad;
            Zona = zona;
            Regimen = regimen;
            NumeroCuenta = numeroCuenta;
            TipoCuenta = tipoCuenta;
            TipoPersona = tipoPersona;
            Banco = banco;
            EsPropietario = esPropietario;
            EsInquilino = esInquilino;

        }
    }
}
