using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ExamCenter.Models
{
    [Table("student")]
    public partial class student
    {
        public student()
        {
            student_answers = new HashSet<student_answer>();
            student_courses = new HashSet<student_course>();
            student_exams = new HashSet<student_exam>();
        }

        [Key]
        public int Std_ID { get; set; }
        [Required]
        [StringLength(45)]
        public string Std_Name { get; set; }
        [Required]
        [StringLength(45)]
        public string UserName { get; set; }
        [Required]
        [StringLength(45)]
        public string PassWord { get; set; }

        [InverseProperty(nameof(student_answer.Student_Std))]
        public virtual ICollection<student_answer> student_answers { get; set; }
        [InverseProperty(nameof(student_course.Std))]
        public virtual ICollection<student_course> student_courses { get; set; }
        [InverseProperty(nameof(student_exam.Std))]
        public virtual ICollection<student_exam> student_exams { get; set; }
    }
}
