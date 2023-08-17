using ExamCenter.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCenter.Logic.LogIn
{
    public class LogInLogic 
    {
       readonly Context _context = new();
        public LogInLogic()
        {
            
        }

        public async Task<int> Login( string username , string password)
        {
            if (await _context.Students.AnyAsync(a => a.UserName == username) && await _context.Students.AnyAsync(a => a.PassWord == password))
                return  await _context.Students.Where(s => s.UserName == username).Select(a => a.Std_ID).SingleOrDefaultAsync();
            else return 0;
            

        }


    }
}
