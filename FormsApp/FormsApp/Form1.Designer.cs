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
            this.btn_Fill_Basic_Info = new System.Windows.Forms.Button();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Basic_Information_Label = new System.Windows.Forms.Label();
            this.Surname_TextBox = new System.Windows.Forms.TextBox();
            this.Surname_Label = new System.Windows.Forms.Label();
            this.ID_no_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Location = new System.Drawing.Point(51, 126);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(47, 16);
            this.Name_Label.TabIndex = 0;
            this.Name_Label.Text = "Name:";
            // 
            // btn_Fill_Basic_Info
            // 
            this.btn_Fill_Basic_Info.Location = new System.Drawing.Point(852, 432);
            this.btn_Fill_Basic_Info.Name = "btn_Fill_Basic_Info";
            this.btn_Fill_Basic_Info.Size = new System.Drawing.Size(82, 41);
            this.btn_Fill_Basic_Info.TabIndex = 1;
            this.btn_Fill_Basic_Info.Text = "Fill Info";
            this.btn_Fill_Basic_Info.UseVisualStyleBackColor = true;
            this.btn_Fill_Basic_Info.Click += new System.EventHandler(this.button1_Click);
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(116, 124);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(136, 22);
            this.Name_textBox.TabIndex = 2;
            // 
            // Basic_Information_Label
            // 
            this.Basic_Information_Label.AutoSize = true;
            this.Basic_Information_Label.Location = new System.Drawing.Point(427, 36);
            this.Basic_Information_Label.Name = "Basic_Information_Label";
            this.Basic_Information_Label.Size = new System.Drawing.Size(109, 16);
            this.Basic_Information_Label.TabIndex = 3;
            this.Basic_Information_Label.Text = "Basic Information";
            // 
            // Surname_TextBox
            // 
            this.Surname_TextBox.Location = new System.Drawing.Point(116, 179);
            this.Surname_TextBox.Name = "Surname_TextBox";
            this.Surname_TextBox.Size = new System.Drawing.Size(136, 22);
            this.Surname_TextBox.TabIndex = 5;
            // 
            // Surname_Label
            // 
            this.Surname_Label.AutoSize = true;
            this.Surname_Label.Location = new System.Drawing.Point(51, 181);
            this.Surname_Label.Name = "Surname_Label";
            this.Surname_Label.Size = new System.Drawing.Size(64, 16);
            this.Surname_Label.TabIndex = 4;
            this.Surname_Label.Text = "Surname:";
            // 
            // ID_no_TextBox
            // 
            this.ID_no_TextBox.Location = new System.Drawing.Point(116, 232);
            this.ID_no_TextBox.Name = "ID_no_TextBox";
            this.ID_no_TextBox.Size = new System.Drawing.Size(136, 22);
            this.ID_no_TextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID no:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(697, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 92);
            this.button1.TabIndex = 8;
            this.button1.Text = "Import excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 532);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ID_no_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Surname_TextBox);
            this.Controls.Add(this.Surname_Label);
            this.Controls.Add(this.Basic_Information_Label);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.btn_Fill_Basic_Info);
            this.Controls.Add(this.Name_Label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Button btn_Fill_Basic_Info;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Label Basic_Information_Label;
        private System.Windows.Forms.TextBox Surname_TextBox;
        private System.Windows.Forms.Label Surname_Label;
        private System.Windows.Forms.TextBox ID_no_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

