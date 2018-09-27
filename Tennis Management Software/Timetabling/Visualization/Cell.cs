using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tennis_Management_Software.Timetabling.Visualization
{
    [Serializable]
    public partial class Cell : UserControl
    {
        public enum CellAttribute
        {
            Heading,
            Normal,
            Empty
        }

        private CellAttribute attribute;
        public CellAttribute Attribute
        {
            set
            {
                attribute = value;
                switch (attribute)
                {
                    case CellAttribute.Heading:
                        this.BackColor = Color.Red;
                        break;
                    case CellAttribute.Normal:
                        this.BackColor = Color.LightGray;
                        break;
                    case CellAttribute.Empty:
                        this.BackColor = Color.Yellow;
                        break;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of theTennis_Management_Software.Timetabling.Visualization.Cell class.
        /// </summary>
        /// <param name="attribute">The attribute to set.</param>
        public Cell(CellAttribute attribute)
        {
            InitializeComponent();
            this.textLabel.Text = string.Empty;
            this.Attribute = attribute;
        }

        /// <summary>
        /// Sets the text of the Cell.
        /// </summary>
        /// <param name="text">The text to set.</param>
        public void SetText(string text)
        {
            this.textLabel.Text = text;
            if(text != string.Empty)
            {
                ResizeFormBorder(textLabel);
                RepositionLabel();
            }
        }

        /// <summary>
        /// Sets the color of the Cell.
        /// </summary>
        /// <param name="color">The color to set.</param>
        public void SetColor(Color color)
        {
            this.BackColor = color;
        }

        /// <summary>
        /// Resizes the form border according to the label.
        /// </summary>
        /// <param name="label"></param>
        private void ResizeFormBorder(Label label)
        {
            int height = label.Height;
            int width = label.Width;
            this.Height = (int)Math.Round(height * 1.2f);
            this.Width = (int)Math.Round(width * 1.2f);
        }

        /// <summary>
        /// Repositions the label to the middle of the Cell.
        /// </summary>
        public void RepositionLabel()
        {
            int labelMidX = this.textLabel.Width / 2;
            int labelMidY = this.textLabel.Height / 2;

            int cellMidX = this.Width / 2;
            int cellMidY = this.Height / 2;

            this.textLabel.Location = new Point(cellMidX - labelMidX, cellMidY - labelMidY);
        }

        /// <summary>
        /// Returns the text of the label.
        /// </summary>
        /// <returns></returns>
        public string GetLabelText()
        {
            return this.textLabel.Text;
        }

        /// <summary>
        /// Returns the location from the center of the cell.
        /// </summary>
        /// <returns></returns>
        public Point MidPointLocation()
        {
            return new Point(Location.X + (Width / 2), Location.Y + (Height / 2));
        }
    }
}
