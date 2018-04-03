using System.Net;
using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class InstallerHelperTests
    {
        private InstallerHelper _installer;
        private Mock<IFileDownlaoder> _fakeFileDownloader;

        [SetUp]
        public void SetUp()
        {
            _fakeFileDownloader = new Mock<IFileDownlaoder>();
            _installer = new InstallerHelper(_fakeFileDownloader.Object);
        }

        [Test]
        public void DownloadInstaller_EmptyParameters_ReturnFalse()
        {
            _fakeFileDownloader.Setup(fl => fl.Download(It.IsAny<string>(), It.IsAny<string>())).Throws<WebException>();

            var result = _installer.DownloadInstaller("", "");

            Assert.That(result, Is.False);
        }

        [Test]
        public void DownloadInstaller_WhenSuccess_ReturnTrue()
        {
            var result = _installer.DownloadInstaller("customer", "installer");

            Assert.That(result, Is.True);
        }
        
    }
}
