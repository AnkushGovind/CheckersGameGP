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
        //string Connstring;
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

        // Gets questions from database 
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


        //Add players informations into the database
        public int AddRegistration(object[] PlayerInfo)
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
                param1.Value = PlayerInfo[0];
                param2.Value = PlayerInfo[1];
                param3.Value = PlayerInfo[2];
                param4.Value = PlayerInfo[3];
                param5.Value = PlayerInfo[4];
                // param6.Value = DateTime.Now;             
            
                return checkerData.ExecuNonQuery(sqlQuery, CommandType.Text, param1, param2, param3, param4, param5);
            }

            catch (Exception ex)
            {
                LastError = ex.Message;
                return -1;
            }
        }//addFeedBack


        //Retrives the information of all the players who have played
        public DataTable PlayersHistory()
        {
            
            string sqlQuery = "select * from PlayerInfoTbl;";
            try
            {
                return this.GetTable(sqlQuery, CommandType.Text);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return null;
            }
        }


        //Inserts players feed back into COmments table
        public int AddFeedBack(int gameId, string comments, string status)
        {
            CheckerGameDAClass checkerData = new CheckerGameDAClass();
            string sqlQuery = "Insert into CommentTbl values(@GameId, @Comments, @Status);";
            SqlParameter param1 = new SqlParameter("@GameId", SqlDbType.Int);
            SqlParameter param2 = new SqlParameter("@Comments", SqlDbType.NVarChar);
            SqlParameter param3 = new SqlParameter("@Status", SqlDbType.VarChar);



            param1.Value = gameId;
            param2.Value = comments;
            param3.Value = status;

            try
            {
                return checkerData.ExecuNonQuery(sqlQuery, CommandType.Text, param1, param2, param3);
            }

            catch (Exception ex)
            {
                LastError = ex.Message;
                return -1;
            }
        }//addFeedBack

    }
}