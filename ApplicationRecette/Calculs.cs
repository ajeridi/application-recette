using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationRecette
{
    public class Calculs
    {
        public static decimal CalculTVACAvecHTVA (decimal HTVA, decimal taux)
        {
            //TVAC = HTVA + TVA avec TVA = HTVA * Taux/100 --> TVAC = HTVA(1 + TAUX/100)
            return HTVA * (1 + ((decimal)taux / 100));
        }

        public static decimal CalculTVACAvecTVA(decimal TVA, decimal taux)
        {
            //HTVA = TVA * 100/taux
            return TVA * (1 + (100 / (decimal)taux));
        }

        public static decimal CalculHTVAavecTVAC(decimal TVAC, decimal taux)
        {
            // HTVA = TVAC - TVA
            //Exprimer TVA en fonction de TVAC --> TVA = (TVAC*(taux/100))/(1 - (taux/100)
            return TVAC / (1 + ((decimal)taux / 100));
        }

        public static decimal CalculHTVAavecTVA(decimal TVA, decimal taux)
        {
            //TVA = HTVA * taux/100 --> HTVA = TVA * 100/taux
            return TVA * (100 / (decimal)taux);
        }

        public static decimal CalculTVAavecTVAC(decimal TVAC, decimal taux)
        {
            return TVAC / (1+ (100/(decimal)taux));
        }
        
        public static decimal CalculTVAavecHTVA(decimal HTVA, decimal taux)
        {
            return HTVA * ((decimal)taux / 100);
        }

        public static decimal CalculTotalTVA(decimal TVA21, decimal TVA12, decimal TVA6)
        {
            return TVA21 + TVA12 + TVA6;
        }

        public static decimal CalculTotalHTVA(decimal HTVA21, decimal HTVA12, decimal HTVA6)
        {
            return HTVA21 + HTVA12 + HTVA6;
        }

        public static decimal CalculTotalTVAC(decimal TVAC21, decimal TVAC12, decimal TVAC6)
        {
            return TVAC21 + TVAC12 + TVAC6;
        }

    }
}
