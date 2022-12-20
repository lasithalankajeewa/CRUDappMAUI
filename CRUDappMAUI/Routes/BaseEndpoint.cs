using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDappMAUI.Routes
{
    public class BaseEndpoint
    {
        //private static string ProductionBaseURL = "https://bl360x.com//BLECOMTEST/api/";
        private static string ProductionBaseURL = "https://bluelotus360.co/CoreAPI/api/";

        private static string ReportDevURL = "http://localhost:62185/api/";
        private static string DevURL = "https://localhost:7036/api/";

        private static bool IsDevMode = false;
        public static string BaseURL
        {
            get
            {
                if (IsDevMode)
                {
                    return DevURL;

                }
                return ProductionBaseURL;
            }
        }

        public static string ReportURL
        {
            get
            {
                if (IsDevMode)
                {
                    return ReportDevURL + "telerikreports";

                }
                return "https://bl360x.com//BLECOMTEST/api/telerikreports";
            }
        }
        public static string ProductImageURL
        {
            get
            {
                return "https://bl360x.com/BLECOMTEST/images/product_images";
            }
        }
    }
}
