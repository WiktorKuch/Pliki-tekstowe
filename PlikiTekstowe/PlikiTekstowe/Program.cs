using System;

namespace PlikiTekstowe
{
    class Program
    {

        static void ScanAndAppend()
        {
            var files = Directory.GetFiles("C:/Users/Wiktro Kucharek/append/","*.txt",SearchOption.AllDirectories);
            foreach (string file in files)
            {
                File.AppendAllText(file, "All rights reserved");
            }

        }
        static void ReadFiles()
        {
            var document1 = File.ReadAllText(@"C:\Users\Wiktro Kucharek\Desktop\Tekst do c#.txt");
            var document2 = File.ReadAllLines(@"C:\Users\Wiktro Kucharek\Desktop\Tekst do c#2.txt");


            var document2String = string.Join(Environment.NewLine, document2);

            Console.WriteLine("document1");
            Console.WriteLine(document1);

            Console.WriteLine("document2");
            Console.WriteLine(document2String);
        }

        static void GenerateDocuments()
        {
            Console.WriteLine("Insert name");
            var name = Console.ReadLine();

            Console.WriteLine("Insert orderNumber");
            var orderNumber = Console.ReadLine();

            var template = File.ReadAllText(@"C:\Users\Wiktro Kucharek\Desktop\template.txt");
            var document = template.Replace("{name}", name).Replace("{orderNumber}", orderNumber).Replace("{dateTime}", DateTime.Now.ToString());

            File.WriteAllText($"C:/Users/Wiktro Kucharek/docu-{name}.txt", document);
        }


        static void Main(string[] args)
        {
            //ReadFiles(); // czyta plik txt jako jeden ciąg lub jako tablice 

            //GenerateDocuments(); // pobiera dane od użytkownika - wkleja te dane w miejsce konkretnych
                                    //"znaczników"-zastępując je/podmieniając w specjalnym szablonie
                                    //- generując nowy plik txt w wybranym folderze  na bazie szablonu w którym zostały podmienione wyrazy
            //ScanAndAppend(); //skanuje folder i podfoldery z filtrem "*.txt" - dodaje wybrany tekst na koncu każdego dokumentu
        }
        
       
    }
}