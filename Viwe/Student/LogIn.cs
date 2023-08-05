using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamCenter.Viwe.Student
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }



        public void LOGIN(Object o, EventArgs e)
        {


        }

        public void SignUp(Object o, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }
    }
}
