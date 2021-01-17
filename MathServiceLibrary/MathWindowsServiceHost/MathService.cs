using System.ServiceProcess;
using MathServiceLibrary;
using System.ServiceModel;
using System;

namespace MathWindowsServiceHost
{
    public partial class MathService : ServiceBase
    {
        public MathService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            myHost?.Close();

            //myHost = new ServiceHost(typeof(MathService));
            //var address = new Uri("http://localhost:8080/MathServiceLibrary");
            //var binding = new WSHttpBinding();
            //var contract = typeof(IBasicMath);
            //myHost.AddServiceEndpoint(contract, binding, address);

            myHost = new ServiceHost(typeof(MathService),
                new Uri("http://localhost:8080/MathServiceLibrary"));
            myHost.AddDefaultEndpoints();

            myHost.Open();
        }

        protected override void OnStop()
        {
            myHost?.Close();
        }

        private ServiceHost myHost;
    }
}
