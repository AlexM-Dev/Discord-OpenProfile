using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord_OpenProfile.Storage {
    /*
     * Stores profile information about a user, including their statuses,
     * etc. This is the only major storage class that will change frequently
     * in the future as Discord expands its functionality.
     * 
     * This is written in accordance to https://discordapp.com/developers/docs/resources/user#user-object,
     * with an additional Timestamp.
     * 
     * The ProfileFlags flag enumeration is written in accordance to
     * https://discordapp.com/developers/docs/resources/user#user-object-user-flags.
     * 
     * The PremiumType enumeration is written in accordance to 
     * https://discordapp.com/developers/docs/resources/user#user-object-premium-types.
     */
    class ProfileData {
        public DateTime Timestamp { get; set; }
        public long Id { get; set; }
        public string Username { get; set; }
        public string Discriminator { get; set; }
        public string Avatar { get; set; }
        public bool? Bot { get; set; }
        public bool? System { get; set; }
        public bool? MultifactorEnabled { get; set; }
        public string Locale { get; set; }
        public bool? Verified { get; set; }
        public string Email { get; set; }
        public ProfileFlags? Flags { get; set; }
        public NitroType? NitroType { get; set; }
        public ProfileFlags? PublicFlags { get; set; }
    }

    [Flags]
    enum ProfileFlags {
        None = 0,
        DiscordEmployee = 1 << 0,
        DiscordPartner = 1 << 1,
        HypesquadEvents = 1 << 2,
        BugHunterLevel1 = 1 << 3,
        HouseBravery = 1 << 6,
        HouseBrilliance = 1 << 7,
        HouseBalance = 1 << 8,
        EarlySupproter = 1 << 9,
        TeamUser = 1 << 10,
        System = 1 << 12,
        BugHunterLevel2 = 1 << 14,
        VerifiedBot = 1 << 16,
        VerifiedBotDeveloper = 1 << 17
    }

    enum NitroType {
        None = 0,
        NitroClassic = 1,
        Nitro = 2
    }
}
