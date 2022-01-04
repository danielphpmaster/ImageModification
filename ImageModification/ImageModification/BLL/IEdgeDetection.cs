using System.Drawing;

namespace ImageModification.BLL
{
    /// <summary>
    /// Interface for EdgeDetection class
    /// </summary>
    public interface IEdgeDetection
    {
        /// <summary>
        /// Apply various edge detection filters on a bitmap
        /// </summary>
        /// <param name="bmp">Bitmap to apply edge detection on</param>
        /// <param name="FilterMatrix">Selected edge detection filter</param>
        /// <returns>The result filtered image</returns>
        Bitmap filter(Bitmap bmp, double[,] FilterMatrix);

        /// <summary>
        /// Get the FilterMatrix used for edge detection
        /// </summary>
        /// <param name="filter">Name of the edge detection filter</param>
        /// <returns>A filter matrix</returns>
        double[,] getFilterMatrix(string filter);
    }
}