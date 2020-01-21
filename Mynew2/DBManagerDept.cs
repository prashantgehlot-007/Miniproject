using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.ComponentModel;

namespace Mynew2
{
    [DataObject(true)]
    public class DBManagerDept
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public DBManagerDept()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconstr"].ConnectionString);
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]

        public DataTable GetAllDept()
        {
            da = new SqlDataAdapter("GetAllDept", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        [DataObjectMethod(DataObjectMethodType.Insert, true)]

        public void SaveDept(int Dno, string DName)
        {
            cmd = new SqlCommand("SaveDept", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Dno", Dno);
            cmd.Parameters.AddWithValue("DName", DName);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        [DataObjectMethod(DataObjectMethodType.Update, true)]

        public void UpdateDept(int Dno, string DName)
        {
            cmd = new SqlCommand("UpdateDept", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("Dno", Dno);
            cmd.Parameters.AddWithValue("DName", DName);
            
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]

        public void DeleteDept(int Dno)
        {
            cmd = new SqlCommand("DeleteDept", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Dno", Dno);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}