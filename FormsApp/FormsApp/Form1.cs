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
using formsApp.service;

namespace FormsApp
{
    public partial class Form1 : Form
    {
        private List<GeneralInfoEntity> persons = new List<GeneralInfoEntity>();
        public Form1()
        {
            InitializeComponent();
        }

        private bool verifyInputInfo()
        {
            return true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            createForms_btn.Enabled = true;

            string file = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); 
            if (result != DialogResult.OK)
            {
                MessageBox.Show("cannot open file");
                return;
            }

            file = openFileDialog1.FileName;
            string filePath = file;
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();

            Dictionary<string, string> person1 = new Dictionary<string, string>();
            Dictionary<string, string> person2 = new Dictionary<string, string>();

            persons = new List<GeneralInfoEntity>();

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

                    persons.Add(oPerson1);
                    
                    //will have to change this check
                    if (person2.Any(c => c.Value != "" && c.Value != null))
                        persons.Add(oPerson2);
                }
            }

            //Fill edit boxes
            Name_textBox.Text = persons[0].name;
            Surname_TextBox.Text = persons[0].surname;
            ID_no_TextBox.Text = persons[0].id;
            maidenName_textBox.Text = persons[0].maidenName;
            occupation_textBox.Text = persons[0].occupation;
            qualification_textBox.Text = persons[0].qualification;
            durationOfCourse_textBox.Text = persons[0].durationOfCourse;
            grossIncome_textBox.Text = persons[0].grossIncome;
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createForms_btn_Click(object sender, EventArgs e)
        {
            if (replacementPolicyAdvice_cb.Checked == true)
            {
                _ = new replacementFileWriter(persons);
            }

            if (statementOfHealth_cb.Checked == true)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createForms_btn.Enabled = false;
        }

    }
}
