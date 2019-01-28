using System;
using System.Collections.Generic;
using System.IO;

namespace messenger.Models
{

    public class FileSupport
    {
        public static List<string> Read()
        {
            string readPath = @"wwwroot\storage.txt";
            StreamReader sr = new StreamReader(readPath);
            List<string> text = new List<string>();
            while (!sr.EndOfStream)
            {
                text.Add(sr.ReadLine());
            }
            sr.Close();
            return text;
        }
        public static void Writing(string name, string mess)
        {
            string writePath = @"wwwroot\storage.txt";
            string text = DateTime.Now.ToString("M") + " " + DateTime.Now.ToString("t") + " " + name + ": " + mess;
            StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default);
            sw.WriteLine(text);
            sw.Close();
        }
    }
}