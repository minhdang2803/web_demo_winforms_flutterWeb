using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace webDemo
{
    public class ServiceLocator
    {
        private Dictionary<string, object> _services;
        private static ServiceLocator? locator;
        private ServiceLocator() { _services = new Dictionary<string, object>();}
        public static ServiceLocator Instance
        {
            get
            {
                if (locator == null)
                {
                    locator = new ServiceLocator();
                }
                return locator;
            }
        }

        public void Register(string serviceName, object serviceInstance)
        {
            _services[serviceName] = serviceInstance;
        }

        public object GetService(string serviceName)
        {
            object serviceInstance = _services[serviceName];
            return serviceInstance;
        }

    }
}