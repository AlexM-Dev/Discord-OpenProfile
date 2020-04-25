using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord_OpenProfile.Storage;

namespace Discord_OpenProfile.Collections {
    /*
     * UnknownUser class is designed to identify a user via their Name
     * and Discriminator. This is done by adding the user as a friend, 
     * enumerating all friends (which includes pending friend requests)
     * and then grabbing that user. If desired, the request can be removed,
     * making it *nearly* invisible.
     * 
     * This is a flaw by design of Discord and therefore isn't particularly
     * patchable. It is the only way to get access to a user's profile without
     * knowing their ID. 
     */
    class UnknownUser {
        public async Task<UserReference> IdentifyUser(UserReference userRef, bool remove) {
            // Add the friend here.
            if (!await addUserFriend(userRef)) {
                // Couldn't add the user for some reason.
            }

            // Enumerate the friends.
            var enumUser = await grabUserFromFriends(userRef);
            if (enumUser == userRef) {
                // Couldn't enumerate the user for some reason.
            }

            // Remove the friend if applicable.
            if (remove) {
                if (!await removeUserFriend(userRef)) {
                    // Couldn't remove the user.
                }
            }

            return enumUser;
        }

        private async Task<bool> addUserFriend(UserReference userRef) {
            return true;
        }

        private async Task<UserReference> grabUserFromFriends(UserReference userRef) {
            return new UserReference(-1);
        }

        private async Task<bool> removeUserFriend(UserReference userRef) {
            return true;
        }
    }
}
