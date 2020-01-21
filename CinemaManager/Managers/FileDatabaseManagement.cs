using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManager
{
    abstract class FileDatabaseManagement<T> : IBasicFileOperations<T>
    {
        public string FileName { get; set; }
        protected FileStream FileStream { get; set; }
        protected List<T> DBObjects { get; private set; }

        public FileDatabaseManagement(string fileName)
        {
            FileName = fileName;
            DBObjects = ReadFromFile();
        }
       
        public  List<T> ReadFromFile()
        {
            FileStream = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(FileStream);
            List<T> dbObjects = new List<T>();
            string singleLine;

            while (!reader.EndOfStream && (singleLine = reader.ReadLine()) != "")
            {
                string[] lineMembers = singleLine.Split(new char[] { ' ' });
                T obj = ReadSingleTxtLineToDbObj(lineMembers);
                dbObjects.Add(obj);
            }

            reader.Close();
            FileStream.Close();
            DBObjects = dbObjects;
            return dbObjects;
        }

        public void WriteToFile(T obj)
        {           
            int id = DBObjects.Count + 1;
            DBObjects.Add(obj);
            FileStream = new FileStream(FileName, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(FileStream);

            string newObjToFile = id + ". " + obj.ToString();

            writer.WriteLine(newObjToFile);
            writer.Close();
            FileStream.Close();
        }

        public void DeleteObj(int index)
        {
            DBObjects.RemoveAt(index-1);
            UpdateDbFile();
        }

        public void DeleteObj(T item)
        {
            DBObjects.Remove(item);
            UpdateDbFile();
        }

        private void UpdateDbFile()
        {
            List<T> TObjects = new List<T>();
            foreach(T obj in DBObjects)
            {
                TObjects.Add(obj);
            }
            
            DBObjects.Clear();
            FileStream = new FileStream(FileName, FileMode.Create);
            FileStream.Close();
            foreach (T obj in TObjects)
            {
                WriteToFile(obj);
            }                  
        }

        public virtual void EditDbObject(int index, T newObj)
        {           
            DeleteObj(index);
            DBObjects.Insert(index-1, newObj);
            UpdateDbFile();
        }
        protected abstract T ReadSingleTxtLineToDbObj(string[] singleLineMembers);
    }
}
