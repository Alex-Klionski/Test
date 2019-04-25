using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Media;
using TestApp.BLL;

namespace Test
{
   
    public partial class FChooseTest : Form
    {
        static public Question question = new Question();
        FMain main = new FMain();
        int m = 0, s = 0; // Таймер

        static Random rand = new Random();
        public FChooseTest()
        {          
            InitializeComponent();
            this.KeyPreview = true;
            this.btnNext.Click += new EventHandler(FirstAction); // Двойное нажатие

            InitTest();
        }
        
        private void InitTest()
        {
            labelNumberOfQuestions.Text = question.GetNumberOfQuestions().ToString();
            groupQuestion.Visible = true;
            Timer();
            btnNext.Text = "Следующий вопрос";
            question.InitTest();
            RadioChecked();
            radio_turn_on_off();
            labelResult.Text = "";
            ShowQuestion();
        }


        private void load_data()
        {

        }

        private void RadioChecked()
        {
            panelCorrect.Visible = false;
            panelCorrect.Visible = false;
            panelError.Visible = false;
            labelError.Visible = false;
            pictureBox.Visible = false;
            radioAnswer1.Checked = false;
            radioAnswer2.Checked = false;
            radioAnswer3.Checked = false;
            radioAnswer4.Checked = false;
        }

        private void FChooseTest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.D0 || e.KeyChar == (char)Keys.NumPad0)
            {
                MessageBox.Show("Рекомендация : " + question.GetArrayReccomend());
            }

            if (e.KeyChar == (char)Keys.D1 || e.KeyChar == (char)Keys.NumPad1)
            {
                if (groupQuestion.Enabled)
                    radioAnswer1.Checked = true;
            }

            if (e.KeyChar == (char)Keys.D2 || e.KeyChar == (char)Keys.NumPad2)
            {
                if (groupQuestion.Enabled)
                    radioAnswer2.Checked = true;
            }

            if (e.KeyChar == (char)Keys.D3 || e.KeyChar == (char)Keys.NumPad3)
            {
                if (groupQuestion.Enabled)
                    radioAnswer3.Checked = true;
            }

            if (e.KeyChar == (char)Keys.D4 || e.KeyChar == (char)Keys.NumPad4)
            {
                if (groupQuestion.Enabled)
                    radioAnswer4.Checked = true;
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (labelTimer.Visible)
            {
                if (s < 59)
                {
                    s++;
                    if (s < 10)
                        labelTimerSec.Text = "0" + s.ToString();
                    else
                        labelTimerSec.Text = s.ToString();
                }
                else
                {
                    if (m < 59)
                    {
                        m++;
                        if (m < 10)
                            labelTimerMin.Text = "0" + m.ToString();
                        else
                            labelTimerMin.Text = m.ToString();
                        s = 0;
                        labelTimerSec.Text = "00";
                    }
                    else
                    {
                        m = 0;
                        labelTimerMin.Text = "00";
                    }
                }
                labelTimer.Visible = false;
            }
            else
            {
                labelTimer.Visible = true;
            }

        }

        private void radio_turn_on_off()
        {
            if (question.GetAmountQuestion() < 0)
            {
                radioAnswer1.Visible = false;
                radioAnswer2.Visible = false;
                radioAnswer3.Visible = false;
                radioAnswer4.Visible = false;
            }
            else
            {
                radioAnswer1.Visible = true;
                radioAnswer2.Visible = true;
                radioAnswer3.Visible = true;
                radioAnswer4.Visible = true;
            }
        }

        private void ShowQuestion()
        {
            labelNumber.Text = question.GetI().ToString();
            btnNext.Text = "Ответить";
            listQuestion.Items.Clear();
            RadioChecked();
            PictureCheck();
            listQuestion.Items.Add(question.GetArrayQuestion());
            Picture();
            RadioTags(rand.Next(1, 6));
        }


