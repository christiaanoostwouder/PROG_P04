using System;

namespace FileDirOpdracht
{
    internal class Pragram
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\oostw\OneDrive\Bureaublad\MA college\periode 4\PROG\PROG_P04");
            FileInfo[] files = dir.GetFiles();
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(files[i]);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            for (int i = 0; i < dirs.Length; i++)
            {
                Console.WriteLine(dirs[i]);
            }
        }
    }
}
