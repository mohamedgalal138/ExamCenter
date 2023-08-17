namespace ExamCenter.Pages.Admin
{
    partial class EditeAndDeleteExam
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            ExamList = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            button1 = new Button();
            BtnLogOut = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label6 = new Label();
            label2 = new Label();
            CountOfQuestions = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ExamTitle = new TextBox();
            CourseName = new TextBox();
            ExamDuration = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExamList).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ExamList);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 813);
            panel1.TabIndex = 0;
            // 
            // ExamList
            // 
            ExamList.AllowUserToAddRows = false;
            ExamList.AllowUserToDeleteRows = false;
            ExamList.AllowUserToResizeColumns = false;
            ExamList.AllowUserToResizeRows = false;
            ExamList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ExamList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            ExamList.BackgroundColor = Color.White;
            ExamList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ExamList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ExamList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ExamList.Dock = DockStyle.Left;
            ExamList.GridColor = Color.Black;
            ExamList.Location = new Point(0, 75);
            ExamList.MultiSelect = false;
            ExamList.Name = "ExamList";
            ExamList.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ExamList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ExamList.RowHeadersWidth = 51;
            ExamList.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ExamList.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExamList.RowTemplate.Height = 29;
            ExamList.RowTemplate.Resizable = DataGridViewTriState.False;
            ExamList.ShowCellToolTips = false;
            ExamList.ShowEditingIcon = false;
            ExamList.ShowRowErrors = false;
            ExamList.Size = new Size(382, 738);
            ExamList.TabIndex = 1;
            ExamList.CellClick += ExamList_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(382, 75);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(130, 23);
            label1.Name = "label1";
            label1.Size = new Size(98, 37);
            label1.TabIndex = 1;
            label1.Text = "Exams";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Dock = DockStyle.Left;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(382, 0);
            button1.Name = "button1";
            button1.Size = new Size(45, 813);
            button1.TabIndex = 24;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BtnLogOut
            // 
            BtnLogOut.AutoSize = true;
            BtnLogOut.BackColor = Color.Red;
            BtnLogOut.Dock = DockStyle.Left;
            BtnLogOut.FlatAppearance.BorderColor = Color.Red;
            BtnLogOut.FlatAppearance.BorderSize = 0;
            BtnLogOut.FlatStyle = FlatStyle.Flat;
            BtnLogOut.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BtnLogOut.ForeColor = Color.White;
            BtnLogOut.Location = new Point(0, 0);
            BtnLogOut.Name = "BtnLogOut";
            BtnLogOut.Size = new Size(114, 57);
            BtnLogOut.TabIndex = 28;
            BtnLogOut.Text = "LogOut";
            BtnLogOut.UseVisualStyleBackColor = false;
            BtnLogOut.Click += BtnLogOut_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(BtnLogOut);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(427, 756);
            panel3.Name = "panel3";
            panel3.Size = new Size(601, 57);
            panel3.TabIndex = 29;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnAdd);
            panel4.Controls.Add(btnUpdate);
            panel4.Controls.Add(btnDelete);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(CountOfQuestions);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(ExamTitle);
            panel4.Controls.Add(CourseName);
            panel4.Controls.Add(ExamDuration);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(427, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(601, 377);
            panel4.TabIndex = 30;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.FlatAppearance.BorderColor = Color.Green;
            btnAdd.FlatAppearance.BorderSize = 2;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(5, 282);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(192, 80);
            btnAdd.TabIndex = 30;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Blue;
            btnUpdate.FlatAppearance.BorderColor = Color.Blue;
            btnUpdate.FlatAppearance.BorderSize = 2;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(203, 282);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(192, 80);
            btnUpdate.TabIndex = 29;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatAppearance.BorderColor = Color.Red;
            btnDelete.FlatAppearance.BorderSize = 2;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(400, 282);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(192, 80);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(3, 3);
            label6.Name = "label6";
            label6.Size = new Size(156, 39);
            label6.TabIndex = 22;
            label6.Text = "Exam Ditels";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(9, 54);
            label2.Name = "label2";
            label2.Size = new Size(104, 35);
            label2.TabIndex = 14;
            label2.Text = "Course :";
            // 
            // CountOfQuestions
            // 
            CountOfQuestions.BorderStyle = BorderStyle.None;
            CountOfQuestions.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CountOfQuestions.Location = new Point(254, 226);
            CountOfQuestions.Name = "CountOfQuestions";
            CountOfQuestions.ReadOnly = true;
            CountOfQuestions.Size = new Size(90, 34);
            CountOfQuestions.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(9, 104);
            label3.Name = "label3";
            label3.Size = new Size(139, 35);
            label3.TabIndex = 15;
            label3.Text = "Exam Title :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(9, 218);
            label4.Name = "label4";
            label4.Size = new Size(238, 35);
            label4.TabIndex = 20;
            label4.Text = "Count Of Questions:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(9, 161);
            label5.Name = "label5";
            label5.Size = new Size(124, 35);
            label5.TabIndex = 16;
            label5.Text = "Duration: ";
            // 
            // ExamTitle
            // 
            ExamTitle.BorderStyle = BorderStyle.None;
            ExamTitle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ExamTitle.Location = new Point(154, 113);
            ExamTitle.Name = "ExamTitle";
            ExamTitle.ReadOnly = true;
            ExamTitle.Size = new Size(206, 34);
            ExamTitle.TabIndex = 19;
            // 
            // CourseName
            // 
            CourseName.BorderStyle = BorderStyle.None;
            CourseName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CourseName.Location = new Point(122, 62);
            CourseName.Name = "CourseName";
            CourseName.ReadOnly = true;
            CourseName.Size = new Size(206, 34);
            CourseName.TabIndex = 17;
            // 
            // ExamDuration
            // 
            ExamDuration.BorderStyle = BorderStyle.None;
            ExamDuration.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ExamDuration.Location = new Point(139, 170);
            ExamDuration.Name = "ExamDuration";
            ExamDuration.ReadOnly = true;
            ExamDuration.Size = new Size(120, 34);
            ExamDuration.TabIndex = 18;
            // 
            // EditeAndDeleteExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 813);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "EditeAndDeleteExam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditAndDeleteEX";
            Load += EditeAndDeleteExam_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ExamList).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private DataGridView ExamList;
        private Button button1;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button BtnLogOut;
        private Panel panel3;
        private Panel panel4;
        private Label label6;
        private Label label2;
        private TextBox CountOfQuestions;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox ExamTitle;
        private TextBox CourseName;
        private TextBox ExamDuration;
    }
}