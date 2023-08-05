using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamCenter.Data;
using ExamCenter.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamCenter.Pages.Admin
{
    public partial class AddNewEX : Form
    {

        readonly Context _context = new();

        List<RadioButton> MCQAnswerList = new List<RadioButton>();

        List<RadioButton> TrueOrFalseAnswerList = new List<RadioButton>();

        public AddNewEX()
        {
            InitializeComponent();
            AddTruOrFalAnswerToList();

        }

        public void AddTruOrFalAnswerToList()
        {
            TrueOrFalseAnswerList.Add(TrueAnswer);
            TrueOrFalseAnswerList.Add(FalseAnswer);
        }

        public void LoadCouresName()
        {
            var course = _context.Courses.ToList();
            foreach (var item in course)
            {
                CourseName.Items.Add(item.Course_Name);
                CourseName.DisplayMember = item.Course_Name;
                CourseName.Text = item.Course_Name;
                CourseName.ValueMember = item.course_ID.ToString();
            }
        }

        private void AddNewEX_Load(object sender, EventArgs e)
        {
            LoadCouresName();

        }

        public int GetLastExamId()
        {
            
           var exam = _context.Exams.OrderBy(e => e.Exam_ID).LastOrDefault();
            return exam.Exam_ID;
        }

        public int GetLastQuestionID()
        {
            int id;
            question question = new question();
            question = _context.Questions.OrderBy(e => e.Que_ID).LastOrDefault();
            id = question.Que_ID;
            return id;
        }

        public void AddExam()
        {

            var exam = new exam
            {
                Title = Title.Text,
                Duration = (int)Duration.Value,
                Course_ID = CourseName.SelectedIndex + 1,
                Created_Date = DateTime.Now
            };
            _context.Exams.Add(exam);
            _context.SaveChanges();
            MessageBox.Show("Done....");

        }

        public void AddExamQuestions()
        {

            int exam_id = GetLastExamId();

            question question = new question()
            {
                Title = QuestionHead.Text,
                Mark = (int)Mark.Value,
                Exam_ID = exam_id,
            };

            _context.Questions.Add(question);
            _context.SaveChanges();
        }

        public void AddTruOrFalAnswerQuestion()
        {
            int ques_Id = GetLastQuestionID();
            foreach (var item in TrueOrFalseAnswerList)
            {
                answer Answer = new answer();
                Answer.Value = item.Checked.ToString();
                if (item.Checked)
                {
                    Answer.IScorrect = 1;
                }
                Answer.Question_ID = ques_Id;
                _context.Answers.Add(Answer);
            }
            _context.SaveChanges();

            MessageBox.Show("Adding Question is Done.....");
        }

        public void AddMCQAnswerQuestion()
        {
            int id = GetLastQuestionID();

            foreach (var item in MCQAnswerList)
            {
                answer Answer = new answer();
                Answer.Value = item.Text;
                if (item.Checked)
                {
                    Answer.IScorrect = 1;
                }
                Answer.Question_ID = id;
                _context.Answers.Add(Answer);
            }
            _context.SaveChanges();

            MessageBox.Show("Adding Answers Is Done......");
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Title.Text) || string.IsNullOrEmpty(Title.Text) || Duration.Value == 0)
            {
                this.Opacity = 50;
                MessageBox.Show("You Can Not Add Exam Without Title Or Duration");
            }
            else
            {
                AddExam();
                // ClearExamForm();
                //butSave.Enabled = false;
                //Title.ReadOnly = true;
                //Duration.ReadOnly = true;
                //CourseName.Enabled = false;
                NewExam.Enabled = false;
                panelExamQuestionForm.Enabled = true;
                butAddQuestion.Enabled = true;
            }
        }

        public void ClearExamForm()
        {
            Title.Text = string.Empty;
            Duration.Value = 0;
        }

        public void ClearQuestionForm()
        {
            QuestionHead.Text = string.Empty;
            Mark.Value = 0;
            //TrueAnswer.Checked = false;
            //FalseAnswer.Checked = false;
            AddNewEX eX = new();

        }

        public void RemovChecked()
        {
            TrueOrFalseAnswerList.ForEach((item) => item.Checked = false);
        }

        private void butAddQuestion_Click(object sender, EventArgs e)
        {

            QuestionPanel.Enabled = true;
            MarkPanel.Enabled = true;
            TypeQuesPanel.Enabled = true;
            QuestionHead.Text = string.Empty;
            Mark.Value = 0;
            flowLayoutPanel1.Visible = false;
            panelTruFalAnswer.Visible = false;
            butAddQuestion.Enabled = false;
            
        }

        private void butAddQueAns_Click(object sender, EventArgs e)
        {

            bool flag1 = true;
            bool flag2 = true;
            flag2 = MCQAnswerList.Any((item) => item.Checked);
            flag1 = TrueOrFalseAnswerList.Any((item) => item.Checked);

            if (TypeOfQuestion.SelectedIndex != 0 && TypeOfQuestion.SelectedIndex != 1)
            {
                MessageBox.Show("You Can Not Adding Question Without Chosie Type Of Question \nPlease Chosie Type First");
            }
            else if (Mark.Value == 0)
            {
                MessageBox.Show("You Can Not Adding Question Without Mark \nPlease Add Mark First");
            }
            else if (string.IsNullOrEmpty(QuestionHead.Text) || string.IsNullOrWhiteSpace(QuestionHead.Text))
            {
                MessageBox.Show("You Can Not Adding Question Without Question Head \nPlease Add Question Head First");

            }
            else if (TypeOfQuestion.SelectedIndex == 0 && flag1 == false)
            {
                MessageBox.Show("You Can Not Adding Question Without Choice Right Answer  \nPlease Choice Right Answer First");
            }
            else if (TypeOfQuestion.SelectedIndex == 1 && flag2 == false)
            {
                MessageBox.Show("You Can Not Adding Question Without Choice Right Answer  \nPlease Choice Right Answer First");
            }
            else
            {
                AddExamQuestions();
                if (TypeOfQuestion.SelectedIndex == 0)
                {
                    AddTruOrFalAnswerQuestion();
                    RemovChecked();
                    panelTruFalAnswer.Visible = false;

                }
                else
                {
                    AddMCQAnswerQuestion();
                    MCQAnswerList.Clear();
                    flowLayoutPanel1.Controls.Clear();
                    MCQAnswerValue.Visible = false;
                    flowLayoutPanel1.Visible = false;
                    butAddAnswer.Visible = false;
                }

                ClearQuestionForm();
                butFinishingExam.Enabled = true;
                butAddQuestion.Enabled = true;
                QuestionPanel.Enabled = false;
                MarkPanel.Enabled = false;
                TypeQuesPanel.Enabled = false;
            }

        }

        private void TypeOfQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeOfQuestion.SelectedIndex == 0)
            {
                panelTruFalAnswer.Location = new Point(112, 361);
                flowLayoutPanel1.Visible = false;
                panelTruFalAnswer.Visible = true;
                butAddAnswer.Visible = false;
                MCQAnswerValue.Visible = false;


            }
            else if (TypeOfQuestion.SelectedIndex == 1)
            {
                flowLayoutPanel1.Visible = true;
                MCQAnswerValue.Visible = true;
                panelTruFalAnswer.Visible = false;
                butAddAnswer.Visible = true;

            }

        }

        private void butAddAnswer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MCQAnswerValue.Text))
            {
                MessageBox.Show("Can Not Adding Empty Answer");
            }
            else
            {
                AnswerRow answer = new AnswerRow(MCQAnswerValue.Text, flowLayoutPanel1);
                flowLayoutPanel1.Controls.Add(answer.radio);
                flowLayoutPanel1.Controls.Add(answer.delete);
                MCQAnswerList.Add(answer.Add());
                MCQAnswerValue.Text = string.Empty;
                MCQAnswerValue.Focus();
            }

        }

        private void QuestionHead_TextChanged(object sender, EventArgs e)
        {
            if (QuestionHead.TextLength > 0)
            {
                // TypeOfQuestion.Enabled = false;
            }
        }

        private void butFinishingExam_Click(object sender, EventArgs e)
        {
            string message = "Do You Want Add New Exam?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                NewExam.Enabled = true;
                panelExamQuestionForm.Enabled = false;
                ClearExamForm();
                Title.Focus();
            }
            else if (result == DialogResult.No)
            {

                EditAndDeleteEX edit = new EditAndDeleteEX();
                edit.Show();
                this.Close();
            }


        }

    }
}
