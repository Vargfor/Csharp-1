using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.IO;

namespace Project1 { 
    class Test1
    {
        static void Main(string[] args)
        {
            string genderA = "Man";
            string genderB = "Woman";

            Console.WriteLine("Input age;");
            string age = Console.ReadLine();
            Console.WriteLine("There where once a " + genderA + " and a " + genderB + " They where both " + age + " years old");
            
        }
    }
}