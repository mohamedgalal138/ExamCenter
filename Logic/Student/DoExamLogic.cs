using ExamCenter.Data;
using ExamCenter.Logic.LogIn;
using ExamCenter.Models;
using ExamCenter.Pages;
using ExamCenter.Viwe.Student;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCenter.business_logic.Student
{
    public class DoExamLogic
    {

       private exam? exam;

        Context? _context = new();

        public DoExamLogic()
        {
           
        }
        public DoExamLogic( exam _exam)
        {
            this.exam = _exam;
                
        }

        public  course? GetCourse(int courseexamid) 
        {
            return _context.Courses.Where(c => c.course_ID == courseexamid).FirstOrDefault();
        }

        public async Task SubmitExam(List<question> questions) 
        {
            foreach (var item in questions)
            {
               
                
                var answers = await _context.Answers.Where(a => a.Question_ID == item.Que_ID).ToListAsync();

                await _context.Student_answers.AddAsync(new student_answer()
                {
                    Question_Que_ID = item.Que_ID,
                    Student_Std_ID = LogIn.StudentId,
                    Student_Answer = item.StudentAnswerString?? "Null",
                });
            }

            await _context.Student_exams.AddAsync(new student_exam()
            {
                Exam_Date = DateTime.Now,
                Std_ID = LogIn.StudentId,
                Exam_ID = exam.Exam_ID,

            });

            await _context.SaveChangesAsync();  
        }
    }
}
