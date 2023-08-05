using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ExamCenter.Models
{
    [Table("course")]
    public partial class course
    {
        public course()
        {
            exams = new HashSet<exam>();
            student_courses = new HashSet<student_course>();
        }

        [Key]
        public int course_ID { get; set; }
        [Required]
        [StringLength(45)]
        public string Course_Name { get; set; }

        [InverseProperty(nameof(exam.Course))]
        public virtual ICollection<exam> exams { get; set; }
        [InverseProperty(nameof(student_course.Course))]
        public virtual ICollection<student_course> student_courses { get; set; }
    }
}
