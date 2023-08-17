using ExamCenter.Data;
using ExamCenter.Logic.LogIn;
using ExamCenter.Models;
using ExamCenter.Viwe.Student;
using ExamCenter.Viwe;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCenter.Logic.Student
{
    public class DegreeOfExmaLogic
    {
        Context? _context = new();


        public DegreeOfExmaLogic()
        {


        }

        public async Task<int> ExamDegree(int examid)
        {
            return await _context.Questions.Where(q => q.Exam_ID == examid).SumAsync(q => q.Mark);
        }

        public async Task<string?> GetExamTitle(int examid)
        {

            return await _context.Exams.Where(e => e.Exam_ID == examid).Select(e => e.Title).FirstOrDefaultAsync();
            //var id = await _context.Student_answers.Where(s => s.Student_Std_ID == studentid).Select(q => q.Question_Que_ID).FirstOrDefaultAsync();
            //return await _context.Questions.Where(q => q.Que_ID == id).Select(e => e.Exam.Title).SingleOrDefaultAsync() ?? "Null";

        }

        public async Task<string> GetStudentName(int studentid)
        {
            return await _context.Students.Where(s => s.Std_ID == studentid).Select(s => s.Std_Name).SingleOrDefaultAsync() ?? "Null";
        }

        public async Task<string?> GetCourseName(int examid)
        {
            return await _context.Exams.Where(e => e.Exam_ID == examid).Select(e => e.Course.Course_Name).FirstOrDefaultAsync();
            //var id = await _context.Student_answers.Where(s => s.Student_Std_ID == studentid).Select(q => q.Question_Que_ID).FirstOrDefaultAsync();
            //return await _context.Questions.Where(q => q.Que_ID == id).Select(e => e.Exam.Course.Course_Name).SingleOrDefaultAsync() ?? "Null";

        }

        public async Task<question?> GetQuestionsID(int questionid)
        {
            return await
                        _context.Questions.
                        Where(q => q.Que_ID == questionid).
                        FirstOrDefaultAsync();

        }

        public async Task<List<student_answer>> GetAllQuestions(int studentid , int examid )
        {

            return  await (from q1 in _context.Student_answers
                    from q2 in _context.Questions
                    where q1.Student_Std_ID == studentid
                    &&  q2.Exam_ID == examid
                    && q1.Question_Que_ID == q2.Que_ID
                    select q1).ToListAsync();
        }

        public async Task<List<answer>> GetAnswers(int questionid)
        {

            return await _context.Answers.
                          Where(a => a.Question_ID == questionid).
                          ToListAsync();
        }




    }
}
