using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsApp
{
    public class PolicyDetailsDot
    {
        public Dictionary<string, string> newPolicies { get; set; }

        public Dictionary<string, string> policyReplaced { get; set; }
        public string nameOfRep { get; set; }
        public string fspName { get; set; }
        public string fspNo { get; set; }
    }
}
