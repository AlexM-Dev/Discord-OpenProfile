using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord_OpenProfile.Distribution {
    /*
     * Assigns a set of proxies to a set of tokens (and vice versa).
     * Operations done with a set of tokens are always used with the proxy
     * given. 
     * 
     * Proxies and tokens chosen are done in batches. For example, a single token
     * must utilise the UnknownUser Collections class alone while another might
     * gain data on it.
     * 
     * The factory will also define the cycle for which proxies and
     * tokens are used. I.e. after completing the identification process,
     * the cycle will increment and another token will be used, and so on.
     * This is to mitigate suspicion from Discord. There are also rate limits
     * which should *probably* be monitored.
     * 
     * This is relying on the hope that proxies have no limit to the number of 
     * requests or data transfer.
     */
    class ProxyDistributionFactory {
    }
}
