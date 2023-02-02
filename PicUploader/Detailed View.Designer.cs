namespace PicUploader
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
            this.SuspendLayout();
            // 
            // flowLayoutPanelGif
            // 
            this.flowLayoutPanelGif.AutoScroll = true;
            this.flowLayoutPanelGif.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelGif.BackgroundImage = global::PicUploader.Properties.Resources._36393f;
            this.flowLayoutPanelGif.ForeColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelGif.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelGif.Name = "flowLayoutPanelGif";
            this.flowLayoutPanelGif.Size = new System.Drawing.Size(415, 85);
            this.flowLayoutPanelGif.TabIndex = 0;
            this.flowLayoutPanelGif.WrapContents = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BackgroundImage = global::PicUploader.Properties.Resources._36393f;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-4, 89);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(415, 85);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // Detailed_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(418, 173);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanelGif);
            this.Name = "Detailed_View";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Detailed_View";
            this.Load += new System.EventHandler(this.Detailed_View_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelGif;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}