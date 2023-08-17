using ExamCenter.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ExamCenter.Viwe.Student;
using ExamCenter.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamCenter.business_logic.SignUp
{
    public class SignUpLogic
    {
       readonly Context _context = new ();

        public string? email;

        public string? password;

        public string? Name;

        public SignUpLogic(string _name , string _email , string _password)
        {
            this.email = _email;
            this.password = _password;
            this.Name = _name;  
        }
       
        public async Task<bool> AddNewStudent()
        {
            bool flag = true;
            try
            {
                await _context.Students.AddAsync(new student()
                {
                    Std_Name = Name?? "null",
                    UserName = email?? "null",
                    PassWord = password?? "null",
                });
                 await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                flag = false;
            }
            return flag;
   
        }
        

    }
}
