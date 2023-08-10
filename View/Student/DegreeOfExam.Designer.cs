namespace ExamCenter.View.Student
{
    partial class DegreeOfExam
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
            PanelExamInfo = new Panel();
            labelExamName = new Label();
            labelCourseName = new Label();
            labelStudentName = new Label();
            PanelQuestions = new FlowLayoutPanel();
            PanelExamInfo.SuspendLayout();
            SuspendLayout();
            // 
            // PanelExamInfo
            // 
            PanelExamInfo.BackColor = SystemColors.ActiveCaption;
            PanelExamInfo.BorderStyle = BorderStyle.FixedSingle;
            PanelExamInfo.Controls.Add(labelExamName);
            PanelExamInfo.Controls.Add(labelCourseName);
            PanelExamInfo.Controls.Add(labelStudentName);
            PanelExamInfo.Dock = DockStyle.Top;
            PanelExamInfo.Location = new Point(0, 0);
            PanelExamInfo.Name = "PanelExamInfo";
            PanelExamInfo.Size = new Size(990, 165);
            PanelExamInfo.TabIndex = 0;
            // 
            // labelExamName
            // 
            labelExamName.AutoSize = true;
            labelExamName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelExamName.Location = new Point(24, 110);
            labelExamName.MinimumSize = new Size(200, 0);
            labelExamName.Name = "labelExamName";
            labelExamName.Size = new Size(200, 28);
            labelExamName.TabIndex = 2;
            labelExamName.Text = "Exam : ";
            // 
            // labelCourseName
            // 
            labelCourseName.AutoSize = true;
            labelCourseName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCourseName.Location = new Point(24, 68);
            labelCourseName.MinimumSize = new Size(200, 0);
            labelCourseName.Name = "labelCourseName";
            labelCourseName.Size = new Size(200, 28);
            labelCourseName.TabIndex = 1;
            labelCourseName.Text = "Course : ";
            // 
            // labelStudentName
            // 
            labelStudentName.AutoSize = true;
            labelStudentName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelStudentName.Location = new Point(24, 23);
            labelStudentName.MinimumSize = new Size(200, 0);
            labelStudentName.Name = "labelStudentName";
            labelStudentName.Size = new Size(200, 28);
            labelStudentName.TabIndex = 0;
            labelStudentName.Text = "Student Name : ";
            // 
            // PanelQuestions
            // 
            PanelQuestions.AutoScroll = true;
            PanelQuestions.AutoSize = true;
            PanelQuestions.BackColor = SystemColors.GradientInactiveCaption;
            PanelQuestions.Dock = DockStyle.Fill;
            PanelQuestions.FlowDirection = FlowDirection.TopDown;
            PanelQuestions.Location = new Point(0, 165);
            PanelQuestions.Name = "PanelQuestions";
            PanelQuestions.Size = new Size(990, 559);
            PanelQuestions.TabIndex = 1;
            PanelQuestions.WrapContents = false;
            // 
            // DegreeOfExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(990, 724);
            Controls.Add(PanelQuestions);
            Controls.Add(PanelExamInfo);
            Name = "DegreeOfExam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DegreeOfExam";
            Load += DegreeOfExam_Load;
            PanelExamInfo.ResumeLayout(false);
            PanelExamInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel PanelExamInfo;
        private Label labelExamName;
        private Label labelCourseName;
        private Label labelStudentName;
        private FlowLayoutPanel PanelQuestions;
    }
}