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
    public partial class MainForm : Form
    {
        List<Question> Questions = new List<Question>
        {
             new Question{ Q_ID = 1, Q_Title = "How many days do we have in a week?", Q_Option1 = "2", Q_Option2 = "3", Q_Option3 ="7", Q_Answer = 3 },
             new Question{ Q_ID = 2, Q_Title = "How many colors are there in a rainbow?", Q_Option1 = "2", Q_Option2 = "7", Q_Option3 ="4", Q_Answer = 2 },
             new Question{ Q_ID = 3, Q_Title = "How many sides are there in a triangle?", Q_Option1 = "2", Q_Option2 = "3", Q_Option3 ="1", Q_Answer = 2 },
             new Question{ Q_ID = 4, Q_Title = "Which animal is called King of Jungle?", Q_Option1 = "Lion", Q_Option2 = "Tiger", Q_Option3 ="Cheetah", Q_Answer = 1 },
             new Question{ Q_ID = 5, Q_Title = "What do you call a house made of ice?", Q_Option1 = "Igloo", Q_Option2 = "Apartment", Q_Option3 ="Property", Q_Answer = 1 }

        };
        public string RegNo { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            RegNo = txt_RegNo.Text.ToString();
        }
    }
}
