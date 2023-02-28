using System.Text;
using static System.Windows.Forms.DataFormats;

namespace schnitztestwin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string ort = "";

        string fileName = "";

        bool start = true;

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (start == true)
            {
                _start = DateTime.Now;
                timer1.Start();

                label1.Text = "Lösung";

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
                    Byte[] text = new UTF8Encoding(true).GetBytes("");
                    fs.Write(text, 0, text.Length);
                }


                fileName = myDesktop + @"\file.txt";

                //Kopiert von https://www.c-sharpcorner.com/UploadFile/mahesh/create-a-text-file-in-C-Sharp/

                try
                {
                    // Create a new file on the Desktop
                    using (FileStream fs = File.Create(fileName))
                    {
                        // Add some text to file    
                        Byte[] text = new UTF8Encoding(true).GetBytes(ordner);
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

                label4.Text = ordner;

                start = false;

            }
            else if (start == false)
            {
                

                timer1.Stop();

                File.Delete(ort);

                File.Delete(fileName);

                

                start = true;

            }




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


        private DateTime _start;

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = ort;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan duration = DateTime.Now - _start;
            label2.Text = duration.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    
}
