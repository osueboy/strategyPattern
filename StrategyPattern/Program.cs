namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ContextImageSaver imageSaver = new ContextImageSaver();
            switch (imageSaver.AskForImage())
            {
                case ImageFormats.Png:
                    imageSaver.SetImageSaver(new PngSaver());
                    break;
                case ImageFormats.Bmp:
                    imageSaver.SetImageSaver(new BmpSaver());
                    break;
                case ImageFormats.Jpeg:
                    imageSaver.SetImageSaver(new JpegSaver());
                    break;
            }
            imageSaver.SaveImage();
        }
    }
}
