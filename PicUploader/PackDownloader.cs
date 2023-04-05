using System.Net;

namespace PicUploader
{
    class PackDownloader
    {
        public void downloadPack(string Link, string Location, Detailed_View detailed)
        {
            WebClient downloader = new WebClient();
            try
            {
                downloader.DownloadFile(Link, Location);
                System.IO.Compression.ZipFile.ExtractToDirectory(Location, @"./Storage/");
                File.Delete(Location);

                detailed.RefreshData();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
