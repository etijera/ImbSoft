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
    class CtrlUsuarios
    {
        public static DataTable InsertarBasico(Usuario usuario)
        {
            SqlParameter[] dbParametros = new[] {   new SqlParameter("@Operacion", "INSERTBASICO")
                                                    ,new SqlParameter("@Nombre", usuario.Nombre)
                                                    ,new SqlParameter("@Usuario", usuario.User)
                                                    ,new SqlParameter("@Clave", usuario.Clave)
                                                    ,new SqlParameter("@CodTipoUsuario", usuario.TipoUsuario.Codigo)
                                                };

            return DataBase.ExecuteQueryDataTable("PA_Usuarios", "datos", CommandType.StoredProcedure, dbParametros, ConexionDB.getInstancia().Conexion(null, null));        
        }

        public static bool Actualizar(Usuario usuario)
        {
            SqlParameter[] dbParametros = new[] {   new SqlParameter("@Operacion", "UPDATE")
                                                    ,new SqlParameter("@Id", usuario.Id)
                                                    ,new SqlParameter("@Nombre", usuario.Nombre)
                                                    ,new SqlParameter("@Usuario", usuario.User)
                                                    ,new SqlParameter("@Clave", usuario.Clave)
                                                    ,new SqlParameter("@CodTipoUsuario", usuario.TipoUsuario.Codigo)
                                                };


            return DataBase.ExecuteNonQuery("PA_Usuarios", CommandType.StoredProcedure, dbParametros, ConexionDB.getInstancia().Conexion(null, null));
        }

        public static DataTable GetUsuarioOne(Usuario usuario)
        {
            SqlParameter[] dbParametros = new[] {   new SqlParameter("@Operacion", "SELECTID")
                                                    ,new SqlParameter("@Id", usuario.Id)
                                                };

            return DataBase.ExecuteQueryDataTable("PA_Usuarios", "datos", CommandType.StoredProcedure, dbParametros, ConexionDB.getInstancia().Conexion(null, null));
        }

        public static DataTable GetUsuarioName(Usuario usuario)
        {
            SqlParameter[] dbParametros = new[] {   new SqlParameter("@Operacion", "SELECTNAME")
                                                    ,new SqlParameter("@Usuario", usuario.User)
                                                };

            return DataBase.ExecuteQueryDataTable("PA_Usuarios", "datos", CommandType.StoredProcedure, dbParametros, ConexionDB.getInstancia().Conexion(null, null));            
        }

        public static DataTable GetUsuarioAll()
        {
            SqlParameter[] dbParametros = new[] { new SqlParameter("@Operacion", "SELECTALL") };

            return DataBase.ExecuteQueryDataTable("PA_Usuarios", "datos", CommandType.StoredProcedure, dbParametros, ConexionDB.getInstancia().Conexion(null, null));
        }

        public static bool Eliminar(Usuario usuario)
        {
            SqlParameter[] dbParametros = new[] {   new SqlParameter("@Operacion", "DEL")
                                                    ,new SqlParameter("@Id", usuario.Id)
                                                };

            return DataBase.ExecuteNonQuery("PA_Usuarios", CommandType.StoredProcedure, dbParametros, ConexionDB.getInstancia().Conexion(null, null));            
        }

    }
}
