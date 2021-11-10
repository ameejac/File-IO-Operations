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
            file.FileExist(Path);
            file.ReadAllLine();
          }
    }
}
