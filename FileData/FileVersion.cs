using FileData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;


   public class FileVersion:IFileInterface
    {

        FileDetails _fileDetails = new FileDetails();
        public int Size(string type, string filePath)
        {
            int size = -1;
            try
            {
                if (type.ToLower().Trim() == "-s" || type.ToLower().Trim() == "--s" || type.ToLower().Trim() == "/s" || type.ToLower().Trim() == "--size")
                    size = _fileDetails.Size(filePath);

                else
                    size = -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return size;
        }

        public string Version(string type, string filePath)
        {
            string version = "";
            try
            {
                if (type.ToLower().Trim() == "-v" || type.ToLower().Trim() == "--v" || type.ToLower().Trim() == "/v" || type.ToLower().Trim() == "--version")
                    version = _fileDetails.Version(filePath);                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return version;
        }
    }

