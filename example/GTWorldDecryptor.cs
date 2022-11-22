using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace example
{
    public class GTWorldDecryptor
    {
        public static async Task Main(string[] args)
        {
            var baseDirectoryPath = "D:\\Tools\\jadx\\apps\\cordova-code";
            var baseDirectory = new DirectoryInfo(baseDirectoryPath);

            if (!baseDirectory.Exists)
            {
                Console.WriteLine("The base directory does not exist.");
            }

            await ProcessDirectoryAsync(baseDirectory, 2);
        }


        private static async Task ProcessDirectoryAsync(DirectoryInfo directory, int level)
        {
            WriteToConsole(level, $"> Processing Directory: {directory.Name}");
            foreach (var fileInfo in directory.EnumerateFiles())
            {
                await ProcessFileAsync(fileInfo, level + 1);
            }

            foreach (var directoryInfo in directory.EnumerateDirectories())
            {
                await ProcessDirectoryAsync(directoryInfo, level + 1);
            }
        }


        private static async Task ProcessFileAsync(FileSystemInfo file, int level)
        {
            WriteToConsole(level, $"> Processing File: {file.Name}");

            var fileContents = await File.ReadAllTextAsync(file.FullName);
            try
            {
                var decodedBytes = Convert.FromBase64String(fileContents.Trim());
                using var aes = new AesManaged
                {
                    Key = Encoding.UTF8.GetBytes("GzgLjqCtquNMWS0oZ3o7iTbrPWXTrl8o"),
                    IV = Encoding.UTF8.GetBytes("K2z3VZgXZvU3cVeF")
                };

                var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                await using var msDecrypt = new MemoryStream(decodedBytes);
                await using var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);
                using var srDecrypt = new StreamReader(csDecrypt);
                var plainText = await srDecrypt.ReadToEndAsync();
                await File.WriteAllTextAsync(file.FullName, plainText);
            }
            catch (FormatException)
            {
                WriteToConsole(level, $">  [WARNING] Skipping File: {file.Name}. File is not Base64.");
            }   
        }


        private static void PrintLevelPusher(int level)
        {
            for (var i = 0; i < level; i++)
            {
                Console.Write("=");
            }
        }


        private static void WriteToConsole(int level, string format, params object[] data)
        {
            PrintLevelPusher(level);
            Console.WriteLine(format, data);
        }
    }
}
