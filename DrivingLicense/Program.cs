using System;

namespace DrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun, sisesta oma sünniaasta;");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2022 - yearOfBirth;

            Console.WriteLine($"Selge, oled järelikult {userAge} aastat vana.");


            if (userAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube taotlema asuda.");
            }
            else if (userAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhilube taodelda");
            }
            else
            {
                Console.WriteLine("Palju õnne! Nüüd saad taotlema asuda!*");
            }

            
        }
    }
}
