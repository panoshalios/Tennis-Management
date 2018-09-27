using System.Drawing;
using System.Drawing.Imaging;

namespace Tennis_Management_Software.Imaging
{
    public static class ImageHandling
    {
        /// <summary>
        /// Returns a Bitmap of the panel. Used to capture parts of non-visible areas.
        /// </summary>
        /// <param name="panel"></param>
        /// <returns></returns>
        public static Bitmap GetBitmapFromPanel(System.Windows.Forms.Panel panel)
        {
            Point oldPosition = new Point(panel.HorizontalScroll.Value, panel.VerticalScroll.Value);

            panel.PerformLayout();

            ComposeImage ci = new ComposeImage(new Size(panel.DisplayRectangle.Width, panel.DisplayRectangle.Height));

            int visibleWidth = panel.Width - (panel.VerticalScroll.Visible ? System.Windows.Forms.SystemInformation.VerticalScrollBarWidth : 0);
            int visibleHeightBuffer = panel.Height - (panel.HorizontalScroll.Visible ? System.Windows.Forms.SystemInformation.HorizontalScrollBarHeight : 0);

            for (int x = panel.DisplayRectangle.Width - visibleWidth; x >= 0; x -= visibleWidth)
            {

                int visibleHeight = visibleHeightBuffer;

                for (int y = panel.DisplayRectangle.Height - visibleHeight; y >= 0; y -= visibleHeight)
                {
                    panel.HorizontalScroll.Value = x;
                    panel.VerticalScroll.Value = y;

                    panel.PerformLayout();

                    Bitmap bmp = new Bitmap(visibleWidth, visibleHeight);

                    panel.DrawToBitmap(bmp, new Rectangle(0, 0, visibleWidth, visibleHeight));
                    ci.Images.Add(new ImagePart(new Point(x, y), bmp));

                    if (y - visibleHeight < (panel.DisplayRectangle.Height % visibleHeight))
                        visibleHeight = panel.DisplayRectangle.Height % visibleHeight;

                    if (visibleHeight == 0)
                        break;
                }

                if (x - visibleWidth < (panel.DisplayRectangle.Width % visibleWidth))
                    visibleWidth = panel.DisplayRectangle.Width % visibleWidth;
                if (visibleWidth == 0)
                    break;
            }

            Bitmap img = ci.ComposeTheImage();

            panel.HorizontalScroll.Value = oldPosition.X;
            panel.VerticalScroll.Value = oldPosition.Y;
            return img;
        }

        /// <summary>
        /// Resizes the bounds of the rectangle.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="rect"></param>
        /// <returns></returns>
        public static Rectangle GetResizedRectBoundsFromBitmap(Bitmap image, Rectangle rect)
        {
            //Image is bigger than rectangle.
            if ((double)image.Width / (double)image.Height > (double)rect.Width / (double)rect.Height)
            {
                rect.Height = (int)((double)image.Height / (double)image.Width * (double)rect.Width);
            }
            else
            {
                rect.Width = (int)((double)image.Width / (double)image.Height * (double)rect.Height);
            }

            return rect;
        }

        /// <summary>
        /// Save an image.
        /// </summary>
        /// <param name="image">The image to save.</param>
        /// <param name="filePath">The path to save the image.</param>
        /// <param name="format">The format to save the image.</param>
        public static void SaveImage(Image image, string filePath, ImageFormat format)
        {
            if (image != null)
            {
                System.IO.File.Delete(filePath);
                image.Save(filePath, format);
                image.Dispose();
            }
        }

        /// <summary>
        /// Returns a value indicating if an image file is corrupted.
        /// </summary>
        /// <param name="filename">The path of the image.</param>
        /// <returns></returns>
        public static bool IsImageCorrupted(string filename)
        {
            try
            {
                using (Bitmap bitmap = new Bitmap(filename))
                {
                }
                return false;
            }
            catch (System.Exception)
            {
                
                return true;
            }
        }
    }
}
