using Estandar.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Referencias;

namespace Estandar.Controladores
{
    class CtrlTipoUsuarios
    {
        public static DataTable InsertarBasico(TipoUsuario tipoUsuario)
        {
            SqlParameter[] dbParametros = new[] {   new SqlParameter("@Operacion", "INSERTBASICO")
                                                    ,new SqlParameter("@Nombre", tipoUsuario.Nombre)
                                                    ,new SqlParameter("@PoderAdicionar", tipoUsuario.PoderAdicionar)
                                                    ,new SqlParameter("@PoderEditar", tipoUsuario.PoderEditar)
                                                    ,new SqlParameter("@PoderEliminar", tipoUsuario.PoderEliminar)
                                                    ,new SqlParameter("@PoderExportar", tipoUsuario.PoderExportar)
                                                    ,new SqlParameter("@PoderGuardar", tipoUsuario.PoderGuardar)
                                                    ,new SqlParameter("@PoderImprimir", tipoUsuario.PoderImprimir)
                                                };

            return DataBase.ExecuteQueryDataTable("PA_TipoUsuarios", "datos", CommandType.StoredProcedure, dbParametros, ConexionDB.getInstancia().Conexion(null, null));
        }
   
        public static bool Actualizar(TipoUsuario tipoUsuario)
        {

            SqlParameter[] dbParametros = new[] {   new SqlParameter("@Operacion", "UPDATE")
                                                    ,new SqlParameter("@Id", tipoUsuario.Id)
                                                    ,new SqlParameter("@Nombre", tipoUsuario.Nombre)
                                                    ,new SqlParameter("@PoderAdicionar", tipoUsuario.PoderAdicionar)
                                                    ,new SqlParameter("@PoderEditar", tipoUsuario.PoderEditar)
                                                    ,new SqlParameter("@PoderEliminar", tipoUsuario.PoderEliminar)
                                                    ,new SqlParameter("@PoderExportar", tipoUsuario.PoderExportar)
                                                    ,new SqlParameter("@PoderGuardar", tipoUsuario.PoderGuardar)
                                                    ,new SqlParameter("@PoderImprimir", tipoUsuario.PoderImprimir)
                                                };

            return DataBase.ExecuteNonQuery("PA_TipoUsuarios", CommandType.StoredProcedure, dbParametros, ConexionDB.getInstancia().Conexion(null, null));            
        }

        public static DataTable GetTipoUsuarioOne(TipoUsuario tipoUsuario)
        {
            SqlParameter[] dbParametros = new[] {   new SqlParameter("@Operacion", "SELECTID")
                                                    ,new SqlParameter("@Id", tipoUsuario.Id)
                                                };

            return DataBase.ExecuteQueryDataTable("PA_TipoUsuarios", "datos", CommandType.StoredProcedure, dbParametros, ConexionDB.getInstancia().Conexion(null, null));
        }

        public static DataTable GetTipoUsuarioName(TipoUsuario tipoUsuario)
        {
            SqlParameter[] dbParametros = new[] {   new SqlParameter("@Operacion", "SELECTNAME")
                                                    ,new SqlParameter("@Nombre", tipoUsuario.Nombre)
                                                };
            return DataBase.ExecuteQueryDataTable("PA_TipoUsuarios", "datos", CommandType.StoredProcedure, dbParametros, ConexionDB.getInstancia().Conexion(null, null));
        }

        public static DataTable GetUsuarioAll()
        {
            SqlParameter[] dbParametros = new[] { new SqlParameter("@Operacion", "SELECTALL") };

            return DataBase.ExecuteQueryDataTable("PA_TipoUsuarios", "datos", CommandType.StoredProcedure, dbParametros, ConexionDB.getInstancia().Conexion(null, null));
        }

        public static bool Eliminar(TipoUsuario tipoUsuario)
        {

            SqlParameter[] dbParametros = new[] {   new SqlParameter("@Operacion", "DEL")
                                                    ,new SqlParameter("@Id", tipoUsuario.Id)
                                                };

            return DataBase.ExecuteNonQuery("PA_TipoUsuarios", CommandType.StoredProcedure, dbParametros, ConexionDB.getInstancia().Conexion(null, null));            
        }

    }
}
