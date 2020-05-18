using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_1
{
    public partial class mainForm : Form
    {
        FastBitmap bmp;
        bool[,] structElement = null;
        string extraOperation = "none";

        public mainForm()
        {
            InitializeComponent();
            bmp = new FastBitmap(pictureBox.Width, pictureBox.Height);
            changeFiltersEnabled(true);
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files|*.png;*.jpg;*.bmp|All files|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                bmp = new FastBitmap(dialog.FileName);
                pictureBox.Image = bmp.image;
                pictureBox.Refresh();
                changeFiltersEnabled(false);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Image files|*.png;*.jpg;*.bmp|All files|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image.Save(dialog.FileName, ImageFormat.Png);
            }
        }

        private void chooseStructElementButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files|*.png;*.jpg;*.bmp|All files|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap structBmp = new Bitmap(dialog.FileName);
                if (structBmp.Width > 7 || structBmp.Height > 7)
                    MessageBox.Show("Размер структурного элемента не должен превышать 7 пикселей", "Неверный структурный элемент");
                else
                {
                    structElement = new bool[structBmp.Width, structBmp.Height];
                    for (int x = 0; x < structBmp.Width; ++x)
                        for (int y = 0; y < structBmp.Height; ++y)
                        {
                            Color color = structBmp.GetPixel(x, y);
                            structElement[x, y] = color.R == 0;
                        }
                    changeFiltersEnabled(false);
                }
            }
        }

        private void inversionButton_Click(object sender, EventArgs e)
        {
            InvertFilter filter = new InvertFilter();
            backgroundWorker.RunWorkerAsync(filter);
            changeFiltersEnabled(true);
        }

        private void grayWorldButton_Click(object sender, EventArgs e)
        {
            GrayWorldFilter filter = new GrayWorldFilter();
            backgroundWorker.RunWorkerAsync(filter);
            changeFiltersEnabled(true);
        }

        private void perfectReflectorButton_Click(object sender, EventArgs e)
        {
            PerfectReflectorFilter filter = new PerfectReflectorFilter();
            backgroundWorker.RunWorkerAsync(filter);
            changeFiltersEnabled(true);
        }

        private void linearStretchingButton_Click(object sender, EventArgs e)
        {
            LinearStretchingFilter filter = new LinearStretchingFilter();
            backgroundWorker.RunWorkerAsync(filter);
            changeFiltersEnabled(true);
        }

        private void rotateButton_Click(object sender, EventArgs e)
        {
            RotateFilter filter = new RotateFilter(45);
            backgroundWorker.RunWorkerAsync(filter);
            changeFiltersEnabled(true);
        }

        private void glassButton_Click(object sender, EventArgs e)
        {
            GlassFilter filter = new GlassFilter();
            backgroundWorker.RunWorkerAsync(filter);
            changeFiltersEnabled(true);
        }

        private void medianButton_Click(object sender, EventArgs e)
        {
            MedianFilter filter = new MedianFilter(3);
            backgroundWorker.RunWorkerAsync(filter);
            changeFiltersEnabled(true);
        }

        private void blurButton_Click(object sender, EventArgs e)
        {
            BlurFilter filter = new BlurFilter();
            backgroundWorker.RunWorkerAsync(filter);
            changeFiltersEnabled(true);
        }

        private void gaussianButton_Click(object sender, EventArgs e)
        {
            GaussianFilter filter = new GaussianFilter(3);
            backgroundWorker.RunWorkerAsync(filter);
            changeFiltersEnabled(true);
        }

        private void stampingButton_Click(object sender, EventArgs e)
        {
            StampingFilter filter = new StampingFilter();
            backgroundWorker.RunWorkerAsync(filter);
            changeFiltersEnabled(true);
        }

        private void glowingEdgesButton_Click(object sender, EventArgs e)
        {
            GlowingEdgesFilter filter = new GlowingEdgesFilter();
            backgroundWorker.RunWorkerAsync(filter);
            changeFiltersEnabled(true);
        }

        private void dilationButton_Click(object sender, EventArgs e)
        {
            DilationFilter filter = new DilationFilter(structElement);
            backgroundWorker.RunWorkerAsync(filter);
            changeFiltersEnabled(true);
        }

        private void erosionButton_Click(object sender, EventArgs e)
        {
            ErosionFilter filter = new ErosionFilter(structElement);
            backgroundWorker.RunWorkerAsync(filter);
            changeFiltersEnabled(true);
        }

        private void closingButton_Click(object sender, EventArgs e)
        {
            DilationFilter firstFilter = new DilationFilter(structElement);
            backgroundWorker.RunWorkerAsync(firstFilter);
            extraOperation = "erosion";
            changeFiltersEnabled(true);
        }

        private void openingButton_Click(object sender, EventArgs e)
        {
            ErosionFilter firstFilter = new ErosionFilter(structElement);
            backgroundWorker.RunWorkerAsync(firstFilter);
            extraOperation = "dilation";
            changeFiltersEnabled(true);
        }

        private void morphGradButton_Click(object sender, EventArgs e)
        {
            MorphGradFilter filter = new MorphGradFilter(structElement);
            backgroundWorker.RunWorkerAsync(filter);
            changeFiltersEnabled(true);
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            FastBitmap newBmp = ((Filter)e.Argument).ProcessImage(bmp, backgroundWorker);
            if (backgroundWorker.CancellationPending != true)
                bmp = newBmp;
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            if (e.ProgressPercentage > 90)
            {
                progressBar.Value = 100;
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (extraOperation == "erosion")
            {
                ErosionFilter firstFilter = new ErosionFilter(structElement);
                backgroundWorker.RunWorkerAsync(firstFilter);
                extraOperation = "none";
            }
            else if (extraOperation == "dilation")
            {
                DilationFilter firstFilter = new DilationFilter(structElement);
                backgroundWorker.RunWorkerAsync(firstFilter);
                extraOperation = "none";
            }
            else
            {
                pictureBox.Image = bmp.image;
                pictureBox.Refresh();
                changeFiltersEnabled(false);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            backgroundWorker.CancelAsync();
            changeFiltersEnabled(false);
        }

        private void changeFiltersEnabled(bool workIsGoing)
        {
            progressBar.Value = 0;
            cancelButton.Enabled = workIsGoing;

            inversionButton.Enabled = !workIsGoing;
            grayWorldButton.Enabled = !workIsGoing;
            perfectReflectorButton.Enabled = !workIsGoing;
            linearStretchingButton.Enabled = !workIsGoing;
            rotateButton.Enabled = !workIsGoing;
            glassButton.Enabled = !workIsGoing;
            medianButton.Enabled = !workIsGoing;

            blurButton.Enabled = !workIsGoing;
            gaussianButton.Enabled = !workIsGoing;
            stampingButton.Enabled = !workIsGoing;
            glowingEdgesButton.Enabled = !workIsGoing;

            if (structElement != null)
            {
                dilationButton.Enabled = !workIsGoing;
                erosionButton.Enabled = !workIsGoing;
                closingButton.Enabled = !workIsGoing;
                openingButton.Enabled = !workIsGoing;
                morphGradButton.Enabled = !workIsGoing;
            }
        }
    }
}