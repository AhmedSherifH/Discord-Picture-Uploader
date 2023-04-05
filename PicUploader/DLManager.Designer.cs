namespace PicUploader
{
    partial class DLManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DLManager));
            this.pic_PEPE = new System.Windows.Forms.PictureBox();
            this.lbl_PEPE = new System.Windows.Forms.Label();
            this.btn_PEPE = new System.Windows.Forms.Button();
            this.pic_peepoGif = new System.Windows.Forms.PictureBox();
            this.lbl_pepegif = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PEPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_peepoGif)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_PEPE
            // 
            this.pic_PEPE.Image = ((System.Drawing.Image)(resources.GetObject("pic_PEPE.Image")));
            this.pic_PEPE.Location = new System.Drawing.Point(3, 12);
            this.pic_PEPE.Name = "pic_PEPE";
            this.pic_PEPE.Size = new System.Drawing.Size(40, 40);
            this.pic_PEPE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_PEPE.TabIndex = 0;
            this.pic_PEPE.TabStop = false;
            // 
            // lbl_PEPE
            // 
            this.lbl_PEPE.AutoSize = true;
            this.lbl_PEPE.Location = new System.Drawing.Point(49, 27);
            this.lbl_PEPE.Name = "lbl_PEPE";
            this.lbl_PEPE.Size = new System.Drawing.Size(61, 15);
            this.lbl_PEPE.TabIndex = 1;
            this.lbl_PEPE.Text = "Pepe Pack";
            // 
            // btn_PEPE
            // 
            this.btn_PEPE.Location = new System.Drawing.Point(144, 23);
            this.btn_PEPE.Name = "btn_PEPE";
            this.btn_PEPE.Size = new System.Drawing.Size(75, 23);
            this.btn_PEPE.TabIndex = 2;
            this.btn_PEPE.Text = "Download";
            this.btn_PEPE.UseVisualStyleBackColor = true;
            this.btn_PEPE.Click += new System.EventHandler(this.btn_PEPE_Click);
            // 
            // pic_peepoGif
            // 
            this.pic_peepoGif.Image = ((System.Drawing.Image)(resources.GetObject("pic_peepoGif.Image")));
            this.pic_peepoGif.Location = new System.Drawing.Point(3, 71);
            this.pic_peepoGif.Name = "pic_peepoGif";
            this.pic_peepoGif.Size = new System.Drawing.Size(40, 40);
            this.pic_peepoGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_peepoGif.TabIndex = 3;
            this.pic_peepoGif.TabStop = false;
            // 
            // lbl_pepegif
            // 
            this.lbl_pepegif.AutoSize = true;
            this.lbl_pepegif.Location = new System.Drawing.Point(49, 86);
            this.lbl_pepegif.Name = "lbl_pepegif";
            this.lbl_pepegif.Size = new System.Drawing.Size(89, 15);
            this.lbl_pepegif.TabIndex = 4;
            this.lbl_pepegif.Text = "Pepe Pack (GIF)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Download";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BTN_pepegif);
            // 
            // DLManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 153);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_pepegif);
            this.Controls.Add(this.pic_peepoGif);
            this.Controls.Add(this.btn_PEPE);
            this.Controls.Add(this.lbl_PEPE);
            this.Controls.Add(this.pic_PEPE);
            this.Name = "DLManager";
            this.Text = "DLManager";
            ((System.ComponentModel.ISupportInitialize)(this.pic_PEPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_peepoGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pic_PEPE;
        private Label lbl_PEPE;
        private Button btn_PEPE;
        private PictureBox pic_peepoGif;
        private Label lbl_pepegif;
        private Button button1;
    }
}