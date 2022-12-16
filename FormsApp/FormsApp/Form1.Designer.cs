namespace FormsApp
{
    partial class Form1
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
            this.Name_Label = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Basic_Information_Label = new System.Windows.Forms.Label();
            this.Surname_TextBox = new System.Windows.Forms.TextBox();
            this.Surname_Label = new System.Windows.Forms.Label();
            this.ID_no_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.maidenName_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.occupation_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.qualification_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grossIncome_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.durationOfCourse_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Close_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.createForms_btn = new System.Windows.Forms.Button();
            this.statementOfHealth_cb = new System.Windows.Forms.CheckBox();
            this.replacementPolicyAdvice_cb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Location = new System.Drawing.Point(21, 87);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(49, 17);
            this.Name_Label.TabIndex = 0;
            this.Name_Label.Text = "Name:";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(148, 87);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(136, 22);
            this.Name_textBox.TabIndex = 2;
            // 
            // Basic_Information_Label
            // 
            this.Basic_Information_Label.AutoSize = true;
            this.Basic_Information_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Basic_Information_Label.Location = new System.Drawing.Point(357, 9);
            this.Basic_Information_Label.Name = "Basic_Information_Label";
            this.Basic_Information_Label.Size = new System.Drawing.Size(251, 32);
            this.Basic_Information_Label.TabIndex = 3;
            this.Basic_Information_Label.Text = "Basic Information";
            // 
            // Surname_TextBox
            // 
            this.Surname_TextBox.Location = new System.Drawing.Point(148, 125);
            this.Surname_TextBox.Name = "Surname_TextBox";
            this.Surname_TextBox.Size = new System.Drawing.Size(136, 22);
            this.Surname_TextBox.TabIndex = 5;
            // 
            // Surname_Label
            // 
            this.Surname_Label.AutoSize = true;
            this.Surname_Label.Location = new System.Drawing.Point(21, 130);
            this.Surname_Label.Name = "Surname_Label";
            this.Surname_Label.Size = new System.Drawing.Size(69, 17);
            this.Surname_Label.TabIndex = 4;
            this.Surname_Label.Text = "Surname:";
            // 
            // ID_no_TextBox
            // 
            this.ID_no_TextBox.Location = new System.Drawing.Point(148, 174);
            this.ID_no_TextBox.Name = "ID_no_TextBox";
            this.ID_no_TextBox.Size = new System.Drawing.Size(136, 22);
            this.ID_no_TextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID no:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(835, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 92);
            this.button1.TabIndex = 8;
            this.button1.Text = "Import excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // maidenName_textBox
            // 
            this.maidenName_textBox.Location = new System.Drawing.Point(148, 240);
            this.maidenName_textBox.Name = "maidenName_textBox";
            this.maidenName_textBox.Size = new System.Drawing.Size(136, 22);
            this.maidenName_textBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Maiden name:";
            // 
            // occupation_textBox
            // 
            this.occupation_textBox.Location = new System.Drawing.Point(148, 282);
            this.occupation_textBox.Name = "occupation_textBox";
            this.occupation_textBox.Size = new System.Drawing.Size(136, 22);
            this.occupation_textBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Occupation:";
            // 
            // qualification_textBox
            // 
            this.qualification_textBox.Location = new System.Drawing.Point(148, 325);
            this.qualification_textBox.Name = "qualification_textBox";
            this.qualification_textBox.Size = new System.Drawing.Size(136, 22);
            this.qualification_textBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Qualification:";
            // 
            // grossIncome_textBox
            // 
            this.grossIncome_textBox.Location = new System.Drawing.Point(148, 411);
            this.grossIncome_textBox.Name = "grossIncome_textBox";
            this.grossIncome_textBox.Size = new System.Drawing.Size(136, 22);
            this.grossIncome_textBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Gross Income:";
            // 
            // durationOfCourse_textBox
            // 
            this.durationOfCourse_textBox.Location = new System.Drawing.Point(148, 369);
            this.durationOfCourse_textBox.Name = "durationOfCourse_textBox";
            this.durationOfCourse_textBox.Size = new System.Drawing.Size(136, 22);
            this.durationOfCourse_textBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Duration of course:";
            // 
            // Close_btn
            // 
            this.Close_btn.Location = new System.Drawing.Point(835, 232);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(188, 87);
            this.Close_btn.TabIndex = 19;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Create following forms:";
            // 
            // createForms_btn
            // 
            this.createForms_btn.Location = new System.Drawing.Point(835, 134);
            this.createForms_btn.Name = "createForms_btn";
            this.createForms_btn.Size = new System.Drawing.Size(188, 92);
            this.createForms_btn.TabIndex = 23;
            this.createForms_btn.Text = "Create forms";
            this.createForms_btn.UseVisualStyleBackColor = true;
            this.createForms_btn.Click += new System.EventHandler(this.createForms_btn_Click);
            // 
            // statementOfHealth_cb
            // 
            this.statementOfHealth_cb.AutoSize = true;
            this.statementOfHealth_cb.Location = new System.Drawing.Point(391, 121);
            this.statementOfHealth_cb.Name = "statementOfHealth_cb";
            this.statementOfHealth_cb.Size = new System.Drawing.Size(153, 21);
            this.statementOfHealth_cb.TabIndex = 24;
            this.statementOfHealth_cb.Text = "Statement of health";
            this.statementOfHealth_cb.UseVisualStyleBackColor = true;
            // 
            // replacementPolicyAdvice_cb
            // 
            this.replacementPolicyAdvice_cb.AutoSize = true;
            this.replacementPolicyAdvice_cb.Location = new System.Drawing.Point(391, 148);
            this.replacementPolicyAdvice_cb.Name = "replacementPolicyAdvice_cb";
            this.replacementPolicyAdvice_cb.Size = new System.Drawing.Size(198, 21);
            this.replacementPolicyAdvice_cb.TabIndex = 25;
            this.replacementPolicyAdvice_cb.Text = "Replacement policy advice";
            this.replacementPolicyAdvice_cb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 532);
            this.Controls.Add(this.replacementPolicyAdvice_cb);
            this.Controls.Add(this.statementOfHealth_cb);
            this.Controls.Add(this.createForms_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.durationOfCourse_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grossIncome_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.qualification_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.occupation_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maidenName_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ID_no_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Surname_TextBox);
            this.Controls.Add(this.Surname_Label);
            this.Controls.Add(this.Basic_Information_Label);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.Name_Label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Label Basic_Information_Label;
        private System.Windows.Forms.TextBox Surname_TextBox;
        private System.Windows.Forms.Label Surname_Label;
        private System.Windows.Forms.TextBox ID_no_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox maidenName_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox occupation_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox qualification_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox grossIncome_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox durationOfCourse_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button createForms_btn;
        private System.Windows.Forms.CheckBox statementOfHealth_cb;
        private System.Windows.Forms.CheckBox replacementPolicyAdvice_cb;
    }
}

