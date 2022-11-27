using DataAccessLayer;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace IntermediaryLayer
{
    //created by shwetha N.G
    public class CheckerIntermediaryClass : CheckerGameDAClass
    {
        string Connstring;
        public CheckerIntermediaryClass() : base()
        {
        
        }


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
           
            string sqlQuery = "select * from QuestionsTbl;";
            try
            {
                return this.GetDataSet(sqlQuery);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return null;
            }
        }

        public int AddRegistration(string[] P1Info, string[] P2Info)
        {
            CheckerGameDAClass checkerData = new CheckerGameDAClass();
            string sqlQuery = "Insert into PlayerInfoTbl values(@PlayerType, @Firstname, @Lastname, @Gender, @Age);";
            SqlParameter param1 = new SqlParameter("@PlayerType", SqlDbType.VarChar);
            SqlParameter param2 = new SqlParameter("@Firstname", SqlDbType.VarChar);
            SqlParameter param3 = new SqlParameter("@Lastname", SqlDbType.VarChar);
            SqlParameter param4 = new SqlParameter("@Gender", SqlDbType.VarChar);
            SqlParameter param5 = new SqlParameter("@Age", SqlDbType.VarChar);
            //SqlParameter param6 = new SqlParameter("@Date", SqlDbType.DateTime);
            // SqlParameter param5 = new SqlParameter("@AmountPaid", SqlDbType.Int);

            try
            {
                param1.Value = P1Info[0];
                param2.Value = P1Info[1];
                param3.Value = P1Info[2];
                param4.Value = P1Info[3];
                param5.Value = P1Info[4];
               // param6.Value = DateTime.Now;
               int o= checkerData.ExecuNonQuery(sqlQuery, CommandType.Text, param1, param2, param3, param4, param5);
           
                param1.Value = P2Info[0];
                param2.Value = P2Info[1];
                param3.Value = P2Info[2];
                param4.Value = P2Info[3];
                param5.Value = P2Info[4];
              //  param6.Value = DateTime.Now;
                return checkerData.ExecuNonQuery(sqlQuery, CommandType.Text, param1, param2, param3, param4, param5);
            }

            catch (Exception ex)
            {
                LastError = ex.Message;
                return -1;
            }
        }//addFeedBack

    }
}