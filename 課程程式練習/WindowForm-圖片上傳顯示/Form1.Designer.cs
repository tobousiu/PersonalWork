namespace WinForms_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.P1 = new System.Windows.Forms.PictureBox();
            this.P2 = new System.Windows.Forms.PictureBox();
            this.Button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.結束ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.效果ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.灰階化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.二階化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.權重平滑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.索柏XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.索柏YToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.平滑濾波ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.P1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // P1
            // 
            this.P1.Image = ((System.Drawing.Image)(resources.GetObject("P1.Image")));
            this.P1.Location = new System.Drawing.Point(0, 67);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(564, 755);
            this.P1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P1.TabIndex = 0;
            this.P1.TabStop = false;
            this.P1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // P2
            // 
            this.P2.Location = new System.Drawing.Point(618, 67);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(564, 755);
            this.P2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P2.TabIndex = 1;
            this.P2.TabStop = false;
            // 
            // Button
            // 
            this.Button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Button.Location = new System.Drawing.Point(530, 3);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(122, 58);
            this.Button.TabIndex = 2;
            this.Button.Text = "按鈕";
            this.Button.UseVisualStyleBackColor = false;
            this.Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.效果ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1222, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開啟檔案ToolStripMenuItem,
            this.結束ToolStripMenuItem});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.檔案ToolStripMenuItem.Text = "檔案";
            this.檔案ToolStripMenuItem.Click += new System.EventHandler(this.檔案ToolStripMenuItem_Click);
            // 
            // 開啟檔案ToolStripMenuItem
            // 
            this.開啟檔案ToolStripMenuItem.Name = "開啟檔案ToolStripMenuItem";
            this.開啟檔案ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.開啟檔案ToolStripMenuItem.Text = "開啟檔案";
            this.開啟檔案ToolStripMenuItem.Click += new System.EventHandler(this.開啟檔案ToolStripMenuItem_Click);
            // 
            // 結束ToolStripMenuItem
            // 
            this.結束ToolStripMenuItem.Name = "結束ToolStripMenuItem";
            this.結束ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.結束ToolStripMenuItem.Text = "結束";
            this.結束ToolStripMenuItem.Click += new System.EventHandler(this.結束ToolStripMenuItem_Click);
            // 
            // 效果ToolStripMenuItem
            // 
            this.效果ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.灰階化ToolStripMenuItem,
            this.二階化ToolStripMenuItem,
            this.權重平滑ToolStripMenuItem,
            this.索柏XToolStripMenuItem,
            this.索柏YToolStripMenuItem,
            this.平滑濾波ToolStripMenuItem});
            this.效果ToolStripMenuItem.Name = "效果ToolStripMenuItem";
            this.效果ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.效果ToolStripMenuItem.Text = "效果";
            this.效果ToolStripMenuItem.Click += new System.EventHandler(this.效果ToolStripMenuItem_Click);
            // 
            // 灰階化ToolStripMenuItem
            // 
            this.灰階化ToolStripMenuItem.Name = "灰階化ToolStripMenuItem";
            this.灰階化ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.灰階化ToolStripMenuItem.Text = "灰階化";
            this.灰階化ToolStripMenuItem.Click += new System.EventHandler(this.灰階化ToolStripMenuItem_Click);
            // 
            // 二階化ToolStripMenuItem
            // 
            this.二階化ToolStripMenuItem.Name = "二階化ToolStripMenuItem";
            this.二階化ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.二階化ToolStripMenuItem.Text = "二階化";
            this.二階化ToolStripMenuItem.Click += new System.EventHandler(this.二階化ToolStripMenuItem_Click);
            // 
            // 權重平滑ToolStripMenuItem
            // 
            this.權重平滑ToolStripMenuItem.Name = "權重平滑ToolStripMenuItem";
            this.權重平滑ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.權重平滑ToolStripMenuItem.Text = "權重平滑";
            this.權重平滑ToolStripMenuItem.Click += new System.EventHandler(this.權重平滑ToolStripMenuItem_Click);
            // 
            // 索柏XToolStripMenuItem
            // 
            this.索柏XToolStripMenuItem.Name = "索柏XToolStripMenuItem";
            this.索柏XToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.索柏XToolStripMenuItem.Text = "索柏X";
            this.索柏XToolStripMenuItem.Click += new System.EventHandler(this.索柏XToolStripMenuItem_Click);
            // 
            // 索柏YToolStripMenuItem
            // 
            this.索柏YToolStripMenuItem.Name = "索柏YToolStripMenuItem";
            this.索柏YToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.索柏YToolStripMenuItem.Text = "索柏Y";
            this.索柏YToolStripMenuItem.Click += new System.EventHandler(this.索柏YToolStripMenuItem_Click);
            // 
            // 平滑濾波ToolStripMenuItem
            // 
            this.平滑濾波ToolStripMenuItem.Name = "平滑濾波ToolStripMenuItem";
            this.平滑濾波ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.平滑濾波ToolStripMenuItem.Text = "平滑濾波";
            this.平滑濾波ToolStripMenuItem.Click += new System.EventHandler(this.平滑濾波ToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 820);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.P1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox P1;
        private PictureBox P2;
        private Button Button;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 檔案ToolStripMenuItem;
        private ToolStripMenuItem 開啟檔案ToolStripMenuItem;
        private ToolStripMenuItem 結束ToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem 效果ToolStripMenuItem;
        private ToolStripMenuItem 灰階化ToolStripMenuItem;
        private ToolStripMenuItem 二階化ToolStripMenuItem;
        private ToolStripMenuItem 權重平滑ToolStripMenuItem;
        private ToolStripMenuItem 索柏XToolStripMenuItem;
        private ToolStripMenuItem 索柏YToolStripMenuItem;
        private ToolStripMenuItem 平滑濾波ToolStripMenuItem;
    }
}