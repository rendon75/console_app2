﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console_app2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            Console.ReadLine();
        }
    }
}
