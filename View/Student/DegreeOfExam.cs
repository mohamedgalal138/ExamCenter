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
        Context _context = new();
        
        DegreeOfExmaLogic _Logic = new();
        QuestionsCorrect QuestionsCorrect = new();
        public DegreeOfExam()
        {
            InitializeComponent();
          
        }

        private async void DegreeOfExam_Load(object sender, EventArgs e)
        {

            await QuestionsCorrect.CreatePanel(PanelQuestions);
            labelStudentName.Text += await _Logic.GetStudentName(LogIn.StudentId);
            //var id = await _context.Student_answers.Where(s => s.Student_Std_ID == 6).Select(q => q.Question_Que_ID).FirstOrDefaultAsync();
            labelExamName.Text += await _Logic.GetExamTitle(LogIn.StudentId);
            labelCourseName.Text += await _Logic.GetCourseName(LogIn.StudentId);
        }
    }
}
