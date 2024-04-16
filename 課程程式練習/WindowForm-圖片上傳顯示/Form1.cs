namespace WinForms_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void 檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 開啟檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                P1.Load(openFileDialog1.FileName);
            }
        }
        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 效果ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 灰階化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int average;
            Bitmap img1 = (Bitmap)P1.Image;
            Bitmap img2 = new Bitmap(img1.Width,img1.Height);

            Color c1, c2;

            for(int i=0;i<img1.Width;i++)
                for(int j=0;j<img2.Height;i++)
                {
                    c1=img1.GetPixel(i,j);
                    average = (c1.R + c1.G + c1.B) / 3;
                    c2=Color.FromArgb(average,average,average);
                    img2.SetPixel(i,j,c2);
                }
            P2.Image = img2;
        }

        private void 二階化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int average;
            int th = 128;
            Bitmap img1 = (Bitmap)P1.Image;
            Bitmap img2 = new Bitmap(img1.Width, img1.Height);

            Color c1, c2;

            for (int i = 0; i < img1.Width; i++)
                for (int j = 0; j < img2.Height; i++)
                {
                    c1 = img1.GetPixel(i, j);
                    average = (c1.R + c1.G + c1.B) / 3;

                    if (average > th)
                        average = 255;
                    else
                        average = 0;

                    c2 = Color.FromArgb(average, average, average);
                    img2.SetPixel(i, j, c2);
                }
            P2.Image = img2;
        }
        private Bitmap filterProcessing(Bitmap originImg,int[,] filterArray,int div)
        {
            
            Bitmap newImg = new Bitmap(originImg.Width, originImg.Height);

            int grayValue;
            Color c1;

            for(int i=1;i<originImg.Width-1;i++)
                for(int j=1;j<originImg.Height-1;j++)
                {
                    grayValue = 0;
                    for(int x=-1;x<=1;x++)
                    {
                        for(int y=-1;y<=1;y++)
                        {
                            c1=originImg.GetPixel(x+i,y+j);

                            grayValue +=(int)(c1.R*0.299+c1.G*0.587+c1.B*0.114)*filterArray[x+1,y+1];
                        }
                    }
                    grayValue /= div;

                    if (grayValue > 255)
                    {
                        grayValue = 255;
                    }
                    else if (grayValue < 0)
                    {
                        grayValue = 0;
                    }
                    newImg.SetPixel(i, j,Color.FromArgb(grayValue,grayValue,grayValue));
                }

            return newImg;
        }

        private void 權重平滑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[,] filterArray = { {1,2,1 },{2,4,2 },{1,2,1 } };
            int div = 16;
            Bitmap originImg = (Bitmap)P1.Image;
            P2.Image = filterProcessing(originImg, filterArray, div);
        }

        private void 平滑濾波ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[,] filterArray = { { 1, 1, 1 }, { 1,1,1 }, { 1, 1, 1 } };
            int div = 9;

            P2.Image = filterProcessing((Bitmap)P1.Image, filterArray, div);
        }

        private void 索柏XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[,] filterArray = { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
            int div = 1;

            P2.Image = filterProcessing((Bitmap)P1.Image, filterArray, div);
        }

        private void 索柏YToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[,] filterArray = { { 1, 2, 1 }, { 0, 0, 0 }, { -1, -2, -1 } };
            int div = 1;

            P2.Image = filterProcessing((Bitmap)P1.Image, filterArray, div);
        }
    }
    
}