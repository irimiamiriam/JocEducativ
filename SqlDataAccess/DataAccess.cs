using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JocEducativ.SqlDataAccess
{
    public class DataAccess
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }
        public static string GetUtilizatoriPath()
        {
            return ConfigurationManager.AppSettings["UtilizatoriPath"];
        }
        public static string GetRezultatePath()
        {
            return ConfigurationManager.AppSettings["RezultatePath"];
        }
        public static string GetItemiPath()
        {
            return ConfigurationManager.AppSettings["ItemiPath"];
        }
        public static string GetCuvintePath()
        {
            return ConfigurationManager.AppSettings["CuvintePath"];
        }
    }

}
