using ExamCenter.Data;
using ExamCenter.Logic.Student;
using ExamCenter.Models;
using ExamCenter.View.Custom_Component;
using ExamCenter.Viwe.Student;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamCenter.View.Student
{
    public partial class DegreeOfExam : Form
    {
        exam exam;

        DegreeOfExmaLogic _Logic = new();

        QuestionsCorrect QuestionsCorrect = new();

        public DegreeOfExam(exam _exam)
        {
            InitializeComponent();
            this.exam = _exam;
        }

        private async void DegreeOfExam_Load(object sender, EventArgs e)
        {
            labelStudentDegree.Text += QuestionsCorrect.Degree.ToString();
            labelExamDegree.Text += await _Logic.ExamDegree(exam.Exam_ID);
            labelStudentName.Text += await _Logic.GetStudentName(LogIn.StudentId);
            labelExamName.Text += await _Logic.GetExamTitle(exam.Exam_ID);
            labelCourseName.Text += await _Logic.GetCourseName(exam.Exam_ID);
            await QuestionsCorrect.CreatePanel(PanelQuestions, exam);
        }


    }
}
