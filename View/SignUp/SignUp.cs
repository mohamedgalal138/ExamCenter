using ExamCenter.business_logic.SignUp;
using ExamCenter.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamCenter.Viwe.Student
{
    public partial class SignUp : Form
    {

        public SignUp()
        {
            InitializeComponent();
        }


        public async void Submit(Object o, EventArgs e)
        {
            Loader loader = new Loader(this.Width, this.Height);
            Controls.Add(loader.panel);
            Regex Email = new(@"^[A-Za-z]\w+\@\w+\.\w+");
            Regex FullName = new(@"^[A-Za-z]\w+\s\w+");
            if (!FullName.IsMatch(NameText.Text))
            {
                MessageBox.Show("This FullName Is Not Valid....");
                Controls.Remove(loader.panel);
            }
            else if (!Email.IsMatch(EmailText.Text))
            {
                MessageBox.Show("This E-mail Is Not Valid....");
                Controls.Remove(loader.panel);
            }
            else if (PassWordText.Text.Length <= 5 || PassWordText.Text.Length >= 11)
            {
                MessageBox.Show("PassWord Should be MoreThan> 5 and LessThan < 10");
                Controls.Remove(loader.panel);
            }
            else
            {
                SignUpLogic Logic = new SignUpLogic(NameText.Text, EmailText.Text, PassWordText.Text);
                bool flag = await Logic.AddNewStudent();
                Controls.Remove(loader.panel);
                if (flag != true) MessageBox.Show("This Email is Exsit");
                else
                {
                    MessageBox.Show("Sucsessfully");
                    LogIn logIn = new LogIn();
                    logIn.Show();
                    this.Close();
                }
            }
        }

    }
}
