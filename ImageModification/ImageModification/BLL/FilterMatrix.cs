namespace ImageModification.BLL
{
    /// <summary>
    /// FilterMatrix class that provides the edge detection filter matrices
    /// </summary>
    public class FilterMatrix
    {
        /// <summary>
        /// Laplacian3x3 matrix
        /// </summary>
        public static double[,] Laplacian3x3
        {
            get
            {
                return new double[,]
                { { -1, -1, -1,  },
                  { -1,  8, -1,  },
                  { -1, -1, -1,  }, };
            }
        }

        /// <summary>
        /// Sobel3x3Vertical matrix
        /// </summary>
        public static double[,] Sobel3x3Vertical
        {
            get
            {
                return new double[,]
                { {  1,  2,  1, },
                  {  0,  0,  0, },
                  { -1, -2, -1, }, };
            }
        }

        /// <summary>
        /// Prewitt3x3Horizontal matrix
        /// </summary>
        public static double[,] Prewitt3x3Horizontal
        {
            get
            {
                return new double[,]
                { { -1,  0,  1, },
                  { -1,  0,  1, },
                  { -1,  0,  1, }, };
            }
        }
    }
}
