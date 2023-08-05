using ExamCenter.Data;
using ExamCenter.Models;
using ExamCenter.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCenter.business_logic.Student
{
    public class DoExamLogic
    {
        Context _context = new();

        public course? GetCourse(int courseexamid) 
        {
            return _context.Courses.Where(c => c.course_ID == courseexamid).FirstOrDefault();
        }

        public void SubmitExam(List<question> questions) 
        {
            foreach (var item in questions)
            {

                var answers = _context.Answers.Where(a => a.Question_ID == item.Que_ID).ToList();

               _context.Student_answers.Add(new student_answer()
                {
                    Question_Que_ID = item.Que_ID,
                    Student_Std_ID = 1,
                    Student_Answer = item.StudentAnswerString,
                });
            }
            _context.SaveChanges();
        }
    }
}
