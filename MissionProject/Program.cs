using System;

namespace MissionProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Age;
            string IdNumber;

            while (true)
            {
                Console.Write("Yaşınız:");
                Age = Convert.ToInt16(Console.ReadLine());

                if (Validator.AgeControl(Age))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Yaşınızı düzeltiniz!");
                }
            }

            while (true)
            {
                Console.Write("Tc Kimlik Numaranız:");
                IdNumber = Console.ReadLine();

                if (Validator.IdNumberControl(IdNumber))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Tc kimlik numaranızı düzeltiniz!");
                }
            }


            Console.Write("Deneyim Yılınız:");
            int Exp = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Kullandığınız Teknolojileri Seçiniz: (Virgül ile ayırınız.)");
            Console.WriteLine("1.C# , 2.HTML , 3.JS , 4.MSSQL , 5.ALGORITHM , 6.DATA STRUCTURE");

        }
    }
}
