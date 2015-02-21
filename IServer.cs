using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCraft
{
    interface IServer
    {
        public abstract void SetMOTD(String MOTD);
        public abstract void SetMaxPlayers(int MaxPlayers);
        public abstract void SetOP(String player);
        public abstract void EnableWhitelist(Boolean whitelistEnabled);
        public abstract void SetWhitelistedPlayers(String[] whitelist);
        public abstract void StartServer();
        public abstract void StopServer();
    }
}
