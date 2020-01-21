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
    public class DBManagerState
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public DBManagerState()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconstr"].ConnectionString);
        }

        [DataObjectMethod(DataObjectMethodType.Select,true)]
        
        public DataTable GetAllState()
        {
            da = new SqlDataAdapter("GetAllState", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        [DataObjectMethod(DataObjectMethodType.Insert,true)]
        
        public void SaveState(int StId,string StName)
        {
            cmd = new SqlCommand("SaveState", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("StId", StId);
            cmd.Parameters.AddWithValue("StName", StName);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        [DataObjectMethod(DataObjectMethodType.Update,true)]

        public void UpdateState(int StId,string StName)
        {
            cmd = new SqlCommand("UpdateState", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("StId", StId);
            cmd.Parameters.AddWithValue("StName", StName);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        [DataObjectMethod(DataObjectMethodType.Delete,true)]

        public void DeleteState(int StId)
        {
            cmd = new SqlCommand("DeleteState", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("StId", StId);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        [DataObjectMethod(DataObjectMethodType.Select,true)]
        public DataTable GetCityByStID(int StId)
        {
            da = new SqlDataAdapter("GetCityByStID", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@StId", StId);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}