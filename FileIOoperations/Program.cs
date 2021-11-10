using System;
using FileIOoperations.FileIO;
namespace FileIOoperations.FileIO
{
    class Program
    {
         static void Main(string[] args)
         {

            string Path = @"C:\Users\Dell\Desktop\AmeejaFolder\FileIOoperations\FileIOoperations\Sample.txt";
            FileReadWriteOperation file = new FileReadWriteOperation();
            //uc1 file is exist or not
            file.FileExist(Path);

            //uc2 read all lines
            file.ReadAllLine();

            //uc3 read all text 
            file.ReadAllText();

          }
    }
}
