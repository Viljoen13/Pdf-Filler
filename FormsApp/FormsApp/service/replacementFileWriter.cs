using System;
using System.IO;

namespace formsApp.service
{
    public class replacementFileWriter
    {
        public replacementFileWriter()
        {
        }

        public void createPdfFile()
        {

            string Path = Directory.GetCurrentDirectory().

            PdfReader reader = null;
            PdfWriter writer = null;
            try
            {
                reader = new PdfReader("C:\\Users\\ASmit\\SB\\demo\\pdfRace\\src\\main\\resources\\replacement_POLICY_ADVICE.pdf");
                writer = new PdfWriter("C:\\Users\\ASmit\\SB\\demo\\pdfRace\\src\\main\\resources\\replacement_POLICY_ADVICE_FILLED.pdf");
            }
            catch (IOException e)
            {
                e.printStackTrace();
            }
        }
    }
}

