


using System;
using System.Text;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;



namespace AsciiArt
{
    class Program
    {
        private static readonly string _asciiChars = "@%#*+-. ";
        static void Main()
        {
            string path = "./1000102881.jpg";
            if (!System.IO.File.Exists(path))
            {
                Console.WriteLine("Error file is not exists");
                return;
            }
            try
            {
                using (Image<Rgba32> image = Image.Load<Rgba32>(path))
                {
                    int consoleWidth = 250;
                    double aspectRatio = (double)image.Height / image.Width;
                    int consoleHeight = (int)(consoleWidth * aspectRatio * 0.4);
                    image.Mutate(x=>x.Resize(consoleWidth,consoleHeight));
                    StringBuilder art = new StringBuilder();
                    image.ProcessPixelRows(accessor=>{
                            for(int y =0;y<accessor.Height;y++)
                            {
                                var pixelRow = accessor.GetRowSpan(y);
                                for(int x =0;x<pixelRow.Length;x++)
                                {
                                    Rgba32 pixel = pixelRow[x];
                                    int brightness = (pixel.R + pixel.G + pixel.B )/3;
                                    int charIndex = (brightness*(_asciiChars.Length-1))/255;
                                    art.Append(_asciiChars[charIndex]);
                                }
                                art.AppendLine();
                                
                            }
                            });
                    Console.WriteLine(art.ToString());
                }

            }
            catch(Exception err)
            {
                Console.WriteLine($"ERROR {err.Message}");
            }

        }
    }
}
