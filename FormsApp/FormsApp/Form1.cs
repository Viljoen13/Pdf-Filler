using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!verifyInputInfo())
                return;

            Client_Information Info = new Client_Information
            {
                Name = Name_textBox.Text,
                Surname = Surname_TextBox.Text,
                Id = ID_no_TextBox.Text
            };

            var test = Info;
        }

        private bool verifyInputInfo()
        {
            return true;
        }
    }
}
