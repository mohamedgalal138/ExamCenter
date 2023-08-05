namespace ExamCenter.Pages.Student
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel2 = new Panel();
            button2 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            ListExamView = new DataGridView();
            CourseName = new TextBox();
            ExamDuration = new TextBox();
            ExamTitle = new TextBox();
            CountOfQuestions = new TextBox();
            label4 = new Label();
            panel4 = new Panel();
            button1 = new Button();
            errorProvider1 = new ErrorProvider(components);
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ListExamView).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(334, 656);
            panel2.Name = "panel2";
            panel2.Size = new Size(638, 64);
            panel2.TabIndex = 12;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Bottom;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(0, 2);
            button2.Name = "button2";
            button2.Size = new Size(638, 62);
            button2.TabIndex = 1;
            button2.Text = "Start";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Left;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            button5.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(334, 0);
            button5.Name = "button5";
            button5.Size = new Size(42, 656);
            button5.TabIndex = 13;
            button5.Text = "<";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 46);
            label1.Name = "label1";
            label1.Size = new Size(104, 35);
            label1.TabIndex = 14;
            label1.Text = "Course :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 96);
            label2.Name = "label2";
            label2.Size = new Size(139, 35);
            label2.TabIndex = 15;
            label2.Text = "Exam Title :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 153);
            label3.Name = "label3";
            label3.Size = new Size(124, 35);
            label3.TabIndex = 16;
            label3.Text = "Duration: ";
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 69);
            panel1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(125, 9);
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
            panel3.Size = new Size(334, 720);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ListExamView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ListExamView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ListExamView.DefaultCellStyle = dataGridViewCellStyle2;
            ListExamView.Dock = DockStyle.Fill;
            ListExamView.GridColor = Color.Black;
            ListExamView.Location = new Point(0, 69);
            ListExamView.MultiSelect = false;
            ListExamView.Name = "ListExamView";
            ListExamView.RowHeadersWidth = 51;
            ListExamView.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListExamView.RowTemplate.Height = 29;
            ListExamView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ListExamView.Size = new Size(334, 651);
            ListExamView.TabIndex = 3;
            ListExamView.CellClick += CellClick;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(17, 210);
            label4.Name = "label4";
            label4.Size = new Size(238, 35);
            label4.TabIndex = 20;
            label4.Text = "Count Of Questions:";
            // 
            // panel4
            // 
            panel4.Controls.Add(button1);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(CountOfQuestions);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(ExamTitle);
            panel4.Controls.Add(CourseName);
            panel4.Controls.Add(ExamDuration);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(376, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(596, 299);
            panel4.TabIndex = 22;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(532, 5);
            button1.Name = "button1";
            button1.Size = new Size(46, 38);
            button1.TabIndex = 22;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ListOfExams
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 720);
            Controls.Add(panel4);
            Controls.Add(button5);
            Controls.Add(panel2);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListOfExams";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListOfExams";
            Load += ListOfExams_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ListExamView).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }


        #endregion
        private Panel panel2;
        private Button button2;
        private Button button5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label label5;
        private Panel panel3;
        public DataGridView ListExamView;
        private TextBox CourseName;
        private TextBox ExamDuration;
        private TextBox ExamTitle;
        private TextBox CountOfQuestions;
        private Label label4;
        private Panel panel4;
        private Button button1;
        private ErrorProvider errorProvider1;
    }
}