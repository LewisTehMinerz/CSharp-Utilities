using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// View Server.cs for example.

namespace MyNamespace
{
    interface IServer
    {
        void SetMOTD(String MOTD);
        void SetServerName(String serverName);
        void SetMaxPlayers(int maxPlayers);
        void SetOP(String player);
        void EnableWhitelist(Boolean whitelistEnabled);
        void SetWhitelistedPlayers(String[] whitelist);
        void StartServer();
        void StopServer();
    }
}
