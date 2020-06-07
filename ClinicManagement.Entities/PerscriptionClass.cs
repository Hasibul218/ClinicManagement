using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.Entities
{
    public class PrescriptionClass
    {
        public string Symptom { get; set; }
        public string Diseases { get; set; }
        public string Test { get; set; }
        public string Testclinicname { get; set; }
        public string Testclinicid { get; set; }
        public string Report { get; set; }
        public string Medicines { get; set; }
    }
}
