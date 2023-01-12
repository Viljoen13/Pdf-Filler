using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsApp.entities
{
    public class oddsExcelEntity
    {
        public string nameSurname { get; set; }
        public string age { get; set; }
        public string advisor { get; set; }
        public string code { get; set; }
        public string planNumber { get; set; }
        public string quotationNumber { get; set; }
        public Boolean analysisDone { get; set; }
        public Boolean estateAnalysis { get; set; }
        public string productType { get; set; }
        public Boolean productMatch { get; set; }
        public string premium { get; set; }
        public string payMethod { get; set; }
        public string occupation { get; set; }
        public string qualification { get; set; }
        public string monthlyIncome { get; set; }
        public Boolean clientLapses { get; set; }
        public Boolean outstandingLoans { get; set; }
        public Boolean clientSequestrated { get; set; }
        public string firstYearCommision { get; set; }
        public Boolean caseSubmitted { get; set; }
        public Boolean clientFamily { get; set; }
        public Boolean moreThanMonth { get; set; }
        public string motivation { get; set; }
    }
}
