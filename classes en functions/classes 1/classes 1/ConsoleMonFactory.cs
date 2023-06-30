using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_1
{
    internal class ConsoleMonFactory
    {
        internal void Load(string datafile) 
        {
            string[] lines = File.ReadAllLines(datafile);
            foreach (string line in lines)
            {

                Console.WriteLine(line);


            }
        }
    }
}
