using ExamCenter.Data;
using ExamCenter.Logic.Student;
using ExamCenter.Models;
using ExamCenter.Viwe.Student;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCenter.View.Custom_Component
{
    public class QuestionsCorrect
    {

        public  int Degree ;

        readonly DegreeOfExmaLogic Logic = new ();
       

        public Panel? MainPanel ;
        public Label? QuestionsLabel ;
        public TextBox? QuestionsText ;
        public Label? AnswerLabel ;
        public RadioButton? AnswerButton ;
        public FlowLayoutPanel? flow1;
        public Label? Right;
        public Label? Wrong;
        public Label? StudentAnswerLabel;
        public Label? StudentAnswerValue;
        public Label? QuestionMarkLabel;
        public Label? Mark;
        
        public QuestionsCorrect() 
        {
            
        }

        public async Task AddControls()
        {

            MainPanel.Controls.Add(QuestionsLabel);
            MainPanel.Controls.Add(QuestionsText);
            MainPanel.Controls.Add(AnswerLabel);
            MainPanel.Controls.Add(flow1);
            MainPanel.Controls.Add(Right);
            MainPanel.Controls.Add(Wrong);
            MainPanel.Controls.Add(StudentAnswerLabel);
            MainPanel.Controls.Add(StudentAnswerValue);
            MainPanel.Controls.Add(QuestionMarkLabel);
            MainPanel.Controls.Add(Mark);
        }

        public async Task CreatePanel(FlowLayoutPanel flow , exam exam)
        {
            
            var studentanswers = await Logic.GetAllQuestions(LogIn.StudentId, exam.Exam_ID);
           
            foreach (var item in studentanswers)
            {
                var questiontitle = await Logic.GetQuestionsID(item.Question_Que_ID);


                MainPanel = new()
                {
                    Margin = new(6),
                    Padding = new(6),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White,
                    ForeColor = Color.Black,
                    AutoSize = true,
                    MinimumSize = new()
                    {
                        Height = 500
                    },
                   // Dock = DockStyle.Fill,
                    Height = 600,

                };
                QuestionsLabel = new()
                {
                    Top = 0,
                    Left = 0,
                    Text = "Question",
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12),
                };
                QuestionsText = new()
                {
                    Top = 20,
                    Left = 100,
                    Text = questiontitle?.Title,
                    Font = new Font("Segoe UI", 14),
                    Width = 800,
                    Height = 100,
                    Multiline = true,
                    ReadOnly = true,
                };
                AnswerLabel = new()
                {
                    Top = 130,
                    Left = 0,
                    Text = "Answers",
                    Font = new Font("Segoe UI", 12),
                };
                flow1 = new()
                {
                    AutoScroll = true,
                    AutoSize = true,
                    FlowDirection = FlowDirection.TopDown,
                    Top = 180,
                    Left = 100,
                    WrapContents = false,
                    MinimumSize = new(400, 100),
                    BackColor = Color.White,


                };
                Wrong = new()
                {
                    Text = "Wrong",
                    BackColor = Color.Red,
                    Top = 450,
                    Left = 700,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12),
                    TextAlign = ContentAlignment.MiddleCenter,

                };
                Right = new()
                {
                    Text = "Right",
                    BackColor = Color.Green,
                    Top = 450,
                    Left = 800,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12),
                    TextAlign = ContentAlignment.MiddleCenter,
                };
                StudentAnswerLabel = new()
                {
                    Text = "Your Answer : ",
                    AutoSize = true,
                    Top = 400,
                    Left = 0,
                    Font = new Font("Segoe UI", 12),
                };
                StudentAnswerValue = new()
                {

                    Text = item.Student_Answer?? "Empty",
                    AutoSize = true,
                    Top = 400,
                    Left = 150,
                    Font = new Font("Segoe UI", 12),
                };
                QuestionMarkLabel = new()
                {
                    Text = "Your Mark : " ,
                    AutoSize = true,
                    Top = 450,
                    Left = 0,
                    Font = new Font("Segoe UI", 12),
                };
                Mark = new()
                {
                    AutoSize = true,
                    Top = 450,
                    Left = 150,
                    Font = new Font("Segoe UI", 12),
                };

                var answers = await Logic.GetAnswers(item.Question_Que_ID);

                foreach (var answer in answers)
                {
                  
                    AnswerButton = new()
                    {
                        Left = 200,
                        Text = answer.Value,
                        AutoSize = true,
                        AutoCheck = false,
                        Checked = false,
                        Padding = new(3),
                        Margin = new(3),
                    };
                
                    if (answer.IScorrect == 1)
                    {
                        AnswerButton.BackColor = Color.Green;
                        AnswerButton.Checked = true;

                        if (item.Student_Answer == answer.Value)
                        {
                            AnswerButton.Checked = true;
                            AnswerButton.BackColor = Color.Green;
                            StudentAnswerValue.BackColor = Color.Green;
                            Right.Visible = true;
                            Wrong.Visible = false;
                            Mark.Text = questiontitle?.Mark.ToString();
                            Degree += questiontitle.Mark;
                            MessageBox.Show(" d = " + Degree);
                        }

                        else
                        {
                            
                            AnswerButton.BackColor= Color.Red;
                            StudentAnswerValue.BackColor = Color.Red;
                            Right.Visible = false;
                            Wrong.Visible = true;
                            Mark.Text = "0";
                        }
                    }  

                    else
                    {
                        AnswerButton.BackColor = Color.White;
                    }

                  

                    flow1.Controls.Add(AnswerButton);
                    await AddControls();
                }
                flow.Controls.Add(MainPanel);

            }
           
        }
    }
}
