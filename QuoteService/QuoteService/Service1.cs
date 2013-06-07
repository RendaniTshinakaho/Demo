using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using QuoteServer;


namespace QuoteService
{
    public partial class Service1 : ServiceBase
    {
        private ClsQuoteServer quoteServer;
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            quoteServer = new ClsQuoteServer(@"c:\Quote.txt");
            quoteServer.Start();

        }
        

        protected override void OnStop()
        {
            quoteServer.Stop();
        }
        protected override void OnPause()
        {
            quoteServer.Suspend();
        }
        protected override void OnContinue()
        {
            quoteServer.Resume();
        }
        protected override void OnShutdown()
        {
           OnStop();
        }

        public const int commandRefresh = 128;
        protected override void OnCustomCommand(int command)
        {
            switch (command)
            {
                case commandRefresh:
                    quoteServer.RefreshQuotes();
                    break;
                default:
                    break;
                    
            }
        }
    }
}
