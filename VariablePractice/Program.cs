﻿using System;

namespace VariablesTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int ourNumber;
            ourNumber = 0;
            Console.WriteLine(ourNumber);
            
            ourNumber = 10;
            Console.WriteLine(ourNumber);

            ourNumber = 2 + 2;
            Console.WriteLine(ourNumber);

            double decimalNumber;
            decimalNumber = 10.15;
            Console.WriteLine(decimalNumber);
            
            int number = 5;
            Console.WriteLine(number);

            char myCharacter = 'c';
            Console.WriteLine(myCharacter);

            string myName = "Joshua";
            Console.WriteLine(myName);
            
            int newVariable = ourNumber - number;
            Console.WriteLine(newVariable);

            Boolean temp = true;
            Console.WriteLine(temp);
        }
    }
}
