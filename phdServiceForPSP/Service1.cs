using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace phdServiceForPSP
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
            if (!System.Diagnostics.EventLog.SourceExists("pspService"))
            {
                System.Diagnostics.EventLog.CreateEventSource("pspService", "PSP log");
            }
            eventLog1.Source = "testowaUslugaMarcin";
            eventLog1.Log = "PSP log";


        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("Service was started");
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("Service was stoped");
        }

        protected override void OnContinue()
        {
            eventLog1.WriteEntry("Service is running");
        }
    }
}
