using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageModification.IO
{
    class InputOutput
    {
        /// <summary>
        /// Lets the user choose a png/jpg/bmp from his windows file system
        /// </summary>
        /// <returns>A Bitmap selected by the user</returns>
        public Bitmap LoadImage()
        {
            Bitmap image = null;

            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Select an image file.",
                Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg"
            };
            ofd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(ofd.FileName);
                image = new Bitmap(streamReader.BaseStream);
                streamReader.Close();
            }

            return image;
        }
        /// <summary>
        /// Lets the user save a png/jpg/bmp on his windows file system
        /// </summary>
        /// <param name="image">A Bitmap to be saved by the user</param>
        public void SaveImage(Bitmap image)
        {
            if (image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Title = "Specify a file name and file path",
                    Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg"
                };
                sfd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string fileExtension = Path.GetExtension(sfd.FileName).ToUpper();
                    ImageFormat imgFormat = ImageFormat.Png;

                    if (fileExtension == "BMP")
                    {
                        imgFormat = ImageFormat.Bmp;
                    }
                    else if (fileExtension == "JPG")
                    {
                        imgFormat = ImageFormat.Jpeg;
                    }

                    StreamWriter streamWriter = new StreamWriter(sfd.FileName, false);
                    image.Save(streamWriter.BaseStream, imgFormat);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }
        }
    }
}
