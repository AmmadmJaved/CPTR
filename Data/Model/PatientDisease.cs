using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Model
{
   public class PatientDisease
    {
        [Key]
        public int DiseaseId { get; set; }
        public DiseasePrevalence DiseasePrevalence { get; set; }
        public Diagnose Diagnose { get; set; }
        public string Treatment { get; set; }
        public string Medicine { get; set; }
        public int PatientUserId { get; set; }
        public virtual PatientUser PatientUser { get; set; }
    }
}
