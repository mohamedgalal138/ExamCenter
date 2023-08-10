namespace ExamCenter.Viwe.Student
{
    partial class SignUp
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
            NameText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            EmailText = new TextBox();
            label3 = new Label();
            PassWordText = new TextBox();
            BtnSubmit = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // NameText
            // 
            NameText.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            NameText.Location = new Point(191, 40);
            NameText.Multiline = true;
            NameText.Name = "NameText";
            NameText.PlaceholderText = "Full Name";
            NameText.Size = new Size(469, 40);
            NameText.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(46, 40);
            label1.Name = "label1";
            label1.Size = new Size(123, 32);
            label1.TabIndex = 1;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(46, 102);
            label2.Name = "label2";
            label2.Size = new Size(81, 32);
            label2.TabIndex = 3;
            label2.Text = "E-mail";
            // 
            // EmailText
            // 
            EmailText.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            EmailText.Location = new Point(191, 102);
            EmailText.Multiline = true;
            EmailText.Name = "EmailText";
            EmailText.PlaceholderText = "E-mail";
            EmailText.Size = new Size(469, 43);
            EmailText.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(46, 172);
            label3.Name = "label3";
            label3.Size = new Size(115, 32);
            label3.TabIndex = 5;
            label3.Text = "PassWord";
            // 
            // PassWordText
            // 
            PassWordText.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            PassWordText.Location = new Point(191, 172);
            PassWordText.Name = "PassWordText";
            PassWordText.PasswordChar = '*';
            PassWordText.PlaceholderText = "PassWord";
            PassWordText.Size = new Size(469, 39);
            PassWordText.TabIndex = 4;
            PassWordText.UseSystemPasswordChar = true;
            // 
            // BtnSubmit
            // 
            BtnSubmit.FlatAppearance.BorderSize = 2;
            BtnSubmit.FlatStyle = FlatStyle.Flat;
            BtnSubmit.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSubmit.Location = new Point(191, 260);
            BtnSubmit.Name = "BtnSubmit";
            BtnSubmit.Size = new Size(152, 51);
            BtnSubmit.TabIndex = 6;
            BtnSubmit.Text = "Submit";
            BtnSubmit.UseVisualStyleBackColor = true;
            BtnSubmit.Click += Submit;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 630);
            Controls.Add(BtnSubmit);
            Controls.Add(label3);
            Controls.Add(PassWordText);
            Controls.Add(label2);
            Controls.Add(EmailText);
            Controls.Add(label1);
            Controls.Add(NameText);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameText;
        private Label label1;
        private Label label2;
        private TextBox EmailText;
        private Label label3;
        private TextBox PassWordText;
        private Button BtnSubmit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}