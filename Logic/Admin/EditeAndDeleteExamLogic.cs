using ExamCenter.Data;
using ExamCenter.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCenter.Logic.Admin
{
    public class EditeAndDeleteExamLogic
    {
        Context _context = new();
        public async Task<bool> DeleteExam( int examid)
        {
            bool flag = true;
            var exam = await _context.Exams.SingleOrDefaultAsync(e => e.Exam_ID == examid);
            var questions = await _context.Questions.Where(q => q.Exam_ID == exam.Exam_ID).ToListAsync();
           
           
            if(exam == null)
            {
                flag = false;
            }
            else if(questions == null)
            {
                  _context.Exams.Remove(exam);
                  await _context.SaveChangesAsync();
                  flag = true; 
            }
            else 
            {
                foreach (var question in questions)
                {
                    var Answers = await _context.Answers.Where(a => a.Question_ID == question.Que_ID).ToListAsync();
                    _context.Answers.RemoveRange(Answers);
                    await _context.SaveChangesAsync();
                }
                _context.Questions.RemoveRange(questions);
                _context.Exams.Remove(exam);
                await _context.SaveChangesAsync();
                flag = true;
            }
            return flag;

               //// int id = (int)ExamList.CurrentRow.Cells[0].Value;
               // var questionexam = _context.Exams.Where(e => e.Exam_ID == id).FirstOrDefault().questions;
               // if (questionexam != null)
               // {
               //     foreach (var question in questionexam)
               //     {
               //         var answers = _context.Answers.Where(e => e.Question_ID == question.Que_ID).ToList();
               //         _context.Answers.RemoveRange(answers);
               //         _context.Questions.Remove(question);

               //     }
               //     var exam = _context.Exams.Where(e => e.Exam_ID == id).FirstOrDefault();
               //     _context.Exams.Remove(exam);
               //     _context.SaveChanges();

               // }
               // else
               // {
               //     var exam = _context.Exams.Where(e => e.Exam_ID == id).FirstOrDefault();
               //     _context.Exams.Remove(exam);
               //     _context.SaveChanges();
               // }
            

        }

        public async Task LoadExams(DataGridView view )
        {
            var Exams = from exam in _context.Exams
                        select new
                        {
                            id = exam.Exam_ID,

                            ExamTitle = exam.Title,

                            duration = exam.Duration,

                            course = exam.Course_ID,

                            countOfQuestions = exam.questions.Count,
                        };
            view.DataSource = await Exams.ToListAsync();

        }
    }
}
