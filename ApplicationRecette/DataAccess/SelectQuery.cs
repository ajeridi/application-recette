using ApplicationRecette.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ApplicationRecette.DataAccess
{
    public class SelectQuery
    {
        private List<Recette> recettes = new List<Recette>();

        public static List<RecetteConsultation> GetAllRecettes()
        {
            try
            {
                using (IDbConnection conn = new SqlConnection(DataAccess.connectionString))
                {
                    var output = conn.Query<RecetteConsultation>($"SELECT * from Donnees ORDER BY DateOperation ASC").ToList();
                    return output;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<RecetteConsultation>();
            }
        }

        public static List<Recette> SearchDate(string date)
        {
            try
            {
                using (IDbConnection conn = new SqlConnection(DataAccess.connectionString))
                {
                    var output = conn.Query<Recette>($"SELECT * from Donnees WHERE DateOperation like '{date}'").ToList();
                    return output;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<Recette>();
            }
        }

        public static string GetLastDateOfOperation()
        {
            try
            {
                using (IDbConnection conn = new SqlConnection(DataAccess.connectionString))
                {
                    var reader = conn.ExecuteReader($"SELECT FORMAT([DateOperation], 'yyyy-MM-dd') from Donnees WHERE Id = (SELECT MAX(Id) FROM Donnees)");
                    string result;
                    while (reader.Read())
                    {
                        result = reader.GetString(0);
                        return result;
                    }
                    return "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        public static List<RecetteConsultation> GetRecette(string dateDebut, string dateFin, bool removeLastDate)
        {
            
            List<RecetteConsultation> output = new List<RecetteConsultation>();

            string operateur = "<=";

            if (removeLastDate == true)
                operateur = "<";

            if (dateDebut == " " && dateFin == " ")
            {
                try
                {
                    using (IDbConnection conn = new SqlConnection(DataAccess.connectionString))
                    {
                       output = conn.Query<RecetteConsultation>("SELECT * from Donnees ORDER BY DateOperation ASC").ToList();
                        return output;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                    return output; 
                }
            }

            else if (dateDebut != " " && dateFin == " ")
            {
                try
                {
                    using (IDbConnection conn = new SqlConnection(DataAccess.connectionString))
                    {
                        output = conn.Query<RecetteConsultation>($@"SELECT * from Donnees WHERE 
                          DateOperation >= '{dateDebut}' ORDER BY DateOperation ASC").ToList();
                        return output;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                    return output;
                }
            }

            else if (dateDebut == " " && dateFin != " ")
            {
                try
                {
                    using (IDbConnection conn = new SqlConnection(DataAccess.connectionString))
                    {
                        output = conn.Query<RecetteConsultation>($@"SELECT * from Donnees WHERE 
                          DateOperation {operateur} '{dateFin}' ORDER BY DateOperation ASC").ToList();
                        return output;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return output;
                }
            }
            else if (dateDebut != " " && dateFin != " ")
            {
                try
                {
                    using (IDbConnection conn = new SqlConnection(DataAccess.connectionString))
                    {
                        output = conn.Query<RecetteConsultation>($@"SELECT * from Donnees WHERE 
                          DateOperation >= '{dateDebut}' and DateOperation {operateur} '{dateFin}' ORDER BY DateOperation ASC ").ToList();
                        return output;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return output;
                }
            }
            return output;
        }

       
    }
}
