using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationRecette.Model
{
    public class RecetteConsultation
    {
        public string DateOperation { get; set; } = null!;
       
        public decimal? MontantHTVA_21 { get; set; }
        public decimal? MontantTVA_21 { get; set; }
        public decimal? MontantHTVA_12 { get; set; }
        public decimal? MontantTVA_12 { get; set; }
        public decimal? MontantHTVA_6 { get; set; }
        public decimal? MontantTVA_6 { get; set; }
        
        public decimal? TotalHTVA { get; set; }
        public decimal? TotalTVA { get; set; }
        public decimal? TotalTVAC { get; set; }
        public decimal? TotalCartes { get; set; }
        public decimal? TotalLiquide { get; set; }
    }
}
