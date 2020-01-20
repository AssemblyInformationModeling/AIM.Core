using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;
using ICSharpCode.SharpZipLib.Zip;


namespace AIM.Core
{
    public class Reader
    {
        string filePath;

        public Reader(string filePath)
        {
            if (File.Exists(filePath))
            {
                this.filePath = filePath;
            }
            else
            {
                throw new Exception("File doesn't exist!");
            }
        }

        public Model Load()
        {
            return null;
        }
    }
}
