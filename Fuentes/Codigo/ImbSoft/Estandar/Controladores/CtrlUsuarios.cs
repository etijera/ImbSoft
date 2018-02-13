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
        public static Int32 InsertarBasico(Usuario usuario)
        {
            SqlParameter[] dbParametros = new SqlParameter[]
            {
                DBHelper.MakeParam("@Operacion",SqlDbType.VarChar,0,"INSERTBASICO"),
                DBHelper.MakeParam("@Nombre",SqlDbType.VarChar,0,usuario.Nombre),
                DBHelper.MakeParam("@Contrasenia",SqlDbType.VarChar,0,usuario.Clave)
            };

            return Convert.ToInt32(DBHelper.ExecuteScalar("PA_Usuarios", dbParametros));
        }
   
        public static Int32 Actualizar(Usuario usuario)
        {
            SqlParameter[] dbParametros = new SqlParameter[]
            {
                DBHelper.MakeParam("@Operacion",SqlDbType.VarChar,0,"UPDATE"),
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,usuario.Id), 
                DBHelper.MakeParam("@Contrasenia",SqlDbType.VarChar,0,usuario.Clave)
            };

            return Convert.ToInt32(DBHelper.ExecuteScalar("PA_Usuarios", dbParametros));
        }

        public static DataSet GetUsuarioOne(Usuario usuario)
        {
            SqlParameter[] dbParametros = new SqlParameter[]
            {
                DBHelper.MakeParam("@Operacion",SqlDbType.VarChar,0,"SELECTID"), 
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,usuario.Id),               
            };

            return DBHelper.ExecuteDataSet("PA_Usuarios", dbParametros);
        }

        public static DataSet GetUsuarioName(Usuario usuario)
        {
            SqlParameter[] dbParametros = new SqlParameter[]
            {
                DBHelper.MakeParam("@Operacion",SqlDbType.VarChar,0,"SELECTNAME"), 
                DBHelper.MakeParam("@Nombre",SqlDbType.VarChar,0,usuario.Nombre),               
            };

            return DBHelper.ExecuteDataSet("PA_Usuarios", dbParametros);
            
        }

        public static DataTable GetUsuarioAll()
        {
            SqlParameter[] dbParametros = new SqlParameter[]
            {
                DBHelper.MakeParam("@Operacion",SqlDbType.VarChar,0,"SELECTALL")            
            };

            DataTable dtPermisos = DataBase.ExecuteQueryDataTable("PA_Usuarios", "datos", CommandType.StoredProcedure, dbParametros, ConexionDB.getInstancia().Conexion(null, null));

            return dtPermisos;
        }

        public static Int32 Eliminar(Usuario usuario)
        {
            SqlParameter[] dbParametros = new SqlParameter[]
            {
                DBHelper.MakeParam("@Operacion",SqlDbType.VarChar,0,"DEL"),
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,usuario.Id)
            };

            return Convert.ToInt32(DBHelper.ExecuteScalar("PA_Usuarios", dbParametros));
        }

    }
}
