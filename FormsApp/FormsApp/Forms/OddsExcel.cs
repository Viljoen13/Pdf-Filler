using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsApp.entities;
using FormsApp.service;

namespace FormsApp
{
    public partial class OddsExcel : Form
    {
        private GeneralInfoEntity pInfo;
        public OddsExcel(List<GeneralInfoEntity> info)
        {
            InitializeComponent();

            pInfo = info[0];
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string paymentMethod = "";
            if (cb_stopOrder.Checked)
                paymentMethod = "Stop Order";
            if (cb_debit.Checked)
                paymentMethod = "Debit";

            var data = new oddsExcelEntity
            {
                nameSurname = $"{pInfo.name} {pInfo.surname}",
                age = tb_age.Text,
                advisor = name_of_rep_tb.Text,
                code = tb_code.Text,
                planNumber = tb_planNum.Text,
                quotationNumber = tb_quote.Text,
                analysisDone = cb_analysisDone.Checked,
                estateAnalysis = cb_estateAnalysis.Checked,
                productType = tb_typeofProduct.Text,
                productMatch = cb_productMatch.Checked,
                premium = tb_premiumAmount.Text,
                payMethod = paymentMethod,
                occupation = tb_occupation.Text,
                qualification = tb_qualification.Text,
                monthlyIncome = tb_monthlyIncome.Text,
                clientLapses = cb_prevLapses.Checked,
                outstandingLoans = cb_outstandingLoans.Checked,
                clientSequestrated = cb_clientSequestrated.Checked,
                firstYearCommision = tb_firstCommision.Text,
                caseSubmitted = cb_caseSubmitted.Checked,
                clientFamily = cb_clientFamily.Checked,
                moreThanMonth = cb_MoreThanMonth.Checked
            };

            _ = new excelFileWriter(data);
        }

        private void OddsExcel_Load(object sender, EventArgs e)
        {
            name_surname_tb.Text = $"{pInfo.name} {pInfo.surname}";
            name_of_rep_tb.Text = pInfo.nameOfRepresentative;

        }
    }
}
