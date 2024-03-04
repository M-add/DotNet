using System;
using System.IO;
using System.Text;

namespace File_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set the File Path where you want to Create the File in your Disk
            string FilePath = @"E:\Madhan 23\file.txt";

            string data;

            FileStream fileStream = new FileStream(FilePath, FileMode.Open , FileAccess.Read);

            using (StreamReader read = new StreamReader(fileStream))
            {
                data = read.ReadToEnd();
            }

            Console.WriteLine(data);
                // byte[] txt = Encoding.Default.GetBytes("One Piece is real!!");

                //fileStream.Write(txt, 0, txt.Length);

                fileStream.Close();
            //Console.Write("File has been created and the Path is E:\Madhan 23\file.txt");
            Console.ReadKey();
        }
    }
}
