﻿using ExamCenter.Data;
using ExamCenter.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ExamCenter.Pages
{
    public class ExamForm
    {
       
        int index = 0;

        public exam exam = new();

        public Context _context = new();

        public RadioButton? answer;

        public List<question> questions = new List<question>();

        public List<answer> answerList = new List<answer>();

        public List<RadioButton> AnswersRadioButton = new List<RadioButton>();

         Button Next = new()
        {
            BackColor = Color.CadetBlue,
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point),
            Location = new Point(581, 408),
            Name = "button3",
            Size = new Size(128, 33),
            TabIndex = 21,
            Text = "Next >>",
            UseVisualStyleBackColor = false,
          
        };

         Label? AnswersLabel;

         Button Previous = new()
        {
            BackColor = Color.CadetBlue,
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point),
            Location = new Point(149, 408),
            Name = "button4",
            Size = new Size(128, 33),
            TabIndex = 22,
            Text = "<< previous",
            UseVisualStyleBackColor = false,
           
        };

        public Panel MainPanel = new()
        {
            Dock = DockStyle.Fill,
            BorderStyle = BorderStyle.FixedSingle,
            Anchor = AnchorStyles.Top | AnchorStyles.Left,
            Name = "MainPanel",

        };

        public List<Panel> panels = new List<Panel>();
     
        public ExamForm ( exam _exam)
        {
            this.exam = _exam;

            MainPanel.Controls.Add(Next);
            MainPanel.Controls.Add(Previous);
            LoadQuestionAndAnswer();
            Next.Click += NextPage;
            Previous.Click += PreviousPage; 
            Previous.Visible = false;
        }
        public void NextPage(object sender , EventArgs e)
        {


            if(index == panels.Count - 2)
            {
                panels[++index].BringToFront();
                Next.Visible = false;
            }
            else
            {
                panels[++index].BringToFront();
                Next.Visible = true;
                Previous.Visible = true;
            }
        }

        public void PreviousPage(object sender, EventArgs e)
        {
                if (index > 0)
                {
                    panels[--index].BringToFront();
                    Previous.Visible = true;
                     Next.Visible = true;

                }
                else if(index == panels.Count)
                {
                  panels[--index].BringToFront();
                  Previous.Visible = false;
                }      
        }

        public async void LoadQuestionAndAnswer()
        {
            var Questions =  _context.Questions.Where(Q =>Q.Exam_ID == exam.Exam_ID).ToList();
            foreach(var Quest in Questions) 
            {
                FlowLayoutPanel FlowPanel= new()
                {
                    BackColor = Color.White,
                    Top = 80,
                    Left = 140,
                    Margin = new(0),
                    Padding = new(0),
                    Height = 200,
                    Width = 676,
                    AutoScroll = true,
                    FlowDirection = FlowDirection.TopDown,
                };

                Panel ChildQueAndAnwPanel = new()
                {
                            Dock = DockStyle.None,
                            Top = 0,
                            Height = 350,
                            Width = 957,
                            BackColor = Color.Aqua,
                            AutoScroll = true,
                            Name = "ChildQuesPane",
                };

                Label QuestionLabel = new()
                  {
                      Text = "Question",
                      Name = "QuestionLabel",
                      Font = new Font("Segoe UI", 12),
                      Top = 0,
                      Left = 9

                  };

                TextBox QuestionText = new()
                   {
                       Font = new Font("Segoe UI", 12),
                        Top = 40,
                        Left = 140,
                        ReadOnly = true,
                        Width = 676,
                        Height = 200
                   };

                ChildQueAndAnwPanel.Controls.Add(QuestionLabel);
                ChildQueAndAnwPanel.Controls.Add(QuestionText);
                QuestionText.Text = Quest.Title.ToString();
                questions.Add(Quest);
                var Answers =  _context.Answers.Where(A => A.Question_ID == Quest.Que_ID).ToList();
                
                foreach (var anws in Answers)
                {
                      Panel panel1 = new()
                      {
                        Margin = new(0),
                        Padding = new(0),
                        Height = 40,
                      };
                      AnswersLabel = new()
                                    {
                                    Text = "Answers",
                                    Name = "AnswersLabel",
                                    Font = new Font("Segoe UI", 12),
                                    Top = 60,
                                    Left = 9
                                    };
                      answer = new()
                      {
                        Left = 30,
                        Size = new Size(17, 15),
                        Name = Quest.Que_ID.ToString(),
                        Font = new Font("Segoe UI ", 12),
                        AutoSize = true
                      };
                      
                      AnswersRadioButton.Add(answer);
                      FlowPanel.Controls.Add(answer);
                      ChildQueAndAnwPanel.Controls.Add(AnswersLabel);
                      ChildQueAndAnwPanel.Controls.Add(FlowPanel);
                      answer.Text = anws.Value.ToString();
                }
                panels.Add(ChildQueAndAnwPanel);
                MainPanel.Controls.Add(ChildQueAndAnwPanel);
            }
        }
    }
}
