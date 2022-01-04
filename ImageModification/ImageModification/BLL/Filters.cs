using System.Drawing;

namespace ImageModification.BLL
{
    public class Filters : IFilters
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
        public Bitmap ApplyFilter(Bitmap bmp, int alpha, int red, int blue, int green)
        {

            Bitmap temp = new Bitmap(bmp.Width, bmp.Height);


            for (int i = 0; i < bmp.Width; i++)
            {
                for (int x = 0; x < bmp.Height; x++)
                {
                    Color c = bmp.GetPixel(i, x);
                    Color cLayer = Color.FromArgb(c.A / alpha, c.R / red, c.G / green, c.B / blue);
                    temp.SetPixel(i, x, cLayer);
                }

            }
            return temp;
        }

        /// <summary>
        /// Black and white image filter
        /// </summary>
        /// <param name="Bmp">The image that the filter will be applied to</param>
        /// <returns>The result filtered image</returns>
        public Bitmap BlackWhite(Bitmap Bmp)
        {
            int rgb;
            Color c;

            for (int y = 0; y < Bmp.Height; y++)
                for (int x = 0; x < Bmp.Width; x++)
                {
                    c = Bmp.GetPixel(x, y);
                    rgb = (int)((c.R + c.G + c.B) / 3);
                    Bmp.SetPixel(x, y, Color.FromArgb(rgb, rgb, rgb));
                }
            return Bmp;

        }

        /// <summary>
        /// Image filter swap
        /// </summary>
        /// <param name="bmp">The image that the filter will be applied to</param>
        /// <returns>The result filtered image</returns>
        public Bitmap ApplyFilterSwap(Bitmap bmp)
        {

            Bitmap temp = new Bitmap(bmp.Width, bmp.Height);


            for (int i = 0; i < bmp.Width; i++)
            {
                for (int x = 0; x < bmp.Height; x++)
                {
                    Color c = bmp.GetPixel(i, x);
                    Color cLayer = Color.FromArgb(c.A, c.G, c.B, c.R);
                    temp.SetPixel(i, x, cLayer);
                }

            }
            return temp;
        }
    }
}