        private void RadioTags(int p)
        {
            switch (p)
            {
                case 1: radioAnswer1.Text = question.GetArrayVar3(); radioAnswer2.Text = question.GetArrayRight(); radioAnswer3.Text = question.GetArrayVar2(); radioAnswer4.Text = question.GetArrayVar1(); break;
                case 2: radioAnswer1.Text = question.GetArrayRight(); radioAnswer2.Text = question.GetArrayVar1(); radioAnswer3.Text = question.GetArrayVar3(); radioAnswer4.Text = question.GetArrayVar2(); break;
                case 3: radioAnswer1.Text = question.GetArrayVar1(); radioAnswer2.Text = question.GetArrayVar3(); radioAnswer3.Text = question.GetArrayRight(); radioAnswer4.Text = question.GetArrayVar2(); break;
                case 4: radioAnswer1.Text = question.GetArrayVar2(); radioAnswer2.Text = question.GetArrayVar3(); radioAnswer3.Text = question.GetArrayVar1(); radioAnswer4.Text = question.GetArrayRight(); break;
                case 5: radioAnswer1.Text = question.GetArrayVar3(); radioAnswer2.Text = question.GetArrayVar2(); radioAnswer3.Text = question.GetArrayRight(); radioAnswer4.Text = question.GetArrayVar1(); break;
                case 6: radioAnswer1.Text = question.GetArrayVar3(); radioAnswer2.Text = question.GetArrayVar1(); radioAnswer3.Text = question.GetArrayVar2(); radioAnswer4.Text = question.GetArrayRight(); break;
            }
        }

        private void FirstAction(object sender, EventArgs e)
        {
            if (question.GetAmountQuestion() < 0) { InitTest(); return; }
            if (!(radioAnswer1.Checked || radioAnswer2.Checked || radioAnswer3.Checked || radioAnswer4.Checked))
            {
                MessageBox.Show("Выберите вариант ответа");
                return;
            }

            if ((radioAnswer1.Checked && radioAnswer1.Text == question.GetArrayRight()) ||
                 (radioAnswer2.Checked && radioAnswer2.Text == question.GetArrayRight()) ||
                 (radioAnswer3.Checked && radioAnswer3.Text == question.GetArrayRight()) ||
                 (radioAnswer4.Checked && radioAnswer4.Text == question.GetArrayRight()))
            {
                question.SoundPlayCorrect();
                panelCorrect.Visible = true;
                labelCorrect.Visible = true;
                question.RightAnswer();

            }
            else
            {
                question.SoundPlayNotCorrect();
                panelError.Visible = true;
                labelError.Visible = true;
                MessageBox.Show("Правильный вариант ответа: " + question.GetArrayRight());
                question.NotAnswer();
            }


            if (question.GetAmountQuestion() < 0)
            {

                labelResult.Text = "Правильных ответов: " + question.GetRightAnswer().ToString() + "\n" +
                "Неправильных ответов: " + question.GetNotAnswer().ToString();
                listQuestion.Items.Add("Результат теста");
                timer1.Enabled = false;
                labelTimer.Visible = true;
                btnNext.Text = "Тест заново";
                listQuestion.Items.Clear();
                groupQuestion.Visible = false;
                PictureCheck();
                radio_turn_on_off();
                question.GetNull();
                return;
            }

            this.btnNext.Click -= new EventHandler(FirstAction);
            btnNext.Text = "Следующий вопрос";
            groupQuestion.Enabled = false;
            this.btnNext.Click += new EventHandler(SecondAction);
        }

        private void SecondAction(object sender, EventArgs e)
        {
            groupQuestion.Enabled = true;
            ShowQuestion();
            this.btnNext.Click -= new EventHandler(SecondAction);
            this.btnNext.Click += new EventHandler(FirstAction);
        }

        private void Picture()
        {
            if (question.GetArrayPicture() != "-")
            {
                pictureBox.Visible = true;
                pictureBox.Image = new Bitmap(question.GetArrayPicture());
                groupQuestion.Location = new System.Drawing.Point(505, 113);
                groupQuestion.Size = new System.Drawing.Size(576, 258);
                listQuestion.Location = new System.Drawing.Point(505, 12);
                listQuestion.Size = new System.Drawing.Size(603, 95);
            }
        }

        private void PictureCheck()
        {
            groupQuestion.Location = new System.Drawing.Point(209, 113);
            groupQuestion.Size = new System.Drawing.Size(654, 258);
            listQuestion.Location = new System.Drawing.Point(209, 12);
            listQuestion.Size = new System.Drawing.Size(654, 95);
            pictureBox.Visible = false;
        }

        private void FChooseTest_Load(object sender, EventArgs e)
        {

        }

        private void FChooseTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            if (e.CloseReason != CloseReason.UserClosing) return;
            e.Cancel = DialogResult.Yes != main.ShowDialog();
        }

        private void labelNumber_Click(object sender, EventArgs e)
        {

        }

        private void Timer()
        {
            m = 0; s = 0;
            timer1.Enabled = true;
            timer1.Interval = 500;
            labelTimer.Visible = true;
            labelTimerMin.Text = "00";
            labelTimerSec.Text = "00";
        }

    }

}
