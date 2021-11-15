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
            var pixelArray = new List<int[]>();

            using (var pixels = image.GetPixels())
            {
                for (int x = 0; x < image.Width; x++)
                {
                    for (int y = 0; y < image.Height; y++)
                    {
                        var pixelValue = pixels.GetValue(x, y);
                        pixelArray.Add(new int[] { pixelValue[0], pixelValue[1], pixelValue[2] });
                    }
                }
            }

            var test = pixelArray[0];
            test[test.Length] = 4;

            Console.WriteLine("Loaded image!");
            Console.WriteLine($"Image size: {image.Width} x {image.Height}");
            Console.WriteLine("Iterating through pixel contents:");

            foreach (var array in pixelArray)
            {
                Console.WriteLine($"({array[0]}, {array[1]}, {array[2]})");
            }
        }
    }
}