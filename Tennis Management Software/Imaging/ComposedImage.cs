using System.Collections.Generic;
using System.Drawing;

namespace Tennis_Management_Software.Imaging
{
    public class ComposeImage
    {
        public Size Dimensions { get; set; }
        public List<ImagePart> Images { get; set; }

        /// <summary>
        /// Initializes a new instance of the Tennis_Management_Software.Imaging.ComposeImage class.
        /// </summary>
        /// <param name="dimensions">The dimensions to set to the composed image.</param>
        public ComposeImage(Size dimensions)
        {
            this.Dimensions = dimensions;
            this.Images = new List<ImagePart>();
        }

        /// <summary>
        /// Initializes a new instance of the Tennis_Management_Software.Imaging.ComposeImage class.
        /// </summary>
        /// <param name="dimensions">The dimensions to set to the composed image.</param>
        /// <param name="images">The list of images to compose.</param>
        public ComposeImage(Size dimensions, List<ImagePart> images)
        {
            this.Dimensions = dimensions;
            this.Images = images;
        }

        /// <summary>
        /// Composes the images into one image.
        /// </summary>
        /// <returns></returns>
        public Bitmap ComposeTheImage()
        {
            if (Dimensions == null || Images == null)
                return null;

            Bitmap fullbitmap = new Bitmap(Dimensions.Width, Dimensions.Height);

            using (Graphics graphics = Graphics.FromImage(fullbitmap))
            {
                foreach (ImagePart image in Images)
                {
                    graphics.DrawImage(image.Image, image.Location.X, image.Location.Y);
                }
            }
            return fullbitmap;
        }
    }
}
