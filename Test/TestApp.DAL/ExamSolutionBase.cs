using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Data;
namespace TestApp.DAL
{
    public class ExamSolutionBase
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = users.mdb");

        public void SolutionNotRight()
        {

            connection.Open();

            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "update [user] set solve='notpass' where userID="+AuthorizationBase.Id+"";
            command.CommandText = query;

            command.ExecuteNonQuery();
            connection.Close();
        }

        public void SolutionRight()
        {
            connection.Open();

            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "update [user] set solve='pass' where userID=" + AuthorizationBase.Id + "";
            command.CommandText = query;

            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
