using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Discord_OpenProfile.Storage;

namespace Discord_OpenProfile.Collections {
    /*
     * The collector class serves as the physical timed 
     * data collector for the entire lifetime of the application.
     * 
     * As such, it contains the critical components such as the client,
     * current proxy, proxy cycle, etc.
     */
    class Collector {
        public HttpClient Client { get; set; }
        public int CurrentProxyCycle { get; set; }
        public List<ProxyInfo> ProxyCycle { get; set; }
    }
}
