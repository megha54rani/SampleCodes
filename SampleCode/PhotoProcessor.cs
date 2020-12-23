using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    
    public class PhotoProcessor
    {
       // public delegate void PhotoProcessorDelegate(Photo photoToFilter);

        public void PhotoProcess(string path, Action<Photo> flietrsfunctions)
        {
            var photo = Photo.LoadPhoto(path);
            flietrsfunctions(photo);
        }      
    }
}
