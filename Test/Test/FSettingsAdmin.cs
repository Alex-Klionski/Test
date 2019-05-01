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
    public partial class FSettingsAdmin : Form
    {
        public FSettingsAdmin()
        {
            InitializeComponent();
            CheckOnAdmin();
        }
        private void CheckOnAdmin()
        {
            if(Login.login.Name == "admin")
            {
                dataGridView1.Visible = true;
                bindingNavigator1.Visible = true;
            }
            else
            {
                checkBoxRight.Location = new Point(120, 78);
                checkBoxNotRight.Location = new Point(120, 110);
            }
        }
        private void FSettings_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Questions". При необходимости она может быть перемещена или удалена.
            this.questionsTableAdapter.Fill(this.databaseDataSet.Questions);

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            this.questionsTableAdapter.Update(this.databaseDataSet.Questions);

            if(checkBoxRight.Checked == true)
            {
                FChooseTest.question.SoundStopCorrect();
                Exam.questionExam.SoundStopCorrect();
            }

            if(checkBoxNotRight.Checked == true)
            {
                FChooseTest.question.SoundStopNotCorrect();
                Exam.questionExam.SoundStopNotCorrect();
            }

        }

        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void questionsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
