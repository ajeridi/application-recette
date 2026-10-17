using ApplicationRecette.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationRecette.DataAccess
{
    public class Updates
    {
        public static void UpdateDate(Recette updatedRecette)
        {
            try
            {
                using (IDbConnection conn = new SqlConnection(DataAccess.connectionString))
                {
                    string UPDATE_SQL =
                        @"UPDATE Donnees SET 
                    MontantTVAC_21=@MontantTVAC_21,
                    MontantHTVA_21=@MontantHTVA_21,
                    MontantTVA_21=@MontantTVA_21,
                    MontantTVAC_12=@MontantTVAC_12,
                    MontantHTVA_12=@MontantHTVA_12,
                    MontantTVA_12=@MontantTVA_12,
                    MontantTVAC_6=@MontantTVAC_6,
                    MontantHTVA_6=@MontantHTVA_6,
                    MontantTVA_6=@MontantTVA_6,
                    TotalTVAC=@TotalTVAC,
                    TotalHTVA=@TotalHTVA,
                    TotalTVA=@TotalTVA,
                    TotalCartes=@TotalCartes,
                    TotalLiquide=@TotalLiquide,
                    DateModification=@DateModification
                    WHERE DateOperation=@DateOperation";
                    conn.Execute(UPDATE_SQL, updatedRecette);
                    string affichage = DateOperations.ChangeDateFormat(updatedRecette.DateOperation, "yyyy-MM-dd", "dd-MM-yyyy");
                    MessageBox.Show($"Date '{affichage}' mise à jour.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }
    }
}
