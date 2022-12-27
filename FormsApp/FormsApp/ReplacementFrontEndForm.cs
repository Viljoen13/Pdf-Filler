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
    public partial class ReplacementFrontEndForm : Form
    {
        private GeneralInfoEntity pInfo;
        public ReplacementFrontEndForm(List<GeneralInfoEntity> info)
        {
            InitializeComponent();
            pInfo = info[0];
        }

        public ReplacementFrontEndForm()
        {
            InitializeComponent();
        }

        private void make_replacement_btn_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void ReplacementFrontEndForm_Load(object sender, EventArgs e)
        {
            id_client_tb.Text = pInfo.id;
            name_surname_tb.Text = $"{pInfo.name} {pInfo.surname}";
            name_of_rep_tb.Text = "Add";
            fsp_name_tb.Text = "Add";
            fsp_no_tb.Text = "Add";
        }
    }
}
