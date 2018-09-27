using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tennis_Management_Software
{
    public partial class PictureInput : UserControl
    {
        private const uint imageWidth = 250, imageHeight = 300;
        private Image resizedPicture = null;

        /// <summary>
        /// Initializes a new instance of the Tennis_Management_Software.PictureInput class.
        /// </summary>
        public PictureInput()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets or returns the image of the picture box.
        /// </summary>
        public Image MainPictureBoxImage
        {
            get
            {
                if (resizedPicture != null)
                    return resizedPicture;

                return null;
            }
            set
            {
                resizedPicture = value;
                mainPictureBox.BackgroundImage = value;
            }
        }

        /// <summary>
        /// Clears the background image of the picture box.
        /// </summary>
        private void ClearPictureBoxBackgroundImage()
        {
            mainPictureBox.BackgroundImage = null;
        }

        /// <summary>
        /// Resizes an Image object.
        /// </summary>
        /// <param name="picture">The image to resize.</param>
        /// <param name="width">The new width.</param>
        /// <param name="height">The new height.</param>
        /// <returns>Resized image.</returns>
        private Bitmap GetResizedImage(Image picture, uint width, uint height)
        {
            Bitmap resizedImage = new Bitmap(picture, (int)width, (int)height);
            return resizedImage;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Select Picture";
            fileDialog.Filter = "Image Files (*.png), (*.jpg), (*.bmp)|*.png;*.jpg;*.bmp";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!Tennis_Management_Software.Imaging.ImageHandling.IsImageCorrupted(fileDialog.FileName))
                {
                    using (Image picture = Image.FromFile(fileDialog.FileName))
                    {
                        mainPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                        ClearPictureBoxBackgroundImage();
                        resizedPicture = GetResizedImage(picture, imageWidth, imageHeight);
                        mainPictureBox.BackgroundImage = resizedPicture;
                    }
                }
            }
        }

        private void mainPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void mainPanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePath = (string[])e.Data.GetData(DataFormats.FileDrop, true);
            if (filePath.Length == 1)
            {
                string fileExtension = Path.GetExtension(filePath[0]);

                if ((fileExtension == ".png" || fileExtension == ".PNG" || fileExtension == ".jpg" || fileExtension == ".bmp") && !Tennis_Management_Software.Imaging.ImageHandling.IsImageCorrupted(filePath[0]))
                {
                    using(Image picture = Image.FromFile(filePath[0]))
                    {
                        ClearPictureBoxBackgroundImage();
                        mainPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                        resizedPicture = GetResizedImage(picture, imageWidth, imageHeight);
                        mainPictureBox.BackgroundImage = resizedPicture;
                    }
                }
            }
        }

        /// <summary>
        /// Disposes the picture box.
        /// </summary>
        public void DisposePictureBox()
        {
            resizedPicture.Dispose();
            mainPictureBox.Dispose();
        }
    }
}
