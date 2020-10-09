using System;
using System.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assign2
{

    public class Ques1
    {
        // Function to check File Existance 
        public bool FileExists(string filename, string rootPath)
        {
            if (File.Exists(Path.Combine(rootPath, filename)))
                return true;
            foreach (string subDir in Directory.GetDirectories(rootPath))
            {
                if (FileExists(filename, subDir))
                    return true;
            }

            return false;
        }

    }
}
