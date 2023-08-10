using ExamCenter.business_logic.Student;
using ExamCenter.Data;
using ExamCenter.Logic.Student;
using ExamCenter.Models;
using ExamCenter.View.Student;
using ExamCenter.Viwe.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamCenter.Pages.Student
{
    public partial class DoExam : Form
    {

        public exam exam;

        DoExamLogic logic = new();

        public ExamForm examForm;

        int Secounds = 60;

        int mints;
        public DoExam(exam _exam)
        {
            InitializeComponent();
            this.exam = _exam;
            examForm = new ExamForm(exam);
            label1.Text = Secounds.ToString();
            mints = exam.Duration - 1;
            timer.Start();
        }
        private void DoExam_Load(object sender, EventArgs e)
        {
            panel2.Controls.Add(examForm.MainPanel);
            LoadDuration();
            loadExamTitle();
            loadExamCourse(exam.Course_ID);
        }

        public void loadExamTitle()
        {
            label3.Text += exam.Title.ToString();

        }

        public void LoadDuration()
        {
            label5.Text = mints.ToString();
        }

        public void loadExamCourse(int courseexamid)
        {
            label4.Text += logic.GetCourse(courseexamid)?.Course_Name.ToString() ?? "No Courses found.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListOfExams listOfExams = new ();
            listOfExams.Show();
            this.Close();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
           
            var x = examForm.AnswersRadioButton.Where(a => a.Checked == true).ToList();
            

            examForm.questions.ForEach(async a =>
            {
                a.StudentAnswerString =  x.Where(b => b.Name == a.Que_ID.ToString()).FirstOrDefault().Text;
              
            });


            await logic.SubmitExam(examForm.questions );
            DegreeOfExam degreeOfExam = new();
            degreeOfExam.Show();
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            label1.Text = Secounds--.ToString();
            if (Secounds == 0)
            {
                Secounds = 60;
                label5.Text = (--mints).ToString();
            }

            if (mints < 0 && Secounds == 0)
            {
                timer.Stop();
                ListOfExams listOfExams = new();
                listOfExams.Show();
                this.Close();
            }
        }

 
    }
}
