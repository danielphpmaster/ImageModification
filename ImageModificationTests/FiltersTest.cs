using ImageModification.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System.Drawing;

namespace ImageModificationTests
{
    /// <summary>
    /// FiltersTest unit test class to test the methods of the Filters class
    /// </summary>
    [TestClass]
    public class FiltersTest
    {
        /// <summary>
        /// CompareBitmap to compare images
        /// </summary>
        private CompareBitmap comparatorBitmap = new CompareBitmap();

        /// <summary>
        /// Filters interface that is substituted 
        /// </summary>
        private IFilters filter = Substitute.For<IFilters>();

        /// <summary>
        /// Filters class
        /// </summary>
        private Filters filterClass = new Filters();

        /// <summary>
        /// Bitmap source image
        /// </summary>
        private Bitmap sourceImage = Properties.Resources.penguins;

        /// <summary>
        /// Miami filter test
        /// </summary>
        [TestMethod]
        public void MiamiFilterTest()
        {
            Bitmap filteredImage = Properties.Resources.penguins_miamiFilter;

            filter.ApplyFilter(sourceImage, 1, 1, 10, 1).Returns(filteredImage);

            Bitmap resultImage = filterClass.ApplyFilter(sourceImage, 1, 1, 10, 1);

            comparatorBitmap.CompareBitmapPixels(filter.ApplyFilter(sourceImage, 1, 1, 10, 1), resultImage);

        }

        /// <summary>
        /// Black and White filter test
        /// </summary>
        [TestMethod]
        public void BlackAndWhiteFilterTest()
        {
            Bitmap filteredImage = Properties.Resources.penguins_blackWhiteFilter;

            filter.BlackWhite(sourceImage).Returns(filteredImage);

            Bitmap resultImage = filterClass.BlackWhite(sourceImage);

            comparatorBitmap.CompareBitmapPixels(filter.BlackWhite(sourceImage), resultImage);

        }

        /// <summary>
        /// Swap filter test
        /// </summary>
        [TestMethod]
        public void SwapFilterTest()
        {
            Bitmap filteredImage = Properties.Resources.penguins_swapFilter;

            filter.ApplyFilterSwap(sourceImage).Returns(filteredImage);

            Bitmap resultImage = filterClass.ApplyFilterSwap(sourceImage);

            comparatorBitmap.CompareBitmapPixels(filter.ApplyFilterSwap(sourceImage), resultImage);

        }
    }
}
