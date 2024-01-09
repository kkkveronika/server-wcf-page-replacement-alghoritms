using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace wcf_pra
{
    public class Server
    {
        private ServiceHost host;

        public void Start()
        {
            host = new ServiceHost(typeof(Service_pra));
            host.Open();
        }

        public void Stop()
        {
            host.Close();
        }
    }
}
