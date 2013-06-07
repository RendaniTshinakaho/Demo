using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService2
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }
        public void Debug()
        {
           OnStart(null); 
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                System.IO.File.Create(AppDomain.CurrentDomain.BaseDirectory + "OnStart.txt");
            }
            catch (Exception ex)
            {

                throw new Exception("Could not write to file!");
            }
        }

        protected override void OnStop()
        {
        }
    }
}
