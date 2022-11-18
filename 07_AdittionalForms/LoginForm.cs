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
    public partial class LoginForm : Form
    {
        public LoginInfo Info { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            Info = new LoginInfo();
        }
        public LoginForm(LoginInfo info)
        {
            InitializeComponent();
            Info = info;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //1 - витягувати дані 
            //Info = new LoginInfo()
            //{
            //    Login = LoginTB.Text,
            //    Password = PasswordTB.Text
            //};
            //this.DialogResult = DialogResult.OK;
            //this.Close();

            //2 - передавати  дані
            if (string.IsNullOrWhiteSpace(LoginTB.Text) || string.IsNullOrWhiteSpace(PasswordTB.Text))
            {
                MessageBox.Show("Enter login or password ");
                return;
            }
            Info.Login = LoginTB.Text;
            Info.Password = PasswordTB.Text;
       
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
