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

        private PolicyDetailsDot policyDot = new PolicyDetailsDot();
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
            clearInfo();

            string file = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog(); 
            if (result != DialogResult.OK)
            {
                MessageBox.Show("Cannot open file");
                return;
            }

            file = openFileDialog.FileName;
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
                        grossIncome = person1.FirstOrDefault(c => c.Key == "Gross income").Value,
                        nameOfRepresentative = string.IsNullOrEmpty(tb_NameOfRep.Text) ? tb_NameOfRep.Text : "",
                        fspName = string.IsNullOrEmpty(tb_FSPName.Text) ? tb_FSPName.Text : "",
                        fspNumber = string.IsNullOrEmpty(tb_FSPNo.Text) ? tb_FSPNo.Text : ""
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
                        grossIncome = person2.FirstOrDefault(c => c.Key == "Gross income").Value,
                        nameOfRepresentative = string.IsNullOrEmpty(tb_NameOfRep.Text) ? tb_NameOfRep.Text : "",
                        fspName = string.IsNullOrEmpty(tb_FSPName.Text) ? tb_FSPName.Text : "",
                        fspNumber = string.IsNullOrEmpty(tb_FSPNo.Text) ? tb_FSPNo.Text : ""
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

            //try and create folder on desktop
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"\\{persons[0].name}-{persons[0].surname}";

            // Try to create the folder
            try
            {
                Directory.CreateDirectory(folderPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not create folder on your Desktop");
                return;
            }

            gb_CreateForms.Enabled = true;
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gb_CreateForms.Enabled = false;
            statementOfHealth_cb.Enabled = false;
            cb_replacementAdvice.Enabled = false;
            

        }

        private void replacementPolicyAdvice_cb_CheckedChanged_1(object sender, EventArgs e)
        {
            if (replacementPolicyAdvice_cb.Checked == false)
                return;

            if (!verifyInputInfo())
            {
                MessageBox.Show("Filled in information is incorrect");
                return;
            }

            policyDot.nameOfRep = tb_NameOfRep.Text;
            policyDot.fspName = tb_FSPName.Text;
            policyDot.fspNo = tb_FSPNo.Text;

            this.Hide();

            replacement_advice_frontend_form replacement_form = new replacement_advice_frontend_form(persons, policyDot);

            replacement_form.ShowDialog();

            this.Show();

            if (policyDot.newPolicies == null || policyDot.policyReplaced == null)
                policyDot = replacement_form.policyDot;
        }

        private void cb_replacementAdvice_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_replacementAdvice.Checked == false)
                return;

            if (!verifyInputInfo())
            {
                MessageBox.Show("Filled in information is incorrect");
                return;
            }

            policyDot.nameOfRep = tb_NameOfRep.Text;
            policyDot.fspName = tb_FSPName.Text;
            policyDot.fspNo = tb_FSPNo.Text;

            this.Hide();

            ReplacementFrontEndForm replacement_form = new ReplacementFrontEndForm(persons, policyDot);

            replacement_form.ShowDialog();

            this.Show();

            if (policyDot.newPolicies == null || policyDot.policyReplaced == null)
                policyDot = replacement_form.policyDot;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clearInfo();
        }

        private void clearInfo()
        {
            policyDot = new PolicyDetailsDot();
            persons = new List<GeneralInfoEntity>();

            Name_textBox.Text = "";
            Surname_TextBox.Text = "";
            ID_no_TextBox.Text = "";
            maidenName_textBox.Text = "";
            occupation_textBox.Text = "";
            qualification_textBox.Text = "";
            durationOfCourse_textBox.Text = "";
            grossIncome_textBox.Text = "";
            tb_NameOfRep.Text = "";
            tb_FSPName.Text = "";
            tb_FSPNo.Text = "";

            replacementPolicyAdvice_cb.Checked = false;
            cb_replacementAdvice.Checked = false;

            statementOfHealth_cb.Checked = false;
            replacementPolicyAdvice_cb.Checked = false;
            cb_replacementAdvice.Checked = false;
            cb_OddsExcel.Checked = false;
            cb_AEB.Checked = false;
            gb_CreateForms.Enabled = false;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_OddsExcel.Checked == false)
                return;

            if (!verifyInputInfo())
            {
                MessageBox.Show("Filled in information is incorrect");
                return;
            }

            this.Hide();

            OddsExcel oddsExcelForm = new OddsExcel(persons);

            oddsExcelForm.ShowDialog();

            this.Show();
        }

        private void AEB_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_AEB.Checked == false)
                return;

            this.Hide();

            AEB_E_form aEB_E_Form = new AEB_E_form(persons);

            aEB_E_Form.ShowDialog();

            this.Show();
        }
    }
}
