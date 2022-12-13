using iText.Forms.Fields;
using iText.Forms;
using iText.Kernel.Pdf;
using System;
using System.IO;
using System.Linq;
using FormsApp;
using System.Collections.Generic;

namespace formsApp.service
{
    public class replacementFileWriter
    {

        private List<GeneralInfoEntity> info;
        public replacementFileWriter(List<GeneralInfoEntity> info)
        {
            this.info = info;
        }

        public void createPdfFile()
        {
            string Path = Directory.GetParent(Environment.CurrentDirectory).ToString() + "\\resources";

            PdfReader reader = null;
            PdfWriter writer = null;
            try
            {
                reader = new PdfReader(Path + "\\replacement_POLICY_ADVICE.pdf");
                writer = new PdfWriter(Path + "\\replacement_POLICY_ADVICE_FILLED.pdf");
            }
            catch (IOException e)
            {
               
            }

            PdfDocument pdfDocument = new PdfDocument(reader, writer);

            //PdfFormField name = PdfFormField.createEmptyField(pdfDocument);

            //name.setFieldName("FirstName");
            ////y max value is 792
            ////xmax value is 609
            ////bottom left coner

            //PdfTextFormField firstName = PdfTextFormField.createText(pdfDocument, new Rectangle(608, 200, 500, 5),
            //    "FirstName", "john");

            //name.addKid(firstName);

            //pdfDocument.getPage(2);
            //PdfAcroForm.getAcroForm(pdfDocument, true).addField(name, pdfDocument.getFirstPage());

            //pdfDocument.close();
        }
    }
}

