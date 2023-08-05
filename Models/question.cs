using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ExamCenter.Models
{
    [Table("question")]
    [Index(nameof(Exam_ID), Name = "fk_Question_Exam1_idx")]
    public partial class question
    {
        public question()
        {
            answers = new HashSet<answer>();
            Student_Answer = new HashSet<student_answer>();
        }
        [NotMapped]
        public string StudentAnswerString { get; set; }

        [Key]
        public int Que_ID { get; set; }
        [Required]
        [StringLength(300)]
        public string Title { get; set; }
        public int Mark { get; set; }
        public int Exam_ID { get; set; }

        [ForeignKey(nameof(Exam_ID))]
        [InverseProperty(nameof(exam.questions))]
        public virtual exam Exam { get; set; }
        [InverseProperty(nameof(answer.Question))]
        public virtual ICollection<answer> answers { get; set; }
        [InverseProperty(nameof(student_answer.Question_Que))]
        public virtual ICollection< student_answer> Student_Answer  { get; set; }
    }
}
