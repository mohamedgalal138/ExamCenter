using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ExamCenter.Models
{
    [Table("student_exam")]
    [Index(nameof(Exam_ID), Name = "fk_Exam_idx")]
    [Index(nameof(Std_ID), Name = "fk_Student_idx")]
    public partial class student_exam
    {
        [Key]
        public int Std_ID { get; set; }
        [Key]
        public int Exam_ID { get; set; }
        public DateTime Exam_Date { get; set; }
        public int Exam_Degree { get; set; }

        [ForeignKey(nameof(Exam_ID))]
        [InverseProperty(nameof(exam.student_exams))]
        public virtual exam Exam { get; set; }
        [ForeignKey(nameof(Std_ID))]
        [InverseProperty(nameof(student.student_exams))]
        public virtual student Std { get; set; }
    }
}
