using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormsApp.entities;
using System.IO;

namespace FormsApp.service
{
    public class excelFileWriter
    {
        oddsExcelEntity info;
        public excelFileWriter(oddsExcelEntity info)
        {
            this.info = info;
            createExcelFile();
        }

        public async void createExcelFile()
        {
            string Path = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString() + "\\resources";

            //PdfReader reader = null;
            //PdfWriter writer = null;
            //try
            //{
            //    reader = new PdfReader(Path + "\\replacement_POLICY_ADVICE.pdf");
            //    writer = new PdfWriter(Path + "\\replacement_POLICY_ADVICE_FILLED.pdf");
            //}
            //catch (IOException e)
            //{
            //    MessageBox.Show("Close file");
            //    return;
            //}
        }
    }
}
