using System.Net;

namespace TestNinja.Mocking
{
    public class FileDownlaoder : IFileDownlaoder
    {
        public void Download(string url, string fileDestination)
        {
            var client = new WebClient();
            client.DownloadFile(url, fileDestination);

        }
    }
}
