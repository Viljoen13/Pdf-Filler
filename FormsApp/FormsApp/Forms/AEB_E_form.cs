using FormsApp.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class AEB_E_form : Form
    {
        private GeneralInfoEntity pInfo;
        public AEB_E_form(List<GeneralInfoEntity> info)
        {
            InitializeComponent();

            pInfo = info[0];
            nameTB.Text = pInfo.name + " " + pInfo.surname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = new AEB_E_Enity
            {

                quotationNo =new List<string> { Quotation1TB.Text, Quotation2TB.Text, Quotation3TB.Text },
                policyPlanNo = new List<string> { policyTB1.Text, policyTB2.Text, policyTB3.Text },
                name = nameTB.Text,
                id = idTB.Text,
                nameOfPayer = payerNameTB.Text,
                idOfPayer = payerIdTB.Text,
                initialsOfPayer = payerInitialsTB.Text,
                nameOfIntermediary = intermediartNameTB.Text,
                permitCheck = permitCB.Checked,
                productCheck = productCB.Checked,
                investmentCheck = investmentCB.Checked,
                contactYes = contactCB.Checked,
                contactNo = contactNoCB.Checked,
                directContactInitials = contactTB.Text,
                advisoryFee = feeTB.Text,
                nameOfEmployer = emploerNameTB.Text,
                nameOfTransferringFund = fundTB.Text,
                startDate = startTB.Text,
                endDate  = endTB.Text,
                nameOfSpouse = spouseNameTB.Text,
                idOfSpouse = spouseIdTB.Text,
            };

            _ = new AEBFileWriter(data);

            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
