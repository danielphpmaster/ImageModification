using System.Drawing;

namespace ImageModification.BLL
{
    public interface IFilters
    {
        Bitmap ApplyFilter(Bitmap bmp, int alpha, int red, int blue, int green);
        Bitmap ApplyFilterSwap(Bitmap bmp);
        Bitmap BlackWhite(Bitmap Bmp);
    }
}