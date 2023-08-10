namespace ExamCenter.Pages.Student
{
    partial class DoExam
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
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            button2 = new Button();
            panel2 = new Panel();
            timer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(44, 104);
            label4.Name = "label4";
            label4.Size = new Size(107, 32);
            label4.TabIndex = 20;
            label4.Text = "Course : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(44, 59);
            label3.Name = "label3";
            label3.Size = new Size(135, 32);
            label3.TabIndex = 19;
            label3.Text = "Exam Title: ";
          
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(392, 8);
            label5.Name = "label5";
            label5.Size = new Size(47, 37);
            label5.TabIndex = 27;
            label5.Text = "00";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(890, 9);
            button1.Name = "button1";
            button1.Size = new Size(46, 37);
            button1.TabIndex = 28;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 653);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 88);
            panel1.TabIndex = 29;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            button2.FlatAppearance.MouseOverBackColor = Color.Green;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(701, 20);
            button2.Name = "button2";
            button2.Size = new Size(158, 56);
            button2.TabIndex = 0;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 181);
            panel2.Name = "panel2";
            panel2.Size = new Size(957, 472);
            panel2.TabIndex = 30;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tag = "Duration";
            timer.Tick += timer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(455, 8);
            label1.Name = "label1";
            label1.Size = new Size(47, 37);
            label1.TabIndex = 31;
            label1.Text = "00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(436, 9);
            label2.Name = "label2";
            label2.Size = new Size(23, 37);
            label2.TabIndex = 32;
            label2.Text = ":";
            // 
            // DoExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 741);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DoExam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoExam";
            Load += DoExam_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label3;
        private Label label5;
        private Button button1;
        private Panel panel1;
        private Button button2;
        private Panel panel2;
        private System.Windows.Forms.Timer timer;
        private Label label1;
        private Label label2;
    }
}