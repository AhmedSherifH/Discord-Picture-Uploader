using System.Net;
using WebPWrapper;


namespace PicUploader
{
    public partial class Detailed_View : Form
    {
        public static readonly string FolderPath = @".\Storage";

        public Detailed_View()
        {
            InitializeComponent();
            this.TopMost = true;
            this.TopLevel = true;
        }

        readonly WebClient webClient = new();
        readonly HttpClient httpClient = new();


        public void Detailed_View_Load_1(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(FolderPath)) { }
            else { System.IO.Directory.CreateDirectory(FolderPath); }
            RefreshData();
        }

        public async void RefreshData()
        { 
            DirectoryInfo directory = new(FolderPath);
            FileInfo[] files = directory.GetFiles();
            flowLayoutPanel1.Controls.Clear();  
            flowLayoutPanelGif.Controls.Clear();
            string[] FileFormats = { ".png", ".jpg", ".jpeg", ".txt", ".webp", ".gif" }; //0 png, 1jpg, 2jpeg, 3txt, 4webp, 5gif
            for (int pictureCreator = 0; pictureCreator < files.Length; pictureCreator++)
            {
                FileInfo file = files[pictureCreator];
                if (file.FullName.EndsWith(FileFormats[3]))
                {
                    string url = File.ReadAllText(file.FullName);
                    bool isGif = url.Contains(FileFormats[5]);
                    bool isWebp = url.Contains(FileFormats[4]);

                    if (isGif)
                    {

                        Image gif = Image.FromStream(await httpClient.GetStreamAsync(url));
                        PictureBox picture = new()
                        {
                            Name = url,
                            Size = new(45, 45),
                            Image = gif,
                            SizeMode = PictureBoxSizeMode.Zoom
                        };
                        picture.Click += Gif_Click;
                        picture.MouseEnter += PictureResizeBig;
                        picture.MouseLeave += PictureResizeOriginal;
                        flowLayoutPanelGif.Controls.Add(picture);
                    }
                }


                if (!file.FullName.EndsWith(FileFormats[3]) && !file.FullName.EndsWith(FileFormats[4]))
                {
                    PictureBox picture = new()
                    {
                        Name = "picture",
                        Size = new(45, 45),
                        Image = Image.FromFile(file.FullName),
                        SizeMode = PictureBoxSizeMode.Zoom
                    };
                    picture.Click += Pic_Click;
                    picture.MouseEnter += PictureResizeBig;
                    picture.MouseLeave += PictureResizeOriginal;
                    flowLayoutPanel1.Controls.Add(picture);
                }

                if (file.FullName.Contains(".webp"))
                {
                    WebP webp = new();
                    Bitmap bitmap = webp.Load(file.FullName);
                    PictureBox picture = new()
                    {
                        Name = file.Name,
                        Size = new(45, 45),
                        Image = bitmap,
                        SizeMode = PictureBoxSizeMode.Zoom
                    };

                    picture.Click += WebP_Click;
                    picture.MouseEnter += PictureResizeBig;
                    picture.MouseLeave += PictureResizeOriginal;
                    flowLayoutPanel1.Controls.Add(picture);
                }

            }
        }





        private void BTN_AddGif_Click(object sender, EventArgs e)
        {
           try
            {
                string picIDNum = new(TXT_Add.Text.Where(char.IsDigit).ToArray());
                string picID = picIDNum.Remove(picIDNum.Length - 2);
                string picURL = TXT_Add.Text;
                string picLocationTXT = FolderPath + "\\" + picID + ".txt";
                string picLocationWEBP = FolderPath + "\\" + picID + ".webp";
                if (!string.IsNullOrWhiteSpace(TXT_Add.Text))
                {
                    if (picURL.Contains(".gif"))
                    {
                        File.WriteAllText(picLocationTXT, picURL);
                        RefreshData();
                        TXT_Add.Text = null;
                    }

                    if (picURL.Contains(".webp"))
                    {
                        webClient.DownloadFile(picURL, picLocationWEBP);
                        RefreshData();
                        TXT_Add.Text = null;
                    }
                }
                else
                {
                    MessageBox.Show("Empty Input!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void Pic_Click(object? sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                PicGen _ = new(pictureBox);
            }
        }

        private void Gif_Click(object? sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                string url = pictureBox.Name;
                GifGen _ = new(url);
            }

        }

        private void WebP_Click(object? sender, EventArgs e)
        {

            if (sender is PictureBox pictureBox)
            {
                WebPGen _ = new(pictureBox);
            }

        }

        
        private void PictureResizeBig(object? sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                pictureBox.BackColor = Color.FromArgb(79, 82, 91);

            }
        }

        private void PictureResizeOriginal(object? sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                pictureBox.BackColor = Color.Transparent;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DLManager dlManager = new DLManager(this);
            dlManager.Show();
        }
    }
}


