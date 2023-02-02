namespace PicUploader
{
    public partial class Detailed_View : Form
    {
        public Detailed_View(Form1 form1)
        {
            InitializeComponent();
            this.Form1 = form1;
            this.TopMost = true;
            this.TopLevel = true;
        }

        private Form1 Form1 { get; set; }
        readonly HttpClient httpClient = new();
        public static readonly string FolderPath = @".\Storage";

        public async void Detailed_View_Load_1(object sender, EventArgs e)
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
                            GC.Collect();
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
                    GC.Collect();
                    PictureBox picture = new()
                    {
                        Name = "emoji",
                        Size = new(45, 45),
                        Image = Image.FromFile(file.FullName),
                        SizeMode = PictureBoxSizeMode.Zoom
                    };
                    picture.Click += Pic_Click;
                    flowLayoutPanel1.Controls.Add(picture);
                }
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

    }
}
