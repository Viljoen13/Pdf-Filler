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

namespace formsApp.service
{
    public class replacementFileWriter
    {

        private List<GeneralInfoEntity> info;

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

        public replacementFileWriter(List<GeneralInfoEntity> info)
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
                writer = new PdfWriter(Path + "\\replacement_POLICY_ADVICE_FILLED.pdf");
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

            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(phId).SetValue(info[0].id);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(phName).SetValue(info[0].name + " " + info[0].surname);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(repName).SetValue("repName");
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(fspName).SetValue("fspName");
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(fspNumber).SetValue("2");

            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(policy1).SetValue("policy1");
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(policy2).SetValue("policy2");
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(policy3).SetValue("policy3");
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(policy4).SetValue("policy4");
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(policy5).SetValue("policy5");
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(policy6).SetValue("policy6");
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(insure1).SetValue("insure1");
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(insure2).SetValue("insure2");
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(insure3).SetValue("insure3");
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(insure4).SetValue("insure4");
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(insure5).SetValue("insure5");
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(insure6).SetValue("insure6");

            checkboxFill(pdfDocument, additionalFeesCB, CHECK_STYLE, true);
            checkboxFill(pdfDocument, riskPremiumsCB, CHECK_STYLE, false);
            checkboxFill(pdfDocument, oddPolicyCB, CHECK_STYLE, true);
            checkboxFill(pdfDocument, exclusionsCB, CHECK_STYLE, false);
            checkboxFill(pdfDocument, investmentGuarantessCB, CHECK_STYLE, true);
            checkboxFill(pdfDocument, withDrawCB, CHECK_STYLE, false);
            checkboxFill(pdfDocument, taxAdvantageCB, CHECK_STYLE, false);
            checkboxFill(pdfDocument, valueChangeCB, CHECK_STYLE, true);
            checkboxFill(pdfDocument, investmentRiskCB, CHECK_STYLE, false);
            checkboxFill(pdfDocument, amendedCB, CHECK_STYLE, true);
            checkboxFill(pdfDocument, replaceCB, CHECK_STYLE, false);
            checkboxFill(pdfDocument, internetCB, CHECK_STYLE, true);
            checkboxFill(pdfDocument, telephoneCB, CHECK_STYLE, true);
            checkboxFill(pdfDocument, directMarketingCB, CHECK_STYLE, true);

            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(date).SetValue(DateTime.FromOADate(100).ToString());
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(time).SetValue("15:00");
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(reference).SetValue("reference");

            //PdfAcroForm.GetAcroForm(pdfDocument, true).FlattenFields();

            pdfDocument.Close();
            MessageBox.Show("pdf was successfully made");
        }

        private static void checkboxFill(PdfDocument pdfDocument,string fieldName,int checkStyle,Boolean check)
        {
            if (check)
            {
                PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(fieldName).SetCheckType(checkStyle).SetValue("");
            }
            
        }
    }
}

