using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace конвертер_валют_консоль {
    public class ClassValute {
        XDocument doc = XDocument.Load("Valute.xml");
        private string valuteID { get; set; }
        public int numCode { get; set; }
        public string charCode{get;set;}
        public int nominal { get; set; }
        public string name { get; set; }
        public double value { get; set; }
        public ClassValute(string valueID, int numCoe, string charCode, int nominal, string name, double value)
        {
            this.valuteID = valueID;
            this.numCode = numCoe;
            this.charCode = charCode;
            this.nominal = nominal;
            this.name = name;
            this.value = value;
        }
    }
}
