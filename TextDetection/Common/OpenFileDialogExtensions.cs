using System;
using System.Windows.Forms;

namespace TextDetection.Common
{
    public static class OpenFileDialogExtensions
    {
        public static void OpenImage(this OpenFileDialog openFileDialog, Action<string> onImageOpened)
        {
            openFileDialog.Title = "Open Image";
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                onImageOpened(openFileDialog.FileName);
        }
    }
}
