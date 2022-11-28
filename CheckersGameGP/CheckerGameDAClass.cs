using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System;

namespace DataAccessLayer
{
    public class CheckerGameDAClass
    {
        //connection object
        private SqlConnection CGConnection;
        //connection string
        string CGConnString = ConfigurationManager.ConnectionStrings["CheckersGameGP.Properties.Settings.CheckerConnectionString"].ConnectionString;

        public CheckerGameDAClass()
        {
          if(CGConnection==null) CGConnection = new SqlConnection(CGConnString);
        }       

        private SqlConnection GetConnection()
        {
            if (CGConnection == null) CGConnection = new SqlConnection(CGConnString);
            return CGConnection;
        }//GetConnection
        private void OpenConnection()
        {
            if (CGConnection.State == System.Data.ConnectionState.Closed) CGConnection.Open();
        }//openconnection
        private void CloseConnection()
        {
            CGConnection.Close();
        }//close connection

        private SqlDataReader GetReader(String procNameOrQuery, CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null, SqlParameter param3 = null, SqlParameter param4 = null, SqlParameter param5 = null, SqlParameter param6 = null)
        {

            //instantiate command object
            SqlCommand cgSqlCommand = new SqlCommand(procNameOrQuery, this.GetConnection());
            cgSqlCommand.CommandType = cmdType; //set the cmd type as incoming cmdType: how the sqlcommand textis to be interpreted.
            //set the parameters(parameters are the incoming value)
            if (param1 != null) cgSqlCommand.Parameters.Add(param1);
            if (param2 != null) cgSqlCommand.Parameters.Add(param2);
            if (param3 != null) cgSqlCommand.Parameters.Add(param3);
            if (param4 != null) cgSqlCommand.Parameters.Add(param4);
            if (param5 != null) cgSqlCommand.Parameters.Add(param5);
            if (param6 != null) cgSqlCommand.Parameters.Add(param6);

            try
            {
                this.OpenConnection(); //open connection
                return cgSqlCommand.ExecuteReader(); //returns one row at a time.

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cgSqlCommand.Dispose();
            }
        }//getReader()
        public DataTable GetTable(string procNameOrQuery, CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null, SqlParameter param3 = null, SqlParameter param4 = null, SqlParameter param5 = null, SqlParameter param6 = null)
        {
            //load a data table from the database using either query or text or a sorted procesure name.
            DataTable table = new DataTable();
            SqlDataReader reader = null;

            try
            {
                //instantiate reader using zGetReader method.
                reader = GetReader(procNameOrQuery, cmdType, param1, param2, param3, param4, param5, param6);
                table.Load(reader);
                reader.Close();
                return table;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }//getTable().

        public int ExecuNonQuery(string procNameOrQuery, CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null, SqlParameter param3 = null, SqlParameter param4 = null, SqlParameter param5 = null, SqlParameter param6 = null)
        {
            SqlCommand cgSqlCommand = new SqlCommand(procNameOrQuery, this.GetConnection());
            cgSqlCommand.CommandType = cmdType;
            if (param1 != null) cgSqlCommand.Parameters.Add(param1);
            if (param2 != null) cgSqlCommand.Parameters.Add(param2);
            if (param3 != null) cgSqlCommand.Parameters.Add(param3);
            if (param4 != null) cgSqlCommand.Parameters.Add(param4);
            if (param5 != null) cgSqlCommand.Parameters.Add(param5);
          //  if (param6 != null) cgSqlCommand.Parameters.Add(param6);

            try
            {
                this.OpenConnection();
                return cgSqlCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection();
                cgSqlCommand.Dispose();
            }
        }//ExecuteNonQuery()

        public Object ExecScalarQuery(String procNameOrQuery, CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null, SqlParameter param3 = null, SqlParameter param4 = null, SqlParameter param5 = null, SqlParameter param6 = null)
        {
            SqlCommand cgSqlCommand = new SqlCommand(procNameOrQuery, this.GetConnection());
            cgSqlCommand.CommandType = cmdType;
            if (param1 != null) cgSqlCommand.Parameters.Add(param1);
            if (param2 != null) cgSqlCommand.Parameters.Add(param2);
            if (param3 != null) cgSqlCommand.Parameters.Add(param3);
            if (param4 != null) cgSqlCommand.Parameters.Add(param4);
            if (param5 != null) cgSqlCommand.Parameters.Add(param5);
            if (param6 != null) cgSqlCommand.Parameters.Add(param6);

            try
            {
                this.OpenConnection();
                return cgSqlCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection();
                cgSqlCommand.Dispose();
            }
        }//execScalarquery()
        public DataSet GetDataSet(string sqlString)
        {
            DataSet cgDataSet = new DataSet();

            try
            {
                SqlDataAdapter cgAdapter = new SqlDataAdapter(sqlString, CGConnection);
                this.OpenConnection();
                cgAdapter.Fill(cgDataSet);
                return cgDataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }

        }
    }
}