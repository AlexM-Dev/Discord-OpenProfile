# Discord-OpenProfile

## What is this?
\* Yes, this is a selfbot.

"An open source profile change-over-time tracker for Discord" is probably the most concise definition you'll find of this program.
What it essentially does is uses various tokens and proxies (\*) to identify a set of users added to be tracked and reads their
profile information, monitoring changes over time. It's applicable in the scenarios where scammers are constantly changing their 
name and discriminator. Because they can't change their ID however, they can be traced to a single person. Obviously this is beneficial
in those cases.

## Can I track people I don't know the ID of?
Yes. Ish. You can track people you are able to add as a friend initially - any time after that you are always able to track them. 
There are 3 'levels' to 'trackability': Friend, Known and Unknown. Friend is obviously someone who is a confirmed friend on 
Discord - not pending or unadded. Known is someone for whom you have the ID for but aren't friends with. You have access
to less information (such as online status) than a Friend. Unknown is a user whom you don't know the ID of but know the Name
and Discriminator of. This is still useful, because an Unknown user can become a known user by the following process:

1. Adding the user as a friend (doesn't have to confirm).
2. Enumerating your friends list to find that user and grab their ID.
3. Optionally, removing that user. If this is done, the user cannot become a Friend, so less information for you :-P.

## Milestones
I'm taking this project slowly to ensure genuine completion and efficient workflow. 

1. Project started 25/04/2020.
2. ???

## Brief notes and ideas.
```
**Discord Profiler**
Take snapshots of people's profiles periodically to track profile changes over time.

*Collections Framework*
- Friend (Friends & ID)
- Known (ID only)
- Unknown (No ID; Name, Discrim.)

*Periodicity & Distribution Framework*
- Token Distribution
- Proxy Distribution
- Periodicity in Seconds

*Modification Framework*
- Changes in JSON fields at given times.

*Storage Framework*
- User Info - Raw
- User Flags & Notes
```
