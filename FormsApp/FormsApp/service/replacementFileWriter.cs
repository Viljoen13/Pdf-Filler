using iText.Forms.Fields;
using iText.Forms;
using iText.Kernel.Pdf;
using System;
using System.IO;
using System.Linq;
using FormsApp;
using System.Collections.Generic;
using iText.Kernel.Geom;
using System.Windows.Forms;
using iText.Pdfa;
using FormsApp.entities;

namespace formsApp.service
{
    public class replacementFileWriter
    {

        private replacementShortEntity info;

        private PdfDocument pdfDocument;

        private static readonly int CHECK_STYLE = 1;
        private static readonly string phId = "Id/Policy holder";
        private static readonly string phName = "name and surname of policy holder";
        private static readonly string repName = "Name of Rep";
        private static readonly string fspName = "Full name of FSP";
        private static readonly string fspNumber = "FSP N.O";
        private static readonly string policy1 = "policy n app n.o 1";
        private static readonly string policy2 = "policy n app n.o 2";
        private static readonly string policy3 = "policy n app n.o 3";
        private static readonly string policy4 = "policy n app n.o 4";
        private static readonly string policy5 = "policy n app n.o 5";
        private static readonly string policy6 = "policy n app n.o 6";
        private static readonly string insure1 = "Insure 1";
        private static readonly string insure2 = "Insure 2";
        private static readonly string insure3 = "Insure 3";
        private static readonly string insure4 = "Insure 4";
        private static readonly string insure5 = "Insure 5";
        private static readonly string insure6 = "Insure 6";
        private static readonly string additionalFeesCB = "Check Box6";
        private static readonly string riskPremiumsCB = "Check Box7";
        private static readonly string oddPolicyCB = "Check Box8";
        private static readonly string exclusionsCB = "Check Box9";
        private static readonly string investmentGuarantessCB = "Check Box10";
        private static readonly string withDrawCB = "Check Box11";
        private static readonly string taxAdvantageCB = "Check Box12";
        private static readonly string valueChangeCB = "Check Box13";
        private static readonly string investmentRiskCB = "Check Box14";
        private static readonly string amendedCB = "Check Box16";
        private static readonly string replaceCB = "Check Box17";
        private static readonly string internetCB = "Check Box18";
        private static readonly string telephoneCB = "Check Box19";
        private static readonly string directMarketingCB  = "Check Box20";
        private static readonly string date = "Date";
        private static readonly string time = "Time";
        private static readonly string reference = "Text23";

        public replacementFileWriter(replacementShortEntity info)
        {
            this.info = info;
            createPdfFile();
        }

        public async void createPdfFile()
        {
            string Path = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString() + "\\resources";

            PdfReader reader = null;
            PdfWriter writer = null;
            try
            {
                reader = new PdfReader(Path + "\\replacement_POLICY_ADVICE.pdf");
                writer = new PdfWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"\\{info.nameSurname.Replace(' ', '-')}\\replacement_POLICY_ADVICE_FILLED.pdf");
            }
            catch (IOException e)
            {
                MessageBox.Show("Close file");
                return;
            }

            pdfDocument = new PdfDocument(reader, writer);

            //PdfFormField name = PdfFormField.CreateEmptyField(pdfDocument);

            //name.SetFieldName("FirstName");
            //name.
            ////y max value is 792
            ////xmax value is 609
            ////bottom left coner

            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(phId).SetValue(info.id);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(phName).SetValue(info.nameSurname);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(repName).SetValue(info.representative);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(fspName).SetValue(info.fspName);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(fspNumber).SetValue(info.fspName);

            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(policy1).SetValue(info.newPolicies[0]);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(policy2).SetValue(info.newPolicies[1]);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(policy3).SetValue(info.newPolicies[2]);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(policy4).SetValue(info.replacedPolicies[0]);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(policy5).SetValue(info.replacedPolicies[1]);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(policy6).SetValue(info.replacedPolicies[2]);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(insure1).SetValue(info.newInsurers[0]);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(insure2).SetValue(info.newInsurers[1]);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(insure3).SetValue(info.newInsurers[2]);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(insure4).SetValue(info.replacedInsurers[0]);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(insure5).SetValue(info.replacedInsurers[1]);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(insure6).SetValue(info.replacedInsurers[2]);

            checkboxFill(pdfDocument, additionalFeesCB, CHECK_STYLE, info.customerChecks);
            checkboxFill(pdfDocument, riskPremiumsCB, CHECK_STYLE, info.customerChecks);
            checkboxFill(pdfDocument, oddPolicyCB, CHECK_STYLE, info.customerChecks);
            checkboxFill(pdfDocument, exclusionsCB, CHECK_STYLE, info.customerChecks);
            checkboxFill(pdfDocument, investmentGuarantessCB, CHECK_STYLE, info.customerChecks);
            checkboxFill(pdfDocument, withDrawCB, CHECK_STYLE, info.customerChecks);
            checkboxFill(pdfDocument, taxAdvantageCB, CHECK_STYLE, info.customerChecks);
            checkboxFill(pdfDocument, valueChangeCB, CHECK_STYLE, info.customerChecks);
            checkboxFill(pdfDocument, investmentRiskCB, CHECK_STYLE, info.customerChecks);
            checkboxFill(pdfDocument, amendedCB, CHECK_STYLE, info.customerChecks);
            checkboxFill(pdfDocument, replaceCB, CHECK_STYLE, info.customerChecks);
            checkboxFill(pdfDocument, internetCB, CHECK_STYLE, info.internetCheck);
            checkboxFill(pdfDocument, telephoneCB, CHECK_STYLE, info.telephoneCheck);
            checkboxFill(pdfDocument, directMarketingCB, CHECK_STYLE, info.directCheck);

            checkboxFill(pdfDocument, additionalFeesCB, CHECK_STYLE, false);

            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(date).SetValue(info.date.ToString("yyyy/MM/dd"));
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(time).SetValue(info.date.ToString("HH:mm"));
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(reference).SetValue(info.reference);

            //PdfAcroForm.GetAcroForm(pdfDocument, true).FlattenFields();

            pdfDocument.Close();
            MessageBox.Show("pdf was successfully made");
        }

        private static void checkboxFill(PdfDocument pdfDocument,string fieldName,int checkStyle,Boolean check)
        {
            if (check)
            {
                PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(fieldName).SetCheckType(checkStyle).SetValue("True");
            }
        }
    }
}

