using System;

namespace StrategyPattern
{
    public class ContextImageSaver
    {
        private ISaveImage _imageSaver;
        private string _nombre;
        public void SetImageSaver(ISaveImage imageSaver)
        {
            _imageSaver = imageSaver;
        }

        public string AskForImage()
        {
            Console.WriteLine("proporciona el nómbre de imagen");
            _nombre = Console.ReadLine();
            Console.WriteLine("proporciona el formato en que la quieres guardar, {0},{1},{2}", ImageFormats.Png, ImageFormats.Bmp, ImageFormats.Jpeg);
            string formato = Console.ReadLine();
            return formato;
        }
        public void SaveImage()
        {
           _imageSaver.SaveImage(_nombre);
        }
    }
}
