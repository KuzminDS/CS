using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.CS.Task1
{
    public class FileFinder
    {
        public static IEnumerable<string> GetFilesBySignature(string directoryPath, byte[] signatureBytes)
        {
            var signature = signatureBytes.ToByteArray();
            var files = Directory.EnumerateFiles(directoryPath, "*.txt", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                var fileBytes = File.ReadAllBytes(file).ToByteArray();
                if (fileBytes.Contains(signature))
                    yield return file;
            }
        }
    }
}
