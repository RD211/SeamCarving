using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace SeamCarving
{
    public static class Carver
    {
        private static Color[,] edgeImageArray;
        private static Color[,] originalImageArray;
        private static DirectBitmap CropImage(DirectBitmap img, Rectangle cropArea)
        {
            Bitmap bmp = new Bitmap(img.Bitmap);
            return new DirectBitmap(bmp.Clone(cropArea, bmp.PixelFormat));
        }
        public static DirectBitmap ResizeCarving(DirectBitmap original, Size size)
        {
            var edgeImage = EdgeDetector.GetEdgeImage(original);
            edgeImageArray = new Color[edgeImage.Height, edgeImage.Width];
            originalImageArray = new Color[edgeImage.Height, edgeImage.Width];
            for(int i = 0;i<edgeImage.Height;i++)
            {
                for(int j = 0;j<edgeImage.Width;j++)
                {
                    edgeImageArray[i, j] = edgeImage.GetPixel(j, i);
                    originalImageArray[i, j] = original.GetPixel(j, i);
                }
            }
            foreach (int i in Enumerable.Range(0,original.Width-size.Width))
            {
                CarveVertical(original.Width-i,original.Height);
            }
            foreach (int i in Enumerable.Range(0, original.Height - size.Height))
            {
                CarveHorizontal(size.Width, original.Height-i);
            }
            var resized = CropImage(original, new Rectangle(0, 0, size.Width,size.Height));
            for (int i = 0; i < resized.Height; i++)
            {
                for (int j = 0; j < resized.Width; j++)
                {
                    resized.SetPixel(j, i, originalImageArray[i, j]);
                }
            }
            return resized;
        }

        public static void CarveVertical(int actualWidth, int actualHeight)
        {
            int[,] dp = new int[actualHeight + 5, actualWidth+ 5];

            for (int j = 0; j < actualWidth; j++)
                dp[0, j] = (int)((-edgeImageArray[0,j].A)*255);

            int x = 0, y = 0;
            int maximizeEnd = int.MinValue;
            for(int i = 1;i<actualHeight; i++)
            {
                for(int j = 0;j< actualWidth; j++)
                {
                    int maximize = int.MinValue;
                    if (j != 0)
                        maximize = Math.Max(dp[i - 1, j - 1], maximize);
                    maximize = Math.Max(dp[i - 1, j], maximize);
                    if (j != actualWidth - 1)
                        maximize = Math.Max(dp[i - 1, j + 1], maximize);
                    dp[i, j] = maximize + (int)((-edgeImageArray[i, j].A) * 255);
                    if(i== actualHeight - 1 && dp[i,j]> maximizeEnd)
                    {
                        maximizeEnd = dp[i, j];
                        x = j;
                        y = i;
                    }
                }
            }

            List<Point> path = new List<Point>() {new Point(x,y)};
            while(y!=0)
            {
                int maximize = int.MinValue;
                int nx=-1, ny=-1;
                if (x != 0) {
                    if (maximize < dp[y - 1, x - 1])
                    {
                        maximize = dp[y - 1, x - 1];
                        nx = x - 1; ny = y - 1;
                    }
                }
                if(maximize < dp[y-1,x])
                {
                    maximize = dp[y - 1, x];
                    nx = x; ny = y - 1;
                }
                if (x != actualWidth-1)
                {
                    if (maximize < dp[y - 1, x + 1])
                    {
                        maximize = dp[y - 1, x + 1];
                        nx = x + 1; ny = y - 1;
                    }
                }
                x = nx; y = ny;
                path.Add(new Point(x, y));
            }

            for(int j=0;j<path.Count;j++)
            {
                var point = path[j];
                originalImageArray[point.Y, point.X] = Color.Green;
                for (int i = point.X; i < actualWidth - 1; i++)
                {
                    originalImageArray[point.Y, i] = originalImageArray[point.Y, i + 1];
                    edgeImageArray[point.Y, i] = edgeImageArray[point.Y, i + 1];
                }
            }
        }
        public static void CarveHorizontal(int actualWidth, int actualHeight)
        {
            int[,] dp = new int[actualHeight + 5, actualWidth + 5];

            foreach(int i in Enumerable.Range(0,actualHeight))
                dp[i,0] = (int)((-edgeImageArray[i,0].A) * 255);

            int x = 0, y = 0;
            int maximizeEnd = int.MinValue;
            for (int j = 1; j < actualWidth; j++)
            {
                for (int i = 0; i < actualHeight; i++)
                {
                    int maximize = int.MinValue;
                    if (i != 0)
                        maximize = Math.Max(dp[i - 1, j - 1], maximize);
                    maximize = Math.Max(dp[i, j-1], maximize);
                    if (i != actualHeight - 1)
                        maximize = Math.Max(dp[i + 1, j - 1], maximize);
                    dp[i, j] = maximize + (int)((-edgeImageArray[i,j].A) * 255);
                    if (j == actualWidth - 1 && dp[i, j] > maximizeEnd)
                    {
                        maximizeEnd = dp[i, j];
                        x = j;
                        y = i;
                    }
                }
            }

            List<Point> path = new List<Point>() { new Point(x, y) };
            while (x != 0)
            {
                int maximize = int.MinValue;
                int nx = -1, ny = -1;
                if (y != 0)
                {
                    if (maximize < dp[y - 1, x - 1])
                    {
                        maximize = dp[y - 1, x - 1];
                        nx = x - 1; ny = y - 1;
                    }
                }
                if (maximize < dp[y, x-1])
                {
                    maximize = dp[y, x-1];
                    nx = x-1; ny = y;
                }
                if (y != actualHeight - 1)
                {
                    if (maximize < dp[y + 1, x - 1])
                    {
                        maximize = dp[y + 1, x - 1];
                        nx = x - 1; ny = y + 1;
                    }
                }
                x = nx; y = ny;
                path.Add(new Point(x, y));
            }

            for(int j = 0;j<path.Count;j++)
            {
                var point = path[j];
                for (int i = point.Y; i < actualHeight - 1; i++)
                {
                    originalImageArray[i, point.X] = originalImageArray[i + 1, point.X];
                    edgeImageArray[i, point.X] = edgeImageArray[i + 1, point.X];
                }
            }
        }
    }
}
