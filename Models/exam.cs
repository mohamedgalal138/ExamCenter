using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ExamCenter.Models
{
    [Table("exam")]
    [Index(nameof(Course_ID), Name = "fk_Exam_Course_idx")]
    public partial class exam
    {
        public exam()
        {
            questions = new HashSet<question>();
            student_exams = new HashSet<student_exam>();
        }

        [Key]
        public int Exam_ID { get; set; }
        [Required]
        [StringLength(45)]
        public string Title { get; set; }
       
        public int Duration { get; set; }
        public DateTime Created_Date { get; set; }
        public int Course_ID { get; set; }

        [ForeignKey(nameof(Course_ID))]
        [InverseProperty(nameof(course.exams))]
        public virtual course Course { get; set; }
        [InverseProperty(nameof(question.Exam))]
        public virtual ICollection<question> questions { get; set; }
        [InverseProperty(nameof(student_exam.Exam))]
        public virtual ICollection<student_exam> student_exams { get; set; }
    }
}
