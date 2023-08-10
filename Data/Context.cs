using System;
using System.Collections.Generic;
using ExamCenter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ExamCenter.Data
{
    public partial class Context : DbContext
    {
        public virtual DbSet<answer> Answers { get; set; }
        public virtual DbSet<course> Courses { get; set; }
        public virtual DbSet<exam> Exams { get; set; }
        public virtual DbSet<question> Questions { get; set; }
        public virtual DbSet<student> Students { get; set; }
        public virtual DbSet<student_answer> Student_answers { get; set; }
        public virtual DbSet<student_course> Student_courses { get; set; }
        public virtual DbSet<student_exam> Student_exams { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public Context()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;database=Exam_Center;uid=root;pwd=12345", ServerVersion.Parse("8.0.32-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<answer>(entity =>
            {
                entity.HasKey(e => e.Answer_ID)
                    .HasName("PRIMARY");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.answers)
                    .HasForeignKey(d => d.Question_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Answer_Question1");
            });

            modelBuilder.Entity<course>(entity =>
            {
                entity.HasKey(e => e.course_ID)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<exam>(entity =>
            {
                entity.HasKey(e => e.Exam_ID)
                    .HasName("PRIMARY");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.exams)
                    .HasForeignKey(d => d.Course_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Exam_Course");
            });

            modelBuilder.Entity<question>(entity =>
            {
                entity.HasKey(e => e.Que_ID)
                    .HasName("PRIMARY");

                entity.HasOne(d => d.Exam)
                    .WithMany(p => p.questions)
                    .HasForeignKey(d => d.Exam_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Question_Exam1");
            });

            modelBuilder.Entity<student>(entity =>
            {
                entity.HasKey(e => e.Std_ID)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<student_answer>(entity =>
            {
                entity.HasKey(e => new { e.Student_Std_ID, e.Question_Que_ID })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.HasOne(d => d.Question_Que)
                    .WithMany(p => p.Student_Answer)
                    .HasForeignKey(d => d.Question_Que_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Question_ID");

                entity.HasOne(d => d.Student_Std)
                    .WithMany(p => p.student_answers)
                    .HasForeignKey(d => d.Student_Std_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Std_ID");
            });

            modelBuilder.Entity<student_course>(entity =>
            {
                entity.HasKey(e => new { e.Std_ID, e.Course_ID })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.student_courses)
                    .HasForeignKey(d => d.Course_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Course_ID");

                entity.HasOne(d => d.Std)
                    .WithMany(p => p.student_courses)
                    .HasForeignKey(d => d.Std_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Student_ID");
            });

            modelBuilder.Entity<student_exam>(entity =>
            {
                entity.HasKey(e => new { e.Std_ID, e.Exam_ID })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.HasOne(d => d.Exam)
                    .WithMany(p => p.student_exams)
                    .HasForeignKey(d => d.Exam_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Exam_ID");

                entity.HasOne(d => d.Std)
                    .WithMany(p => p.student_exams)
                    .HasForeignKey(d => d.Std_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Std3_ID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
