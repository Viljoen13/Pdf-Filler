using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsApp
{
    public class AEB_E_Enity
    {
        public List<string> policyPlanNo { get; set; }
        public List<string> quotationNo { get; set; }
        public string name { get; set; }
        public string id { get; set; }
        public string nameOfPayer { get; set; }
        public string idOfPayer { get; set; }
        public string nameOfSpouse { get; set; }
        public string idOfSpouse { get; set; }
        public string initialsOfPayer { get; set; }
        public string nameOfIntermediary { get; set; }
        public bool permitCheck { get; set; }
        public bool productCheck { get; set; }
        public bool investmentCheck { get; set; }
        public bool contactYes { get; set; }
        public bool contactNo { get; set; }
        public string directContactInitials { get; set; }
        public string advisoryFee { get; set; }
        public string nameOfEmployer { get; set; }
        public string nameOfTransferringFund { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }

    }
}
