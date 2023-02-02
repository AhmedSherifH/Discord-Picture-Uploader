using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PicUploader
{
    internal class GifGen
    {
        public GifGen(string url) 
        {
                 Clipboard.Clear();
                GC.Collect();
                string ResizedGif =url;
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
}
