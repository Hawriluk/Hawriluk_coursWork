using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courseWork
{
    public partial class Form1 : Form
    {
        Rectangle Rect;
        int OriginX=1, OriginY=1;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRender_Click_1(object sender, EventArgs e)
        {            
            Render();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Bitmap Image|*.bmp|JPEG Image|*.jpg";
            dialog.Title = "Save Image";
            dialog.ShowDialog();

            if (dialog.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)dialog.OpenFile();

                switch (dialog.FilterIndex)
                {
                    case 1:
                        PBOutput.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 2:
                        PBOutput.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                }

                fs.Close();
            }
        }

        private void SetZoomingRectangle (int moveToX, int moveToY)
        {
            moveToX = Math.Max(0, Math.Min(moveToX, PBOutput.Image.Width));
            moveToY = Math.Max(0, Math.Min(moveToY, PBOutput.Image.Height));

            if (moveToX == 0) moveToX = 1;
            if (moveToX >= PBOutput.Image.Width)
                moveToX -= 1;
            if (moveToY == 0) moveToY = 1;
            if (moveToY >= PBOutput.Image.Height)
                moveToY -= 1;

            if (moveToX >= Rect.X)    
                Rect.Width = moveToX - OriginX;
            else                          
            {
                Rect.X = moveToX;
                Rect.Width = OriginX - moveToX;
            }

            if (moveToY >= Rect.Y)    
                Rect.Height = moveToY - OriginY;
            else                          
            {
                Rect.Y = moveToY;
                Rect.Height = OriginY - moveToY;
            }

            if (RatioChecker.Checked)
            {
                double ratio = (double)imageWidth / (double)imageHeight;

                if (Rect.Height > Rect.Width) 
                    Rect.Width = (int)(ratio * Rect.Height);
                else
                    Rect.Height = (int)(Rect.Width/ratio);
            }
        }

        private void PBOutput_Paint(object sender, PaintEventArgs e)
        {
            if (PBOutput.Image != null && Rect.Width > 0 && Rect.Height > 0)
            {
                Pen pen = new Pen(Color.Red, 1);
                Graphics g = e.Graphics;
                g.DrawRectangle(pen, Rect);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Програма для реалізації фракталів, розроблена Наталією Гаврилюк! Copyright (C)");
        }       
    }
}
