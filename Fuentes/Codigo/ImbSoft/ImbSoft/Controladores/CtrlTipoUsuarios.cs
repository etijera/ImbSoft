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
                //,,,,
                DBHelper.MakeParam("@Operacion",SqlDbType.VarChar,0,"INSERTBASICO"),
                DBHelper.MakeParam("@Nombre",SqlDbType.VarChar,0,tipoUsuario.Nombre), 
                DBHelper.MakeParam("@PoderEditar",SqlDbType.VarChar,0,tipoUsuario.PoderAdicionar), 
                DBHelper.MakeParam("@PoderEditar",SqlDbType.VarChar,0,tipoUsuario.PoderEditar), 
                DBHelper.MakeParam("@PoderEliminar",SqlDbType.VarChar,0,tipoUsuario.PoderEliminar), 
                DBHelper.MakeParam("@PoderExportar",SqlDbType.VarChar,0,tipoUsuario.PoderExportar), 
                DBHelper.MakeParam("@PoderGuardar",SqlDbType.VarChar,0,tipoUsuario.PoderGuardar), 
                DBHelper.MakeParam("@PoderImprimir",SqlDbType.VarChar,0,tipoUsuario.PoderImprimir)
            };

            return Convert.ToInt32(DBHelper.ExecuteScalar("PA_TipoUsuarios", dbParametros));
        }
   
        public static Int32 Actualizar(TipoUsuario tipoUsuario)
        {
            SqlParameter[] dbParametros = new SqlParameter[]
            {
                DBHelper.MakeParam("@Operacion",SqlDbType.VarChar,0,"UPDATE"),
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,tipoUsuario.Id),
                DBHelper.MakeParam("@Nombre",SqlDbType.VarChar,0,tipoUsuario.Nombre), 
                DBHelper.MakeParam("@PoderEditar",SqlDbType.VarChar,0,tipoUsuario.PoderAdicionar), 
                DBHelper.MakeParam("@PoderEditar",SqlDbType.VarChar,0,tipoUsuario.PoderEditar), 
                DBHelper.MakeParam("@PoderEliminar",SqlDbType.VarChar,0,tipoUsuario.PoderEliminar), 
                DBHelper.MakeParam("@PoderExportar",SqlDbType.VarChar,0,tipoUsuario.PoderExportar), 
                DBHelper.MakeParam("@PoderGuardar",SqlDbType.VarChar,0,tipoUsuario.PoderGuardar), 
                DBHelper.MakeParam("@PoderImprimir",SqlDbType.VarChar,0,tipoUsuario.PoderImprimir)
            };

            return Convert.ToInt32(DBHelper.ExecuteScalar("PA_TipoUsuarios", dbParametros));
        }

        public static DataSet GetTipoUsuarioOne(TipoUsuario tipoUsuario)
        {
            SqlParameter[] dbParametros = new SqlParameter[]
            {
                DBHelper.MakeParam("@Operacion",SqlDbType.VarChar,0,"SELECTID"), 
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,tipoUsuario.Id),               
            };

            return DBHelper.ExecuteDataSet("PA_TipoUsuarios", dbParametros);
        }

        public static DataSet GetTipoUsuarioName(TipoUsuario tipoUsuario)
        {
            SqlParameter[] dbParametros = new SqlParameter[]
            {
                DBHelper.MakeParam("@Operacion",SqlDbType.VarChar,0,"SELECTNAME"), 
                DBHelper.MakeParam("@Nombre",SqlDbType.VarChar,0,tipoUsuario.Nombre),               
            };

            return DBHelper.ExecuteDataSet("PA_TipoUsuarios", dbParametros);
            
        }

        public static DataTable GetUsuarioAll()
        {
            SqlParameter[] dbParametros = new SqlParameter[]
            {
                DBHelper.MakeParam("@Operacion",SqlDbType.VarChar,0,"SELECTALL")            
            };

            DataTable dtPermisos = DataBase.ExecuteQueryDataTable("PA_TipoUsuarios", "datos", CommandType.StoredProcedure, dbParametros, ConexionDB.getInstancia().Conexion(null, null));

            return dtPermisos;
        }

        public static Int32 Eliminar(TipoUsuario tipoUsuario)
        {
            SqlParameter[] dbParametros = new SqlParameter[]
            {
                DBHelper.MakeParam("@Operacion",SqlDbType.VarChar,0,"DEL"),
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,tipoUsuario.Id)
            };

            return Convert.ToInt32(DBHelper.ExecuteScalar("PA_TipoUsuarios", dbParametros));
        }

    }
}
