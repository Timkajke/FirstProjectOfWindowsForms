using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13
{
    class FilterFactory
    {
        List<IFilter> filters;
        public FilterFactory()
        {
            filters = new List<IFilter>()
            {
                new RedFilter(),
                new GreyFilter(),
                new Reverse()
            };
        }
        public List<string> GetNames()
        {
            List<string> names = new List<string>();
            foreach (IFilter filter in filters)
            {
                names.Add(filter.GetName());
            }
            return names;
        }
        public Bitmap ApplyFilter(int num, Bitmap bitmap)
        {
            num %= filters.Count();
            num = Math.Abs(num);
            return filters[num].Apply(bitmap);
        }
    }
}