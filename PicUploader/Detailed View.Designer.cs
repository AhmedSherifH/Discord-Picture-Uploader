﻿namespace PicUploader
{
    partial class Detailed_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detailed_View));
            this.flowLayoutPanelGif = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TXT_Add = new System.Windows.Forms.TextBox();
            this.BTN_AddGif = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelGif
            // 
            this.flowLayoutPanelGif.AutoScroll = true;
            this.flowLayoutPanelGif.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelGif.BackgroundImage = global::PicUploader.Properties.Resources._36393f;
            this.flowLayoutPanelGif.ForeColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelGif.Location = new System.Drawing.Point(0, -2);
            this.flowLayoutPanelGif.Name = "flowLayoutPanelGif";
            this.flowLayoutPanelGif.Size = new System.Drawing.Size(475, 85);
            this.flowLayoutPanelGif.TabIndex = 0;
            this.flowLayoutPanelGif.WrapContents = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BackgroundImage = global::PicUploader.Properties.Resources._36393f;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 89);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(475, 85);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // TXT_Add
            // 
            this.TXT_Add.Location = new System.Drawing.Point(37, 180);
            this.TXT_Add.Name = "TXT_Add";
            this.TXT_Add.Size = new System.Drawing.Size(330, 23);
            this.TXT_Add.TabIndex = 2;
            // 
            // BTN_AddGif
            // 
            this.BTN_AddGif.Location = new System.Drawing.Point(373, 180);
            this.BTN_AddGif.Name = "BTN_AddGif";
            this.BTN_AddGif.Size = new System.Drawing.Size(52, 23);
            this.BTN_AddGif.TabIndex = 3;
            this.BTN_AddGif.Text = "Add";
            this.BTN_AddGif.UseVisualStyleBackColor = true;
            this.BTN_AddGif.Click += new System.EventHandler(this.BTN_AddGif_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(460, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Detailed_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(483, 208);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_AddGif);
            this.Controls.Add(this.TXT_Add);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanelGif);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Detailed_View";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Picture Uploader";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Detailed_View_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelGif;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox TXT_Add;
        private Button BTN_AddGif;
        private PictureBox pictureBox1;
    }
}