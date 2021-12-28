using System.Drawing;

namespace ImageModification.BLL
{
    public interface IEdgeDetection
    {
        Bitmap filter(Bitmap bmp, string xfilter, string yfilter);
    }
}