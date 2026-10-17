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
    public class Inserts
    {
        public static void InsertNew(Recette recette)
        {
            try
            {
                using (IDbConnection conn = new SqlConnection(DataAccess.connectionString))
                {
                    string INSERT_SQL =
                @"INSERT INTO Donnees
                (DateOperation,
                MontantTVAC_21,
                MontantHTVA_21,
                MontantTVA_21,
                MontantTVAC_12,
                MontantHTVA_12,
                MontantTVA_12, 
                MontantTVAC_6,
                MontantHTVA_6,
                MontantTVA_6,
                TotalTVAC,
                TotalHTVA,
                TotalTVA,
                DateCreation,
                DateModification,
                Remarque,
                TotalCartes,
                TotalLiquide)
               
               VALUES
                 (@DateOperation,
                @MontantTVAC_21,
                @MontantHTVA_21,
                @MontantTVA_21,
                @MontantTVAC_12,
                @MontantHTVA_12,
                @MontantTVA_12, 
                @MontantTVAC_6,
                @MontantHTVA_6,
                @MontantTVA_6,
                @TotalTVAC,
                @TotalHTVA,
                @TotalTVA,
                @DateCreation,
                @DateModification,
                @Remarque,
                @TotalCartes,
                @TotalLiquide)";

                    conn.Execute(INSERT_SQL, recette);
                    string affichage = DateOperations.ChangeDateFormat(recette.DateOperation, "yyyy-MM-dd", "dd-MM-yyyy");
                    MessageBox.Show($"Recette à la date du '{affichage}' ajoutée.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }
    }
}
