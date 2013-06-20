using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SingleResponsabilityPrinciple.Good
{
    public class Logger
    {
        private StringWriter logger;

        public Logger()
        {
            logger = new StringWriter();
        }

        public void WriteToLog(string value)
        {
            logger.WriteLine(value);
        }

        public void SaveLog()
        {
            //Do stuff for Save log to File
        }
    }
}
