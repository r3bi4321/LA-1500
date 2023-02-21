using System;
using System.Text;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            Console.WriteLine(myDocuments);

            string myDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            Console.WriteLine(myDesktop);

            string myPictures = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            Console.WriteLine(myPictures);






            string fileName = myPictures + @"\file.txt";

            Console.WriteLine(fileName);




            var directories = Directory.GetDirectories(myPictures);

            int i = 0;
            foreach (var directory in directories) 
            {
                Console.WriteLine(directories[i]);
                i++;
            }

            i++;

            Random rnd = new Random();
            int num = rnd.Next(0, i);

            Console.WriteLine(i);

            Console.WriteLine(num);

            num = 0;

            var directories2 = Directory.GetDirectories(directories[num]);

            int b = 0;
            foreach (var dire in directories2)
            {
                Console.WriteLine(directories2[b]);
                b++;
            }




            //Kopiert von https://www.c-sharpcorner.com/UploadFile/mahesh/create-a-text-file-in-C-Sharp/

            try
            {
                // Create a new file     
                using (FileStream fs = File.Create(fileName))
                {
                    // Add some text to file    
                    Byte[] text = new UTF8Encoding(true).GetBytes("Hello World");
                    fs.Write(text, 0, text.Length);
                }

                // Open the stream and read it back.    
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }
    }
}
