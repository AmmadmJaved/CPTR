using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Model
{
  public  class Diagnose
    {
        [Key]
        public int DiagnoseId { get; set; }
        public string Laboratorytest { get; set; }
        public string Bloodtest { get; set; }
        public string Urinetest { get; set; }
        public string Throatswab { get; set; }

        public string Stoolsample { get; set; }
        public string Spinaltap_lumbarPuncture { get; set; }
        public string ImagingScans { get; set; }
        public string Biopsies { get; set; }
    }
}
