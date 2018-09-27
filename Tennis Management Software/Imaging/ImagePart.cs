using System.Drawing;

namespace Tennis_Management_Software.Imaging
{
    public class ImagePart
    {
        public Point Location { get; set; }
        public Bitmap Image { get; set; }

        /// <summary>
        /// Initializes a new instance of the Tennis_Management_Software.Imaging.ImagePart class.
        /// </summary>
        /// <param name="location"></param>
        /// <param name="image"></param>
        public ImagePart(Point location, Bitmap image)
        {
            this.Location = location;
            this.Image = image;
        }
    }
}
