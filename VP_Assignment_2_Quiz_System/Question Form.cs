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
    public partial class Question_Form : Form
    {
        List<Question> Questions = new List<Question>
        {
             new Question{ Q_Title = "How many days do we have in a week?", Q_Option1 = "2", Q_Option2 = "3", Q_Option3 ="7", Q_Answer = "7" },
             new Question{ Q_Title = "How many colors are there in a rainbow?", Q_Option1 = "2", Q_Option2 = "7", Q_Option3 ="4", Q_Answer = "7" },
             new Question{ Q_Title = "How many sides are there in a triangle?", Q_Option1 = "2", Q_Option2 = "3", Q_Option3 ="1", Q_Answer = "3" },
             new Question{ Q_Title = "Which animal is called King of Jungle?", Q_Option1 = "Lion", Q_Option2 = "Tiger", Q_Option3 ="Cheetah", Q_Answer = "Lion" },
             new Question{ Q_Title = "What do you call a house made of ice?", Q_Option1 = "Igloo", Q_Option2 = "Apartment", Q_Option3 ="Property", Q_Answer = "Igloo" },
              new Question{ Q_Title = "How many days do we have in a week?", Q_Option1 = "2", Q_Option2 = "3", Q_Option3 ="7", Q_Answer = "7" },
             new Question{ Q_Title = "How many colors are there in a rainbow?", Q_Option1 = "2", Q_Option2 = "7", Q_Option3 ="4", Q_Answer = "7" },
             new Question{ Q_Title = "How many sides are there in a triangle?", Q_Option1 = "2", Q_Option2 = "3", Q_Option3 ="1", Q_Answer = "3" },
             new Question{ Q_Title = "Which animal is called King of Jungle?", Q_Option1 = "Lion", Q_Option2 = "Tiger", Q_Option3 ="Cheetah", Q_Answer = "Lion" },
             new Question{ Q_Title = "What do you call a house made of ice?", Q_Option1 = "Igloo", Q_Option2 = "Apartment", Q_Option3 ="Property", Q_Answer = "Igloo" }
        };
        string RegNo;
        int count = -1;
        int Skipped = 0;
        int Correct = 0;
        int Wrong = 0;
        Result_Summary rs;
        public Question_Form(string RegNo)
        {
            InitializeComponent();
            this.RegNo = RegNo;
        }

        private void Question_Form_Load(object sender, EventArgs e)
        {
            getNewQuestion();
        }

        private void getNewQuestion()
        {
            this.count++;
            if (count < Questions.Count)
            {

                lbl_title.Text = Questions[count].Q_Title;
                rb_opt1.Text = Questions[count].Q_Option1;
                rb_opt2.Text = Questions[count].Q_Option2;
                rb_opt3.Text = Questions[count].Q_Option3;
                rb_opt1.Checked = false;
                rb_opt2.Checked = false;
                rb_opt3.Checked = false;
            }
            else
            {
                this.Hide();
                rs = new Result_Summary(RegNo, Correct, Wrong, Skipped);
                rs.Show();
            }
        }


        private void btn_next_Click(object sender, EventArgs e)
        {
            string ans = Questions[count].Q_Answer.ToString();
            if (rb_opt1.Checked)
            {
                if (rb_opt1.Text == ans)
                    this.Correct++;
                else
                    this.Wrong++;
                getNewQuestion();
            }
            else if (rb_opt2.Checked)
            {
                if (rb_opt2.Text == ans)
                    this.Correct++;
                else
                    this.Wrong++;
                getNewQuestion();
            }
            else if (rb_opt3.Checked)
            {
                if (rb_opt3.Text == ans)
                    this.Correct++;
                else
                    this.Wrong++;
                getNewQuestion();
            }
            else
            {
                MessageBox.Show("Please Select an Option!");
            }
        }

        private void btn_skip_Click(object sender, EventArgs e)
        {
            this.Skipped++;
            getNewQuestion();
        }
    }
}
