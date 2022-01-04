using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageModificationTests
{
    /// <summary>
    /// CompareBitmap class that provides image comparison by pixels
    /// </summary>
    public class CompareBitmap
    {
        /// <summary>
        /// Test if two Bitmaps are identical by each pixel
        /// </summary>
        /// <param name="resultImage">Result image</param>
        /// <param name="filteredImage">Filtered image</param>
        public void CompareBitmapPixels(Bitmap resultImage, Bitmap filteredImage)
        {
            Assert.AreEqual(resultImage.Size, filteredImage.Size);

            for (int y = 0; y < resultImage.Height - 1; y++)
            {
                for (int x = 0; x < resultImage.Width - 1; x++)
                {
                    Assert.AreEqual(resultImage.GetPixel(x, y), filteredImage.GetPixel(x, y));
                }
            }
        }
    }
}
