using Image;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

namespace ImageTests
{
    [TestClass]
    public class EdgeDetectionTest
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

        //Test if a X=Laplacian3x3 Y=Laplacian3x3 edge detection works
        [TestMethod]
        public void TestEdgeDetectionLap3x3Lap3x3()
        {
            Bitmap filteredLap3x3Lap3x3Image = new Bitmap(ImageTests.Properties.Resources.penguinsLap3x3Lap3x3);

            Bitmap sourceImage = new Bitmap(ImageTests.Properties.Resources.penguinsOrigin);
            Bitmap resultImage = EdgeDetection.filter(sourceImage, "Laplacian3x3", "Laplacian3x3");

            CompareBitmapPixels(resultImage, filteredLap3x3Lap3x3Image);
        }

        //Test if a X=Laplacian5x5 Y=Laplacian5x5 edge detection works
        [TestMethod]
        public void TestEdgeDetectionLap5x5Lap5x5()
        {
            Bitmap filteredLap5x5Lap5x5Image = new Bitmap(ImageTests.Properties.Resources.penguinsLap5x5Lap5x5);

            Bitmap sourceImage = new Bitmap(ImageTests.Properties.Resources.penguinsOrigin);
            Bitmap resultImage = EdgeDetection.filter(sourceImage, "Laplacian5x5", "Laplacian5x5");

            CompareBitmapPixels(resultImage, filteredLap5x5Lap5x5Image);
        }

        //Test if a X=Kirsch3x3Horizontal Y=Kirsch3x3Vertical edge detection works
        [TestMethod]
        public void TestEdgeDetectionSobel3x3HSobel3x3V()
        {
            Bitmap filteredSobel3x3HSobel3x3VImage = new Bitmap(ImageTests.Properties.Resources.penguinsSobel3x3HSobel3x3V);

            Bitmap sourceImage = new Bitmap(ImageTests.Properties.Resources.penguinsOrigin);
            Bitmap resultImage = EdgeDetection.filter(sourceImage, "Sobel3x3Horizontal", "Sobel3x3Vertical");

            CompareBitmapPixels(resultImage, filteredSobel3x3HSobel3x3VImage);
        }

        //Test if a X=Prewitt3x3Horizontal Y=Prewitt3x3Vertical edge detection works
        [TestMethod]
        public void TestEdgeDetectionPrewitt3x3HPrewitt3x3V()
        {
            Bitmap filteredPrewitt3x3HPrewitt3x3VImage = new Bitmap(ImageTests.Properties.Resources.penguinsPrewitt3x3HPrewitt3x3V);

            Bitmap sourceImage = new Bitmap(ImageTests.Properties.Resources.penguinsOrigin);
            Bitmap resultImage = EdgeDetection.filter(sourceImage, "Prewitt3x3Horizontal", "Prewitt3x3Vertical");

            CompareBitmapPixels(resultImage, filteredPrewitt3x3HPrewitt3x3VImage);
        }

        //Test if a X=Kirsch3x3Horizontal Y=Kirsch3x3Horizontal edge detection works
        [TestMethod]
        public void TestEdgeDetectionKirsch3x3HKirsch3x3V()
        {
            Bitmap filteredKirsch3x3HKirsch3x3VImage = new Bitmap(ImageTests.Properties.Resources.penguinsKirsch3x3HKirsch3x3V);

            Bitmap sourceImage = new Bitmap(ImageTests.Properties.Resources.penguinsOrigin);
            Bitmap resultImage = EdgeDetection.filter(sourceImage, "Kirsch3x3Horizontal", "Kirsch3x3Vertical");

            CompareBitmapPixels(resultImage, filteredKirsch3x3HKirsch3x3VImage);
        }

        //Test if the filter returns null if it gets Bitmap=null
        [TestMethod]
        public void TestImageNull()
        {
            Bitmap resultImage = EdgeDetection.filter(null, "Laplacian3x3", "Laplacian3x3");
            Assert.IsNull(resultImage);
        }

        //Test if the filter uses Laplacian3x3 if it gets X=null
        [TestMethod]
        public void TestXNull()
        {
            Bitmap filteredLap3x3Lap3x3Image = new Bitmap(ImageTests.Properties.Resources.penguinsLap3x3Lap3x3);
            
            Bitmap sourceImage = new Bitmap(ImageTests.Properties.Resources.penguinsOrigin);
            Bitmap resultImage = EdgeDetection.filter(sourceImage, null, "Laplacian3x3");

            CompareBitmapPixels(resultImage, filteredLap3x3Lap3x3Image);
        }

        //Test if the filter uses Laplacian3x3 if it gets Y=null
        [TestMethod]
        public void TestYNull()
        {
            Bitmap filteredLap3x3Lap3x3Image = new Bitmap(ImageTests.Properties.Resources.penguinsLap3x3Lap3x3);
            
            Bitmap sourceImage = new Bitmap(ImageTests.Properties.Resources.penguinsOrigin);
            Bitmap resultImage = EdgeDetection.filter(sourceImage, "Laplacian3x3", null);

            CompareBitmapPixels(resultImage, filteredLap3x3Lap3x3Image);
        }
    }
}
