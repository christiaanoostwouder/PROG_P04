using System.Xml;

namespace FileIOOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dir1 = @"leesdezefile.txt";
            string[] content = File.ReadAllLines(dir1);

            for(int i = 0; i < content.Length; i++)
            {
                Console.WriteLine(content[i]);
            }
            Directory.CreateDirectory(@"output");
            string[] text = new string[] { "test test" };
            File.WriteAllLines(@"output/mijnnieuwefile.txt", text);

           
        }
    }
}
