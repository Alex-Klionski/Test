using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using TestApp.BLL;

namespace Test
{
    public partial class Exam : Form
    {
        FMain main = new FMain();

        public static Question questionExam = new Question();
        ExamSolution solution = new ExamSolution();
        static Random rand = new Random();

        private int quick = 600;

        public Exam()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.btnNext.Click += new EventHandler(FirstAction); // Двойное нажатие

            InitTest();
        }

        private void InitTest()
        {
            groupQuestion.Visible = true;
            Timer();
            btnNext.Text = "Следующий вопрос";
            questionExam.InitExam();
            RadioChecked();
            radio_turn_on_off();
            labelResult.Text = "";
            ShowQuestion();
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

        private void Exam_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void radio_turn_on_off()
        {
            if (questionExam.GetAmountQuestion() < 0)
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
            btnNext.Text = "Ответить";
            listQuestion.Items.Clear();
            RadioChecked();
            PictureCheck();
            listQuestion.Items.Add(questionExam.GetArrayQuestion());
            Picture();
            RadioTags(rand.Next(1, 6));
        }

        private void RadioTags(int p)
        {
            switch (p)
            {
                case 1: radioAnswer1.Text = questionExam.GetArrayVar3(); radioAnswer2.Text = questionExam.GetArrayRight(); radioAnswer3.Text = questionExam.GetArrayVar2(); radioAnswer4.Text = questionExam.GetArrayVar1(); break;
                case 2: radioAnswer1.Text = questionExam.GetArrayRight(); radioAnswer2.Text = questionExam.GetArrayVar1(); radioAnswer3.Text = questionExam.GetArrayVar3(); radioAnswer4.Text = questionExam.GetArrayVar2(); break;
                case 3: radioAnswer1.Text = questionExam.GetArrayVar1(); radioAnswer2.Text = questionExam.GetArrayVar3(); radioAnswer3.Text = questionExam.GetArrayRight(); radioAnswer4.Text = questionExam.GetArrayVar2(); break;
                case 4: radioAnswer1.Text = questionExam.GetArrayVar2(); radioAnswer2.Text = questionExam.GetArrayVar3(); radioAnswer3.Text = questionExam.GetArrayVar1(); radioAnswer4.Text = questionExam.GetArrayRight(); break;
                case 5: radioAnswer1.Text = questionExam.GetArrayVar3(); radioAnswer2.Text = questionExam.GetArrayVar2(); radioAnswer3.Text = questionExam.GetArrayRight(); radioAnswer4.Text = questionExam.GetArrayVar1(); break;
                case 6: radioAnswer1.Text = questionExam.GetArrayVar3(); radioAnswer2.Text = questionExam.GetArrayVar1(); radioAnswer3.Text = questionExam.GetArrayVar2(); radioAnswer4.Text = questionExam.GetArrayRight(); break;
            }
        }

        private void ActionClose(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void GroupBoxErrorFalse()
        {
            panelError.Visible = false;
            labelError.Visible = false;
        }

        private void GroupBoxCorrectFalse()
        {
            panelCorrect.Visible = false;
            labelCorrect.Visible = false;
        }

        private void FirstAction(object sender, EventArgs e)
        {
            if (questionExam.GetAmountQuestion() < 0) { InitTest(); return; }
            if (!(radioAnswer1.Checked || radioAnswer2.Checked || radioAnswer3.Checked || radioAnswer4.Checked))
            {
                MessageBox.Show("Выберите вариант ответа");
                return;
            }

            if ((radioAnswer1.Checked && radioAnswer1.Text == questionExam.GetArrayRight()) ||
                 (radioAnswer2.Checked && radioAnswer2.Text == questionExam.GetArrayRight()) ||
                 (radioAnswer3.Checked && radioAnswer3.Text == questionExam.GetArrayRight()) ||
                 (radioAnswer4.Checked && radioAnswer4.Text == questionExam.GetArrayRight()))
            {
                questionExam.SoundPlayCorrect();
                panelCorrect.Visible = true;
                labelCorrect.Visible = true;
                questionExam.RightAnswer();
                PanelPoint();
            }
            else
            {
                questionExam.SoundPlayNotCorrect();
                panelError.Visible = true;
                labelError.Visible = true;
                // MessageBox.Show("Правильный вариант ответа: " + questionExam.GetArrayRight());
                questionExam.NotAnswer();
                PanelPoint();
            }

            if(questionExam.GetNotAnswer() == 2 || labelTimerMin.Visible == false)
            {
                GetFail();
                return;
            }
            if (questionExam.GetAmountQuestion() < 0)
            {
                GetPass();
                return;
            }

            this.btnNext.Click -= new EventHandler(FirstAction);
            btnNext.Text = "Следующий вопрос";
            groupQuestion.Enabled = false;
            this.btnNext.Click += new EventHandler(SecondAction);
        }
        private void PanelPoint()
        {
            if (questionExam.I() == 1 && panelCorrect.Visible == true) { Point1.BackColor = Color.Lime; }
            if (questionExam.I() == 2 && panelCorrect.Visible == true) { Point2.BackColor = Color.Lime; }
            if (questionExam.I() == 3 && panelCorrect.Visible == true) { Point3.BackColor = Color.Lime; }
            if (questionExam.I() == 4 && panelCorrect.Visible == true) { Point4.BackColor = Color.Lime; }
            if (questionExam.I() == 5 && panelCorrect.Visible == true) { Point5.BackColor = Color.Lime; }
            if (questionExam.I() == 6 && panelCorrect.Visible == true) { Point6.BackColor = Color.Lime; }
            if (questionExam.I() == 7 && panelCorrect.Visible == true) { Point7.BackColor = Color.Lime; }
            if (questionExam.I() == 8 && panelCorrect.Visible == true) { Point8.BackColor = Color.Lime; }
            if (questionExam.I() == 9 && panelCorrect.Visible == true) { Point9.BackColor = Color.Lime; }
            if (questionExam.I() == 10 && panelCorrect.Visible == true) { Point10.BackColor = Color.Lime; }

            if (questionExam.I() == 1 && panelError.Visible == true) { Point1.BackColor = Color.Red; }
            if (questionExam.I() == 2 && panelError.Visible == true) { Point2.BackColor = Color.Red; }
            if (questionExam.I() == 3 && panelError.Visible == true) { Point3.BackColor = Color.Red; }
            if (questionExam.I() == 4 && panelError.Visible == true) { Point4.BackColor = Color.Red; }
            if (questionExam.I() == 5 && panelError.Visible == true) { Point5.BackColor = Color.Red; }
            if (questionExam.I() == 6 && panelError.Visible == true) { Point6.BackColor = Color.Red; }
            if (questionExam.I() == 7 && panelError.Visible == true) { Point7.BackColor = Color.Red; }
            if (questionExam.I() == 8 && panelError.Visible == true) { Point8.BackColor = Color.Red; }
            if (questionExam.I() == 9 && panelError.Visible == true) { Point9.BackColor = Color.Red; }
            if (questionExam.I() == 10 && panelError.Visible == true) { Point10.BackColor = Color.Red; }
        }

        private void GetPass()
        {
            solution.SolutionPass();
            SoundPlayer passExam = new SoundPlayer("E:\\!Study\\2sem\\!\\Sounds\\passExam.wav");
            labelResult.Text = "Правильных ответов: " + questionExam.GetRightAnswer().ToString() + "\n" +
            "Неправильных ответов: " + questionExam.GetNotAnswer().ToString();
            listQuestion.Visible = false;
            passExam.Play();
            labelTimerMin.Visible = false;
            btnNext.Text = "Отдыхать";
            GroupBoxCorrectFalse();
            this.btnNext.Click -= new EventHandler(FirstAction);
            this.btnNext.Click += new EventHandler(ActionClose);
            groupQuestion.Visible = false;
            groupBoxPass.Visible = true;
            groupBoxNotPass.Visible = false;
            PictureCheck();
            questionExam.GetNull();
            return;
        }

        private void GetFail()
        {
            solution.SolutionNotPass();
            SoundPlayer failExam = new SoundPlayer("E:\\!Study\\2sem\\!\\Sounds\\failExam.wav");
            failExam.Play();
            listQuestion.Visible = false;
            labelTimerMin.Visible = false;
            btnNext.Text = "Идти учить!";
            GroupBoxErrorFalse();
            groupQuestion.Visible = false;
            groupBoxNotPass.Visible = true;
            groupBoxPass.Visible = false;
            this.btnNext.Click -= new EventHandler(FirstAction);
            this.btnNext.Click += new EventHandler(ActionClose);
            questionExam.GetNull();
            PictureCheck();
            return;
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
            if (questionExam.GetArrayPicture() != "-")
            {
                pictureBox.Visible = true;
                pictureBox.Image = new Bitmap(questionExam.GetArrayPicture());
                groupQuestion.Location = new System.Drawing.Point(489, 197);
                groupQuestion.Size = new System.Drawing.Size(623, 258);
                listQuestion.Location = new System.Drawing.Point(489, 67);
                listQuestion.Size = new System.Drawing.Size(623, 258);
            }
        }

        private void PictureCheck()
        {
            groupQuestion.Location = new System.Drawing.Point(210, 213);
            groupQuestion.Size = new System.Drawing.Size(654, 258);
            listQuestion.Location = new System.Drawing.Point(210, 67);
            listQuestion.Size = new System.Drawing.Size(654, 95);
            pictureBox.Visible = false;
        }

        private void Timer()
        {
            timer1.Enabled = true;
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1;
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            quick--;
            labelTimerMin.Text = quick / 60 + ":" + ((quick % 60) >= 10 ? (quick % 60).ToString() : "0" + (quick % 60));
            if (quick == 0)
            {
                labelTimerMin.Visible = false;
                timer1.Enabled = false;
                GetFail();
            }
        }

        private void Exam_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            if (e.CloseReason != CloseReason.UserClosing) return;
            e.Cancel = DialogResult.Yes != main.ShowDialog();
        }

        private void labelTimerMin_Click(object sender, EventArgs e)
        {

        }

        private void Point1_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }
    }
}
