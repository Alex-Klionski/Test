using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace TestApp.DAL
{
    public class AuthorizationBase
    {
        public static string Id { get; set; }
        public static string[] rightLogin, rightPassword, rightID, answer;
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = users.mdb";
        private OleDbConnection myConnection;

        public int Count { get; set; }

        private int Amount()
        {
            int count = 0;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();

            string query = "SELECT * FROM [user] ORDER BY userID";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                count++;
            }
            myConnection.Close();

            return count;
        }

        public AuthorizationBase(out string[] rightLogin,out string[] rightPassword)
        {
            Count = Amount();

            myConnection = new OleDbConnection(connectString);
            myConnection.Open();

            string query = "SELECT * FROM [user] ORDER BY userID";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            rightLogin = new string[Count];
            rightPassword = new string[Count];
            rightID = new string[Count];
            answer = new string[Count];

            int temp = 0;
            while (reader.Read())
            {
                rightID[temp] = reader[0].ToString();
                rightLogin[temp] = reader[1].ToString();
                rightPassword[temp] = reader[2].ToString();
                answer[temp] = reader[6].ToString();
                temp++;
            }
            myConnection.Close();

            reader.Close();
        }
    }
}
