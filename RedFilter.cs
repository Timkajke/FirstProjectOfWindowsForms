using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13
{
    class RedFilter : IFilter
    {
        public Bitmap Apply(Bitmap bitmap)
        {
            int height = bitmap.Height;
            int width = bitmap.Width;
            Bitmap result = new Bitmap(width, height);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color colour = bitmap.GetPixel(j, i);
                    Color c = Color.FromArgb(colour.R, 0, 0);
                    result.SetPixel(j, i, c);
                }
            }
            return result;
        }

        public string GetName()
        {
            return "Red";
        }
    }
}