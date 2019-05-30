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

        public static string[] arrayQuestions, arrayRight, arrayReccommend, arrayVar1, arrayVar2, arrayVar3, arrayPicture;

        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= database.mdb";
        private OleDbConnection myConnection;

        private int AmountQuestions()
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

        public QuestionsBase(out string[] arrayQuestions, out string[] arrayRight, out string[] arrayReccommend, out string[] arrayVar1, out string[] arrayVar2, out  string[] arrayVar3, out string[] arrayPicture)
        {
            Count = AmountQuestions();

            myConnection = new OleDbConnection(connectString);
            myConnection.Open();

            string query = "SELECT q_question, q_recomend, q_answer, q_var1, q_var2, q_var3, q_image FROM Questions ORDER BY q_id";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            arrayQuestions = new string[Count];
            arrayRight = new string[Count];
            arrayReccommend = new string[Count];
            arrayVar1 = new string[Count];
            arrayVar2 = new string[Count];
            arrayVar3 = new string[Count];
            arrayPicture = new string[Count];

            int temp = 0;

            while (reader.Read())
            {
                arrayQuestions[temp] = (string)reader[0];
                arrayReccommend[temp] = (string)reader[1];
                arrayRight[temp] = (string)reader[2];
                arrayVar1[temp] = (string)reader[3];
                arrayVar2[temp] = (string)reader[4];
                arrayVar3[temp] = (string)reader[5];
                arrayPicture[temp] = (string)reader[6];
                temp++;
            }

            reader.Close();
            myConnection.Close();
        }

        private int[] RandomArray(int CountQuestion)
        {
            Random rand = new Random();
            int[] arrayTemp = new int[Count];

            for (int i = 0; i < CountQuestion; i++)
            {
                arrayTemp[i] = i;
            }

            for (int i = 0; i < arrayTemp.Length; i++)
            {
                int tmp = arrayTemp[i];
                int r = rand.Next(i, Count);
                arrayTemp[i] = arrayTemp[r];
                arrayTemp[r] = tmp;
            }

            return arrayTemp;
        }

        public void QuestionRand(out string[] arrayQuestions, out string[] arrayRight, out string[] arrayReccommend, out string[] arrayVar1, out string[] arrayVar2, out string[] arrayVar3, out string[] arrayPicture)
        {
            Count = 10;

            arrayQuestions = new string[Count];
            arrayRight = new string[Count];
            arrayReccommend = new string[Count];
            arrayVar1 = new string[Count];
            arrayVar2 = new string[Count];
            arrayVar3 = new string[Count];
            arrayPicture = new string[Count];

            int[] array = new int[Count];
            array = RandomArray(Count);

            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string query = "SELECT q_question, q_recomend, q_answer, q_var1, q_var2, q_var3, q_image FROM Questions ORDER BY q_id ";

            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            int temp = 0;
            while (reader.Read())
            {
                if(temp == 10)
                {
                    break;
                }
                arrayQuestions[array[temp]] = (string)reader[0];
                arrayReccommend[array[temp]] = (string)reader[1];
                arrayRight[array[temp]] = (string)reader[2];
                arrayVar1[array[temp]] = (string)reader[3];
                arrayVar2[array[temp]] = (string)reader[4];
                arrayVar3[array[temp]] = (string)reader[5];
                arrayPicture[array[temp]] = (string)reader[6];
                temp++;
            }

            reader.Close();
            myConnection.Close();
        }
    }
}