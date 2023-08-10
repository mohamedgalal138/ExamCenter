using ExamCenter.business_logic;
using ExamCenter.Pages.Admin;
using ExamCenter.Pages.Student;
using ExamCenter.View.Student;
using ExamCenter.Viwe.Student;

namespace ExamCenter
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LogIn());
            // Application.Run(new ListOfExams());
            // Application.Run(new AddNewExam());
            //Application.Run(new EditeAndDeleteExam());
            //Application.Run(new DegreeOfExam());
        }
    }
}