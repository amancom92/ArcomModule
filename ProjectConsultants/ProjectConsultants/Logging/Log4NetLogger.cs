using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;
using log4net.Core;

namespace ProjectConsultants.Logging
{
    public class Log4NetLogger
    {
        public ILog logger;

       
        public void Error(string message)
        {
            logger.Error(message);
           
        }

    }
}