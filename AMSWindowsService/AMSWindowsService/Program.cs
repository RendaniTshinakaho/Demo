using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Topshelf;

namespace AMSWindowsService
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>                                 
            {
                x.Service<AMSTaskScheduler>(s =>                        
                {
                    s.ConstructUsing(name => new AMSTaskScheduler());     
                    s.WhenStarted(tc => tc.Start());              
                    s.WhenStopped(tc => tc.Stop());               
                });
                x.RunAsLocalSystem();                            
                x.SetDescription("Airtime Management System Windows Service");        
                x.SetDisplayName("AirtimeManagementSystemService");                       
                x.SetServiceName("AirtimeManagementSystemService");                       
            });                           
        }
    }
}
