using KGySoft.Drawing;
using KGySoft.Drawing.Imaging;
using System.Drawing;

namespace PicUploader
{
    public class PicGen
    {
        public PicGen(PictureBox pictureBox)
        { 
            Clipboard.Clear();
            Bitmap firstImage = new(pictureBox.Image, pictureBox.Width, pictureBox.Height);
            Color backColorBottom = firstImage.GetPixel(0, 0);
            firstImage.ReplaceColor(backColorBottom, Color.FromArgb(54, 57, 63));
            Clipboard.SetImage(firstImage);
        }
    }
}

