using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp13
{
    interface IFilter
    {
        Bitmap Apply(Bitmap bitmap);
        string GetName();
    }
}