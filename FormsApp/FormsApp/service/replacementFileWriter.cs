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

namespace formsApp.service
{
    public class replacementFileWriter
    {

        private List<GeneralInfoEntity> info;
        public replacementFileWriter(List<GeneralInfoEntity> info)
        {
            this.info = info;
            createPdfFile();
        }

        public void createPdfFile()
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

            PdfDocument pdfDocument = new PdfDocument(reader, writer);

            PdfFormField name = PdfFormField.CreateEmptyField(pdfDocument);

            name.SetFieldName("FirstName");
            //y max value is 792
            //xmax value is 609
            //bottom left coner

            PdfTextFormField firstName = PdfTextFormField.CreateText(pdfDocument, new Rectangle(157, 722, 406, 15),
                "FirstName", info[0].name);

            name.AddKid(firstName);

            pdfDocument.GetPage(2);
            PdfAcroForm.GetAcroForm(pdfDocument, true).AddField(name, pdfDocument.GetFirstPage());

            pdfDocument.Close();
        }
    }
}

