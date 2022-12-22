
namespace Csharp_LB2.Forms
{
    partial class Form_worker
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
            this.w_name_textbox = new System.Windows.Forms.TextBox();
            this.w_surname_textbox = new System.Windows.Forms.TextBox();
            this.w_education_textbox = new System.Windows.Forms.TextBox();
            this.w_salary_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.w_position_combobox = new System.Windows.Forms.ComboBox();
            this.Add_worker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // w_name_textbox
            // 
            this.w_name_textbox.Location = new System.Drawing.Point(177, 12);
            this.w_name_textbox.Name = "w_name_textbox";
            this.w_name_textbox.Size = new System.Drawing.Size(207, 31);
            this.w_name_textbox.TabIndex = 0;
            // 
            // w_surname_textbox
            // 
            this.w_surname_textbox.Location = new System.Drawing.Point(177, 49);
            this.w_surname_textbox.Name = "w_surname_textbox";
            this.w_surname_textbox.Size = new System.Drawing.Size(207, 31);
            this.w_surname_textbox.TabIndex = 1;
            // 
            // w_education_textbox
            // 
            this.w_education_textbox.Location = new System.Drawing.Point(177, 86);
            this.w_education_textbox.Name = "w_education_textbox";
            this.w_education_textbox.Size = new System.Drawing.Size(207, 31);
            this.w_education_textbox.TabIndex = 2;
            // 
            // w_salary_textbox
            // 
            this.w_salary_textbox.Location = new System.Drawing.Point(177, 123);
            this.w_salary_textbox.Name = "w_salary_textbox";
            this.w_salary_textbox.Size = new System.Drawing.Size(207, 31);
            this.w_salary_textbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Education";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Position";
            // 
            // w_position_combobox
            // 
            this.w_position_combobox.FormattingEnabled = true;
            this.w_position_combobox.Items.AddRange(new object[] {
            "Seller",
            "Cleaner",
            "Guard"});
            this.w_position_combobox.Location = new System.Drawing.Point(177, 160);
            this.w_position_combobox.Name = "w_position_combobox";
            this.w_position_combobox.Size = new System.Drawing.Size(207, 33);
            this.w_position_combobox.TabIndex = 9;
            // 
            // Add_worker
            // 
            this.Add_worker.Location = new System.Drawing.Point(130, 218);
            this.Add_worker.Name = "Add_worker";
            this.Add_worker.Size = new System.Drawing.Size(182, 34);
            this.Add_worker.TabIndex = 10;
            this.Add_worker.Text = "Add worker";
            this.Add_worker.UseVisualStyleBackColor = true;
            this.Add_worker.Click += new System.EventHandler(this.Add_worker_Click);
            // 
            // Form_worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 276);
            this.Controls.Add(this.Add_worker);
            this.Controls.Add(this.w_position_combobox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.w_salary_textbox);
            this.Controls.Add(this.w_education_textbox);
            this.Controls.Add(this.w_surname_textbox);
            this.Controls.Add(this.w_name_textbox);
            this.Name = "Form_worker";
            this.Text = "Form_worker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox w_name_textbox;
        private System.Windows.Forms.TextBox w_surname_textbox;
        private System.Windows.Forms.TextBox w_education_textbox;
        private System.Windows.Forms.TextBox w_salary_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox w_position_combobox;
        private System.Windows.Forms.Button Add_worker;
    }
}