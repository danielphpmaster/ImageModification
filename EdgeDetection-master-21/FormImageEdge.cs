using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

//My take on and implementation of http://www.getcodesamples.com/src/25E5A923
namespace Image
{
    public partial class FormImageEdge : Form
    {
        private System.Drawing.Image Origin;
        private Bitmap previewBitmap = null;
        private bool filterApplied = false;
        public Bitmap resultBitmap = null;

        public FormImageEdge()
        {
            InitializeComponent();
        }

        //Form on load event
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxResult.SizeMode = PictureBoxSizeMode.Zoom;
            Bitmap image = new Bitmap(Image.Properties.Resources.penguins);
            pictureBoxPreview.Image = image;
            Origin = pictureBoxPreview.Image;
            listBoxXFilter.SelectedIndex = 0;
            listBoxYFilter.SelectedIndex = 0;
        }


        /*
         * ON CLICK EVENTS
         */

        //Load button on click event
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Title = "Select image ";
            OpenFileDialog.Filter = "Jpeg Images(*.jpg)|*.jpg|Png Images(*.png)|*.png|Bitmap Images(*.bmp)|*.bmp";

            if (OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(OpenFileDialog.FileName);
                Bitmap image = new Bitmap(streamReader.BaseStream);
                streamReader.Close();

                pictureBoxPreview.Image = image;

            }
        }

        //Mosaic button on click event
        private void buttonMosaic_Click(object sender, EventArgs e)
        {
            pictureBoxPreview.Image = ImageFilters.FilterMosaic(new Bitmap(pictureBoxPreview.Image));
            labelErrors.Visible = false;
            filterApplied = true;
        }

        //Miami button on click event
        private void buttonMiami_Click(object sender, EventArgs e)
        {
            pictureBoxPreview.Image = ImageFilters.FilterColor(new Bitmap(pictureBoxPreview.Image), 1, 1, 1, 10);
            labelErrors.Visible = false;
            filterApplied = true;
        }

        //Reset button on click event
        private void buttonResetFilter_Click(object sender, EventArgs e)
        {
            pictureBoxPreview.Image = Origin;
            filterApplied = false;
        }

        //Apply Edge Detection button on click event
        private void buttonApplyFilters_Click(object sender, EventArgs e)
        {
            if(filterApplied == true)
            {
                if (listBoxXFilter.SelectedItem.ToString().Length > 0 && listBoxYFilter.SelectedItem.ToString().Length > 0)
                {
                    labelErrors.Visible = false;
                    Bitmap resultBitmap = EdgeDetection.filter(new Bitmap(pictureBoxPreview.Image), listBoxXFilter.SelectedItem.ToString(), listBoxYFilter.SelectedItem.ToString());
                    if (resultBitmap == null)
                    {
                        labelErrors.Text = "You must load an image";
                    }
                    else 
                    {
                        pictureBoxResult.Image = resultBitmap;
                    }
                }
                else
                {
                    labelErrors.Visible = true;
                    labelErrors.Text = "X and Y filters must be selected";
                }
            }    
            else
            {
                labelErrors.Visible = true;
                labelErrors.Text = "You must apply a filter to the image first";
            }  

        }

        //Save Image button on click event
        private void buttonSaveImage_Click(object sender, EventArgs e)
        {
            SaveImage();
        }


        /*
         * METHODS
         */

        //Save the result image only when image filters & edge detection are applied and a file name is given
        public void SaveImage()
        {
            FolderBrowserDialog fl = new FolderBrowserDialog();

            if(pictureBoxResult.Image == null)
            {
                labelErrors.Visible = true;
                labelErrors.Text = "You must apply image filters and edge detection first";
                return;
            }

            if (textBoxFileName.TextLength != 0)
            {
                if (fl.ShowDialog() != DialogResult.Cancel)
                {
                    pictureBoxResult.Image.Save(fl.SelectedPath + @"\" + textBoxFileName.Text + @".png", System.Drawing.Imaging.ImageFormat.Png);
                    labelErrors.Visible = false;
                }
            }
            else
            {
                labelErrors.Visible = true;
                labelErrors.Text = "You must enter a file name first";
            }
        }
    }
}

        
