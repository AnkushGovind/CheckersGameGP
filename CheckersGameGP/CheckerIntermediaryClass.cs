using DataAccessLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace IntermediaryLayer
{
    //created by shwetha N.G
    public class CheckerIntermediaryClass
    {
        //property to hold last error
        public string LastError { get; set; }
        public int AddGameDtls(string gameName, string desc)
        {
            CheckerGameDAClass checkerData = new CheckerGameDAClass();
            string sqlQuery = "Insert into GameDetail values(@GameName, @Description);";
            SqlParameter param1 = new SqlParameter("@GameName", SqlDbType.Text);
            SqlParameter param2 = new SqlParameter("@Description", SqlDbType.Text);           

            param1.Value = gameName;
            param2.Value = desc;
           
            try
            {
                return checkerData.ExecuNonQuery(sqlQuery, CommandType.Text, param1, param2);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return -1;
            }

        }

        public DataSet GetQuestions()
        {
            CheckerGameDAClass checkerData = new CheckerGameDAClass();
            string sqlQuery = "select * from QuestionTbl;";
            try
            {
                return checkerData.GetDataSet(sqlQuery);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return null;
            }
        }

    }
}