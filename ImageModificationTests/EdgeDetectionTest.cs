using ImageModification.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System.Drawing;

namespace ImageModificationTests
{
    /// <summary>
    /// EdgeDetectionTest unit test class to test the methods of the EdgeDetection class
    /// </summary>
    [TestClass]
    public class EdgeDetectionTest
    {
        /// <summary>
        /// CompareBitmap to compare images
        /// </summary>
        private CompareBitmap comparatorBitmap = new CompareBitmap();

        /// <summary>
        /// EdgeDetection interface that is substituted 
        /// </summary>
        private IEdgeDetection edgeDetection = Substitute.For<IEdgeDetection>();

        /// <summary>
        /// EdgeDetection class
        /// </summary>
        private EdgeDetection edgeDetectionClass = new EdgeDetection();

        /// <summary>
        /// Bitmap source image
        /// </summary>
        private Bitmap sourceImage = Properties.Resources.penguins;

        /// <summary>
        /// Laplacian3x3 edge detection test
        /// </summary>
        [TestMethod]
        public void Laplacian3x3Test()
        {
            Bitmap filteredImage = Properties.Resources.penguins_laplacian3x3;

            edgeDetection.filter(sourceImage, edgeDetection.getFilterMatrix("Laplacian3x3")).Returns(filteredImage);

            Bitmap resultImage = edgeDetectionClass.filter(sourceImage, edgeDetectionClass.getFilterMatrix("Laplacian3x3"));

            comparatorBitmap.CompareBitmapPixels(edgeDetection.filter(sourceImage, edgeDetection.getFilterMatrix("Laplacian3x3")), resultImage);

        }

        /// <summary>
        /// Sobel3x3Vertical edge detection test
        /// </summary>
        [TestMethod]
        public void Sobel3x3VerticalTest()
        {
            Bitmap filteredImage = Properties.Resources.penguins_Sobel3x3Vertical;

            edgeDetection.filter(sourceImage, edgeDetection.getFilterMatrix("Sobel3x3Vertical")).Returns(filteredImage);

            Bitmap resultImage = edgeDetectionClass.filter(sourceImage, edgeDetectionClass.getFilterMatrix("Sobel3x3Vertical"));

            comparatorBitmap.CompareBitmapPixels(edgeDetection.filter(sourceImage, edgeDetection.getFilterMatrix("Sobel3x3Vertical")), resultImage);

        }

        /// <summary>
        /// Prewitt3x3Horizontal edge detection test
        /// </summary>
        [TestMethod]
        public void Prewitt3x3HorizontalTest()
        {
            Bitmap filteredImage = Properties.Resources.penguins_Prewitt3x3Horizontal;

            edgeDetection.filter(sourceImage, edgeDetection.getFilterMatrix("Prewitt3x3Horizontal")).Returns(filteredImage);

            Bitmap resultImage = edgeDetectionClass.filter(sourceImage, edgeDetectionClass.getFilterMatrix("Prewitt3x3Horizontal"));

            comparatorBitmap.CompareBitmapPixels(edgeDetection.filter(sourceImage, edgeDetection.getFilterMatrix("Prewitt3x3Horizontal")), resultImage);

        }

        /// <summary>
        /// Prewitt3x3Horizontal edge detection test
        /// </summary>
        [TestMethod]
        public void DefaultEdgeDetectionTest()
        {
            Bitmap filteredImage = Properties.Resources.penguins_laplacian3x3;

            edgeDetection.filter(sourceImage, edgeDetection.getFilterMatrix("")).Returns(filteredImage);

            Bitmap resultImage = edgeDetectionClass.filter(sourceImage, edgeDetectionClass.getFilterMatrix(""));

            comparatorBitmap.CompareBitmapPixels(edgeDetection.filter(sourceImage, edgeDetection.getFilterMatrix("")), resultImage);

        }
    }
}
