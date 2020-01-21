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
    public class DBManagerEmp
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public DBManagerEmp()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconstr"].ConnectionString);
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]

        public DataTable GetAllEmp()
        {
            da = new SqlDataAdapter("GetAllEmp", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        [DataObjectMethod(DataObjectMethodType.Insert, true)]

        public void SaveEmp(int ECode, string EName,int ESal,int Dno,int StId,int CtId)
        {
            cmd = new SqlCommand("SaveEmp", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Ecode", ECode);
            cmd.Parameters.AddWithValue("EName", EName);
            cmd.Parameters.AddWithValue("ESal", ESal);
            cmd.Parameters.AddWithValue("Dno", Dno);
            cmd.Parameters.AddWithValue("StId", StId);
            cmd.Parameters.AddWithValue("CtId", CtId);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        [DataObjectMethod(DataObjectMethodType.Update, true)]

        public void UpdateEmp(int ECode, string EName,int ESal,int Dno,int StId,int CtId)
        {
            cmd = new SqlCommand("UpdateState", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("ECode", ECode);
            cmd.Parameters.AddWithValue("EName", EName);
            cmd.Parameters.AddWithValue("ESal", ESal);
            cmd.Parameters.AddWithValue("Dno", Dno);
            cmd.Parameters.AddWithValue("StId", StId);
            cmd.Parameters.AddWithValue("CtId", CtId);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]

        public void DeleteEmp(int ECode)
        {
            cmd = new SqlCommand("DeleteEmp", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("ECode", ECode);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}