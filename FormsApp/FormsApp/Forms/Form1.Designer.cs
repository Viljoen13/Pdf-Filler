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
            this.statementOfHealth_cb = new System.Windows.Forms.CheckBox();
            this.replacementPolicyAdvice_cb = new System.Windows.Forms.CheckBox();
            this.cb_replacementAdvice = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_FSPNo = new System.Windows.Forms.TextBox();
            this.tb_NameOfRep = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_FSPName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.gb_CreateForms = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gb_CreateForms.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Location = new System.Drawing.Point(31, 32);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(47, 16);
            this.Name_Label.TabIndex = 0;
            this.Name_Label.Text = "Name:";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(158, 32);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(136, 22);
            this.Name_textBox.TabIndex = 2;
            // 
            // Basic_Information_Label
            // 
            this.Basic_Information_Label.AutoSize = true;
            this.Basic_Information_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Basic_Information_Label.Location = new System.Drawing.Point(80, 11);
            this.Basic_Information_Label.Name = "Basic_Information_Label";
            this.Basic_Information_Label.Size = new System.Drawing.Size(159, 32);
            this.Basic_Information_Label.TabIndex = 3;
            this.Basic_Information_Label.Text = "Main Page";
            // 
            // Surname_TextBox
            // 
            this.Surname_TextBox.Location = new System.Drawing.Point(158, 69);
            this.Surname_TextBox.Name = "Surname_TextBox";
            this.Surname_TextBox.Size = new System.Drawing.Size(136, 22);
            this.Surname_TextBox.TabIndex = 5;
            // 
            // Surname_Label
            // 
            this.Surname_Label.AutoSize = true;
            this.Surname_Label.Location = new System.Drawing.Point(31, 69);
            this.Surname_Label.Name = "Surname_Label";
            this.Surname_Label.Size = new System.Drawing.Size(64, 16);
            this.Surname_Label.TabIndex = 4;
            this.Surname_Label.Text = "Surname:";
            // 
            // ID_no_TextBox
            // 
            this.ID_no_TextBox.Location = new System.Drawing.Point(158, 106);
            this.ID_no_TextBox.Name = "ID_no_TextBox";
            this.ID_no_TextBox.Size = new System.Drawing.Size(136, 22);
            this.ID_no_TextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID no:";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(331, 92);
            this.button1.TabIndex = 8;
            this.button1.Text = "Import excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // maidenName_textBox
            // 
            this.maidenName_textBox.Location = new System.Drawing.Point(158, 144);
            this.maidenName_textBox.Name = "maidenName_textBox";
            this.maidenName_textBox.Size = new System.Drawing.Size(136, 22);
            this.maidenName_textBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Maiden name:";
            // 
            // occupation_textBox
            // 
            this.occupation_textBox.Location = new System.Drawing.Point(158, 186);
            this.occupation_textBox.Name = "occupation_textBox";
            this.occupation_textBox.Size = new System.Drawing.Size(136, 22);
            this.occupation_textBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Occupation:";
            // 
            // qualification_textBox
            // 
            this.qualification_textBox.Location = new System.Drawing.Point(158, 225);
            this.qualification_textBox.Name = "qualification_textBox";
            this.qualification_textBox.Size = new System.Drawing.Size(136, 22);
            this.qualification_textBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Qualification:";
            // 
            // grossIncome_textBox
            // 
            this.grossIncome_textBox.Location = new System.Drawing.Point(158, 314);
            this.grossIncome_textBox.Name = "grossIncome_textBox";
            this.grossIncome_textBox.Size = new System.Drawing.Size(136, 22);
            this.grossIncome_textBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Gross Income:";
            // 
            // durationOfCourse_textBox
            // 
            this.durationOfCourse_textBox.Location = new System.Drawing.Point(158, 269);
            this.durationOfCourse_textBox.Name = "durationOfCourse_textBox";
            this.durationOfCourse_textBox.Size = new System.Drawing.Size(136, 22);
            this.durationOfCourse_textBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Duration of course:";
            // 
            // Close_btn
            // 
            this.Close_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Close_btn.FlatAppearance.BorderSize = 0;
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_btn.Location = new System.Drawing.Point(0, 472);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(331, 87);
            this.Close_btn.TabIndex = 19;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // statementOfHealth_cb
            // 
            this.statementOfHealth_cb.AutoSize = true;
            this.statementOfHealth_cb.Location = new System.Drawing.Point(18, 37);
            this.statementOfHealth_cb.Name = "statementOfHealth_cb";
            this.statementOfHealth_cb.Size = new System.Drawing.Size(142, 20);
            this.statementOfHealth_cb.TabIndex = 24;
            this.statementOfHealth_cb.Text = "Statement of health";
            this.statementOfHealth_cb.UseVisualStyleBackColor = true;
            // 
            // replacementPolicyAdvice_cb
            // 
            this.replacementPolicyAdvice_cb.AutoSize = true;
            this.replacementPolicyAdvice_cb.Location = new System.Drawing.Point(18, 63);
            this.replacementPolicyAdvice_cb.Name = "replacementPolicyAdvice_cb";
            this.replacementPolicyAdvice_cb.Size = new System.Drawing.Size(193, 20);
            this.replacementPolicyAdvice_cb.TabIndex = 25;
            this.replacementPolicyAdvice_cb.Text = "Replacement policy advice";
            this.replacementPolicyAdvice_cb.UseVisualStyleBackColor = true;
            this.replacementPolicyAdvice_cb.CheckedChanged += new System.EventHandler(this.replacementPolicyAdvice_cb_CheckedChanged_1);
            // 
            // cb_replacementAdvice
            // 
            this.cb_replacementAdvice.AutoSize = true;
            this.cb_replacementAdvice.Location = new System.Drawing.Point(18, 89);
            this.cb_replacementAdvice.Name = "cb_replacementAdvice";
            this.cb_replacementAdvice.Size = new System.Drawing.Size(149, 20);
            this.cb_replacementAdvice.TabIndex = 26;
            this.cb_replacementAdvice.Text = "Replacement policy";
            this.cb_replacementAdvice.UseVisualStyleBackColor = true;
            this.cb_replacementAdvice.CheckedChanged += new System.EventHandler(this.cb_replacementAdvice_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Name_textBox);
            this.groupBox1.Controls.Add(this.Name_Label);
            this.groupBox1.Controls.Add(this.Surname_Label);
            this.groupBox1.Controls.Add(this.Surname_TextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ID_no_TextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.durationOfCourse_textBox);
            this.groupBox1.Controls.Add(this.maidenName_textBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.grossIncome_textBox);
            this.groupBox1.Controls.Add(this.occupation_textBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.qualification_textBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 359);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_FSPNo);
            this.groupBox2.Controls.Add(this.tb_NameOfRep);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tb_FSPName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(13, 386);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 161);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Company Information";
            // 
            // tb_FSPNo
            // 
            this.tb_FSPNo.Location = new System.Drawing.Point(158, 112);
            this.tb_FSPNo.Name = "tb_FSPNo";
            this.tb_FSPNo.Size = new System.Drawing.Size(136, 22);
            this.tb_FSPNo.TabIndex = 32;
            // 
            // tb_NameOfRep
            // 
            this.tb_NameOfRep.Location = new System.Drawing.Point(158, 32);
            this.tb_NameOfRep.Name = "tb_NameOfRep";
            this.tb_NameOfRep.Size = new System.Drawing.Size(136, 22);
            this.tb_NameOfRep.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "FSP Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 16);
            this.label10.TabIndex = 33;
            this.label10.Text = "Name of representative";
            // 
            // tb_FSPName
            // 
            this.tb_FSPName.Location = new System.Drawing.Point(158, 74);
            this.tb_FSPName.Name = "tb_FSPName";
            this.tb_FSPName.Size = new System.Drawing.Size(136, 22);
            this.tb_FSPName.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "FSP Name";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Clear.FlatAppearance.BorderSize = 0;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(0, 385);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(331, 87);
            this.btn_Clear.TabIndex = 29;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // gb_CreateForms
            // 
            this.gb_CreateForms.Controls.Add(this.statementOfHealth_cb);
            this.gb_CreateForms.Controls.Add(this.replacementPolicyAdvice_cb);
            this.gb_CreateForms.Controls.Add(this.cb_replacementAdvice);
            this.gb_CreateForms.Location = new System.Drawing.Point(46, 96);
            this.gb_CreateForms.Name = "gb_CreateForms";
            this.gb_CreateForms.Size = new System.Drawing.Size(242, 131);
            this.gb_CreateForms.TabIndex = 30;
            this.gb_CreateForms.TabStop = false;
            this.gb_CreateForms.Text = "Create following forms";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 559);
            this.panel1.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_Clear);
            this.panel2.Controls.Add(this.Close_btn);
            this.panel2.Location = new System.Drawing.Point(707, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 559);
            this.panel2.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.gb_CreateForms);
            this.panel3.Controls.Add(this.Basic_Information_Label);
            this.panel3.Location = new System.Drawing.Point(384, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 559);
            this.panel3.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 559);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Main page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gb_CreateForms.ResumeLayout(false);
            this.gb_CreateForms.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.CheckBox statementOfHealth_cb;
        private System.Windows.Forms.CheckBox replacementPolicyAdvice_cb;
        private System.Windows.Forms.CheckBox cb_replacementAdvice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_NameOfRep;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_FSPName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_FSPNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.GroupBox gb_CreateForms;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

