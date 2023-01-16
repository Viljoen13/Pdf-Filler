using iText.Forms;
using iText.Kernel.Pdf;
using iText.Pdfa;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp.service
{
    public class AEBFileWriter
    {
        private static readonly string name = "Ek";
        private static readonly string id = "IDnrPaspoortnr";
        private static readonly string permitCB = "Check Box3";
        private static readonly string productCB = "Check Box30";
        private static readonly string investmentCB = "Check Box35";
        private static readonly string policyPlan1 = "PolisPlannaam";
        //private static readonly string = "PolisPlannaam.3";
        //private static readonly string = "PolisPlannaam.4";
        //private static readonly string = "PolisPlannaam.5";
        private static readonly string policyPlan2 = "PolisPlannommer";
        //private static readonly string = "PolisPlannommer.1";
        //private static readonly string = "PolisPlannommer.2";
        //private static readonly string = "PolisPlannommer.3";
        //private static readonly string = "PolisPlannommer.4";
        //private static readonly string = "PolisPlannommer.5";
        private static readonly string policyPlan3 = "PolisPlannommer2";
        //private static readonly string = "PolisPlannommer2.1";
        //private static readonly string = "PolisPlannommer2.2";
        //private static readonly string = "PolisPlannommer2.3";
        //private static readonly string = "PolisPlannommer2.4";
        //private static readonly string = "PolisPlannommer2.5";
        private static readonly string option1 = "KwotNr";
        //private static readonly string = "KwotNr.3";
        //private static readonly string = "KwotNr.4";
        //private static readonly string = "KwotNr.5";
        private static readonly string option2 = "KwotNr2";
        //private static readonly string = "KwotNr2.1";
        //private static readonly string = "KwotNr2.2";
        //private static readonly string = "KwotNr2.3";
        //private static readonly string = "KwotNr2.4";
        //private static readonly string = "KwotNr2.5";
        private static readonly string option3 = "KwotNr4";
        //private static readonly string = "KwotNr4.1";
        //private static readonly string = "KwotNr4.2";
        //private static readonly string = "KwotNr4.3";
        //private static readonly string = "KwotNr4.4";
        //private static readonly string = "KwotNr4.5";
        //private static readonly string = "SignatureField2";
        //private static readonly string = "Place2";
        //private static readonly string = "Date2";
        //private static readonly string = "SignatureField18";
        //private static readonly string = "SigPlace18";
        //private static readonly string = "SigDate18";
        //private static readonly string = "SignatureField4";
        //private static readonly string = "Place4";
        //private static readonly string = "Date4";
        //private static readonly string = "SignatureField5";
        //private static readonly string = "Place5";
        //private static readonly string = "Date5";
        private static readonly string nameOfPayer = "Ek_3";
        private static readonly string idOfPayer = "volle voorname  van IDnrPaspoortnr_2";
        private static readonly string initialPayer = "InitialsSurnameOfOtherParty";
        //private static readonly string = "SignatureField6";
        //private static readonly string = "Date6";
        private static readonly string nameOfIntermediary = "Ek_5q";
        //private static readonly string = "SignatureField8";
        //private static readonly string = "Place8";
        //private static readonly string = "SignatureField9";
        //private static readonly string = "NamSurnam";
        //private static readonly string = "IntCodee";
        //private static readonly string contactYes = "Check Box111";
        private static readonly string contactYes = "Check Box111.1";
        private static readonly string contactNo = "Check Box111.2";
        private static readonly string initialofSpouse = "ID_5qParaaf";
        private static readonly string nameOfSpouse = "Ek_4";
        private static readonly string idOfSpouse = "ID_5q";
        //private static readonly string = "SignatureField7";
        //private static readonly string = "Place7";
        //private static readonly string = "Date7";
        private static readonly string fee = "AdviseFee";
        private static readonly string nameOfEmployer = "Naam van werkgewer";
        private static readonly string dateStart = "Die werknemer was in diens van die werkgewer vanaf";
        private static readonly string dateEnd = "DDMMEEJJ tot";
        //private static readonly string = "SignatureField10";
        //private static readonly string = "Date10";
        private static readonly string transferringFund = "Naam van oordraende fonds";
        //private static readonly string = "SignatureField1";
        //private static readonly string = "Date1";
        //private static readonly string = "Place1";
        //private static readonly string = "Signature19";
        //private static readonly string = "DateCessionary";
        //private static readonly string = "PlaceCessionary";
        public AEBFileWriter(AEB_E_Enity info) {

            string Path = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString() + "\\resources";

            PdfReader reader = null;
            PdfWriter writer = null;

            try
            {
                reader = new PdfReader(Path + "\\2007_AEB_E.pdf");
                writer = new PdfWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"\\{info.name.Replace(' ', '-')}\\2007_AEB_E_FILLED.pdf");
            }
            catch (IOException e)
            {
                MessageBox.Show("Close file");
                return;
            }

            var pdfDocument = new PdfDocument(reader, writer);

            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(name).SetValue(info.name);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(id).SetValue(info.id);

            checkboxFill(pdfDocument,permitCB, 3,info.permitCheck);
            checkboxFill(pdfDocument, productCB, 3, info.productCheck);
            checkboxFill(pdfDocument, investmentCB, 3, info.investmentCheck);


            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(policyPlan1).SetValue(info.policyPlanNo[0]);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(policyPlan2).SetValue(info.policyPlanNo[1]);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(policyPlan3).SetValue(info.policyPlanNo[2]);


            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(option1).SetValue(info.quotationNo[0]);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(option2).SetValue(info.quotationNo[1]);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(option3).SetValue(info.quotationNo[2]);

            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(nameOfPayer).SetValue(info.nameOfPayer);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(idOfPayer).SetValue(info.idOfPayer);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(initialPayer).SetValue(info.initialsOfPayer);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(nameOfIntermediary).SetValue(info.nameOfIntermediary);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(fee).SetValue(info.advisoryFee);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(nameOfEmployer).SetValue(info.nameOfEmployer);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(nameOfSpouse).SetValue(info.nameOfSpouse);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(initialofSpouse).SetValue(info.directContactInitials);
            checkboxFill(pdfDocument, contactYes, 3, info.contactYes);
            checkboxFill(pdfDocument, contactNo, 3, info.contactNo);

            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(idOfSpouse).SetValue(info.idOfSpouse);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(dateStart).SetValue(info.startDate);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(dateEnd).SetValue(info.endDate);
            PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(transferringFund).SetValue(info.nameOfTransferringFund);

            pdfDocument.Close();
            MessageBox.Show("pdf was successfully made");
        }
        private static void checkboxFill(PdfDocument pdfDocument, string fieldName, int checkStyle, Boolean check)
        {
            if (check)
            {
                PdfAcroForm.GetAcroForm(pdfDocument, true).GetField(fieldName).SetCheckType(checkStyle).SetValue("True");
            }
        }
    }
}
