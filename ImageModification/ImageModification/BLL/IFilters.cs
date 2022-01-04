using System.Drawing;

namespace ImageModification.BLL
{
    /// <summary>
    /// Interface for Filters class
    /// </summary>
    public interface IFilters
    {
        /// <summary>
        /// Color image filter (Miami filter: A=1, R=1, G=1, B=10)
        /// </summary>
        /// <param name="bmp">The image that the filter will be applied to</param>
        /// <param name="alpha">The filter value of opacity</param>
        /// <param name="red">The filter value of red</param>
        /// <param name="blue">The filter value of blue</param>
        /// <param name="green">The filter value of green</param>
        /// <returns>The result filtered image</returns>
        Bitmap ApplyFilter(Bitmap bmp, int alpha, int red, int blue, int green);

        /// <summary>
        /// Image filter swap
        /// </summary>
        /// <param name="bmp">The image that the filter will be applied to</param>
        /// <returns>The result filtered image</returns>
        Bitmap ApplyFilterSwap(Bitmap bmp);

        /// <summary>
        /// Black and white image filter
        /// </summary>
        /// <param name="Bmp">The image that the filter will be applied to</param>
        /// <returns>The result filtered image</returns>
        Bitmap BlackWhite(Bitmap Bmp);
    }
}