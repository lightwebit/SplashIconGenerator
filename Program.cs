
using System.Drawing;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string inputDir = Path.Combine(Directory.GetCurrentDirectory(), "icons");
        string outputDir = Path.Combine(Directory.GetCurrentDirectory(), "output");

        if (!Directory.Exists(inputDir))
        {
            Console.WriteLine("Icons folder not found!");
            return;
        }

        var sizes = new (int w, int h)[] { (256,256), (512,512), (1024,1024) };

        foreach (var file in Directory.GetFiles(inputDir, "*.png"))
        {
            using (var img = Image.FromFile(file))
            {
                foreach (var size in sizes)
                {
                    var bmp = new Bitmap(img, size.w, size.h);
                    string folder = Path.Combine(outputDir, $"{size.w}x{size.h}");
                    Directory.CreateDirectory(folder);
                    string outPath = Path.Combine(folder, Path.GetFileName(file));
                    bmp.Save(outPath);
                    Console.WriteLine($"Saved {outPath}");
                }
            }
        }
    }
}
