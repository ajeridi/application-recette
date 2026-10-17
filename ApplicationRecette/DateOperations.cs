using ApplicationRecette.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationRecette
{
    public class DateOperations
    {
        public static string ChangeDateFormat(string date, string format, string convertedFormat)
        {
            try
            {
               
               
                    string dateString = date;

                    DateTime parsedDate = DateTime.ParseExact(dateString, format, null);

                    //rec.DateOperation = parsedDate.ToString("yyyy-MM-dd");
                    return parsedDate.ToString(convertedFormat);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
                return "";
            }
        }
    }
}
