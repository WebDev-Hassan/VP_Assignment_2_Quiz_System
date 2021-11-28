using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Assignment_2_Quiz_System
{
    public partial class Result_Summary : Form
    {
        public Result_Summary(string RegNo, int Total, int Wrong, int Skipped)
        {
            InitializeComponent();
            lbl_ResTitle.Text = $"Result of Roll Number: {RegNo}";
            lbl_TotalMarks.Text = $"Total Marks: {Total} / 5";
            lbl_WrongAnswers.Text = $"Wrong Answers: {Wrong}";
            lbl_SkippedQuestions.Text = $"Skipped Answers: {Skipped}";

        }
    }
}
