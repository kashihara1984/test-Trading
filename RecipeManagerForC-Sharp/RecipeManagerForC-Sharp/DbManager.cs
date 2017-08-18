using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace RecipeManagerForC_Sharp
{
    class DbManager
    {
        private static DbManager createOnce = null;

        private DbManager()
        {
        }
        public static DbManager CreateOnce
        {
            get
            {
                if (createOnce == null)
                {
                    createOnce = new DbManager();
                }
                return createOnce;
            }
        }

        string strCon = ConfigurationManager.ConnectionStrings["DataBase.ConnectionString"].ConnectionString;

        public DataTable SelectSql(string strSql, List<SqlParameter> objParms)
        {
            DataTable selectDt = new DataTable();
            using (SqlConnection objCon = new SqlConnection(strCon))
            using (SqlCommand objCmd = new SqlCommand(strSql))
            using (SqlDataAdapter objAdpt = new SqlDataAdapter())
            {
                if (objParms != null)
                {
                    foreach (SqlParameter objParm in objParms)
                    {
                        objCmd.Parameters.Add(objParm);
                    }
                }
                objCmd.Connection = objCon;
                objAdpt.SelectCommand = objCmd;
                objAdpt.Fill(selectDt);
                objCmd.Parameters.Clear();
                return selectDt;
            }
        }

        public void RunSql(string strSql, List<SqlParameter> objParms)
        {
            using (SqlConnection objCon = new SqlConnection(strCon))
            using (SqlCommand objCmd = new SqlCommand(strSql))
            {
                objCon.Open();
                objCmd.Connection = objCon;
                //objCmd.CommandType = CommandType.StoredProcedure;
                if (objParms != null)
                {
                    foreach (SqlParameter objParm in objParms)
                    {
                        objCmd.Parameters.Add(objParm);
                    }
                }
                objCmd.ExecuteNonQuery();
                objCmd.Parameters.Clear();
            }
        }
    }
}