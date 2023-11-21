// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.InteropServices;
using System.Threading;


class Program
{
    
    static void Main(string[] args)
    {


       //List<string> sArray = new List<string>();

         int numThreads = Environment.ProcessorCount; // Käytetään käytettävissä olevien ydinten määrää
        Console.WriteLine($"Käytettävissä olevat säikeet: {numThreads}");

            // Taustaprosessi
            Thread thread = new Thread(Work);
            thread.IsBackground = true; // Asetetaan taustasäikeeksi, jotta ohjelma sulkeutuu pääsäikeen mukana
            thread.Start();
        

        for (int i = 0; i < 100000; i++)
        {
            Console.WriteLine("Pääohjelma");
            Thread.Sleep(1000);
        }



        // Anna ohjelman kuormittaa suoritinta ja muistia
        Console.WriteLine("Paina Enter sulkeaksesi ohjelma.");
        Console.ReadLine();
    }
    
    static void Work()
    {

        // Kuormita suoritinta
        while (true)
        {
            Random rnd = new();
            int random = rnd.Next(1, 100000);

            double x = 896.356 * random;
            double r = 248.7214;
            Console.WriteLine(x + r - 100.47 + x.ToString());
            Thread.Sleep(6000);
            
        }
    }
}
