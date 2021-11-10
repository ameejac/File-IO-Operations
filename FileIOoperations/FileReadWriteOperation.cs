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
    }
}
