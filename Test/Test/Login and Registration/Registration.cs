using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "usersDataSet.user". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.usersDataSet.user);
            this.usersDataSet.user.AdduserRow(this.usersDataSet.user.NewuserRow());
            userBindingSource.MoveLast();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            userBindingSource.MoveNext();
            this.userTableAdapter.Update(this.usersDataSet.user);
            userBindingSource.EndEdit();
            Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.usersDataSet.user.AdduserRow(this.usersDataSet.user.NewuserRow());
            userBindingSource.MoveLast();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
        }

    }
}
