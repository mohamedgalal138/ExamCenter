using ExamCenter.business_logic.Student;
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



        public exam? _exam;

       readonly ListOfExamsLogic logic = new();

        public ListOfExams()
        {
            InitializeComponent();
        }

        public async Task HideCulomns()
        {

            ListExamView.Columns[1].Visible = false;
            ListExamView.Columns[2].Visible = false;
            ListExamView.Columns[3].Visible = false;
            ListExamView.Columns[4].Visible = false;
            ListExamView.Columns[5].Visible = false;
            ListExamView.CurrentCell = null;
        }

        private async void ListOfExams_Load(object sender, EventArgs e)
        {

            await logic.LoadExams(ListExamView);
            await HideCulomns();
        }

        private void BtnSideBar_Click(object sender, EventArgs e)
        {
            if (BtnSideBar.Text == ">")
            {
                this.Controls.Add(panel3);
                BtnSideBar.Text = "<";
            }
            else if (BtnSideBar.Text == "<")
            {
                this.Controls.Remove(panel3);
                BtnSideBar.Text = ">";
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnStart_Click_1(object sender, EventArgs e)
        {
            if (ListExamView.CurrentCell == null)
            {
                MessageBox.Show("Select Exam Firts To Start");
            }
            else
            {
                DoExam _doExam = new(new exam()
                {
                    Title = ListExamView.CurrentRow.Cells[0].Value.ToString() ?? "Unkown",
                    Exam_ID = (int)ListExamView.CurrentRow.Cells[1].Value,
                    Course_ID = (int)ListExamView.CurrentRow.Cells[2].Value,
                    Duration = (int)ListExamView.CurrentRow.Cells[4].Value,

                });
                _doExam.Show();
                this.Hide();
            }

        }

        private void ListExamView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ExamTitle.Text = ListExamView.CurrentRow.Cells[0].Value.ToString();
            CourseName.Text = ListExamView.CurrentRow.Cells[3].Value.ToString();
            ExamDuration.Text = ListExamView.CurrentRow.Cells[4].Value.ToString();
            CountOfQuestions.Text = ListExamView.CurrentRow.Cells[5].Value.ToString();

        }
    }
}
