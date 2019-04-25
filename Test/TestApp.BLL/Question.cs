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
        public Question() : base(out ArrayQuestions, out ArrayRight, out ArrayReccommend, out ArrayVar1, out ArrayVar2, out ArrayVar3, out ArrayPicture)
        {

        }
        private new static string[] ArrayQuestions, ArrayRight, ArrayReccommend, ArrayVar1, ArrayVar2, ArrayVar3, ArrayPicture;
        QuestionsBase questionBase = new QuestionsBase(out ArrayQuestions, out ArrayRight, out ArrayReccommend, out ArrayVar1, out ArrayVar2, out ArrayVar3, out ArrayPicture);

        private static int amountQuestion, correctAnswer, NotCorrentAnswer;
        int i = 0;
        int count = 1;
        bool playMusicCorrect = true, playMusicNotCorrect = true;
        SoundPlayer soundNotCorrect = new SoundPlayer("E:\\!Study\\2sem\\!\\Sounds\\notcorrect.wav");
        SoundPlayer soundCorrect = new SoundPlayer("E:\\!Study\\2sem\\!\\Sounds\\correct.wav");
        static Random rand = new Random();

        public void InitExam()
        {
            questionBase.QuestionRand(out ArrayQuestions, out ArrayRight, out ArrayReccommend, out ArrayVar1, out ArrayVar2, out ArrayVar3, out ArrayPicture);
            amountQuestion = 10;
            correctAnswer = 0;
            NotCorrentAnswer = 0;
            amountQuestion--;
        }

        public void InitTest()
        {
            amountQuestion = questionBase.Count;
            correctAnswer = 0;
            NotCorrentAnswer = 0;
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
            NotCorrentAnswer++;
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
        public int GetNotAnswer() { return NotCorrentAnswer; }
        public int GetAmountQuestion() { return amountQuestion; }
        public string GetArrayQuestion() { return ArrayQuestions[i]; }
        public string GetArrayRight() { return ArrayRight[i]; }
        public string GetArrayReccomend() { return ArrayReccommend[i]; }
        public string GetArrayVar1() { return ArrayVar1[i]; }
        public string GetArrayVar2() { return ArrayVar2[i]; }
        public string GetArrayVar3() { return ArrayVar3[i]; }
        public string GetArrayPicture() { return ArrayPicture[i]; }
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
