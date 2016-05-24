using System.Configuration;

namespace ProjectConsultants.Common
{
    public static class Helper
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