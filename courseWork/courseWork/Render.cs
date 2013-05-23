using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courseWork
{
    public partial class Form1 : Form
    {
        const double XMINLIMIT = -2.5;
        const double XMAXLIMIT = 1.5;
        const double YMINLIMIT = -1.5;
        const double YMAXLIMIT = 1.5;

        

        int imageWidth, imageHeight;

        public void Render()
        {
            groupBox1.Enabled = false;

            double xMin, xMax, yMin, yMax;
            int iterations;

            try
            {
                xMin = double.Parse(TxtXMin.Text);
                xMax = double.Parse(TxtXMax.Text);
                yMin = double.Parse(TxtYMin.Text);
                yMax = double.Parse(TxtYMax.Text);
                imageWidth = int.Parse(TxtImgW.Text);
                imageHeight = int.Parse(TxtImgH.Text);
                iterations = int.Parse(TxtIters.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("There was a problem with your parameters; please check and retry.\n\nError was:" + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Image image = new Image(imageWidth, imageHeight);

            double xInc = (xMax - xMin) / imageWidth;
            double yInc = (yMax - yMin) / imageHeight;
            int colsDone = 0;

            double x = xMin;        // Real part

            for (int screenX = 0; screenX < imageWidth; screenX++)
            {
                double y = yMin;    // Imaginary part

                for (int screenY = 0; screenY < imageHeight; screenY++)
                {
                    double x1 = 0, y1 = 0;

                    int iter = 0;
                    while (iter < iterations && Math.Sqrt((x1 * x1) + (y1 * y1)) < 2)
                    {
                        iter++;
                        double xx = (x1 * x1) - (y1 * y1) + x;
                        y1 = 2 * x1 * y1 + y;
                        x1 = xx;
                    }

                    image.SetPixel(screenX, screenY, iter);
                    y += yInc;
                }

                colsDone++;

                double percent = ((double)colsDone / (double)imageWidth) * 100.0;
                ProgressBar.Value = (int)percent;
                x += xInc;
            }

            if (PBOutput.Image != null) PBOutput.Image.Dispose();
            PBOutput.Image = image.ToBitmap();
            PBOutput.Width = imageWidth;
            PBOutput.Height = imageHeight;

            groupBox1.Enabled = true;
            BtnSave.Enabled = true;
            //btnZoom.Enabled = false;
            ProgressBar.Value = 0;
        }
    }
}
