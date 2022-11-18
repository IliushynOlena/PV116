using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_AdittionalForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Open Form
            //SecondForm form = new SecondForm();            
            ////form.Show();
            //form.ShowDialog();
            //1
            string name = NameTB.Text;
            //SecondForm form = new SecondForm(name);         
            //form.ShowDialog();
            //2
            //SecondForm form = new SecondForm();
            //form.UserName = name;
            //form.Show();
            //3
            SecondForm form = new SecondForm();
            form.Show(name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //1
            //LoginInfo info = null;

            //LoginForm login = new LoginForm();
            //if ( login.ShowDialog() == DialogResult.OK)
            //{
            //    info = login.Info;
            //    loginLb.Text = info.Login;
            //    PasswordLb.Text = info.Password;
            //}

            LoginInfo info = new LoginInfo();

            LoginForm login = new LoginForm(info);
            if (login.ShowDialog() == DialogResult.OK)
            { 
                loginLb.Text = info.Login;
                PasswordLb.Text = info.Password;
            }


        }
    }
}
