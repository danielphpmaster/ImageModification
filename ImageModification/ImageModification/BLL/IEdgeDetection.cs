using System.Drawing;

namespace ImageModification.BLL
{
    public interface IEdgeDetection
    {
        Bitmap filter(Bitmap bmp, double[,] FilterMatrix);
        double[,] getFilterMatrix(string filter);
    }
}