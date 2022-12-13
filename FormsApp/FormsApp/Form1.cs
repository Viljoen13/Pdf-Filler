using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using System.IO;

namespace FormsApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!verifyInputInfo())
                return;
        }

        private bool verifyInputInfo()
        {
            return true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\User\\Documents\\CVC_Dev\\Electronic_instruction_page.xlsx"; 
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();

            Dictionary<string, string> person1 = new Dictionary<string, string>();
            Dictionary<string, string> person2 = new Dictionary<string, string>();

            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    do
                    {
                        int counter = 0;
                        while (reader.Read())
                        {
                            if (counter >= 7 && counter <= 16)
                            {
                                if (reader.GetValue(0) == null)
                                    continue;

                                person1.Add(reader.GetValue(0).ToString(), reader.GetValue(1) != null ? reader.GetValue(1).ToString() : "");
                                person2.Add(reader.GetValue(0).ToString(), reader.GetValue(5) != null ? reader.GetValue(5).ToString() : "");

                                if (counter == 60)
                                    break;
                            }
                            
                            counter++;
                        }
                    } while (reader.NextResult());
                    
                    GeneralInfoEntity oPerson1 = new GeneralInfoEntity
                    {                        
                        surname = person1.FirstOrDefault(c => c.Key == "Surname").Value,
                        name = person1.FirstOrDefault(c => c.Key == "Fulle Names").Value,
                        id = person1.FirstOrDefault(c => c.Key == "ID No.:").Value,
                        maidenName = person1.FirstOrDefault(c => c.Key == "Maiden Name").Value,
                        occupation = person1.FirstOrDefault(c => c.Key == "Occupation").Value,
                        qualification = person1.FirstOrDefault(c => c.Key == "Qualification").Value,
                        durationOfCourse = person1.FirstOrDefault(c => c.Key == "Duration of Course").Value,
                        grossIncome = person1.FirstOrDefault(c => c.Key == "Gross income").Value
                    };

                    GeneralInfoEntity oPerson2 = new GeneralInfoEntity
                    {
                        surname = person2.FirstOrDefault(c => c.Key == "Surname").Value,
                        name = person2.FirstOrDefault(c => c.Key == "Fulle Names").Value,
                        id = person2.FirstOrDefault(c => c.Key == "ID No.:").Value,
                        maidenName = person2.FirstOrDefault(c => c.Key == "Maiden Name").Value,
                        occupation = person2.FirstOrDefault(c => c.Key == "Occupation").Value,
                        qualification = person2.FirstOrDefault(c => c.Key == "Qualification").Value,
                        durationOfCourse = person2.FirstOrDefault(c => c.Key == "Duration of Course").Value,
                        grossIncome = person2.FirstOrDefault(c => c.Key == "Gross income").Value
                    };

                    var test = oPerson1;
                    var test2 = oPerson2;

                    //test
                }
            }
        }
    }
}
