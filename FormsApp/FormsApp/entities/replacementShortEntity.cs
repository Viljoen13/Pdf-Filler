using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FormsApp.entities
{
    public class replacementShortEntity : replacementEntity
    {       
        public bool customerChecks { get; set; }
        public bool internetCheck { get; set; }
        public bool telephoneCheck { get; set; }
        public bool directCheck { get; set; }
        public DateTime date { get; set; }
        public string reference { get; set; }
    }
}
