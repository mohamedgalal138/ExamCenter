using ExamCenter.Data;
using ExamCenter.Logic.Admin;
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

namespace ExamCenter.Pages.Admin
{
    public partial class EditeAndDeleteExam : Form
    {
        Context _context = new();

        private int examid;
        public EditeAndDeleteExam()
        {
            InitializeComponent();
            ExamList.CurrentCell = null;
        }

        public async Task HideCulomns()
        {
            ExamList.Columns[0].Visible = false;
            ExamList.Columns[2].Visible = false;
            ExamList.Columns[3].Visible = false;
            ExamList.Columns[4].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "<")
            {
                this.Controls.Remove(panel1);

                button1.Text = ">";
            }
            else if (button1.Text == ">")
            {
                this.Controls.Add(panel1);
                button1.Text = "<";
            }
        }

        private async void EditeAndDeleteExam_Load(object sender, EventArgs e)
        {
            EditeAndDeleteExamLogic logic = new();
            await logic.LoadExams(ExamList);
            await HideCulomns();
            ExamList.CurrentCell = null;
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Close();
        }

        private void ExamList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var CoursName = _context.Courses.Where(c => c.course_ID == (int)ExamList.CurrentRow.Cells[3].Value).FirstOrDefault();
            CourseName.Text = CoursName.Course_Name.ToString();
            ExamDuration.Text = ExamList.CurrentRow.Cells[2].Value.ToString();
            ExamTitle.Text = ExamList.CurrentRow.Cells[1].Value.ToString();
            CountOfQuestions.Text = ExamList.CurrentRow.Cells[4].Value.ToString();
            ExamList.CurrentCell = null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            AddNewExam newEX = new AddNewExam();
            newEX.Show();
            this.Close();
        }

        private async void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (ExamList.Rows.Count == 0)
            {
                MessageBox.Show("List Of Exams Is Empty...");
            }
            else
            {
                examid = (int)ExamList.CurrentRow.Cells[0].Value;
                EditeAndDeleteExamLogic Logic = new();
                bool flag = await Logic.DeleteExam(examid);
                if (flag)
                {
                    MessageBox.Show("The Exam is Deleted");
                    await Logic.LoadExams(ExamList);
                    await HideCulomns();
                }
                else
                {
                    MessageBox.Show("Ooooops...\n  The Exam is Not Deleted");
                }

            }

        }
    }
}
