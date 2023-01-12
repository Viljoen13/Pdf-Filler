using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormsApp.entities;
using System.IO;
using ExcelDataReader;
using OfficeOpenXml;
using System.Windows.Forms;

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
            string Path = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString() + "\\resources\\ODDS.xlsx";

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            //Cells[row, column]
            using (FileStream fs = File.OpenRead(Path))
            using (ExcelPackage excelPackage = new ExcelPackage(fs))
            {
                ExcelWorkbook excelWorkBook = excelPackage.Workbook;
                ExcelWorksheet excelWorksheet = excelWorkBook.Worksheets.First();
                excelWorksheet.Cells[4, 1].Value = "CLIENT: " + info.nameSurname;
                excelWorksheet.Cells[4, 5].Value = "AGE: " + info.age;
                excelWorksheet.Cells[4, 7].Value = "PLAN NUMBER: " + info.planNumber;
                excelWorksheet.Cells[5, 1].Value = "ADVISOR: " + info.advisor;
                excelWorksheet.Cells[5, 5].Value = "CODE: " + info.code;
                excelWorksheet.Cells[5, 7].Value = "QUATATION NUMBER: " + info.quotationNumber;
                //excelWorksheet.Cells[6, 1].Value = "ODDS: " + ;
                //excelWorksheet.Cells[7, 5].Value = info.age; retention?

                if(info.analysisDone)
                    excelWorksheet.Cells[8, 8].Value = "Yes X";
                else
                    excelWorksheet.Cells[8, 9].Value = "No X";

                if (info.estateAnalysis)
                    excelWorksheet.Cells[9, 8].Value = "Yes X";
                else
                    excelWorksheet.Cells[9, 9].Value = "No X";

                excelWorksheet.Cells[10, 8].Value = info.productType;

                if (info.productMatch)
                    excelWorksheet.Cells[11, 8].Value = "Yes X";
                else
                    excelWorksheet.Cells[11, 9].Value = "No X";

                excelWorksheet.Cells[12, 8].Value = info.premium;

                if (info.payMethod == "Debit")
                    excelWorksheet.Cells[13, 8].Value = info.payMethod + " X";
                else
                    excelWorksheet.Cells[13, 9].Value = info.payMethod + " X";

                excelWorksheet.Cells[14, 8].Value = info.occupation;
                excelWorksheet.Cells[15, 8].Value = info.qualification;
                excelWorksheet.Cells[16, 8].Value = info.monthlyIncome;

                if (info.clientLapses)
                    excelWorksheet.Cells[17, 8].Value = "Yes X";
                else
                    excelWorksheet.Cells[17, 9].Value = "No X";

                if (info.outstandingLoans)
                    excelWorksheet.Cells[18, 8].Value = "Yes X";
                else
                    excelWorksheet.Cells[18, 9].Value = "No X";

                if (info.clientSequestrated)
                    excelWorksheet.Cells[19, 8].Value = "Yes X";
                else
                    excelWorksheet.Cells[19, 9].Value = "No X";

                excelWorksheet.Cells[20, 8].Value = info.firstYearCommision;

                if (info.caseSubmitted)
                    excelWorksheet.Cells[21, 8].Value = "Yes X";
                else
                    excelWorksheet.Cells[21, 9].Value = "No X";

                if (info.clientFamily)
                    excelWorksheet.Cells[22, 8].Value = "Yes X";
                else
                    excelWorksheet.Cells[22, 9].Value = "No X";

                if (info.moreThanMonth)
                    excelWorksheet.Cells[23, 8].Value = "Yes X";
                else
                    excelWorksheet.Cells[23, 9].Value = "No X";

                excelWorksheet.Cells[24, 1].Value = "Motivation from advisor why the policy will stay on the books: " + info.motivation;

                excelPackage.SaveAs(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString() + "\\resources\\" + "Testing.xlsx");
            }

            MessageBox.Show("Excel document was successfully made");
        }
    }
}
