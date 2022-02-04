using ImageMagick;
using System;
using System.Collections.Generic;

namespace ASCIIArt
{
    class Program
    {
        static void Main(string[] args)
        {
            var image = new MagickImage(@"C:\Repos\ASCIIArt\ASCIIArt\ascii-pineapple.jpg");
            var characters = "`^\",:;Il!i~+_-?][}{1)(|\\/tfjrxnuvczXYUJCLQ0OZmwqpdbkhao*#MW&8%B@$".ToCharArray();
            var divider = 256 / characters.Length;

            image.Resize(new Percentage(50));

            using (var pixels = image.GetPixels())
            {
                for (int x = 0; x < image.Width; x++)
                {
                    for (int y = 0; y < image.Height; y++)
                    {
                        var pixelValue = pixels.GetValue(x, y);
                        var pixelBrightness = (pixelValue[0] + pixelValue[1] + pixelValue[2]) / 3;
                        var index = (pixelBrightness * characters.Length) / 255;
                        Console.Write(characters[index]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}