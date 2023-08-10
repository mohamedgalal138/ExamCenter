using ExamCenter.Data;
using ExamCenter.Models;
using ExamCenter.Viwe.Student;
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
        

        List<question>? _questions;
        public DegreeOfExmaLogic() 
        {
            
            
        }

        public async Task< string> GetExamTitle(int ids)
        {
            var id = await _context.Student_answers.Where(s => s.Student_Std_ID == ids).Select(q => q.Question_Que_ID).FirstOrDefaultAsync();
            return await _context.Questions.Where(q => q.Que_ID == id).Select(e => e.Exam.Title).SingleOrDefaultAsync()?? "Null";
           
        }
        public async Task<string> GetStudentName(int id)
        {
           return await _context.Students.Where(s => s.Std_ID == id).Select(s => s.Std_Name).SingleOrDefaultAsync()?? "Null";
        }
        public async Task<string> GetCourseName(int ids)
        {
            var id = await _context.Student_answers.Where(s => s.Student_Std_ID == ids).Select(q => q.Question_Que_ID).FirstOrDefaultAsync();
            return await _context.Questions.Where(q => q.Que_ID == id).Select(e => e.Exam.Course.Course_Name).SingleOrDefaultAsync()?? "Null";

        }

        public async Task<bool> ExamCorrection( int studentid)
        {
            var studanswer = await _context.Student_answers.Where(s => s.Student_Std_ID == studentid).ToListAsync();
            studanswer.ForEach(async (s) =>
            {
                var ques = await _context.Questions.Where(q => q.Que_ID == s.Question_Que_ID).ToListAsync();
                ques.ForEach(async (q) =>
                {
                    var answer = await _context.Answers.Where(a => a.Question_ID == q.Que_ID).ToListAsync();

                });
               
            });
            return true;
        }




    }
}
