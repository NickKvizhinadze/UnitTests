using System.Net;

namespace TestNinja.Mocking
{
    public class InstallerHelper
    {
        private string _setupDestinationFile;
        private readonly IFileDownlaoder _fileDownloader;

        public InstallerHelper(IFileDownlaoder fileDownloader = null)
        {
            _fileDownloader = fileDownloader ?? new FileDownlaoder();
        }

        public bool DownloadInstaller(string customerName, string installerName)
        {
            try
            {
                _fileDownloader.Download($"http://example.com/{customerName}/{installerName}", _setupDestinationFile);

                return true;
            }
            catch (WebException)
            {
                return false; 
            }
        }
    }
}