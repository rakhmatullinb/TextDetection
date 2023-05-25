using Accord.Imaging;
using Accord.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace TextDetection
{
    internal class ImageProcessing
    {
        private Bitmap _image;

        public ImageProcessing(Bitmap image)
        {
            _image = CopyImage(image);
        }

        public Bitmap CopyImage(Bitmap image)
        {
            var newImage = new Bitmap(image.Width, image.Height, image.PixelFormat);
            using (var g = Graphics.FromImage(newImage))
            {
                var rect = new Rectangle(0, 0, image.Width, image.Height);
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, rect, rect, GraphicsUnit.Pixel);
            }
            return newImage;
        }

        public ImageProcessing Preview(Action<Bitmap> onPreview)
        {
            onPreview(_image);
            return this;
        }

        public ImageProcessing Grayscale()
        {
            Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
            _image = filter.Apply(_image);
            return this;
        }

        internal ImageProcessing Opening()
        {
            Opening filter = new Opening();
            _image = filter.Apply(_image);
            return this;
        }

        internal ImageProcessing Binarize(int threshold)
        {
            Threshold filter = new Threshold(threshold);
            filter.ApplyInPlace(_image);
            return this;
        }

        public ImageProcessing DetectEdges(byte lowThreshold, byte highThreshold, double sigma)
        {
            CannyEdgeDetector filter = new CannyEdgeDetector(lowThreshold, highThreshold, sigma);
            filter.ApplyInPlace(_image);
            return this;
        }

        internal ImageProcessing SobelEdge()
        {
            SobelEdgeDetector sobel = new SobelEdgeDetector();
            sobel.ApplyInPlace(_image);
            return this;
        }

        internal ImageProcessing Dilate()
        {
            Dilation dilation = new Dilation();
            dilation.ApplyInPlace(_image);
            return this;
        }

        internal ImageProcessing HorizontalSmear(int smear)
        {
            HorizontalRunLengthSmoothing hrls = new HorizontalRunLengthSmoothing(smear);
            hrls.ApplyInPlace(_image);
            return this;
        }

        internal IEnumerable<Rectangle> GetBlobs()
        {
            BlobCounter bc = new BlobCounter();
            bc.ProcessImage(_image);
            return bc.GetObjectsRectangles();
        }

        public ImageProcessing EqualizeHistogram()
        {
            HistogramEqualization filter = new HistogramEqualization();
            filter.ApplyInPlace(_image);
            return this;
        }
    }
}