using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;


namespace PicUploader
{
    public partial class DLManager : Form
    {
        private Detailed_View detailed;
     

        public DLManager(Detailed_View detailed)
        {
            InitializeComponent();
            this.detailed = detailed;
            this.Focus();
        }
        private string PeepoPicLink = "https://cdn.discordapp.com/attachments/1069733718438203454/1092576376223178863/PeepoPack.zip";
        private string PeepoGifLink = "https://cdn.discordapp.com/attachments/1069733718438203454/1092922908713693264/PepePackGIF.zip";


        private void btn_PEPE_Click(object sender, EventArgs e)
        {
            var downloadPepePic = new PackDownloader();
            downloadPepePic.downloadPack(PeepoPicLink, @"./Storage/PepePack.zip", detailed);
        }

        private void BTN_pepegif(object sender, EventArgs e)
        {
            var downloadPepeGif = new PackDownloader();
            downloadPepeGif.downloadPack(PeepoGifLink, @"./Storage/PepePack.zip", detailed);
        }
    }
}
