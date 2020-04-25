using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord_OpenProfile.Storage {
    /*
     * Stores a reference to a user via their ID or Name & Discriminator.
     * The latter is only temporary as the program aims to collect the ID.
     * The Name & Discriminator are only retrievable assuming
     * (a) the user hasn't blocked you,
     * (b) the user has their friend requests on.
     */
    struct UserReference {
        public long Id { get; set; } 
        public string Name { get; set; }
        public string Discriminator { get; set; }

        public UserReference(string name, string discrim) {
            if (!Int32.TryParse(discrim, out int discrimInt)) {
                throw new Exception("Invalid user.");
            }

            this.Name = name;
            this.Discriminator = discrim;
            this.Id = -1;
        }

        public UserReference(long id) {
            this.Id = id;
            this.Name = null;
            this.Discriminator = null;
        }

        public bool IsUnknown() {
            return (Id == -1 || String.IsNullOrEmpty(Name) || 
                String.IsNullOrEmpty(Discriminator) ||
                !Int32.TryParse(Discriminator, out int _));
        }

        public static bool operator ==(UserReference a, UserReference b) {
            return a.Id == b.Id && 
                String.Equals(a.Name, b.Name) && 
                String.Equals(a.Discriminator, b.Discriminator);
        }

        public static bool operator !=(UserReference a, UserReference b) {
            return !(a == b);
        }
    }
}
