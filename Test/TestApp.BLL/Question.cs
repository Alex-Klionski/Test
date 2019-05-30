using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using TestApp.DAL;

namespace TestApp.BLL
{
    public class Question : QuestionsBase
    {
        QuestionsBase questionBase = new QuestionsBase(out arrayQuestions, out arrayRight, out arrayReccommend, out arrayVar1, out arrayVar2, out arrayVar3, out arrayPicture);

        public Question() : base(out arrayQuestions, out arrayRight, out arrayReccommend, out arrayVar1, out arrayVar2, out arrayVar3, out  arrayPicture)
        {

        }

        private static int amountQuestion, correctAnswer, notCorrentAnswer;
        int i = 0;
        int count = 1;

        bool playMusicCorrect = true, playMusicNotCorrect = true;
        SoundPlayer soundNotCorrect = new SoundPlayer("E:\\!Study\\2sem\\!\\Sounds\\notcorrect.wav");
        SoundPlayer soundCorrect = new SoundPlayer("E:\\!Study\\2sem\\!\\Sounds\\correct.wav");

        static Random rand = new Random();

        public void InitExam()
        {
            questionBase.QuestionRand(out arrayQuestions, out arrayRight, out arrayReccommend, out arrayVar1, out arrayVar2, out arrayVar3, out arrayPicture);
            amountQuestion = questionBase.Count;
            correctAnswer = 0;
            notCorrentAnswer = 0;
            amountQuestion--;
        }

        public void InitTest()
        {
            amountQuestion = questionBase.Count;
            correctAnswer = 0;
            notCorrentAnswer = 0;
            amountQuestion--;
        }

        public void RightAnswer()
        {
            correctAnswer++;
            amountQuestion--;
            i++;
        }

        public void NotAnswer()
        {
            notCorrentAnswer++;
            amountQuestion--;
            i++;
        }

        public void SoundPlayCorrect()
        {
            if(playMusicCorrect)
                soundCorrect.Play();
        }

        public void SoundPlayNotCorrect()
        {
            if (playMusicNotCorrect)
                soundNotCorrect.Play();
        }

        public void SoundStopCorrect()
        {
            soundCorrect.Stop();
            playMusicCorrect = false;
        }

        public void SoundStopNotCorrect()
        {
            soundNotCorrect.Stop();
            playMusicNotCorrect = false;
        }

        public int GetRightAnswer() { return correctAnswer; }
        public int GetNotAnswer() { return notCorrentAnswer; }
        public int GetAmountQuestion() { return amountQuestion; }
        public string GetArrayQuestion() { return arrayQuestions[i]; }
        public string GetArrayRight() { return arrayRight[i]; }
        public string GetArrayReccomend() { return arrayReccommend[i]; }
        public string GetArrayVar1() { return arrayVar1[i]; }
        public string GetArrayVar2() { return arrayVar2[i]; }
        public string GetArrayVar3() { return arrayVar3[i]; }
        public string GetArrayPicture() { return arrayPicture[i]; }
        public void GetNull() { i = 0; }
        public int GetNumberOfQuestions() { return questionBase.Count; }
        public int I () { return i; }
        public int GetI()
        {
            if (count < questionBase.Count)
                return count++;
            if (i == 0)
            {
                count = 1;
                return count;
            }
            else
                return count;
        }

    }
}
