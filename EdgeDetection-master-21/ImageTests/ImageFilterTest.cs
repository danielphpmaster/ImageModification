using Microsoft.VisualStudio.TestTools.UnitTesting;
using Image;
using System.Drawing;

namespace ImageTests
{
    [TestClass]
    public class ImageFilterTest
    {
        //Method to test if two Bitmaps are identical by each pixel
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

        //Test if the miami image filter works
        [TestMethod]
        public void TestFilterMiami()
        {
            Bitmap filteredMiamiImage = new Bitmap(Properties.Resources.penguinsMiami);

            Bitmap sourceImage = new Bitmap(Properties.Resources.penguins2);
            Bitmap resultImage = ImageFilters.FilterColor(sourceImage, 1, 1, 1, 10);

            CompareBitmapPixels(resultImage, filteredMiamiImage);
        }

        //Test if the miami filter returns null if it gets Bitmap=null
        [TestMethod]
        public void TestFilterMiamiNull()
        {
            Bitmap resultImage = ImageFilters.FilterColor(null, 1, 1, 1, 10);
            Assert.IsNull(resultImage);
        }

        //Test if the mosaic image filter works
        [TestMethod]
        public void TestFilterMosaic()
        {
            Bitmap filteredMosaicImage = new Bitmap(Properties.Resources.penguinsMosaic);

            Bitmap sourceImage = new Bitmap(Properties.Resources.penguins2);
            Bitmap resultImage = ImageFilters.FilterMosaic(sourceImage);

            CompareBitmapPixels(resultImage, filteredMosaicImage);
        }

        //Test if the mosaic filter returns null if it gets Bitmap=null
        [TestMethod]
        public void TestFilterMosaicNull()
        {
            Bitmap resultImage = ImageFilters.FilterMosaic(null);
            Assert.IsNull(resultImage);
        }
    }
}
