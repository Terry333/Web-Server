using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.WebSockets;

namespace WebServer.Classes
{
    class Server
    {
        public string TopDirectory;
        public FilePage CurrentPage; 
        public Server(string directoryPath)
        {
            TopDirectory = directoryPath;
            CurrentPage = new FilePage(directoryPath);
            if(CurrentPage != null)
            {
                WebSocket
            }
        }
    }
}
