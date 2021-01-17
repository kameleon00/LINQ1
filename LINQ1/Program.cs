﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisati konzolnu aplikaciju za formiranje niza stringova koji se sastoje od naziva
            //voća.Primenom LINQ odredbi ispisati nazive voća koje počinju sa slovom „k“.

            //1) niz stringova
            string[] voce = { "maline", "kupine", "jabuke", "kruske", "kajsije", "breskve", "banane", "pomorandze", "kesten", "nektarine" };

            var rezultat = from n in voce
                           where n.StartsWith("k")
                           select n;

            Console.WriteLine("Nazivi voca koju pocinju sa k su: ");
            foreach (var v in rezultat)
                Console.WriteLine(v);
            Console.ReadLine();
        }
    }
}
