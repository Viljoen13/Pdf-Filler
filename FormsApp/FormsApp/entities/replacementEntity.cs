using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FormsApp.entities
{
    public class replacementEntity
    {       
        public string nameSurname { get; set; }
        public string id { get; set; }
        public string representative { get; set; }
        public string fspName { get; set; }
        public string fspNumber { get; set; }
        public List<string> newPolicies { get; set; }
        public List<string> newInsurers { get; set; }
        public List<string> replacedPolicies { get; set; }
        public List<string> replacedInsurers { get; set; }
        public bool customerChecks { get; set; }
        public bool internetCheck { get; set; }
        public bool telephoneCheck { get; set; }
        public bool directCheck { get; set; }
        public DateTime date { get; set; }
        public string reference { get; set; }
    }
}
