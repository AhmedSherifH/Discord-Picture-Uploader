using KGySoft.Drawing;
using KGySoft.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PicUploader
{
    public class PicGen
    {
        public PicGen(PictureBox pictureBox)
        { 
            Clipboard.Clear();
            Bitmap firstImage = new(pictureBox.Image, pictureBox.Width + 2, pictureBox.Height + 2);
            Color backColorBottom = firstImage.GetPixel(0, 0);
            firstImage.ReplaceColor(backColorBottom, Color.FromArgb(54, 57, 63));
            Clipboard.SetImage(firstImage);
        }
    }

    public class GifGen
    {
        public GifGen(string url)
        {
            Clipboard.Clear(); 
            string ResizedGif = url;
            for (int i = 10; i < 100; i++)
            {
                if (ResizedGif.Contains("size=" + i))
                {
                    ResizedGif = Regex.Replace(url, "size=" + i, "size=40");
                }
            }
            Clipboard.SetText(ResizedGif);
        }
    }

    public class WebPGen
    {
        public WebPGen(PictureBox pictureBox) 
        {
            string? URL1 = @"https://cdn.discordapp.com/emojis/";
            string? URL3 = @"?size=96&quality=lossless";
            string URL2 = pictureBox.Name;
            string CompleteString = URL1 + URL2 + URL3;
            for (int i = 10; i < 100; i++)
            {
                if (CompleteString.Contains("size=" + i))
                {
                    CompleteString = Regex.Replace(CompleteString, "size=" + i, "size=40");
                }
            }
            Clipboard.SetText(CompleteString);
        }
    }
}

