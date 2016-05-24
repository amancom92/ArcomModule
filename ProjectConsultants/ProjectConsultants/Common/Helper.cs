using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ProjectConsultants.Common
{
    public class Helper
    {
        public static string ServiceUrl
        {
            get
            {
                return ConfigurationManager.AppSettings["ServiceUrl"] ?? string.Empty;
            }
        }
    }
}