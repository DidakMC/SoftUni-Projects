﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();
            string animalType = null;

            switch (animal)
            {
                case "dog":
                    animalType = "mammal";
                        break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    animalType = "reptile";
                    break;

                default:
                    animalType = "unknown";
                    break;
            }
            Console.WriteLine(animalType);
        }
    }
}
