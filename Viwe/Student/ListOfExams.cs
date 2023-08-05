using ExamCenter.Data;
using ExamCenter.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamCenter.Pages.Student
{
    public partial class ListOfExams : Form
    {

        Context _context = new();
        public exam _exam;


        public ListOfExams()
        {
            InitializeComponent();
        }

        public void HideCulomns()
        {
            ListExamView.Columns[0].Visible = false;
            ListExamView.Columns[2].Visible = false;
            ListExamView.Columns[3].Visible = false;
            ListExamView.Columns[4].Visible = false;

        }

        private void ListOfExams_Load(object sender, EventArgs e)
        {

            LoadExam();
            HideCulomns();
        }

        public void LoadExam()
        {
            var exams = from e in _context.Exams
                        select new
                        {
                            id = e.Exam_ID,

                            ExamTitle = e.Title,

                            duration = e.Duration,

                            course = e.Course_ID,

                            countOfQuestions = e.questions.Count,

                        };

            ListExamView.DataSource = exams.ToList();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (button5.Text == ">")
            {
                ListOfExams.ActiveForm.Controls.Add(panel3);
                button5.Text = "<";

            }
            else if (button5.Text == "<")
            {
                ListOfExams.ActiveForm.Controls.Remove(panel3);
                button5.Text = ">";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            _exam = new()
            {
                Exam_ID = (int)ListExamView.CurrentRow.Cells[0].Value,
                Course_ID = (int)ListExamView.CurrentRow.Cells[3].Value,
                Title = ListExamView.CurrentRow.Cells[1].Value.ToString(),
                Duration = (int)ListExamView.CurrentRow.Cells[2].Value,

            };
            // ExamForm examForm = new ExamForm(_exam);
            DoExam _doExam = new(_exam);
            _doExam.Show();
            this.Hide();
        }


        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var CoursName = _context.Courses.Where(c => c.course_ID == (int)ListExamView.CurrentRow.Cells[3].Value).FirstOrDefault();
            CourseName.Text = CoursName.Course_Name.ToString();
            ExamDuration.Text = ListExamView.CurrentRow.Cells[2].Value.ToString();
            ExamTitle.Text = ListExamView.CurrentRow.Cells[1].Value.ToString();
            CountOfQuestions.Text = ListExamView.CurrentRow.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
