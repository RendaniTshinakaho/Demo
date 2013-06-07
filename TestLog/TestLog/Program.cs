using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace TestLog
{
 public  class Program
 {
     private static readonly ILog logger = LogManager.GetLogger(typeof (Program));
        static void Main(string[] args)
        {
            BasicConfigurator.Configure();
            logger.Debug("Here is a debug log");
            logger.Info("...and an info log.");
            logger.Warn(".... and a warning");
            logger.Error("... and an error");
            logger.Fatal("...and a fatal");
            Console.ReadLine();
        }
    }
}
