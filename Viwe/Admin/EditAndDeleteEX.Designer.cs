namespace ExamCenter.Pages.Admin
{
    partial class EditAndDeleteEX
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
            panel1 = new Panel();
            ExamList = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            panel4 = new Panel();
            label6 = new Label();
            label2 = new Label();
            CountOfQuestions = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ExamTitle = new TextBox();
            CourseName = new TextBox();
            ExamDuration = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExamList).BeginInit();
            panel2.SuspendLayout();
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
            ExamList.BackgroundColor = Color.White;
            ExamList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ExamList.Dock = DockStyle.Left;
            ExamList.GridColor = Color.Black;
            ExamList.Location = new Point(0, 75);
            ExamList.Name = "ExamList";
            ExamList.ReadOnly = true;
            ExamList.RowHeadersWidth = 51;
            ExamList.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ExamList.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExamList.RowTemplate.Height = 29;
            ExamList.Size = new Size(382, 738);
            ExamList.TabIndex = 1;
            ExamList.CellContentClick += ExamList_CellContentClick;
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
            label1.Location = new Point(112, 23);
            label1.Name = "label1";
            label1.Size = new Size(98, 37);
            label1.TabIndex = 1;
            label1.Text = "Exams";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.FlatAppearance.BorderSize = 2;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(730, 0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(293, 75);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Transparent;
            btnUpdate.FlatAppearance.BorderSize = 2;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(730, 78);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(293, 79);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.FlatAppearance.BorderSize = 2;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(730, 160);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(293, 80);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(CountOfQuestions);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(ExamTitle);
            panel4.Controls.Add(CourseName);
            panel4.Controls.Add(ExamDuration);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(382, 540);
            panel4.Name = "panel4";
            panel4.Size = new Size(646, 273);
            panel4.TabIndex = 23;
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
            CountOfQuestions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CountOfQuestions.Location = new Point(246, 226);
            CountOfQuestions.Name = "CountOfQuestions";
            CountOfQuestions.ReadOnly = true;
            CountOfQuestions.Size = new Size(108, 27);
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
            ExamTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExamTitle.Location = new Point(154, 113);
            ExamTitle.Name = "ExamTitle";
            ExamTitle.ReadOnly = true;
            ExamTitle.Size = new Size(206, 27);
            ExamTitle.TabIndex = 19;
            // 
            // CourseName
            // 
            CourseName.BorderStyle = BorderStyle.None;
            CourseName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CourseName.Location = new Point(154, 62);
            CourseName.Name = "CourseName";
            CourseName.ReadOnly = true;
            CourseName.Size = new Size(206, 27);
            CourseName.TabIndex = 17;
            // 
            // ExamDuration
            // 
            ExamDuration.BorderStyle = BorderStyle.None;
            ExamDuration.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExamDuration.Location = new Point(154, 170);
            ExamDuration.Name = "ExamDuration";
            ExamDuration.ReadOnly = true;
            ExamDuration.Size = new Size(105, 27);
            ExamDuration.TabIndex = 18;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Dock = DockStyle.Left;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(382, 0);
            button1.Name = "button1";
            button1.Size = new Size(45, 540);
            button1.TabIndex = 24;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // EditAndDeleteEX
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 813);
            Controls.Add(button1);
            Controls.Add(panel4);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(panel1);
            Name = "EditAndDeleteEX";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditAndDeleteEX";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ExamList).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private DataGridView ExamList;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
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
        private Button button1;
    }
}