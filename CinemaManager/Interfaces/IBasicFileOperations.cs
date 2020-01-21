using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManager
{
    interface IBasicFileOperations<T>
    {
        string FileName { get; set; }

        List<T> ReadFromFile();
        void WriteToFile(T obj);
    }
}
