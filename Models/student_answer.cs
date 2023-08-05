using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ExamCenter.Models
{
    [Table("student_answer")]
    [Index(nameof(Question_Que_ID), Name = "fk_Question_idx")]
    [Index(nameof(Student_Std_ID), Name = "fk_Student_idx")]
    public partial class student_answer
    {
        [Key]
        public int Student_Std_ID { get; set; }
        [Key]
        public int Question_Que_ID { get; set; }
        [Required]
        [Column("Student_Answer")]
        [StringLength(45)]
        public string Student_Answer { get; set; }

        [ForeignKey(nameof(Question_Que_ID))]
        [InverseProperty(nameof(question.Student_Answer))]
        public virtual question Question_Que { get; set; }
        [ForeignKey(nameof(Student_Std_ID))]
        [InverseProperty(nameof(student.student_answers))]
        public virtual student Student_Std { get; set; }
    }
}
