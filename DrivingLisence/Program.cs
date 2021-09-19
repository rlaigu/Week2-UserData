using System;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            //programm arvutab kasutaja vanuse;
            //kui kasutaja on noorem kui 18, siis programm kuvab konsoolis;
            //"Oled liiga noor, et juhiluba saada.";
            //kui kasutaja on vanem kui 18, siis programm kuvab konsoolis;
            //"Oled piisavalt vana, et juhiluba saada.";
            //kui kasutaja on 18, siis programm kuvab konsoolis
            //"Palju õnne! Nüüd sa saad juhiluba taotleda.";

            Console.WriteLine("Palun, sisesta oma sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - yearOfBirth;

            if (userAge < 18) 
            {
                Console.WriteLine("Oled liiga noor, et juhiluba saada.");
            }

            else if (userAge > 18) 
            {
                Console.WriteLine("Oled piisavalt vana, et juhiluba saada.");
            }

            // 2003.aastal sündinud
            else 
            {
                Console.WriteLine("Palju õnne! Nüüd sa saad juhiluba taotleda.");
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
