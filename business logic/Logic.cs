using ExamCenter.Data;
using ExamCenter.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ExamCenter.business_logic
{
    public class Logic
    {
        Context _context = new Context();

        public Logic() 
        { 
        }


        public  void AddStudent(student student)
        {
              _context.Students.Add(student);
              _context.SaveChanges();
            if(_context.SaveChanges() >0)
            {
                 
            }
            else
            {
                   
            }


        }

        public void GetStudentById(int id)
        {
            

        }

        public bool StudentLogin(string UserName , string PassWord)
        {
            var s = _context.Students.Where(s => s.UserName == UserName).FirstOrDefault();
            bool flag = true;
            var Students = GetAllStudent();
            foreach (var student in Students)
            {
                if(student.UserName ==  UserName && student.PassWord == PassWord)
                    flag = true;

                else
                    flag = false;
            }
            return flag;
        }

        public List<student> GetAllStudent()
        {
            var students = _context.Students.ToList();
            return students;
        }

        public void RemoveStudent(student student)
        {
            _context.Students.Remove(student);
            _context.SaveChanges();

        }

        public void updateStudent(student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();

        }

        private int GetLastExamId()
        {
            return _context.Exams.LastOrDefault().Exam_ID; 
        }

        private int GetLastQuestionId()
        {
            return _context.Questions.LastOrDefault().Que_ID;
        }
       
        public void AddExam(exam exam)
        {
            _context.Exams.Add(exam);
            _context.SaveChanges();
        }

        public void AddQuestion(question question)
        {
            question.Exam_ID = GetLastExamId();
            _context.Questions.Add(question);
            _context.SaveChanges();
        }


        public exam LoadExamById(int Id)
        {
            var exam = _context.Exams.Where(e => e.Exam_ID == Id).FirstOrDefault();
            return exam ;
        }

        public List<exam> LoadAllExams()
        {
            var Exams = _context.Exams.ToList();
            return Exams;
        }

        public List<question> LoadQuestions( int examid)
        {

            var list = _context.Questions.Where(e => e.Exam_ID ==  examid).ToList();
            return list;
        }

        //public List<answer> LoadAnswers(List<question>  questions )
        //{

        //    foreach (var question in questions)
        //    {
        //        var list = _context.Answers.Where(a => a.Question_ID == question.Que_ID).ToList();

        //        return list;
        //    }
            
        //}
    }
}
