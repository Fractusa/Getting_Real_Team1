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
       
        public List<Vehicle> ReadFromFile2(string fileName)
        {
            List<Vehicle> vehicles = new();

            try
            {
                DataHandler handler = new();

                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] lineArray = line.Split(",");                     

                        Vehicle vehicle = new Vehicle(lineArray[0], int.Parse(lineArray[1]), lineArray[2], int.Parse(lineArray[3]), 
                            DateOnly.ParseExact(lineArray[4], "MM-dd-yyyy"), DateOnly.ParseExact(lineArray[5], "MM-dd-yyyy"));

                        vehicles.Add(vehicle);
                    }
                }
            }
            catch (Exception ex)
            {
                new Exception("Something went wrong with loading your file");
            }

            return vehicles;
        }
    }
}
