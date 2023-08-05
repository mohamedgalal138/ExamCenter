using ExamCenter.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamCenter.Pages.Admin
{
    public partial class EditAndDeleteEX : Form
    {
        Context _context = new();
        public EditAndDeleteEX()
        {
            InitializeComponent();
            LoadExam();

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

            ExamList.DataSource = exams.ToList();
            HideCulomns();
        }

        public void HideCulomns()
        {
            ExamList.Columns[0].Visible = false;
            ExamList.Columns[2].Visible = false;
            ExamList.Columns[3].Visible = false;
            ExamList.Columns[4].Visible = false;

        }

        public void DeleteExam()
        {
            if(ExamList.RowCount == 0)
            {
                MessageBox.Show(" List Of Exams Is Empty");
            }
            else
            {
                int id = (int)ExamList.CurrentRow.Cells[0].Value;
                var questionexam = _context.Exams.Where(e => e.Exam_ID == id).FirstOrDefault().questions;
                if (questionexam != null)
                {
                    foreach (var question in questionexam)
                    {
                        var answers = _context.Answers.Where(e => e.Question_ID == question.Que_ID).ToList();
                        _context.Answers.RemoveRange(answers);
                        _context.Questions.Remove(question);

                    }
                    var exam = _context.Exams.Where(e => e.Exam_ID == id).FirstOrDefault();
                    _context.Exams.Remove(exam);
                    _context.SaveChanges();

                }
                else
                {
                    var exam = _context.Exams.Where(e => e.Exam_ID == id).FirstOrDefault();
                    _context.Exams.Remove(exam);
                    _context.SaveChanges();
                }
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewEX newEX = new AddNewEX();
            newEX.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteExam();
            LoadExam();
        }

        private void ExamList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var CoursName = _context.Courses.Where(c => c.course_ID == (int)ExamList.CurrentRow.Cells[3].Value).FirstOrDefault();
            CourseName.Text = CoursName.Course_Name.ToString();
            ExamDuration.Text = ExamList.CurrentRow.Cells[2].Value.ToString();
            ExamTitle.Text = ExamList.CurrentRow.Cells[1].Value.ToString();
            CountOfQuestions.Text = ExamList.CurrentRow.Cells[4].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "<")
            {
                EditAndDeleteEX.ActiveForm.Controls.Remove(panel1);

                button1.Text = ">";
            }
            else if (button1.Text == ">")
            {

                EditAndDeleteEX.ActiveForm.Controls.Add(panel1);
                button1.Text = "<";
            }
        }
    }
}
