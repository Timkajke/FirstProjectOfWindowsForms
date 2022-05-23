using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13
{
    class Reverse : IFilter
    {
        public Bitmap Apply(Bitmap bitmap)
        {
            int height = bitmap.Height;
            int width = bitmap.Width;
            Bitmap result = new Bitmap(height, width);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color colour = bitmap.GetPixel(j, i);
                    result.SetPixel(width - j - 1, i, colour);
                }
            }
            return result;
        }

        public string GetName()
        {
            return "Reverse";
        }
    }
}
