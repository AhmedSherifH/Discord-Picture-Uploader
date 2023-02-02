namespace PicUploader
{
    public partial class Detailed_View : Form
    {
        public Detailed_View()
        {
            InitializeComponent();
            this.TopMost = true;
            this.TopLevel = true;
            this.DoubleBuffered = true;
        }

        readonly HttpClient httpClient = new();
        public static readonly string FolderPath = @".\Storage";

        public void Detailed_View_Load_1(object sender, EventArgs e)
        {
            RefreshData();
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

        private async void RefreshData()
        {
            DirectoryInfo directory = new(FolderPath);
            FileInfo[] files = directory.GetFiles();
            string[] FileFormats = { ".png", ".jpg", ".jpeg", ".txt" };
            for (int pictureCreator = 0; pictureCreator < files.Length; pictureCreator++)
            {
                FileInfo file = files[pictureCreator];
                if (file.FullName.EndsWith(FileFormats[3]))
                {
                    string url = File.ReadAllText(file.FullName);
                    if (url != null)
                    {
                        try
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
                            flowLayoutPanelGif.Controls.Add(picture);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }

                if (file.FullName.EndsWith(FileFormats[0]))
                {
                    PictureBox picture = new()
                    {
                        Name = "picture",
                        Size = new(45, 45),
                        Image = Image.FromFile(file.FullName),
                        SizeMode = PictureBoxSizeMode.Zoom
                    };
                    picture.Click += Pic_Click;
                    flowLayoutPanel1.Controls.Add(picture);

                }

            }

        }


        private void BTN_AddGif_Click(object sender, EventArgs e)
        {
            try
            {
                string picID = new String(TXT_Add.Text.Where(char.IsDigit).ToArray());
                string picURL = TXT_Add.Text;
                string picLocation = FolderPath + "\\" + picID + ".txt";
                File.WriteAllText(picLocation, picURL);
                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanelGif.Controls.Clear();
                RefreshData();
                TXT_Add.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
