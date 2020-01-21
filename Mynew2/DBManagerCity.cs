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
    public class DBManagerCity
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public DBManagerCity()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconstr"].ConnectionString);
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]

        public DataTable GetAllCity()
        {
            da = new SqlDataAdapter("GetAllCity", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        [DataObjectMethod(DataObjectMethodType.Insert, true)]

        public void SaveCity(int CtId, string CtName,int StId)
        {
            cmd = new SqlCommand("SaveCity", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("CtId", CtId);
            cmd.Parameters.AddWithValue("CtName", CtName);
            cmd.Parameters.AddWithValue("StId", StId);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        [DataObjectMethod(DataObjectMethodType.Update, true)]

        public void UpdateCity(int CtId, string CtName,int StId)
        {
            cmd = new SqlCommand("UpdateCity", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("CtId", CtId);
            cmd.Parameters.AddWithValue("CtName", CtName);
            cmd.Parameters.AddWithValue("StId", StId);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]

        public void DeleteCity(int CtId)
        {
            cmd = new SqlCommand("DeleteCity", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("CtId", CtId);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}