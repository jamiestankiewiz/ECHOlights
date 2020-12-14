using System;
using System.IO;
using System.Linq;

namespace CSharpClient
{
    public class FileManager
    {
        string path = @"C:\LedStatusReport\testing.txt";

        public string ReadFile()
        {
            string[] lines = File.ReadAllLines(path).Where(s => s.Trim() != String.Empty).ToArray();
            string[] data = lines[0].Split(':');
            return data[1].Trim();
        }

        public void SaveFile(string msg)
        {
            string emptyString = "Status: " + msg;
            File.WriteAllText(path, emptyString);
        }
    }
}