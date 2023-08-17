using ExamCenter.Data;
using ExamCenter.Models;
using ExamCenter.Viwe.Student;
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
                                             
            var id = await _context.Student_exams.AnyAsync( e => e.Std_ID == LogIn.StudentId);
            if(id)
            {
                var Exams = from E in _context.Exams
                            from SE in _context.Student_exams
                            where SE.Std_ID == LogIn.StudentId && E.Exam_ID != SE.Exam_ID
                            select new
                            {
                                Exam = E.Title,
                                Id = E.Exam_ID,
                                CourseId = E.Course.course_ID,
                                CourseName = E.Course.Course_Name,
                                Duration = E.Duration,
                                CountOfQuestions = E.questions.Count
                            };
                view.DataSource = await Exams.ToListAsync();
            }
            else
            {
                var Exams = from E in _context.Exams
                            select new
                            {
                                Exam = E.Title,
                                Id = E.Exam_ID,
                                CourseId = E.Course.course_ID,
                                CourseName = E.Course.Course_Name,
                                Duration = E.Duration,
                                CountOfQuestions = E.questions.Count
                            };
                view.DataSource = await Exams.ToListAsync();
            }
              
        }


    }
}
