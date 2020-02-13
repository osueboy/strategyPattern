using System;

namespace StrategyPattern
{
    public class BmpSaver : ISaveImage
    {
        public void SaveImage(string name)
        {
            Console.WriteLine(string.Format(MessageTemplate.SavedImage, name, ImageFormats.Bmp));
        }
    }
}
