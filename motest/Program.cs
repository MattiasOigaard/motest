﻿using System;

namespace motest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the speed limit? ");
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the speed of the car? ");
            int carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
            {
                Console.WriteLine("OK");
            }

            else
            {

            }
        }
    }
}
