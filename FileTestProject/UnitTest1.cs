using Xunit;
using FileData;
using Moq;

namespace FileTestProject
{
    public class UnitTest1
    {

        IFileInterface iFileInterface;
        string filePath = "C:/test.txt";
        string fileType = "-v";

        [Fact]
        [Trait("FileDetails", "Version")]
        public void FileVersionTest()
        {
            Mock<FilesController> obj = new Mock<FilesController>();
            obj.Setup(x => x.Version(fileType, filePath)).Returns("1.4.5");
            FilesController fl = new FilesController(iFileInterface);
            var response = fl.Version(fileType, filePath);
            Xunit.Assert.NotNull(response);
        }
    }
}
