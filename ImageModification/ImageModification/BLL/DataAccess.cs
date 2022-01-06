using ImageModification.IO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageModification.BLL
{
    public class DataAccess : IDataAccess
    {
        /// <summary>
        /// InputOutput interface
        /// </summary>
        private IInputOutput inputOutput = new InputOutput();

        /// <summary>
        /// Lets the user choose a png/jpg/bmp from his windows file system
        /// </summary>
        /// <returns>A Bitmap selected by the user</returns>
        public Bitmap LoadImage(String imagePath)
        {
            return inputOutput.LoadImage(imagePath);
        }

        /// <summary>
        /// Lets the user save a png/jpg/bmp on his windows file system
        /// </summary>
        /// <param name="image">A Bitmap to be saved by the user</param>
        public void SaveImage(Bitmap image, String imagePath)
        {
            inputOutput.SaveImage(image, imagePath);
        }
    }
}
