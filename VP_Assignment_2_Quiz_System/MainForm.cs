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

        string RegNo { get; set; }
        Question_Form q;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            RegNo = txt_RegNo.Text.ToString();
            if (RegNo == String.Empty)
            {
                MessageBox.Show("Please enter Roll Number");
            }
            else
            {
            q = new Question_Form(RegNo);
            this.Hide();
            q.Show();
            }
        }
    }
}
