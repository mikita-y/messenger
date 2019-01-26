using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace messenger.Models
{
    public delegate void Del();

    public class FileSupport
    {
        public static List<string> Read()
        {
            string readPath = @"D:\0.project\storage\ID.txt";
            StreamReader sr = new StreamReader(readPath);
            List<string> text = new List<string>();
            while (!sr.EndOfStream)
            {
                text.Add(sr.ReadLine());
            }
            sr.Close();
            return text;
        }

        public static void Writing(User user, string mess)
        {
            string writePath = @"D:\0.project\storage\ID.txt";
            string text = DateTime.Now.ToString("t") + " " + user.Name + ": " + mess;
            StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default);
            sw.WriteLine(text);
            sw.Close();
        }
    }
}

    