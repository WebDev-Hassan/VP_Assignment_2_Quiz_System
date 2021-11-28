
namespace VP_Assignment_2_Quiz_System
{
    partial class Result_Summary
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
            this.lbl_ResTitle = new System.Windows.Forms.Label();
            this.lbl_TotalMarks = new System.Windows.Forms.Label();
            this.lbl_WrongAnswers = new System.Windows.Forms.Label();
            this.lbl_SkippedQuestions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ResTitle
            // 
            this.lbl_ResTitle.AutoSize = true;
            this.lbl_ResTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ResTitle.Location = new System.Drawing.Point(184, 118);
            this.lbl_ResTitle.Name = "lbl_ResTitle";
            this.lbl_ResTitle.Size = new System.Drawing.Size(392, 25);
            this.lbl_ResTitle.TabIndex = 0;
            this.lbl_ResTitle.Text = "Result of Roll Number: 2019-ARID-3030";
            // 
            // lbl_TotalMarks
            // 
            this.lbl_TotalMarks.AutoSize = true;
            this.lbl_TotalMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalMarks.Location = new System.Drawing.Point(184, 223);
            this.lbl_TotalMarks.Name = "lbl_TotalMarks";
            this.lbl_TotalMarks.Size = new System.Drawing.Size(179, 25);
            this.lbl_TotalMarks.TabIndex = 1;
            this.lbl_TotalMarks.Text = "Total Marks: 6/10";
            this.lbl_TotalMarks.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_WrongAnswers
            // 
            this.lbl_WrongAnswers.AutoSize = true;
            this.lbl_WrongAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WrongAnswers.Location = new System.Drawing.Point(184, 269);
            this.lbl_WrongAnswers.Name = "lbl_WrongAnswers";
            this.lbl_WrongAnswers.Size = new System.Drawing.Size(187, 25);
            this.lbl_WrongAnswers.TabIndex = 2;
            this.lbl_WrongAnswers.Text = "Wrong Answers: 1";
            // 
            // lbl_SkippedQuestions
            // 
            this.lbl_SkippedQuestions.AutoSize = true;
            this.lbl_SkippedQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SkippedQuestions.Location = new System.Drawing.Point(184, 313);
            this.lbl_SkippedQuestions.Name = "lbl_SkippedQuestions";
            this.lbl_SkippedQuestions.Size = new System.Drawing.Size(217, 25);
            this.lbl_SkippedQuestions.TabIndex = 3;
            this.lbl_SkippedQuestions.Text = "Skipped Questions: 3";
            // 
            // Result_Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_SkippedQuestions);
            this.Controls.Add(this.lbl_WrongAnswers);
            this.Controls.Add(this.lbl_TotalMarks);
            this.Controls.Add(this.lbl_ResTitle);
            this.Name = "Result_Summary";
            this.Text = "Result_Summary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ResTitle;
        private System.Windows.Forms.Label lbl_TotalMarks;
        private System.Windows.Forms.Label lbl_WrongAnswers;
        private System.Windows.Forms.Label lbl_SkippedQuestions;
    }
}