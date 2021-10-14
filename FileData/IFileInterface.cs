using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
  public interface IFileInterface
    {
        string Version(string type, string filePath);
        int Size(string type, string filePath);
    }
}
