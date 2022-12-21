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
    public partial class replacement_frontend_form : Form
    {
        private GeneralInfoEntity pInfo;
        public replacement_frontend_form(List<GeneralInfoEntity> info)
        {
            InitializeComponent();
            pInfo = info[0];
        }

        private void make_replacement_btn_Click(object sender, EventArgs e)
        {
            //send through all information to replacement service
            this.Close();
        }

        private void replacement_frontend_form_Load(object sender, EventArgs e)
        {
            id_client_tb.Text = pInfo.id;
            name_surname_tb.Text = $"{pInfo.name} {pInfo.surname}";
            name_of_rep_tb.Text = "Add";
            fsp_name_tb.Text = "Add";
            fsp_no_tb.Text = "Add";


        }
    }
}
