using System;
using System.Collections.Generic;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, string>() { { "message", "Hello World!" } };
            var serialized = new object[] { "message", dictionary };
            Console.WriteLine(serialized);
        }
    }
}