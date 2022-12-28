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

        public PolicyDetailsDot policyDot = new PolicyDetailsDot();
        public ReplacementFrontEndForm(List<GeneralInfoEntity> info, PolicyDetailsDot policyDot)
        {
            InitializeComponent();
            pInfo = info[0];

            if (policyDot.newPolicies != null || policyDot.policyReplaced != null)
                this.policyDot = policyDot;
            else
            {
                this.policyDot = policyDot;
                this.policyDot.newPolicies = new Dictionary<string, string>();
                this.policyDot.policyReplaced = new Dictionary<string, string>();
            }
        }

        public ReplacementFrontEndForm()
        {
            InitializeComponent();
        }

        private void make_replacement_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_policy1.Text) && !policyDot.newPolicies.ContainsKey(tb_policy1.Text))
                policyDot.newPolicies.Add(tb_policy1.Text, tb_insurer1.Text);

            if (!string.IsNullOrEmpty(tb_policy2.Text) && !policyDot.newPolicies.ContainsKey(tb_policy2.Text))
                policyDot.newPolicies.Add(tb_policy2.Text, tb_insurer2.Text);

            if (!string.IsNullOrEmpty(tb_policy3.Text) && !policyDot.newPolicies.ContainsKey(tb_policy3.Text))
                policyDot.newPolicies.Add(tb_policy3.Text, tb_insurer3.Text);

            if (!string.IsNullOrEmpty(tb_replacepolicy1.Text) && !policyDot.policyReplaced.ContainsKey(tb_replacepolicy1.Text))
                policyDot.policyReplaced.Add(tb_replacepolicy1.Text, tb_replaceinsurer1.Text);

            if (!string.IsNullOrEmpty(tb_replacepolicy2.Text) && !policyDot.policyReplaced.ContainsKey(tb_replacepolicy2.Text))
                policyDot.policyReplaced.Add(tb_replacepolicy2.Text, tb_replaceinsurer2.Text);

            if (!string.IsNullOrEmpty(tb_replacepolicy3.Text) && !policyDot.policyReplaced.ContainsKey(tb_replacepolicy3.Text))
                policyDot.policyReplaced.Add(tb_replacepolicy3.Text, tb_replaceinsurer3.Text);

            this.Close();
        }

        private void ReplacementFrontEndForm_Load(object sender, EventArgs e)
        {
            id_client_tb.Text = pInfo.id;
            name_surname_tb.Text = $"{pInfo.name} {pInfo.surname}";

            if(!string.IsNullOrEmpty(policyDot.nameOfRep))
                name_of_rep_tb.Text = policyDot.nameOfRep;
            if (!string.IsNullOrEmpty(policyDot.fspName))
                fsp_name_tb.Text = policyDot.fspName;
            if (!string.IsNullOrEmpty(policyDot.fspNo))
                fsp_no_tb.Text = policyDot.fspNo;

            List<TextBox> newPolicies = new List<TextBox> { tb_policy1, tb_policy2, tb_policy3 };
            List<TextBox> newInsurer = new List<TextBox> { tb_insurer1, tb_insurer3, tb_insurer3 };
            List<TextBox> replacePolicies = new List<TextBox> { tb_replacepolicy1, tb_replacepolicy2, tb_replacepolicy3 };
            List<TextBox> replaceInsurer = new List<TextBox> { tb_replaceinsurer1, tb_replaceinsurer2, tb_replaceinsurer3 };

            if (this.policyDot.newPolicies.Count != 0)
            {
                int count = 0;
                foreach (var policy in this.policyDot.newPolicies)
                {
                    newPolicies[count].Text = policy.Key;
                    newInsurer[count].Text = policy.Value;
                    count++;
                }
            }

            if(this.policyDot.policyReplaced.Count != 0)
            {
                int count = 0;
                foreach (var policy in this.policyDot.policyReplaced)
                {
                    replacePolicies[count].Text = policy.Key;
                    replaceInsurer[count].Text = policy.Value;
                    count++;
                }
            } 
        }
    }
}
