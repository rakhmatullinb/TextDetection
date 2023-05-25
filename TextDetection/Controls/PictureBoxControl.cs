using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace TextDetection.Controls
{
    public class PictureBoxControl
    {
        public Bitmap Bitmap { get => (Bitmap)_pictureBox.Image; }
        private readonly PictureBox _pictureBox;
        private readonly PictureBox _pictureBox2;
        private readonly List<Rectangle> _textAreas;

        public PictureBoxControl(PictureBox pictureBox, PictureBox pictureBox2)
        {
            _pictureBox = pictureBox;
            _pictureBox2 = pictureBox2;
            _textAreas = new List<Rectangle>();
            _pictureBox.Paint += _pictureBox_Paint;
            _pictureBox2.Paint += _pictureBox2_Paint;
        }

        private void _pictureBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (var textAreaRect in _textAreas)
            {
                float scaleX = (float)_pictureBox.Width / Bitmap.Width;
                float scaleY = (float)_pictureBox.Height / Bitmap.Height;
                Rectangle pictureBoxRect = new Rectangle(
                    (int)(textAreaRect.X * scaleX),
                    (int)(textAreaRect.Y * scaleY),
                    (int)(textAreaRect.Width * scaleX),
                    (int)(textAreaRect.Height * scaleY)
                );
                e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Red), 2), pictureBoxRect);

                /*e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Red), 2), textAreaRect);*/
            }
        }

        private void _pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            /*e.Graphics.Clear(Color.White);
            if (_pictureBox2.Image != null)
            {
                var pic = (Bitmap)_pictureBox.Image;
                foreach (var textAreaRect in _textAreas)
                {
                    e.Graphics.DrawImage(pic.Clone(textAreaRect, PixelFormat.Format16bppRgb555), textAreaRect.Location);
                }
         
            }*/
        }

        public void OpenImage(string imageFilePath, Action imageLoaded)
        {
            _pictureBox.Image = Image.FromFile(imageFilePath);
            imageLoaded();
        }

        public void DrawRectangle(List<Rectangle> rectangles)
        {
            _textAreas.AddRange(rectangles);
            var pic = DrawBitmap();
            _pictureBox2.Image = pic;
            _pictureBox.Invalidate();
            _pictureBox2.Invalidate();
        }


        public Bitmap DrawBitmap()
        {
            var pic = Bitmap; // Assuming this is a valid Bitmap object
            Bitmap newBitmap = new Bitmap(pic.Width, pic.Height);
            using (Graphics newGraphics = Graphics.FromImage(newBitmap))
            {
                newGraphics.Clear(Color.White);
                foreach (var textAreaRect in _textAreas)
                {
                    Bitmap clonedImage = pic.Clone(textAreaRect, PixelFormat.Format16bppRgb555);
                    newGraphics.DrawImage(clonedImage, textAreaRect.Location);
                    clonedImage.Dispose(); // Dispose the cloned image after use
                }
            }

            return newBitmap;
        }

            public void SetImage(Bitmap bitmap)
        {
            _pictureBox.Image = bitmap;
        }
    }
}

