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
    public class Delete
    {
        public static void DeleteRow(string date)
        {
            try
            {
                using (IDbConnection conn = new SqlConnection(DataAccess.connectionString))
                {
                    conn.Execute($"DELETE FROM Donnees WHERE DateOperation = '{date}'");
                    MessageBox.Show($"Date '{DateOperations.ChangeDateFormat(date, "yyyy-MM-dd", "dd-MM-yyyy")}' supprimée.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }
    }
}
