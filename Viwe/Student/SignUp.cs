using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamCenter.Viwe.Student
{
    public partial class SignUp : Form
    {

        string regex;
        public SignUp()
        {
            InitializeComponent();
        }


        public void SIGNUP(Object o, EventArgs e)
        {
            regex = @"[a-z] | [A-Z]";
            Regex s = new Regex(regex);
            if (s.IsMatch(textBox1.Text))
            {
                MessageBox.Show("Done...");
            }
            else
            {
                MessageBox.Show("Error...");
            }
        }


    }
}
