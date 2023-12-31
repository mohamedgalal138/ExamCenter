﻿namespace ExamCenter.Pages.Student
{
    partial class ListOfExams
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            BtnSideBar = new Button();
            LabelCourse = new Label();
            LabelExamTitle = new Label();
            LabelExamDuration = new Label();
            panel1 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            ListExamView = new DataGridView();
            CourseName = new TextBox();
            ExamDuration = new TextBox();
            ExamTitle = new TextBox();
            CountOfQuestions = new TextBox();
            LabelCountOfQuestions = new Label();
            panel4 = new Panel();
            BtnExit = new Button();
            panel2 = new Panel();
            BtnStart = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ListExamView).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // BtnSideBar
            // 
            BtnSideBar.Dock = DockStyle.Left;
            BtnSideBar.FlatAppearance.BorderSize = 2;
            BtnSideBar.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            BtnSideBar.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            BtnSideBar.FlatStyle = FlatStyle.Flat;
            BtnSideBar.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSideBar.Location = new Point(345, 0);
            BtnSideBar.Name = "BtnSideBar";
            BtnSideBar.Size = new Size(41, 767);
            BtnSideBar.TabIndex = 13;
            BtnSideBar.Text = "<";
            BtnSideBar.UseVisualStyleBackColor = true;
            BtnSideBar.Click += BtnSideBar_Click;
            // 
            // LabelCourse
            // 
            LabelCourse.AutoSize = true;
            LabelCourse.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LabelCourse.Location = new Point(17, 46);
            LabelCourse.Name = "LabelCourse";
            LabelCourse.Size = new Size(104, 35);
            LabelCourse.TabIndex = 14;
            LabelCourse.Text = "Course :";
            // 
            // LabelExamTitle
            // 
            LabelExamTitle.AutoSize = true;
            LabelExamTitle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LabelExamTitle.Location = new Point(17, 96);
            LabelExamTitle.Name = "LabelExamTitle";
            LabelExamTitle.Size = new Size(139, 35);
            LabelExamTitle.TabIndex = 15;
            LabelExamTitle.Text = "Exam Title :";
            // 
            // LabelExamDuration
            // 
            LabelExamDuration.AutoSize = true;
            LabelExamDuration.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LabelExamDuration.Location = new Point(17, 153);
            LabelExamDuration.Name = "LabelExamDuration";
            LabelExamDuration.Size = new Size(124, 35);
            LabelExamDuration.TabIndex = 16;
            LabelExamDuration.Text = "Duration: ";
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 63);
            panel1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(100, 9);
            label5.Name = "label5";
            label5.Size = new Size(113, 46);
            label5.TabIndex = 0;
            label5.Text = "Exams";
            // 
            // panel3
            // 
            panel3.Controls.Add(ListExamView);
            panel3.Controls.Add(panel1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(345, 767);
            panel3.TabIndex = 8;
            // 
            // ListExamView
            // 
            ListExamView.AllowUserToAddRows = false;
            ListExamView.AllowUserToDeleteRows = false;
            ListExamView.AllowUserToResizeColumns = false;
            ListExamView.AllowUserToResizeRows = false;
            ListExamView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ListExamView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ListExamView.BackgroundColor = Color.White;
            ListExamView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            ListExamView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            ListExamView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            ListExamView.DefaultCellStyle = dataGridViewCellStyle4;
            ListExamView.Dock = DockStyle.Fill;
            ListExamView.EnableHeadersVisualStyles = false;
            ListExamView.GridColor = Color.Black;
            ListExamView.Location = new Point(0, 63);
            ListExamView.MultiSelect = false;
            ListExamView.Name = "ListExamView";
            ListExamView.ReadOnly = true;
            ListExamView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            ListExamView.RowHeadersWidth = 51;
            ListExamView.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListExamView.RowTemplate.Height = 29;
            ListExamView.RowTemplate.ReadOnly = true;
            ListExamView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            ListExamView.Size = new Size(345, 704);
            ListExamView.TabIndex = 4;
            ListExamView.CellClick += ListExamView_CellClick;
            // 
            // CourseName
            // 
            CourseName.BorderStyle = BorderStyle.None;
            CourseName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CourseName.Location = new Point(162, 54);
            CourseName.Name = "CourseName";
            CourseName.ReadOnly = true;
            CourseName.Size = new Size(206, 27);
            CourseName.TabIndex = 17;
            // 
            // ExamDuration
            // 
            ExamDuration.BorderStyle = BorderStyle.None;
            ExamDuration.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExamDuration.Location = new Point(162, 162);
            ExamDuration.Name = "ExamDuration";
            ExamDuration.ReadOnly = true;
            ExamDuration.Size = new Size(105, 27);
            ExamDuration.TabIndex = 18;
            // 
            // ExamTitle
            // 
            ExamTitle.BorderStyle = BorderStyle.None;
            ExamTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExamTitle.Location = new Point(162, 105);
            ExamTitle.Name = "ExamTitle";
            ExamTitle.ReadOnly = true;
            ExamTitle.Size = new Size(206, 27);
            ExamTitle.TabIndex = 19;
            // 
            // CountOfQuestions
            // 
            CountOfQuestions.BorderStyle = BorderStyle.None;
            CountOfQuestions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CountOfQuestions.Location = new Point(260, 218);
            CountOfQuestions.Name = "CountOfQuestions";
            CountOfQuestions.ReadOnly = true;
            CountOfQuestions.Size = new Size(108, 27);
            CountOfQuestions.TabIndex = 21;
            // 
            // LabelCountOfQuestions
            // 
            LabelCountOfQuestions.AutoSize = true;
            LabelCountOfQuestions.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LabelCountOfQuestions.Location = new Point(17, 210);
            LabelCountOfQuestions.Name = "LabelCountOfQuestions";
            LabelCountOfQuestions.Size = new Size(238, 35);
            LabelCountOfQuestions.TabIndex = 20;
            LabelCountOfQuestions.Text = "Count Of Questions:";
            // 
            // panel4
            // 
            panel4.Controls.Add(BtnExit);
            panel4.Controls.Add(LabelCourse);
            panel4.Controls.Add(CountOfQuestions);
            panel4.Controls.Add(LabelExamTitle);
            panel4.Controls.Add(LabelCountOfQuestions);
            panel4.Controls.Add(LabelExamDuration);
            panel4.Controls.Add(ExamTitle);
            panel4.Controls.Add(CourseName);
            panel4.Controls.Add(ExamDuration);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(386, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(679, 273);
            panel4.TabIndex = 22;
            // 
            // BtnExit
            // 
            BtnExit.Anchor = AnchorStyles.None;
            BtnExit.AutoSize = true;
            BtnExit.BackColor = Color.Red;
            BtnExit.FlatStyle = FlatStyle.Flat;
            BtnExit.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnExit.Location = new Point(629, 5);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(46, 38);
            BtnExit.TabIndex = 22;
            BtnExit.Text = "X";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(BtnStart);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(386, 710);
            panel2.Name = "panel2";
            panel2.Size = new Size(679, 57);
            panel2.TabIndex = 23;
            // 
            // BtnStart
            // 
            BtnStart.Dock = DockStyle.Bottom;
            BtnStart.FlatAppearance.BorderSize = 0;
            BtnStart.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnStart.Location = new Point(0, 3);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(679, 54);
            BtnStart.TabIndex = 1;
            BtnStart.Text = "Start";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click_1;
            // 
            // ListOfExams
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 767);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(BtnSideBar);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListOfExams";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListOfExams";
            Load += ListOfExams_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ListExamView).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button BtnSideBar;
        private Label LabelCourse;
        private Label LabelExamTitle;
        private Label LabelExamDuration;
        private Panel panel1;
        private Label label5;
        private Panel panel3;
        private TextBox CourseName;
        private TextBox ExamDuration;
        private TextBox ExamTitle;
        private TextBox CountOfQuestions;
        private Label LabelCountOfQuestions;
        private Panel panel4;
        private Button BtnExit;
        public DataGridView ListExamView;
        private Panel panel2;
        private Button BtnStart;
    }
}