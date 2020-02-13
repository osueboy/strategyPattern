using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class JpegSaver : ISaveImage
    {
        public void SaveImage(string name)
        {
            Console.WriteLine(string.Format(MessageTemplate.SavedImage, name, ImageFormats.Jpeg));
        }
    }
}
