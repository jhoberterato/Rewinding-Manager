using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace RewindingManager.Classes
{
    internal class MainClass
    {
        private SqlConnection conn { get; set; }
        private SqlCommand cmd { get; set; }
        private SqlDataAdapter dataAdapter { get; set; }
        private DataSet dataSet { get; set; }
        private bool isSuccess {  get; set; }

        public MainClass()
        {
           this.conn = new SqlConnection(Properties.Settings.Default.cnStr);
        }

        public void connect()
        {
            if(this.conn.State == ConnectionState.Closed)
            {
                this.conn.Open();
            }
        }

        public DataTable select(string query)
        {
            this.connect();
            this.dataAdapter = new SqlDataAdapter();
            this.dataSet = new DataSet();
            this.cmd = new SqlCommand(query, this.conn);
            this.dataAdapter.SelectCommand = this.cmd;

            this.dataSet.Clear();
            this.dataAdapter.Fill(this.dataSet, "result");
            return this.dataSet.Tables[0];
        }

        public bool actionQuery(string query)
        {
            this.connect() ;
            this.cmd = new SqlCommand(query, this.conn);
            if(this.cmd.ExecuteNonQuery() > 0)
            {
                this.isSuccess = true ;
            }
            else
            {
                this.isSuccess = false ;    
            }
            return this.isSuccess ;
        }
    }
}
