using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextDetection.Common;
using TextDetection.Controls;
using System.IO;

using Emgu;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.OCR;
using Emgu.CV.Structure;
using Emgu.Util;


namespace TextDetection
{
    public partial class Form1 : Form
    {
        private PictureBoxControl _pictureBox;
        /*private PictureBoxControl _pictureBox2;*/
        private readonly TextAreaFilter _textAreaFilter;
        private PictureBoxControl newBitmap;
   

        private string filePath = string.Empty;

        private string lang = string.Empty;

        public Form1()
        {
            InitializeComponent();
            _pictureBox = new PictureBoxControl(pictureBox1, pictureBox2);
            _textAreaFilter = new TextAreaFilter();
            
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e) =>
            new OpenFileDialog().OpenImage((imageFilePath)=>_pictureBox.OpenImage(imageFilePath,()=> detectTextToolStripMenuItem.Enabled = true));

        private void detectTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rectangles = new List<Rectangle>();
            new ImageProcessing(_pictureBox.Bitmap)
                .Grayscale()
                .DetectEdges((byte)nLow.Value, (byte)nHigh.Value, double.Parse(txtSigma.Text))
                .Dilate()
                .Binarize((int)nThreshold.Value)
                .HorizontalSmear((int)nHorizontalSmear.Value)
                .GetBlobs()
                .ForEach((rectangle) => _textAreaFilter.Filter(rectangle, rectangles.Add));
                _pictureBox.DrawRectangle(rectangles);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(filePath) || String.IsNullOrWhiteSpace(filePath))
                {
                    throw new Exception("Картинка не выбрана!");
                }
                else if (toolStripComboBox1.SelectedItem == null)
                {
                    throw new Exception("Язык не выбран!");
                }
                else
                {
                    Tesseract tesseract = new Tesseract(@"C:\test_data", lang, OcrEngineMode.TesseractLstmCombined);

                    tesseract.SetImage(newBitmap);

                    tesseract.Recognize();

                    richTextBox1.Text = tesseract.GetUTF8Text();

                    tesseract.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            EmguCV_textRecognize page2 = new EmguCV_textRecognize();
            page2.Show();
            this.Hide();
        }*/
    }
}