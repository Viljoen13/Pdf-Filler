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
        public bool permitCheck { get; set; }
        public bool productCheck { get; set; }
        public bool investmentCheck { get; set; }
        public bool contactYes { get; set; }
        public bool contactNo { get; set; }
        public string advisoryFeed { get; set; }
        public string nameOfEmployer { get; set; }
        public string nameOfTransferringFund { get; set; }
    }
}
