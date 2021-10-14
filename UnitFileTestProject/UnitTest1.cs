using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileData;

namespace UnitFileTestProject
{
    [TestClass]
    public class UnitTest
    {
                    
        string filePath = "C:/test.txt";
        string fileType = "-v";
        string fileType2 = "-s";

        [TestMethod]
        public void FileVersionTest_Success()
        {
            IFileInterface iFileInterface = new FileVersion();
            FilesController fl = new FilesController(iFileInterface);
            var response = fl.Version(fileType, filePath);
            Assert.IsTrue(string.IsNullOrEmpty(response)?false:true);
        }
        [TestMethod]
        public void FileVersionTest_Failed()
        {
            IFileInterface iFileInterface = new FileVersion();
            FilesController fl = new FilesController(iFileInterface);
            var response = fl.Version("", filePath);
            Assert.AreEqual(response,string.Empty);
        }

        [TestMethod]
        public void FileSizeTest_Success()
        {
            IFileInterface iFileInterface = new FileVersion();
            FilesController fl = new FilesController(iFileInterface);
            var response = fl.Size(fileType2, filePath);
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void FileSizeTest_Failed()
        {
            IFileInterface iFileInterface = new FileVersion();
            FilesController fl = new FilesController(iFileInterface);
            var response = fl.Size("", filePath);
            Assert.AreEqual(response,-1);
        }
    }
}
