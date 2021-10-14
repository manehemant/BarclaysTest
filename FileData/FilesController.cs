using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
   public class FilesController
    {
        IFileInterface iFileInterface;
        public FilesController(IFileInterface diFileInterface)
        {
            this.iFileInterface = diFileInterface;
        }

        public int Size(string type, string filePath)
        {
            return iFileInterface.Size(type, filePath);
        }
        public string Version(string type, string filePath)
        {
            return iFileInterface.Version(type, filePath);
        }
    }
}
