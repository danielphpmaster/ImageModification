using ImageModification.BLL;
using ImageModification.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageModification
{
    public partial class FormImageModification : Form
    {
        /// <summary>
        /// ImageFilter interface
        /// </summary>
        IFilters imageFilter = new Filters();

        /// <summary>
        /// EdgeDetection interface
        /// </summary>
        IEdgeDetection edgeDetection = new EdgeDetection();

        /// <summary>
        /// InputOutput
        /// </summary>
        InputOutput inputOutput = new InputOutput();

        /// <summary>
        /// Image in the picture box without any filter applied
        /// </summary>
        private Image origin;

        /// <summary>
        /// Constructor of the form
        /// </summary>
        public FormImageModification()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method executed when the form is loaded
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void FormImageModification_Load(object sender, EventArgs e)
        {
            pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;
            Bitmap image = new Bitmap(Properties.Resources.penguins);
            pictureBoxPreview.Image = image;
            origin = pictureBoxPreview.Image;
        }

        /// <summary>
        /// Load an image when the load button is clicked
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            labelError.Visible = false;
            Bitmap loadedImage = inputOutput.LoadImage();
            pictureBoxPreview.Image = loadedImage;
            origin = pictureBoxPreview.Image;
        }

        /// <summary>
        /// Save the image when the save button is clicked
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void buttonSaveImage_Click(object sender, EventArgs e)
        {
            if (pictureBoxPreview.Image != null)
            {
                labelError.Visible = false;
                inputOutput.SaveImage(new Bitmap(pictureBoxPreview.Image));
            }
            else
            {
                labelError.Visible = true;
                labelError.Text = "You must load an image first";
            }
        }

        /// <summary>
        /// Reset the filters and show the origin image when the reset button is clicked
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            pictureBoxPreview.Image = origin;
        }

        /// <summary>
        /// Apply a black and white filter to the image when the corresponding button is clicked
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void buttonBlackWhiteFilter_Click(object sender, EventArgs e)
        {
            if(pictureBoxPreview.Image != null) 
            {
                labelError.Visible = false;
                Bitmap filteredImage = imageFilter.BlackWhite(new Bitmap(pictureBoxPreview.Image));
                pictureBoxPreview.Image = filteredImage;
            } 
            else
            {
                labelError.Visible = true;
                labelError.Text = "You must load an image first";
            }
            
        }

        /// <summary>
        /// Apply a miami filter to the image when the corresponding button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMiamiFilter_Click(object sender, EventArgs e)
        {
            if (pictureBoxPreview.Image != null)
            {
                labelError.Visible = false;
                Bitmap filteredImage = imageFilter.ApplyFilter(new Bitmap(pictureBoxPreview.Image), 1, 1, 10, 1);
                pictureBoxPreview.Image = filteredImage;
            }
            else
            {
                labelError.Visible = true;
                labelError.Text = "You must load an image first";
            }
        }

        /// <summary>
        /// Apply a swap filter to the image when the corresponding button is clicked
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void buttonSwapFilter_Click(object sender, EventArgs e)
        {
            if (pictureBoxPreview.Image != null)
            {   
                labelError.Visible = false;
                Bitmap filteredImage = imageFilter.ApplyFilterSwap(new Bitmap(pictureBoxPreview.Image));
                pictureBoxPreview.Image = filteredImage;
            }
            else
            {
                labelError.Visible = true;
                labelError.Text = "You must load an image first";
            }
        }

        /// <summary>
        /// Apply the Laplacian3x3 edge detection to the image when the corresponding button is clicked
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void buttonLaplacian3x3_Click(object sender, EventArgs e)
        {
            if (pictureBoxPreview.Image != null)
            {
                labelError.Visible = false;
                Bitmap resultImage = edgeDetection.filter(new Bitmap(pictureBoxPreview.Image), edgeDetection.getFilterMatrix(buttonLaplacian3x3.Text));
                pictureBoxPreview.Image = resultImage;
            }
            else
            {
                labelError.Visible = true;
                labelError.Text = "You must load an image first";
            }
        }

        /// <summary>
        /// Apply the Sobel3x3Vertical edge detection to the image when the corresponding button is clicked
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void buttonSobel3x3Vertical_Click(object sender, EventArgs e)
        {
            if (pictureBoxPreview.Image != null)
            {
                labelError.Visible = false;
                Bitmap resultImage = edgeDetection.filter(new Bitmap(pictureBoxPreview.Image), edgeDetection.getFilterMatrix(buttonSobel3x3Vertical.Text));
                pictureBoxPreview.Image = resultImage;
            }
            else
            {
                labelError.Visible = true;
                labelError.Text = "You must load an image first";
            }
        }

        /// <summary>
        /// Apply the Prewitt3x3Horizontal edge detection to the image when the corresponding button is clicked
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void buttonPrewitt3x3Horizontal_Click(object sender, EventArgs e)
        {
            if (pictureBoxPreview.Image != null)
            {
                labelError.Visible = false;
                Bitmap resultImage = edgeDetection.filter(new Bitmap(pictureBoxPreview.Image), edgeDetection.getFilterMatrix(buttonPrewitt3x3Horizontal.Text));
                pictureBoxPreview.Image = resultImage;
            }
            else
            {
                labelError.Visible = true;
                labelError.Text = "You must load an image first";
            }
        }
    }
}
