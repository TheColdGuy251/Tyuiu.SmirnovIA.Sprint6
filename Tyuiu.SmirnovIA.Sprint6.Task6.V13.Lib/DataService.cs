using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SmirnovIA.Sprint6.Task6.V13.Lib
{
    public class DataService : ISprint6Task6V13
    {
        public string CollectTextFromFile(string str, string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] word = line.Split(' ');
                    try
                    {
                        resStr += word[word.Length - 2] + " ";
                    }
                    catch
                    {

                    }
                }
            }
            return resStr;
        }
    }
}
