using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp.BLL;
namespace Test
{
    public partial class FMain : Form
    {
        FSettingsAdmin setting = new FSettingsAdmin();

        public FMain()
        {
            InitializeComponent();
            UserToolStripMenuItem.Text = Login.login.Name;
            toolStripTextBox.Text = ExamSolution.Answer;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тут всё просто!");
        }



        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            setting.ShowDialog();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            groupTest.Visible = true;
            Back.Visible = true;
            groupPDD.Visible = false;
            Start.Visible = false;
            Settings.Visible = false;
            Exit.Location = new Point(550, 415);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            groupTest.Visible = false;
            groupPDD.Visible = true;
            Back.Visible = false;
            Start.Visible = true;
            Settings.Visible = true;
            Exit.Location = new Point(332, 415);
        }

        private void Training_Click(object sender, EventArgs e)
        {
            Hide();
            FChooseTest choose = new FChooseTest();
            choose.ShowDialog();

        }

        private void Exam_Click(object sender, EventArgs e)
        {
            Hide();
            Exam exam = new Exam();
            exam.ShowDialog();
        }

        private void FMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void UserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}