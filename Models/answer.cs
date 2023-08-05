using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ExamCenter.Models
{
    [Table("answer")]
    [Index(nameof(Question_ID), Name = "fk_Answer_Question1_idx")]
    public partial class answer
    {
        [Key]
        public int Answer_ID { get; set; }
        [Required]
        [StringLength(45)]
        public string Value { get; set; }
        public sbyte IScorrect { get; set; }
        public int Question_ID { get; set; }

        [ForeignKey(nameof(Question_ID))]
        [InverseProperty(nameof(question.answers))]
        public virtual question Question { get; set; }
    }
}
