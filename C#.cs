using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ordner = "";

            Random rando = new Random();
            int nummer = rando.Next(0, 3);

            Console.WriteLine(nummer);


            // Von Windows generiertr Ordner finden

            string myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string myDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string myPictures = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            string myVideos = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);

            // Zufällig einer dieser Ordner auswählen

            switch (nummer)
            {
                case 0:
                    Console.WriteLine(myDocuments);
                    ordner = myDocuments;
                    break;
                case 1:
                    Console.WriteLine(myVideos);
                    ordner = myVideos;
                    break;
                case 2:
                    Console.WriteLine(myPictures);
                    ordner = myPictures;
                    break;

                default:
                    break;
            }


            // Den ausgewählten ordner durchsuchen und alle Ordner in diesem aufschreiben

            var pfad = durchsuchen(ordner);

            int anzahlordner = 0;

            foreach (var f in pfad)
            {
                Console.WriteLine(f);
                anzahlordner++;
            }

            //Bestimmen wie viele Ordner tief das ganze geht

            nummer = rando.Next(1, 3);

            int tiefe = 0;

            string ort = "";


            //Bis zur angegebenen Tiefe zufällig einen Ordner aussuchen

            while (tiefe < nummer) 
            {
                try
                {
                    Random rnd = new Random();
                    int num = rnd.Next(0, anzahlordner);

                    
                    anzahlordner = 0;

                    if (pfad[num] != "")
                    {
                        ort = pfad[num];
                    }

                    pfad = durchsuchen(pfad[num]);

                    foreach (var f in pfad)
                    {
                        anzahlordner++;
                    }

                    tiefe++;
                }
                catch
                {
                    Console.WriteLine("geht nichtmehr tiefer");
                    tiefe++;
                }
           
            }

            
            //Im ausgesuchten Ordner ein Text file erstellen

            ort = ort + @"\testfile.txt";

            Console.WriteLine("Neues File in " + ort);

            using (FileStream fs = File.Create(ort))
            {
                // Add some text to file    
                Byte[] text = new UTF8Encoding(true).GetBytes("Hello World");
                fs.Write(text, 0, text.Length);
            }


            string fileName = myDesktop + @"\file.txt";

            //Kopiert von https://www.c-sharpcorner.com/UploadFile/mahesh/create-a-text-file-in-C-Sharp/

            try
            {
                // Create a new file on the Desktop
                using (FileStream fs = File.Create(fileName))
                {
                    // Add some text to file    
                    Byte[] text = new UTF8Encoding(true).GetBytes("Hello World");
                    fs.Write(text, 0, text.Length);
                    Console.WriteLine("A new File has been created on your Desktop");
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

            // Bis hier kopiert
            
        }
        

        // Diese Funktion sucht und schreibt dateipfade.
        static string[] durchsuchen(string ordner)
        {
            var pfad = Directory.GetDirectories(ordner);

            int i = 0;
            foreach (var directory in pfad)
            {
                Console.WriteLine(pfad[i]);
                i++;
            }

            i++;

            return pfad;
        }
    }
}
