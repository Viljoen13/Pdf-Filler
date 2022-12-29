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
    public partial class replacement_advice_frontend_form : Form
    {
        private GeneralInfoEntity pInfo;

        public PolicyDetails policyDetails = new PolicyDetails();
        public replacement_advice_frontend_form(List<GeneralInfoEntity> info, PolicyDetails policyDetails)
        {
            InitializeComponent();
            pInfo = info[0];

            if (policyDetails != null)
                this.policyDetails = policyDetails;
            else
            {
                this.policyDetails.newPolicies = new Dictionary<string, string>();
                this.policyDetails.policyReplaced = new Dictionary<string, string>();
            }
        }

        private void make_replacement_btn_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(tb_policy1.Text) && !policyDetails.newPolicies.ContainsKey(tb_policy1.Text))
                policyDetails.newPolicies.Add(tb_policy1.Text, tb_insurer1.Text);

            if (!string.IsNullOrEmpty(tb_policy2.Text) && !policyDetails.newPolicies.ContainsKey(tb_policy1.Text))
                policyDetails.newPolicies.Add(tb_policy2.Text, tb_insurer2.Text);

            if (!string.IsNullOrEmpty(tb_policy3.Text) && !policyDetails.newPolicies.ContainsKey(tb_policy1.Text))
                policyDetails.newPolicies.Add(tb_policy3.Text, tb_insurer3.Text);

            if (!string.IsNullOrEmpty(tb_replacepolicy1.Text) && !policyDetails.policyReplaced.ContainsKey(tb_replacepolicy1.Text))
                policyDetails.policyReplaced.Add(tb_replacepolicy1.Text, tb_replaceinsurer1.Text);

            if (!string.IsNullOrEmpty(tb_replacepolicy2.Text) && !policyDetails.policyReplaced.ContainsKey(tb_replacepolicy2.Text))
                policyDetails.policyReplaced.Add(tb_replacepolicy2.Text, tb_replaceinsurer2.Text);

            if (!string.IsNullOrEmpty(tb_replacepolicy3.Text) && !policyDetails.policyReplaced.ContainsKey(tb_replacepolicy3.Text))
                policyDetails.policyReplaced.Add(tb_replacepolicy3.Text, tb_replaceinsurer3.Text);

            //send through all information to replacement service

            var data = new replacementShortEntity
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
        private void replacement_advice_frontend_form_Load(object sender, EventArgs e)
        {
            id_client_tb.Text = pInfo.id;
            name_surname_tb.Text = $"{pInfo.name} {pInfo.surname}";
            name_of_rep_tb.Text = "Add";
            fsp_name_tb.Text = "Add";
            fsp_no_tb.Text = "Add";

            List<TextBox> newPolicies = new List<TextBox> { tb_policy1, tb_policy2, tb_policy3 };
            List<TextBox> newInsurer = new List<TextBox> { tb_insurer1, tb_insurer3, tb_insurer3 };
            List<TextBox> replacePolicies = new List<TextBox> { tb_replacepolicy1, tb_replacepolicy2, tb_replacepolicy3 };
            List<TextBox> replaceInsurer = new List<TextBox> { tb_replaceinsurer1, tb_replaceinsurer2, tb_replaceinsurer3 };

            if (this.policyDetails.newPolicies.Count != 0)
            {
                int count = 0;
                foreach (var policy in this.policyDetails.newPolicies)
                {
                    newPolicies[count].Text = policy.Key;
                    newInsurer[count].Text = policy.Value;
                    count++;
                }
            }

            if (this.policyDetails.policyReplaced.Count != 0)
            {
                int count = 0;
                foreach (var policy in this.policyDetails.policyReplaced)
                {
                    replacePolicies[count].Text = policy.Key;
                    replaceInsurer[count].Text = policy.Value;
                    count++;
                }
            }
        }
    }
}
