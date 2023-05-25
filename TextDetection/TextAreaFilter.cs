using System;
using System.Drawing;

namespace TextDetection
{
    public class TextAreaFilter
    {

        public void Filter(Rectangle rectangle, Action<Rectangle> onFilterPassed)
        {
            if (rectangle.Width > rectangle.Height &&
                (float)(rectangle.Width / rectangle.Height) > 2f &&
                rectangle.Height > 10)
            {
            onFilterPassed(rectangle);
            }
            
        }
    }
}
