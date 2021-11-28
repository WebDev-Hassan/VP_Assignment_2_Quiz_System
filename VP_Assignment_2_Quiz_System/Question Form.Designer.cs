
namespace VP_Assignment_2_Quiz_System
{
    partial class Question_Form
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.rb_opt1 = new System.Windows.Forms.RadioButton();
            this.rb_opt2 = new System.Windows.Forms.RadioButton();
            this.rb_opt3 = new System.Windows.Forms.RadioButton();
            this.btn_skip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(155, 39);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(431, 29);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "What is the National Game of Pakistan?";
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(160, 363);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(119, 39);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            // 
            // rb_opt1
            // 
            this.rb_opt1.AutoSize = true;
            this.rb_opt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_opt1.Location = new System.Drawing.Point(181, 118);
            this.rb_opt1.Name = "rb_opt1";
            this.rb_opt1.Size = new System.Drawing.Size(152, 29);
            this.rb_opt1.TabIndex = 2;
            this.rb_opt1.TabStop = true;
            this.rb_opt1.Text = "radioButton1";
            this.rb_opt1.UseVisualStyleBackColor = true;
            this.rb_opt1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_opt2
            // 
            this.rb_opt2.AutoSize = true;
            this.rb_opt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_opt2.Location = new System.Drawing.Point(181, 195);
            this.rb_opt2.Name = "rb_opt2";
            this.rb_opt2.Size = new System.Drawing.Size(152, 29);
            this.rb_opt2.TabIndex = 3;
            this.rb_opt2.TabStop = true;
            this.rb_opt2.Text = "radioButton2";
            this.rb_opt2.UseVisualStyleBackColor = true;
            // 
            // rb_opt3
            // 
            this.rb_opt3.AutoSize = true;
            this.rb_opt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_opt3.Location = new System.Drawing.Point(181, 278);
            this.rb_opt3.Name = "rb_opt3";
            this.rb_opt3.Size = new System.Drawing.Size(152, 29);
            this.rb_opt3.TabIndex = 4;
            this.rb_opt3.TabStop = true;
            this.rb_opt3.Text = "radioButton3";
            this.rb_opt3.UseVisualStyleBackColor = true;
            // 
            // btn_skip
            // 
            this.btn_skip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_skip.Location = new System.Drawing.Point(419, 363);
            this.btn_skip.Name = "btn_skip";
            this.btn_skip.Size = new System.Drawing.Size(119, 39);
            this.btn_skip.TabIndex = 5;
            this.btn_skip.Text = "Skip";
            this.btn_skip.UseVisualStyleBackColor = true;
            // 
            // Question_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_skip);
            this.Controls.Add(this.rb_opt3);
            this.Controls.Add(this.rb_opt2);
            this.Controls.Add(this.rb_opt1);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.lbl_title);
            this.Name = "Question_Form";
            this.Text = "Question_Form";
            this.Load += new System.EventHandler(this.Question_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.RadioButton rb_opt1;
        private System.Windows.Forms.RadioButton rb_opt2;
        private System.Windows.Forms.RadioButton rb_opt3;
        private System.Windows.Forms.Button btn_skip;
    }
}