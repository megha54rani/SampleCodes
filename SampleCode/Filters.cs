using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class Filters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Brightness applied to photo");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize applied to photo");
        }

        public void Resize1(Photo photo)
        {
            Console.WriteLine("Resize1 applied to photo");
        }

        public void contrast(Photo photo)
        {
            Console.WriteLine("Contrast applied to photo");
        }
    }
}
