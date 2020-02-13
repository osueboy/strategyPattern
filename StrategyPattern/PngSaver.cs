using System;

namespace StrategyPattern
{
    public class PngSaver : ISaveImage
    {
        public void SaveImage(string name)
        {
            Console.WriteLine(string.Format(MessageTemplate.SavedImage, name, ImageFormats.Png));
        }
    }
}
