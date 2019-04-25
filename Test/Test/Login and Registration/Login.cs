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
    public partial class Login : Form
    {
        static public Authorization login = new Authorization();
        public Login()
        {
            InitializeComponent();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
        }

        private void buttonAutorization_Click(object sender, EventArgs e)
        {
            if (login.Login(textBoxLogin.Text, textBoxPassword.Text) == true)
            {
                login.Name = textBoxLogin.Text;
                Hide();
                FMain main = new FMain();
                main.ShowDialog();
                
            }
            else
                MessageBox.Show("Ошибка ввода!");
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";

        }
    }
}
