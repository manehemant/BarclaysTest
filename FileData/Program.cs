using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                if (args != null)
                {
                    IFileInterface iFileInterface = new FileVersion();
                    FilesController _fd = new FilesController(iFileInterface);

                    string fileVersion = _fd.Version(args[0].ToString(), args[1].ToString());
                    int fileSize = _fd.Size(args[0].ToString(), args[1].ToString());

                    Console.WriteLine(fileVersion);
                    Console.WriteLine(fileSize == -1 ? "Invalid Paramter for file Size" : fileSize.ToString());
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("no arguments have been passed!!!");
                    Console.ReadLine();
                }
            }
            catch (Exception ex )
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
