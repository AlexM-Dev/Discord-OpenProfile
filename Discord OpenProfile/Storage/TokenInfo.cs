using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord_OpenProfile.Storage {
    /* 
     * Holds the token information for a given token.
     * In future, this'll be encrypted. For now though, the storage
     * framework will handle plain text until fully settled.
     * 
     * TokenAbility identfies the restrictions placed upon a token.
     * For example, bots cannot identify unknown users.
     */
    class TokenInfo {
        public TokenAbility TokenRestriction { get; set; }
        public string Token { get; set; }
    }

    enum TokenAbility {
        CanProfile = 0,
        CanIdentify = 1
    }
}
