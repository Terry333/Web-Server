using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WebServer.Classes
{
    class FilePage
    {
        public LinkedList<string> Contents;
        public string CurrentDirectory;
        public FilePage(string directory)
        {
            Contents = ConvertDirectoryInfo(directory);
            if(Contents.First == null)
            {
                Contents = null;
            }
        }

        private LinkedList<string> ConvertDirectoryInfo(string directory)
        {
            LinkedList<string> files = new LinkedList<string>();
            LinkedList<string> folders = new LinkedList<string>();
            LinkedList<string> totalContents = new LinkedList<string>();

            string[] fileNames = Directory.GetFiles(directory);
            string[] folderNames = Directory.GetDirectories(directory);

            foreach (string s in fileNames)
                files.AddLast(s);
            foreach (string s in folderNames)
                folders.AddLast(s);

            int filesCount = files.Count;
            for (int i = 0; i < filesCount + folders.Count; i++)
            {
                if (i >= filesCount)
                    totalContents.AddLast(folders.ElementAt(i - filesCount));
                else
                    totalContents.AddLast(files.ElementAt(i));
            }

            return totalContents;
        }
    }
}
