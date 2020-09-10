using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeamCarving
{
    public static class EdgeDetector
    {
        public static DirectBitmap EdgeImage;
        public static DirectBitmap GetEdgeImage(DirectBitmap image)
        {
            int[,] filter = new int[,] { 
                { 1, 0, -1 }, 
                { 2, 0, -2 }, 
                { 1, 0, -1 } };

            EdgeImage = new DirectBitmap(image.Width, image.Height);
            Graphics g = Graphics.FromImage(EdgeImage.Bitmap);
            g.FillRectangle(new SolidBrush(Color.Black), 0, 0, image.Width, image.Height);
            for (int i = 1; i < image.Height - 1; i++)
            {
                for (int j = 1; j < image.Width - 1; j++)
                {
                    int vertical = 0, horizontal = 0;
                    for (int ii = -1; ii < 2; ii++)
                    {
                        for (int jj = -1; jj < 2; jj++)
                        {
                            vertical += (int)(image.GetPixel(j + jj, i + ii).GetBrightness() * 255) * filter[jj + 1, ii + 1];
                            horizontal += (int)(image.GetPixel(j + jj, i + ii).GetBrightness() * 255) * filter[ii + 1, jj + 1];
                        }
                    }
                    EdgeImage.SetPixel(j, i, Color.FromArgb(Math.Min(255, 
                        (int)(Math.Sqrt(vertical * vertical + horizontal * horizontal))), Color.Black));
                }
            }
            g.Dispose();
            return EdgeImage;
        }
    }
}
