using ImbSoft.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Referencias;

namespace ImbSoft.Controladores
{
    class CtrlTipoUsuarios
    {
        public static Int32 InsertarBasico(TipoUsuario tipoUsuario)
        {
            SqlParameter[] dbParametros = new SqlParameter[]
            {
                DBHelper.MakeParam("@Operacion",SqlDbType.VarChar,0,"INSERTBASICO"),
                DBHelper.MakeParam("@Nombre",SqlDbType.VarChar,0,tipoUsuario.Nombre),
                DBHelper.MakeParam("@Contrasenia",SqlDbType.VarChar,0,tipoUsuario.Clave)//por aqui
            };

            return Convert.ToInt32(DBHelper.ExecuteScalar("PA_Usuarios", dbParametros));
        }
   
        public static Int32 Actualizar(TipoUsuario tipoUsuario)
        {
            SqlParameter[] dbParametros = new SqlParameter[]
            {
                DBHelper.MakeParam("@Operacion",SqlDbType.VarChar,0,"UPDATE"),
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,tipoUsuario.Id), 
                DBHelper.MakeParam("@Contrasenia",SqlDbType.VarChar,0,tipoUsuario.Clave)
            };

            return Convert.ToInt32(DBHelper.ExecuteScalar("PA_Usuarios", dbParametros));
        }

        public static DataSet GetUsuarioOne(TipoUsuario tipoUsuario)
        {
            SqlParameter[] dbParametros = new SqlParameter[]
            {
                DBHelper.MakeParam("@Operacion",SqlDbType.VarChar,0,"SELECTID"), 
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,usuario.Id),               
            };

            return DBHelper.ExecuteDataSet("PA_Usuarios", dbParametros);
        }

        public static DataSet GetUsuarioName(TipoUsuario tipoUsuario)
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

        public static Int32 Eliminar(TipoUsuario tipoUsuario)
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
