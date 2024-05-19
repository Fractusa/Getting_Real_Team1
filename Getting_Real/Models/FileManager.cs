using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_Real.Models
{
    public class FileManager
    {
        private string fileName;

        public string FileName
        { get { return fileName; } set { fileName = value; } }

        public void WriteToFile<T>(string fileName, List<T> listToWrite)
        {
            DataHandler handler = new();

            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (T item in listToWrite)
                {
                    string toWrite = handler.ConvertTypeToString(item);
                    sw.WriteLine(toWrite);
                }
            }
        }

        //public T ReadFromFile<T>(string fileName)
        //{




        //    return 0;
        //}
    }
}
