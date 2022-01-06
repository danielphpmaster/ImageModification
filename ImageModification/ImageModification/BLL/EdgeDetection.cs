using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ImageModification.BLL
{
    /// <summary>
    /// EdgeDetection class that provides edge detection filters
    /// </summary>
    public class EdgeDetection : IEdgeDetection
    {
        /// <summary>
        /// Get the FilterMatrix used for edge detection
        /// </summary>
        /// <param name="filter">Name of the edge detection filter</param>
        /// <returns>A filter matrix</returns>
        public double[,] getFilterMatrix(string filter)
        {
            double[,] FilterMatrix;

            switch (filter)
            {
                case "Laplacian3x3":
                    FilterMatrix = BLL.FilterMatrix.Laplacian3x3;
                    break;
                case "Sobel3x3Vertical":
                    FilterMatrix = BLL.FilterMatrix.Sobel3x3Vertical;
                    break;
                case "Prewitt3x3Horizontal":
                    FilterMatrix = BLL.FilterMatrix.Prewitt3x3Horizontal;
                    break;
                default:
                    FilterMatrix = BLL.FilterMatrix.Laplacian3x3;
                    break;
            }

            return FilterMatrix;
        }

        /// <summary>
        /// Apply various edge detection filters on a bitmap
        /// </summary>
        /// <param name="bmp">Bitmap to apply edge detection on</param>
        /// <param name="FilterMatrix">Selected edge detection filter</param>
        /// <returns>The result filtered image</returns>
        public Bitmap filter(Bitmap bmp, double[,] FilterMatrix)
        {
            double[,] xFilterMatrix = FilterMatrix;
            double[,] yFilterMatrix = FilterMatrix;

            if (bmp != null)
            {
                BitmapData newbitmapData = new BitmapData();
                newbitmapData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppPArgb);

                byte[] pixelbuff = new byte[newbitmapData.Stride * newbitmapData.Height];
                byte[] resultbuff = new byte[newbitmapData.Stride * newbitmapData.Height];

                Marshal.Copy(newbitmapData.Scan0, pixelbuff, 0, pixelbuff.Length);
                bmp.UnlockBits(newbitmapData);

                double blueX = 0.0;
                double greenX = 0.0;
                double redX = 0.0;

                double blueY = 0.0;
                double greenY = 0.0;
                double redY = 0.0;

                double blueTotal = 0.0;
                double greenTotal = 0.0;
                double redTotal = 0.0;

                int filterOffset = 1;
                int calcOffset = 0;

                int byteOffset = 0;

                for (int offsetY = filterOffset; offsetY <
                    bmp.Height - filterOffset; offsetY++)
                {
                    for (int offsetX = filterOffset; offsetX <
                        bmp.Width - filterOffset; offsetX++)
                    {
                        blueX = greenX = redX = 0;
                        blueY = greenY = redY = 0;

                        blueTotal = greenTotal = redTotal = 0.0;

                        byteOffset = offsetY *
                                     newbitmapData.Stride +
                                     offsetX * 4;

                        for (int filterY = -filterOffset;
                            filterY <= filterOffset; filterY++)
                        {
                            for (int filterX = -filterOffset;
                                filterX <= filterOffset; filterX++)
                            {
                                calcOffset = byteOffset +
                                             (filterX * 4) +
                                             (filterY * newbitmapData.Stride);

                                blueX += (double)(pixelbuff[calcOffset]) *
                                          xFilterMatrix[filterY + filterOffset,
                                                  filterX + filterOffset];

                                greenX += (double)(pixelbuff[calcOffset + 1]) *
                                          xFilterMatrix[filterY + filterOffset,
                                                  filterX + filterOffset];

                                redX += (double)(pixelbuff[calcOffset + 2]) *
                                          xFilterMatrix[filterY + filterOffset,
                                                  filterX + filterOffset];

                                blueY += (double)(pixelbuff[calcOffset]) *
                                          yFilterMatrix[filterY + filterOffset,
                                                  filterX + filterOffset];

                                greenY += (double)(pixelbuff[calcOffset + 1]) *
                                          yFilterMatrix[filterY + filterOffset,
                                                  filterX + filterOffset];

                                redY += (double)(pixelbuff[calcOffset + 2]) *
                                          yFilterMatrix[filterY + filterOffset,
                                                  filterX + filterOffset];
                            }
                        }

                        blueTotal = 0;
                        greenTotal = Math.Sqrt((greenX * greenX) + (greenY * greenY));
                        redTotal = 0;

                        if (greenTotal > 255)
                        {
                            greenTotal = 255;
                        }

                        resultbuff[byteOffset] = (byte)(blueTotal);
                        resultbuff[byteOffset + 1] = (byte)(greenTotal);
                        resultbuff[byteOffset + 2] = (byte)(redTotal);
                        resultbuff[byteOffset + 3] = 255;
                    }
                }

                Bitmap resultBitmap = new Bitmap(bmp.Width, bmp.Height);

                BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                         resultBitmap.Width, resultBitmap.Height),
                                                          ImageLockMode.WriteOnly,
                                                      PixelFormat.Format32bppArgb);

                Marshal.Copy(resultbuff, 0, resultData.Scan0, resultbuff.Length);
                resultBitmap.UnlockBits(resultData);
                return resultBitmap;
            }
            else
            {
                return null;
            }
        }
    }
}
