using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Linq;

namespace FileIOoperations.FileIO
{
    class FileReadWriteOperation
    {
       
        public   void  FileExist( string Path)
        {

            if (File.Exists(Path))
            {
                Console.WriteLine("file is Exist");

            }
            else
            {
                Console.WriteLine("file is not Exist");

            }
        }
        public  void ReadAllLine()
        {
            string Path = @"C:\Users\Dell\Desktop\AmeejaFolder\FileIOoperations\FileIOoperations\Sample.txt";
            string[] lines;
            lines = File.ReadAllLines(Path);
            if(lines.Length != 0)
            {
                foreach (var i in lines)
                {
                    Console.WriteLine("sentence: " + i);
                }

            }

        }
        public void ReadAllText()
        {
            try
            {
                string path = @"C:\Users\Dell\Desktop\AmeejaFolder\FileIOoperations\FileIOoperations\Sample.txt";
                string text;
                text = File.ReadAllText(path);
                if (text.Length != 0)
                {
                    Console.WriteLine("edit the file:" +"\n"+ text);
                }
                else
                {
                    Console.WriteLine("does not edit  the file");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
