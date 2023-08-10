using ExamCenter.Data;
using ExamCenter.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCenter.business_logic.Student
{
    public class ListOfExamsLogic
    {
        Context _context = new();


        public async Task LoadExams( DataGridView view )
        {
                                                      
            
            var Exams = from exam in _context.Exams select new
                                                                {
                                                                 Exam = exam.Title , 
                                                                 Id = exam.Exam_ID,
                                                                 CourseId = exam.Course.course_ID, 
                                                                 CourseName = exam.Course.Course_Name,
                                                                 Duration = exam.Duration,
                                                                 CountOfQuestions = exam.questions.Count
                                                                };
            view.DataSource = await Exams.ToListAsync();
            
        }


    }
}
