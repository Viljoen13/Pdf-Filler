namespace FormsApp
{
    partial class replacement_frontend_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.make_replacement_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Testingggg";
            // 
            // make_replacement_btn
            // 
            this.make_replacement_btn.Location = new System.Drawing.Point(662, 366);
            this.make_replacement_btn.Name = "make_replacement_btn";
            this.make_replacement_btn.Size = new System.Drawing.Size(111, 61);
            this.make_replacement_btn.TabIndex = 1;
            this.make_replacement_btn.Text = "Done";
            this.make_replacement_btn.UseVisualStyleBackColor = true;
            this.make_replacement_btn.Click += new System.EventHandler(this.make_replacement_btn_Click);
            // 
            // replacement_frontend_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.make_replacement_btn);
            this.Controls.Add(this.label1);
            this.Name = "replacement_frontend_form";
            this.Text = "replacement_frontend_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button make_replacement_btn;
    }
}