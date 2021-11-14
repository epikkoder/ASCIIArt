using ImageMagick;
using System;

namespace ASCIIArt
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var image = new MagickImage(@"C:\Repos\ASCIIArt\ASCIIArt\ascii-pineapple.jpg"))
            {
                Console.WriteLine("Loaded image!");
                Console.WriteLine($"Image size: {image.Width} x {image.Height}");
            }
        }
    }
}
