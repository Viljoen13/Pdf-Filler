using formsApp.service;
using FormsApp.entities;
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

            var data = new replacementEntity
            {
                nameSurname = name_surname_tb.Text,
                id = id_client_tb.Text,
                fspName = fsp_name_tb.Text,
                representative = "asd",
                fspNumber = "asd",
                newPolicies = new List<string> { tb_policy1.Text, tb_policy2.Text, tb_policy3.Text },
                newInsurers = new List<string> { tb_insurer1.Text, tb_insurer2.Text, tb_insurer3.Text },
                replacedPolicies = new List<string> { tb_replacepolicy1.Text, tb_replacepolicy2.Text, tb_replacepolicy3.Text },
                replacedInsurers = new List<string> { tb_replaceinsurer1.Text, tb_replaceinsurer2.Text, tb_replaceinsurer3.Text },
                customerChecks = fill_cbs_cb.Checked,
                internetCheck = cb_Internet.Checked,
                telephoneCheck = cb_Telephone.Checked,
                directCheck = cb_DirectMarketing.Checked,
                date = dateTimePicker1.Value,
                reference = tb_ref_no.Text
            };

            _ = new replacementFileWriter(data);

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
