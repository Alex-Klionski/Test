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
        public static string[] rightLogin, rightPassword;
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

            int i = 0;
            while (reader.Read())
            {
                rightLogin[i] = reader[1].ToString();
                rightPassword[i] = reader[2].ToString();
                i++;
            }
            reader.Close();
        }
    }
}
