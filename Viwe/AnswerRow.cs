using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCenter.Pages
{
    public class AnswerRow 
    {
        public string text;

        public FlowLayoutPanel panel1;

        public RadioButton radio = new()
        {
            Left = 150,
            MinimumSize = new Size(500, 32),
            Padding = new()
            {
                Top = 0,
                Left = 0,
                Right = 0,
                Bottom = 0,
            },
            Name = "MCQAnswer",
            Font = new Font("Segoe UI ", 12),
            AutoSize = true,
        };

        public Button delete = new()
        {
        
            Left = 40,
            Width = 150,
            BackColor = Color.Red,
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point),
            Size = new Size(32, 32),
            TabIndex = 33,
            Text = "X",
            TextAlign = ContentAlignment.MiddleCenter,
            UseVisualStyleBackColor = false,
            
    };
        public RadioButton Add()
        {
            return radio;
        }
        public AnswerRow(string text, FlowLayoutPanel panel) {
            panel1 = panel;
            this.text = text;
            radio.Text = text;
            delete.FlatAppearance.BorderSize = 0;
            delete.Name = text;
            delete.Click += DeleteRow;
        }
        public void DeleteRow(object sender, EventArgs e)
        {
            panel1.Controls.Remove(delete);
            panel1.Controls.Remove(radio);
        }

    }
}
