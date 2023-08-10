using ExamCenter.business_logic.Student;
using ExamCenter.Logic.LogIn;
using ExamCenter.Pages.Admin;
using ExamCenter.Pages.Student;
using ExamCenter.View.Custom_Component;
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

        public static int StudentId;
        public LogIn()
        {
            InitializeComponent();
        }

        public async void LOGIN(Object o, EventArgs e)
        {
            Loader loader = new(this.Width, this.Height);
            this.Controls.Add(loader.panel);
            if (UserName.Text.ToLower() == "admin" && PassWord.Text == "12345")
            {
                EditeAndDeleteExam Home = new EditeAndDeleteExam();
                this.Controls.Remove(loader.panel);
                MessageBox.Show("Welcome....");
                Home.Show();
                this.Hide();
            }
            else
            {
                LogInLogic logic = new LogInLogic();
                StudentId = await logic.Login(UserName.Text, PassWord.Text);
                DoExamLogic doExam = new()
                {
                 StudentID = StudentId,
                };
                this.Controls.Remove(loader.panel);
                if (StudentId == 0)
                {
                    MessageBox.Show("Opppps....\nUser Name Or PassWord Is Wrong");
                }
                else
                {
                    ListOfExams Home = new();
                    this.Controls.Remove(loader.panel);
                    Home.Show();
                    this.Hide();
                }
               
            }

        }

        public void SignUp(Object o, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }


    }
}
