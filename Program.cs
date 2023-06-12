using System;
using System.ComponentModel.Design;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Домашнее_задание__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            string slovo = " ";
            while (true)
            {
                Console.WriteLine("Введите число от 1 до 6");
                string chislo = Console.ReadLine();
                if ((chislo == "1") || (chislo == "2") || (chislo == "3") || (chislo == "4") || (chislo == "5") || (chislo == "6"))
                {
                    n = int.Parse(chislo);
                    break;
                }
            }

            string naimenovanie = "";
            do
            {
                Console.WriteLine("Введите произвольный текст");
                naimenovanie = Console.ReadLine();
            }
            while (naimenovanie.Length == 0);
            {
                slovo = naimenovanie;
            }

            string DefaultBorders = "";

            for (; n + naimenovanie.Length + n > DefaultBorders.Length; DefaultBorders = DefaultBorders + "+") ;
            {

            }
            Console.WriteLine(DefaultBorders); // выставление границы "++++++++"


            var DefaultSpace = " ";

            if (DefaultBorders.Length != 3) // определение длины "+                 +"
            {
                do
                {
                    DefaultSpace = DefaultSpace + " ";
                }
                while (DefaultSpace.Length < DefaultBorders.Length - 2);
                {

                }
            }
            else
                DefaultSpace = " ";


            int DefaultValue = 0;

            do
            {
                int srednee = DefaultBorders.Length / 2; // вычисляем среднее, чтобы ввести в него произвольный текст
                if (srednee == DefaultValue)
                {
                    do
                    {
                        if (naimenovanie.Length < DefaultBorders.Length - 2)
                        {
                            naimenovanie = naimenovanie + " ";
                        }
                        if (naimenovanie.Length < DefaultBorders.Length - 2)
                        {
                            naimenovanie = " " + naimenovanie;
                        }
                    }
                    while (naimenovanie.Length < DefaultBorders.Length - 2);
                    {
                        naimenovanie = "+" + naimenovanie + "+";
                        Console.WriteLine(naimenovanie);
                        DefaultValue = DefaultValue + 1;
                    }
                }
                DefaultValue = DefaultValue + 1;
                Console.WriteLine("+" + DefaultSpace + "+");
            }

            while (DefaultBorders.Length > DefaultValue); // выставление границы "+                +"
            {

            }
            Console.WriteLine(DefaultBorders); // выставление границы "++++++++"



            string chess = "+";
            string chess1 = " ";

            if (chess.Length < DefaultBorders.Length - 2) // шахматный порядок
            {
                do
                {
                    chess = chess + " ";
                    if (chess.Length < DefaultBorders.Length - 2)
                    {
                        chess = chess + "+";
                    }
                }
                while (chess.Length < DefaultBorders.Length - 2);
                {

                }
            }

            if (chess1.Length < DefaultBorders.Length - 2) // шахматный порядок
            {
                do
                {
                    chess1 = chess1 + "+";
                    if (chess1.Length < DefaultBorders.Length - 2)
                    {
                        chess1 = chess1 + " ";
                    }
                }
                while (chess1.Length < DefaultBorders.Length - 2);
                {

                }
            }


            int DefaultValueChess = 0; // выведение шахматного порядка

            do
            {
                DefaultValueChess = DefaultValueChess + 2;
                Console.WriteLine("+" + chess + "+");
                Console.WriteLine("+" + chess1 + "+");

            }
            while (DefaultBorders.Length > DefaultValueChess);
            {

            }
            Console.WriteLine(DefaultBorders);


            int otstup = 0;
            string DefaultY = "+";
            string DefaultX = "+";
            string Rasstoyanie1 = "";
            string Rasstoyanie2 = "";
            string Rasstoyanie3 = "";
            int shet = 0;
            int seredina = DefaultBorders.Length / 2;
            string peredacna = "";

            do
            {
                if (n == 1 && slovo.Length == 1)
                {
                    break;
                }

                do
                {
                    if (DefaultBorders.Length - 3 < Rasstoyanie1.Length + DefaultX.Length + shet)
                    {
                    }

                    else if (DefaultBorders.Length - 3 > Rasstoyanie1.Length + DefaultX.Length + shet) // вычисляем расстояние 1
                    {
                        Rasstoyanie1 = Rasstoyanie1 + " ";
                    }
                }

                while (DefaultBorders.Length - 3 > Rasstoyanie1.Length + DefaultX.Length + shet); // вычисляем отступ между +
                {
                    shet = shet + 1;
                }


                do
                {
                    if (DefaultBorders.Length - 3 < Rasstoyanie1.Length + DefaultX.Length + Rasstoyanie2.Length)
                    {

                    }
                    else if (DefaultBorders.Length - 3 > Rasstoyanie1.Length + DefaultX.Length + Rasstoyanie2.Length) // вычисляем расстояние 1
                    {
                        Rasstoyanie2 = Rasstoyanie2 + " ";
                    }
                }
                while (DefaultBorders.Length - 3 > Rasstoyanie1.Length + DefaultX.Length + Rasstoyanie2.Length);
                {

                }


                Console.WriteLine("+" + DefaultX + Rasstoyanie1 + "+" + Rasstoyanie2 + "+");


                DefaultX = " " + DefaultX;
                Rasstoyanie1 = "";
                Rasstoyanie2 = "";
                do
                {
                    peredacna = peredacna + " ";
                }
                while (peredacna.Length < Rasstoyanie2.Length);
                {

                }


            }



            while (shet < seredina - 1);
            {
                int shet1 = 0;
                DefaultX = "+";
                int BAZA = 0;



                do
                {
                    if (n == 1 && slovo.Length == 1)
                    {
                        Console.WriteLine("+" + " " + "+");
                        Console.WriteLine("+" + " " + "+");
                        Console.WriteLine("+" + " " + "+");
                        break;
                    }

                    if (slovo.Length % 2 == 0)

                    {

                        do
                        {
                            if (peredacna.Length > Rasstoyanie1.Length + shet1 + 1)
                            {
                                Rasstoyanie1 = Rasstoyanie1 + " ";
                            }
                            else
                            {

                            }
                        }
                        while (peredacna.Length > Rasstoyanie1.Length + shet1 + 1);
                        {

                        }

                        do
                        {
                            if (peredacna.Length - Rasstoyanie1.Length + BAZA > Rasstoyanie2.Length + 1)
                            {
                                Rasstoyanie2 = Rasstoyanie2 + " ";
                            }
                            else
                            {

                            }
                        }
                        while (peredacna.Length - Rasstoyanie1.Length + BAZA > Rasstoyanie2.Length + 1);
                        {
                            BAZA = BAZA + 1;
                        }

                        do
                        {
                            if (DefaultBorders.Length - 4 > Rasstoyanie1.Length + Rasstoyanie2.Length + Rasstoyanie3.Length)
                            {
                                Rasstoyanie3 = Rasstoyanie3 + " ";
                            }
                            else
                            {

                            }

                        }
                        while (DefaultBorders.Length - 4 > Rasstoyanie1.Length + Rasstoyanie2.Length + Rasstoyanie3.Length);


                        Console.WriteLine("+" + Rasstoyanie1 + "+" + Rasstoyanie2 + "+" + Rasstoyanie3 + "+");
                        Rasstoyanie1 = "";
                        Rasstoyanie2 = "";
                        Rasstoyanie3 = "";
                        shet1 = shet1 + 1;
                        shet = shet + 1;

                    }

                    else // проверяю на нечетные числа!!!!!!!!!!!

                    {
                        do
                        {

                            if (peredacna.Length > Rasstoyanie1.Length + shet1)
                            {
                                Rasstoyanie1 = Rasstoyanie1 + " ";
                            }
                            else
                            {

                            }
                        }
                        while (peredacna.Length > Rasstoyanie1.Length + shet1);
                        {

                        }

                        do
                        {
                            if (peredacna.Length - Rasstoyanie1.Length + BAZA > Rasstoyanie2.Length + 1)
                            {
                                Rasstoyanie2 = Rasstoyanie2 + " ";
                            }
                            else
                            {

                            }
                        }
                        while (peredacna.Length - Rasstoyanie1.Length + BAZA > Rasstoyanie2.Length + 1);
                        {
                            BAZA = BAZA + 1;
                        }

                        do
                        {
                            if (DefaultBorders.Length - 4 > Rasstoyanie1.Length + Rasstoyanie2.Length + Rasstoyanie3.Length)
                            {
                                Rasstoyanie3 = Rasstoyanie3 + " ";
                            }
                            else
                            {

                            }

                        }
                        while (DefaultBorders.Length - 4 > Rasstoyanie1.Length + Rasstoyanie2.Length + Rasstoyanie3.Length);


                        if (shet1 == 0)
                        {
                            Console.WriteLine("+" + Rasstoyanie1 + "+" + Rasstoyanie2 + " " + Rasstoyanie3 + "+");
                        }
                        else
                        {
                            Console.WriteLine("+" + Rasstoyanie1 + "+" + Rasstoyanie2 + "+" + Rasstoyanie3 + "+");
                        }

                        Rasstoyanie1 = "";
                        Rasstoyanie2 = "";
                        Rasstoyanie3 = "";
                        shet1 = shet1 + 1;
                        shet = shet + 1;
                    }

                }

                while (shet < DefaultBorders.Length - 2);
                {
                    Console.WriteLine(DefaultBorders);
                }
            }


        }
    }
}