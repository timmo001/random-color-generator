using System;
using System.Drawing;
using System.IO;

namespace RandomColorGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter file = new StreamWriter(args[1], true))
            {
                var random = new Random();
                for (int i = 0; i < Int32.Parse(args[0]); i++)
                {
                    file.WriteLine(String.Format("{0}", ColorTranslator.ToHtml(
                        Color.FromArgb(random.Next(150, 255), random.Next(150, 255), random.Next(150, 255))
                        )));
                }
            }
        }
    }
}
