using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ExamCenter.Models
{
    [Table("student_course")]
    [Index(nameof(Course_ID), Name = "fk_Student_has_Course_Course1_idx")]
    [Index(nameof(Std_ID), Name = "fk_Student_has_Course_Student1_idx")]
    public partial class student_course
    {
        [Key]
        public int Std_ID { get; set; }
        [Key]
        public int Course_ID { get; set; }
        public int Degree { get; set; }

        [ForeignKey(nameof(Course_ID))]
        [InverseProperty(nameof(course.student_courses))]
        public virtual course Course { get; set; }
        [ForeignKey(nameof(Std_ID))]
        [InverseProperty(nameof(student.student_courses))]
        public virtual student Std { get; set; }
    }
}
