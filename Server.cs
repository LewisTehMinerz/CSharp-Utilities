using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Voids are defined by the IServer class.

namespace MyNamespace
{
    class Server : IServer
    {
        public void SetMOTD(string MOTD)
        {
            throw new NotImplementedException();
        }

        public void SetMaxPlayers(int MaxPlayers)
        {
            throw new NotImplementedException();
        }

        public void SetOP(string player)
        {
            throw new NotImplementedException();
        }

        public void EnableWhitelist(bool whitelistEnabled)
        {
            throw new NotImplementedException();
        }

        public void SetWhitelistedPlayers(string[] whitelist)
        {
            throw new NotImplementedException();
        }

        public void StartServer()
        {
            throw new NotImplementedException();
        }

        public void StopServer()
        {
            throw new NotImplementedException();
        }
    }
}
