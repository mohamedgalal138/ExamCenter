using ExamCenter.Data;
using ExamCenter.Models;
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

        public exam exam = new();

        //public List<student_answer> students = new List<student_answer>();

        public student_answer _student_Answer;

        public student_exam _student_Exam;

        Context _context = new();

        int Secounds = 60;

        int mints;

        public ExamForm examForm;
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
            var course = _context.Courses.Where(c => c.course_ID == courseexamid).FirstOrDefault();
            label4.Text += course.Course_Name.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListOfExams listOfExams = new ListOfExams();
            listOfExams.Show();
            this.Close();
        }

        private  void button2_Click(object sender, EventArgs e)
        {

            var questions = examForm.questions;
            MessageBox.Show("count =" + questions.Count);

            foreach (var item in questions)
            {
                
                var answers = _context.Answers.Where(a => a.Question_ID == item.Que_ID).ToList();

                foreach(var answ in answers)
                {
                    var answers1 = examForm.AnswersRadioButton;
                    foreach (var answer in answers1)
                    {
                        _student_Answer = new();
                        if (answer.Checked == true)
                        {
                            _student_Answer.Student_Std_ID = 1;
                            _student_Answer.Question_Que_ID = item.Que_ID;
                            _student_Answer.Student_Answer = answer.Text;
                            _context.Student_answers.Add(_student_Answer);
                            
                        }

                    }
                }
                

            }
            _context.SaveChanges();


            //await _context.Student_answers.AddRangeAsync(examForm.questions.ConvertAll(x => new student_answer()
            //{
            //    Question_Que_ID = x.Que_ID,
            //    Student_Answer = x.Student_Answer.,
            //    Student_Std_ID = 1,
            //}));
            //_context.SaveChanges();
        }

        private void label5_Click(object sender, EventArgs e)
        {

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
                ListOfExams listOfExams = new ListOfExams();
                listOfExams.Show();
                this.Close();
            }
        }

        private void label5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
