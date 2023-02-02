using KGySoft.Drawing;
using KGySoft.Drawing.Imaging;
using System.Security.Cryptography;

namespace PicUploader
{
    public class PicGen
    {
        public PicGen(PictureBox pictureBox)
        { 
            Clipboard.Clear();
            GC.Collect();

            Bitmap firstImage = new(pictureBox.Image, pictureBox.Width, pictureBox.Height);

            Clipboard.SetImage(firstImage);
            firstImage.SetResolution(100, 100);
            Color backColorBottom = firstImage.GetPixel(0, 0);
            firstImage.ReplaceColor(backColorBottom, Color.FromArgb(54, 57, 63));

            
        
            
            /*
              
             
            Bitmap resized = new(pictureBox.Image, 52, 52);
            Color backColorBottom = resized.GetPixel(0, 0);
            for (int i = 0; i < resized.Width; i++)
            {
                for (int j = 0; j < resized.Height; j++)
                {
                    if (resized.GetPixel(i, j) == backColorBottom)
                    {
                        resized.SetPixel(i, j, Color.FromArgb(54, 57, 63));
                    }
                }
            }

            Clipboard.SetImage(resized);
*/
        }
    }
}

