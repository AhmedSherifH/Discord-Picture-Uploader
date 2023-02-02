using System.Drawing;

namespace PicUploader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.TopLevel = true;
            this.TopMost = true;
            InitializeComponent();
        }
        public readonly string FolderPath = @".\Storage";
        public static readonly HttpClient httpClient = new();


        private void Form1_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(FolderPath); //Creates folder named Storage if it does not exit.
        }
        private async void TXT_FileFinder_TextChanged(object sender, EventArgs e)
        {
            string UserInput = TXT_FileFinder.Text;
            string[] PictureFormats = { ".jpg", ".png", ".txt", ".jpeg" };
            for (int formats = 0; formats < 4; formats++)
            {
                string FoundPics = FolderPath + @"\" + UserInput + PictureFormats[formats];
                if (File.Exists(FoundPics))
                {
                    string FileExtension = Path.GetExtension(FoundPics);
                    if (FileExtension != ".txt")
                    {
                        Bitmap picBitmap = new(FoundPics);
                        pictureBox.Image = picBitmap;
                        PicGen _ = new(pictureBox);

                        break;
                    }

                    if (FileExtension == ".txt")
                    {
                        string url = File.ReadAllText(FoundPics);
                        if (url != null)
                        {
                            try
                            {
                                Clipboard.SetText(url);
                                pictureBox.Image = Image.FromStream(await httpClient.GetStreamAsync(url));
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            } 

                        }

                    }
                      
                }
            }

            if (TXT_FileFinder.Text == "")
            {
                pictureBox.Image = null;
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Detailed_View detailed_View = new(this);
            this.Hide();
           detailed_View.ShowDialog();
        }
    }
}


