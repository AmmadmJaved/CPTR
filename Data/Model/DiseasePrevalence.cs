using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Model
{
   public class DiseasePrevalence
    {
        [Key]
        public int DiseasePrevalenceId { get; set; }
        public double Effectiviness { get; set; }
        public double HealthyArea { get; set; }
        public double TotalBodyHealth { get; set; }
    }
}
