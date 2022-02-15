using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Ole kena ja sisesta oma sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - yearOfBirth

            Console.WriteLine("Oled " + userAge + " aastat vana.");

        }
    }
