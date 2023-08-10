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
    public class AddNewExamLogic
    {
        Context _context = new();
        
        public async Task<int> AddNewExam(exam _exam)
        {
            await _context.Exams.AddAsync(_exam);
            await  _context.SaveChangesAsync();

            return _exam.Exam_ID;
        }

        public async Task<int>AddNewQuestion(question _question)
        {
            await _context.Questions.AddAsync(_question);
            await _context.SaveChangesAsync();

            return  _question.Que_ID;
        }

        public async Task<int> AddNewAnswers(List<answer> answers)
        {
            int count;
            await _context.Answers.AddRangeAsync(answers);
            count =   await _context.SaveChangesAsync();
            return count;
        }

        public async Task<int> GetQuestionCount(int examid)
        {
            int count = await _context.Questions.CountAsync(q =>q.Exam_ID == examid);
            return count;
        }
    }
}
