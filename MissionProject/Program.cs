using System;
using System.Collections.Generic;

namespace MissionProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Applicant applicant = new Applicant();
            int Age;
            long IdNumber;
            int Exp;

            string[] techs = { "C#", "HTML", "JS", "MSSQL", "ALGORITHM", "DATA STRUCTURE" };

            while (true)
            {
                try
                {
                    Console.Write("Yaşınız:");
                    Age = Convert.ToInt16(Console.ReadLine());

                    if (Validator.AgeControl(Age))
                    {
                        applicant.Age = Age;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Yaşınızı düzeltiniz!");
                    }
                }
                catch (FormatException)
                {

                    Console.WriteLine("Geçerli değer giriniz!");
                }

            }

            while (true)
            {
                try
                {
                    Console.Write("Tc Kimlik Numaranız:");
                    IdNumber = Convert.ToInt64(Console.ReadLine());

                    if (Validator.IdNumberControl(IdNumber))
                    {
                        applicant.IdentificationNumber = IdNumber;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Tc kimlik numaranızı düzeltiniz!");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Geçerli değer giriniz!");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Deneyim Yılınız:");
                    Exp = Convert.ToInt32(Console.ReadLine());

                    if (Validator.ExpControl(Exp, applicant.Age))
                    {
                        applicant.YearsOfExperience = Exp;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Deneyim yılınızı düzeltiniz!");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Geçerli değer giriniz!");
                }
            }


            Console.WriteLine("Kullandığınız Teknolojileri Seçiniz: y / n");

            foreach (var item in techs)
            {
                while (true)
                {
                    try
                    {
                        Console.Write(string.Format("{0} kullanabilirim :", item));
                        char choose = Convert.ToChar(Console.ReadLine().ToLower());
                        if (choose.Equals('y'))
                        {
                            applicant.AvailableTech.Add(item);
                            break;
                        }
                        else if (choose.Equals('n'))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("y yada n kullanınız!");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("y yada n kullanınız!"); //birden fazla karakter girişi
                    }
                }
            }
        }
    }
}
