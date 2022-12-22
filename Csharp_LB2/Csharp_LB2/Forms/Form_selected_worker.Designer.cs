
namespace Csharp_LB2.Forms
{
    partial class Form_selected_worker
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.w_salary_textbox = new System.Windows.Forms.TextBox();
            this.w_education_textbox = new System.Windows.Forms.TextBox();
            this.w_surname_textbox = new System.Windows.Forms.TextBox();
            this.w_name_textbox = new System.Windows.Forms.TextBox();
            this.w_position_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Education";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // w_salary_textbox
            // 
            this.w_salary_textbox.Location = new System.Drawing.Point(178, 132);
            this.w_salary_textbox.Name = "w_salary_textbox";
            this.w_salary_textbox.Size = new System.Drawing.Size(207, 31);
            this.w_salary_textbox.TabIndex = 13;
            // 
            // w_education_textbox
            // 
            this.w_education_textbox.Location = new System.Drawing.Point(178, 95);
            this.w_education_textbox.Name = "w_education_textbox";
            this.w_education_textbox.Size = new System.Drawing.Size(207, 31);
            this.w_education_textbox.TabIndex = 12;
            // 
            // w_surname_textbox
            // 
            this.w_surname_textbox.Location = new System.Drawing.Point(178, 58);
            this.w_surname_textbox.Name = "w_surname_textbox";
            this.w_surname_textbox.Size = new System.Drawing.Size(207, 31);
            this.w_surname_textbox.TabIndex = 11;
            // 
            // w_name_textbox
            // 
            this.w_name_textbox.Location = new System.Drawing.Point(178, 21);
            this.w_name_textbox.Name = "w_name_textbox";
            this.w_name_textbox.Size = new System.Drawing.Size(207, 31);
            this.w_name_textbox.TabIndex = 10;
            // 
            // w_position_textbox
            // 
            this.w_position_textbox.Location = new System.Drawing.Point(178, 172);
            this.w_position_textbox.Name = "w_position_textbox";
            this.w_position_textbox.Size = new System.Drawing.Size(207, 31);
            this.w_position_textbox.TabIndex = 19;
            // 
            // Form_selected_worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 236);
            this.Controls.Add(this.w_position_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.w_salary_textbox);
            this.Controls.Add(this.w_education_textbox);
            this.Controls.Add(this.w_surname_textbox);
            this.Controls.Add(this.w_name_textbox);
            this.Name = "Form_selected_worker";
            this.Text = "Form_selected_worker";
            this.Load += new System.EventHandler(this.Form_selected_worker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox w_salary_textbox;
        private System.Windows.Forms.TextBox w_education_textbox;
        private System.Windows.Forms.TextBox w_surname_textbox;
        private System.Windows.Forms.TextBox w_name_textbox;
        private System.Windows.Forms.TextBox w_position_textbox;
    }
}