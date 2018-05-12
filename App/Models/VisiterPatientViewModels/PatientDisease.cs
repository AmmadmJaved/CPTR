using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models.VisiterPatientViewModels
{
    public class PatientDisease
    {
        public int DiseaseId { get; set; }
        public DiseasePrevalence DiseasePrevalence { get; set; }
        public Diagnose Diagnose { get; set; }
        public string Treatment { get; set; }
        public string Medicine { get; set; }
        //public int PatientUserId { get; set; }
    }
}
