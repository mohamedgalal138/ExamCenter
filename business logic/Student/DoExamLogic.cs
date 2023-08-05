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
        public student_answer? _student_Answer;

        public student_exam? _student_Exam;

        Context _context = new();

        exam exam;

        public DoExamLogic(exam exam) 
        {
            this.exam = exam;
        }

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
                //foreach (var answ in answers)
                //{
                //    foreach (var answer in answers1)
                //    {
                //        _student_Answer = new();
                //        if (answer.Checked == true)
                //        {
                //            _student_Answer.Student_Std_ID = 1;
                //            _student_Answer.Question_Que_ID = item.Que_ID;
                //            _student_Answer.Student_Answer = answer.Text;
                //            _context.Student_answers.Add(_student_Answer);

                //        }

                //    }
                //}


            }
            _context.SaveChanges();
        }
    }
}
