using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TestApp.DAL
{
    public class QuestionsBase
    {
        public int Count { get; set; }

        public static string[] ArrayQuestions, ArrayRight, ArrayReccommend, ArrayVar1, ArrayVar2, ArrayVar3, ArrayPicture;

        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= database.mdb";
        private OleDbConnection myConnection;
        private int Amount()
        {
            int count = 0;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string query = "SELECT q_id FROM Questions ORDER BY q_id";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                count++;
            }
            myConnection.Close();
            return count;
        }

        public QuestionsBase(string[] ArrayQuestions, string[] ArrayRight, string[] ArrayReccommend, string[] ArrayVar1, string[] ArrayVar2, string[] ArrayVar3, string[] ArrayPicture)
        {
            Count = Amount();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string query = "SELECT q_question, q_recomend, q_answer, q_var1, q_var2, q_var3, q_image FROM Questions ORDER BY q_id";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            ArrayQuestions = new string[Count];
            ArrayRight = new string[Count];
            ArrayReccommend = new string[Count];
            ArrayVar1 = new string[Count];
            ArrayVar2 = new string[Count];
            ArrayVar3 = new string[Count];
            ArrayPicture = new string[Count];
            int k = 0;
            while (reader.Read())
            {
                ArrayQuestions[k] = (string)reader[0];
                ArrayReccommend[k] = (string)reader[1];
                ArrayRight[k] = (string)reader[2];
                ArrayVar1[k] = (string)reader[3];
                ArrayVar2[k] = (string)reader[4];
                ArrayVar3[k] = (string)reader[5];
                ArrayPicture[k] = (string)reader[6];
                k++;
            }
            reader.Close();
            myConnection.Close();


        }
        public void QuestionRand(out string[] ArrayQuestions, out string[] ArrayRight, out string[] ArrayReccommend, out string[] ArrayVar1, out string[] ArrayVar2, out string[] ArrayVar3, out string[] ArrayPicture)
        {
            Count = 10;
            ArrayQuestions = new string[Count];
            ArrayRight = new string[Count];
            ArrayReccommend = new string[Count];
            ArrayVar1 = new string[Count];
            ArrayVar2 = new string[Count];
            ArrayVar3 = new string[Count];
            ArrayPicture = new string[Count];

            Random rand = new Random();
            int[] array = new int[Count];
            for (int i = 0; i < Count; i++)
            {
                array[i] = i;
            }
            for (int i = 0; i < array.Length; i++)
            {
                int tmp = array[i];
                int r = rand.Next(i, Count);
                array[i] = array[r];
                array[r] = tmp;

            }
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string query = "SELECT q_question, q_recomend, q_answer, q_var1, q_var2, q_var3, q_image FROM Questions ORDER BY q_id ";

            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            int k = 0;
            while (reader.Read())
            {
                if(k == 10)
                {
                    break;
                }
                ArrayQuestions[array[k]] = (string)reader[0];
                ArrayReccommend[array[k]] = (string)reader[1];
                ArrayRight[array[k]] = (string)reader[2];
                ArrayVar1[array[k]] = (string)reader[3];
                ArrayVar2[array[k]] = (string)reader[4];
                ArrayVar3[array[k]] = (string)reader[5];
                ArrayPicture[array[k]] = (string)reader[6];
                k++;
            }

            reader.Close();
            myConnection.Close();


        }
    }
}