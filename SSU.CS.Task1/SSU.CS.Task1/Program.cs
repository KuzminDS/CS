using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.CS.Task1
{
    class Program
    {
        private const int _signatureSize = 16;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите название файла с сигнатурой: ");
            var fileName = Console.ReadLine();

            Console.WriteLine("Введите смещение: ");
            var offset = int.Parse(Console.ReadLine());

            var fileBytes = File.ReadAllBytes(fileName);
            var signature = new byte[_signatureSize];
            Array.Copy(fileBytes, offset, signature, 0, _signatureSize);

            Console.WriteLine("Введите путь к директории: ");
            var directoryPath = Console.ReadLine();

            var foundFiles = FileFinder.GetFilesBySignature(directoryPath, signature);
            foreach (var file in foundFiles)
            {
                Console.WriteLine(file);
            }
        }
    }
}
