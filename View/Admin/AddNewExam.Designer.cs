namespace ExamCenter.Pages.Admin
{
    partial class AddNewExam
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
            EXCount = new Label();
            NewExam = new GroupBox();
            BtnSaveExam = new Button();
            CourseName = new ComboBox();
            Duration = new NumericUpDown();
            labelCourse = new Label();
            labelDuration = new Label();
            TitleLabel = new Label();
            Title = new TextBox();
            butAddQuestion = new Button();
            labelAnswer = new Label();
            panelExamQuestionForm = new Panel();
            QuestionPanel = new Panel();
            QuestionHead = new RichTextBox();
            labelQuestionHead = new Label();
            TypeQuesPanel = new Panel();
            TypeOfQuestion = new ComboBox();
            labelTypeOfQuestion = new Label();
            MarkPanel = new Panel();
            Mark = new NumericUpDown();
            labelMark = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            butFinishingExam = new Button();
            panelTruFalAnswer = new Panel();
            TrueAnswer = new RadioButton();
            FalseAnswer = new RadioButton();
            MCQAnswerValue = new TextBox();
            butCancle = new Button();
            BtnSaveQuestionAndAnswer = new Button();
            BtnAddChoice = new Button();
            NewExam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Duration).BeginInit();
            panelExamQuestionForm.SuspendLayout();
            QuestionPanel.SuspendLayout();
            TypeQuesPanel.SuspendLayout();
            MarkPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Mark).BeginInit();
            panelTruFalAnswer.SuspendLayout();
            SuspendLayout();
            // 
            // EXCount
            // 
            EXCount.AutoSize = true;
            EXCount.Location = new Point(205, 108);
            EXCount.Name = "EXCount";
            EXCount.Size = new Size(0, 20);
            EXCount.TabIndex = 2;
            // 
            // NewExam
            // 
            NewExam.BackColor = Color.Aqua;
            NewExam.Controls.Add(BtnSaveExam);
            NewExam.Controls.Add(CourseName);
            NewExam.Controls.Add(Duration);
            NewExam.Controls.Add(labelCourse);
            NewExam.Controls.Add(labelDuration);
            NewExam.Controls.Add(TitleLabel);
            NewExam.Controls.Add(Title);
            NewExam.Dock = DockStyle.Top;
            NewExam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NewExam.Location = new Point(0, 0);
            NewExam.Name = "NewExam";
            NewExam.Size = new Size(1136, 215);
            NewExam.TabIndex = 3;
            NewExam.TabStop = false;
            NewExam.Text = "New Exam";
            // 
            // BtnSaveExam
            // 
            BtnSaveExam.FlatAppearance.BorderSize = 0;
            BtnSaveExam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSaveExam.Location = new Point(961, 147);
            BtnSaveExam.Name = "BtnSaveExam";
            BtnSaveExam.Size = new Size(112, 40);
            BtnSaveExam.TabIndex = 3;
            BtnSaveExam.Text = "Save";
            BtnSaveExam.UseVisualStyleBackColor = true;
            BtnSaveExam.UseWaitCursor = true;
            BtnSaveExam.Click += BtnSaveExam_Click;
            // 
            // CourseName
            // 
            CourseName.DisplayMember = "Course_Name";
            CourseName.DropDownStyle = ComboBoxStyle.DropDownList;
            CourseName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CourseName.FormattingEnabled = true;
            CourseName.Location = new Point(110, 110);
            CourseName.Name = "CourseName";
            CourseName.Size = new Size(229, 36);
            CourseName.TabIndex = 2;
            CourseName.ValueMember = "Course_ID";
            // 
            // Duration
            // 
            Duration.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Duration.Location = new Point(527, 63);
            Duration.Name = "Duration";
            Duration.Size = new Size(76, 34);
            Duration.TabIndex = 1;
            Duration.TextAlign = HorizontalAlignment.Center;
            // 
            // labelCourse
            // 
            labelCourse.AutoSize = true;
            labelCourse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCourse.Location = new Point(30, 113);
            labelCourse.Name = "labelCourse";
            labelCourse.Size = new Size(72, 28);
            labelCourse.TabIndex = 5;
            labelCourse.Text = "Course";
            labelCourse.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDuration.Location = new Point(434, 66);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(89, 28);
            labelDuration.TabIndex = 1;
            labelDuration.Text = "Duration";
            labelDuration.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TitleLabel.Location = new Point(47, 60);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(49, 28);
            TitleLabel.TabIndex = 1;
            TitleLabel.Text = "Title";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Title
            // 
            Title.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Title.Location = new Point(110, 56);
            Title.Name = "Title";
            Title.Size = new Size(229, 34);
            Title.TabIndex = 0;
            // 
            // butAddQuestion
            // 
            butAddQuestion.Location = new Point(917, 9);
            butAddQuestion.Name = "butAddQuestion";
            butAddQuestion.Size = new Size(207, 40);
            butAddQuestion.TabIndex = 4;
            butAddQuestion.Text = "Add New Question";
            butAddQuestion.UseVisualStyleBackColor = true;
            butAddQuestion.Click += butAddQuestion_Click;
            // 
            // labelAnswer
            // 
            labelAnswer.AutoSize = true;
            labelAnswer.Location = new Point(7, 272);
            labelAnswer.Name = "labelAnswer";
            labelAnswer.Size = new Size(75, 28);
            labelAnswer.TabIndex = 10;
            labelAnswer.Text = "Answer";
            labelAnswer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelExamQuestionForm
            // 
            panelExamQuestionForm.BackColor = SystemColors.ActiveCaption;
            panelExamQuestionForm.Controls.Add(QuestionPanel);
            panelExamQuestionForm.Controls.Add(TypeQuesPanel);
            panelExamQuestionForm.Controls.Add(MarkPanel);
            panelExamQuestionForm.Controls.Add(flowLayoutPanel1);
            panelExamQuestionForm.Controls.Add(butFinishingExam);
            panelExamQuestionForm.Controls.Add(panelTruFalAnswer);
            panelExamQuestionForm.Controls.Add(MCQAnswerValue);
            panelExamQuestionForm.Controls.Add(butCancle);
            panelExamQuestionForm.Controls.Add(BtnSaveQuestionAndAnswer);
            panelExamQuestionForm.Controls.Add(BtnAddChoice);
            panelExamQuestionForm.Controls.Add(labelAnswer);
            panelExamQuestionForm.Controls.Add(butAddQuestion);
            panelExamQuestionForm.Dock = DockStyle.Bottom;
            panelExamQuestionForm.Enabled = false;
            panelExamQuestionForm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panelExamQuestionForm.Location = new Point(0, 213);
            panelExamQuestionForm.Name = "panelExamQuestionForm";
            panelExamQuestionForm.Size = new Size(1136, 653);
            panelExamQuestionForm.TabIndex = 11;
            // 
            // QuestionPanel
            // 
            QuestionPanel.Controls.Add(QuestionHead);
            QuestionPanel.Controls.Add(labelQuestionHead);
            QuestionPanel.Enabled = false;
            QuestionPanel.Location = new Point(7, 96);
            QuestionPanel.Name = "QuestionPanel";
            QuestionPanel.Size = new Size(826, 173);
            QuestionPanel.TabIndex = 36;
            // 
            // QuestionHead
            // 
            QuestionHead.Location = new Point(126, 11);
            QuestionHead.MaxLength = 300;
            QuestionHead.Name = "QuestionHead";
            QuestionHead.Size = new Size(672, 131);
            QuestionHead.TabIndex = 8;
            QuestionHead.Text = "";
            // 
            // labelQuestionHead
            // 
            labelQuestionHead.AutoSize = true;
            labelQuestionHead.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelQuestionHead.Location = new Point(14, 11);
            labelQuestionHead.Name = "labelQuestionHead";
            labelQuestionHead.Size = new Size(91, 28);
            labelQuestionHead.TabIndex = 9;
            labelQuestionHead.Text = "Question";
            labelQuestionHead.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TypeQuesPanel
            // 
            TypeQuesPanel.Controls.Add(TypeOfQuestion);
            TypeQuesPanel.Controls.Add(labelTypeOfQuestion);
            TypeQuesPanel.Enabled = false;
            TypeQuesPanel.Location = new Point(464, 3);
            TypeQuesPanel.Name = "TypeQuesPanel";
            TypeQuesPanel.Size = new Size(369, 58);
            TypeQuesPanel.TabIndex = 35;
            // 
            // TypeOfQuestion
            // 
            TypeOfQuestion.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeOfQuestion.FormattingEnabled = true;
            TypeOfQuestion.Items.AddRange(new object[] { "True Or False", "MCQ" });
            TypeOfQuestion.Location = new Point(178, 8);
            TypeOfQuestion.Name = "TypeOfQuestion";
            TypeOfQuestion.Size = new Size(180, 36);
            TypeOfQuestion.TabIndex = 5;
            TypeOfQuestion.SelectedIndexChanged += TypeOfQuestion_SelectedIndexChanged;
            // 
            // labelTypeOfQuestion
            // 
            labelTypeOfQuestion.AutoSize = true;
            labelTypeOfQuestion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTypeOfQuestion.Location = new Point(11, 12);
            labelTypeOfQuestion.Name = "labelTypeOfQuestion";
            labelTypeOfQuestion.Size = new Size(163, 28);
            labelTypeOfQuestion.TabIndex = 4;
            labelTypeOfQuestion.Text = "Type Of Question";
            labelTypeOfQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MarkPanel
            // 
            MarkPanel.Controls.Add(Mark);
            MarkPanel.Controls.Add(labelMark);
            MarkPanel.Enabled = false;
            MarkPanel.Location = new Point(234, 3);
            MarkPanel.Name = "MarkPanel";
            MarkPanel.Size = new Size(198, 58);
            MarkPanel.TabIndex = 34;
            // 
            // Mark
            // 
            Mark.Location = new Point(89, 5);
            Mark.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            Mark.Name = "Mark";
            Mark.Size = new Size(82, 34);
            Mark.TabIndex = 6;
            Mark.TextAlign = HorizontalAlignment.Center;
            // 
            // labelMark
            // 
            labelMark.AutoSize = true;
            labelMark.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelMark.Location = new Point(28, 9);
            labelMark.Name = "labelMark";
            labelMark.Size = new Size(57, 28);
            labelMark.TabIndex = 5;
            labelMark.Text = "Mark";
            labelMark.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Location = new Point(112, 361);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.MaximumSize = new Size(800, 200);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(693, 200);
            flowLayoutPanel1.TabIndex = 33;
            // 
            // butFinishingExam
            // 
            butFinishingExam.Enabled = false;
            butFinishingExam.Location = new Point(110, 593);
            butFinishingExam.Name = "butFinishingExam";
            butFinishingExam.Size = new Size(188, 40);
            butFinishingExam.TabIndex = 11;
            butFinishingExam.Text = "Finishing Exam";
            butFinishingExam.UseVisualStyleBackColor = true;
            butFinishingExam.Click += butFinishingExam_Click;
            // 
            // panelTruFalAnswer
            // 
            panelTruFalAnswer.BackColor = SystemColors.ActiveCaption;
            panelTruFalAnswer.Controls.Add(TrueAnswer);
            panelTruFalAnswer.Controls.Add(FalseAnswer);
            panelTruFalAnswer.Location = new Point(834, 361);
            panelTruFalAnswer.Name = "panelTruFalAnswer";
            panelTruFalAnswer.Size = new Size(208, 200);
            panelTruFalAnswer.TabIndex = 32;
            panelTruFalAnswer.Visible = false;
            // 
            // TrueAnswer
            // 
            TrueAnswer.AutoSize = true;
            TrueAnswer.Location = new Point(19, 15);
            TrueAnswer.Name = "TrueAnswer";
            TrueAnswer.Size = new Size(69, 32);
            TrueAnswer.TabIndex = 26;
            TrueAnswer.TabStop = true;
            TrueAnswer.Text = "True";
            TrueAnswer.UseVisualStyleBackColor = true;
            // 
            // FalseAnswer
            // 
            FalseAnswer.AutoSize = true;
            FalseAnswer.Location = new Point(17, 55);
            FalseAnswer.Name = "FalseAnswer";
            FalseAnswer.Size = new Size(75, 32);
            FalseAnswer.TabIndex = 27;
            FalseAnswer.TabStop = true;
            FalseAnswer.Text = "False";
            FalseAnswer.UseVisualStyleBackColor = true;
            // 
            // MCQAnswerValue
            // 
            MCQAnswerValue.Location = new Point(112, 302);
            MCQAnswerValue.Name = "MCQAnswerValue";
            MCQAnswerValue.Size = new Size(693, 34);
            MCQAnswerValue.TabIndex = 8;
            MCQAnswerValue.Visible = false;
            // 
            // butCancle
            // 
            butCancle.Location = new Point(700, 593);
            butCancle.Name = "butCancle";
            butCancle.Size = new Size(112, 40);
            butCancle.TabIndex = 11;
            butCancle.Text = "Cancel";
            butCancle.UseVisualStyleBackColor = true;
            butCancle.Visible = false;
            // 
            // BtnSaveQuestionAndAnswer
            // 
            BtnSaveQuestionAndAnswer.Location = new Point(1012, 591);
            BtnSaveQuestionAndAnswer.Name = "BtnSaveQuestionAndAnswer";
            BtnSaveQuestionAndAnswer.Size = new Size(112, 40);
            BtnSaveQuestionAndAnswer.TabIndex = 10;
            BtnSaveQuestionAndAnswer.Text = "Save";
            BtnSaveQuestionAndAnswer.UseVisualStyleBackColor = true;
            BtnSaveQuestionAndAnswer.Click += BtnSaveQuestionAndAnswer_Click;
            // 
            // BtnAddChoice
            // 
            BtnAddChoice.Location = new Point(833, 302);
            BtnAddChoice.Name = "BtnAddChoice";
            BtnAddChoice.Size = new Size(170, 40);
            BtnAddChoice.TabIndex = 9;
            BtnAddChoice.Text = "Add Choice";
            BtnAddChoice.UseVisualStyleBackColor = true;
            BtnAddChoice.Visible = false;
            BtnAddChoice.Click += BtnAddChoice_Click;
            // 
            // AddNewEX
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 866);
            Controls.Add(panelExamQuestionForm);
            Controls.Add(NewExam);
            Controls.Add(EXCount);
            Name = "AddNewEX";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNewEX";
            Load += AddNewEX_Load;
            NewExam.ResumeLayout(false);
            NewExam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Duration).EndInit();
            panelExamQuestionForm.ResumeLayout(false);
            panelExamQuestionForm.PerformLayout();
            QuestionPanel.ResumeLayout(false);
            QuestionPanel.PerformLayout();
            TypeQuesPanel.ResumeLayout(false);
            TypeQuesPanel.PerformLayout();
            MarkPanel.ResumeLayout(false);
            MarkPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Mark).EndInit();
            panelTruFalAnswer.ResumeLayout(false);
            panelTruFalAnswer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label EXCount;
        private GroupBox NewExam;
        private Label TitleLabel;
        private TextBox Title;
        private Label labelDuration;
        private Label labelCourse;
        private NumericUpDown Duration;
        private ComboBox CourseName;
        private Button BtnSaveExam;
        private Button butAddQuestion;
        private Label labelAnswer;
        private Panel panelExamQuestionForm;
        private Label labelMark;
        private NumericUpDown Mark;
        private Label labelTypeOfQuestion;
        private ComboBox TypeOfQuestion;
        private Button BtnSaveQuestionAndAnswer;
        private Button BtnAddChoice;
        private RadioButton FalseAnswer;
        private RadioButton TrueAnswer;
        private Button butCancle;
        private TextBox MCQAnswerValue;
        private Panel panelTruFalAnswer;
        private Button butFinishingExam;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel QuestionPanel;
        private RichTextBox QuestionHead;
        private Label labelQuestionHead;
        private Panel TypeQuesPanel;
        private Panel MarkPanel;
    }
}