using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Apteka[] apteka1 = new Apteka[10];
            Lek[] lek1 = new Lek[10];
            int numOfMeds, i, k, n;
            int[] lekAmount = new int[10];
            double price;
            double[] lekPrice = new double[10];
            string number, s, mass, name, num;
            string[] s1 = new string[10], lekMass = new string[10], lekName = new string[10];
            Console.WriteLine("Использовать или read чтобы ввести данные(1 - read, 2 - init)");
            number = Console.ReadLine();
            apteka1[0] = new Apteka();
            if (number == "1")
            {
                apteka1[0].read();
            }
            else if (number == "2")
            {
                Console.WriteLine("Введите название аптеки");
                name = Console.ReadLine();
                Console.WriteLine("Введите номер аптеки");
                num = Console.ReadLine();
                numOfMeds = 0; ;
                Console.WriteLine("Добавить лекарство ? (1 - Да, 0 - Нет)");
                number = Console.ReadLine();
                while (number == "1")
                {
                    Console.WriteLine("Введите название лекарство");
                    lekName[numOfMeds] = Console.ReadLine();
                    Console.WriteLine("Введите код лекарства");
                    lekMass[numOfMeds] = Console.ReadLine();
                    do
                    {
                        Console.WriteLine("Введите цену лекарства");
                        lekPrice[numOfMeds] = Convert.ToDouble(Console.ReadLine());
                    } while (lekPrice[numOfMeds] < 0);
                    do
                    {
                        Console.WriteLine("Введите колличество лекартсва");
                        lekAmount[numOfMeds] = Convert.ToInt32(Console.ReadLine());
                    } while (lekAmount[numOfMeds] < 0);
                    numOfMeds++;
                    Console.WriteLine("Добавить лекарство ?(1 - Да, 0 - нет)");
                    number = Console.ReadLine();
                }
                apteka1[0].init(name, num, numOfMeds, lekName, lekMass, lekPrice, lekAmount);
            }
            i = 0;
            k = 1;
            number = "1";
            while (number != "10")
            {
                Console.WriteLine("Введите номер следующего действия:");
                Console.WriteLine("1 - Показать информацию о аптеки");
                Console.WriteLine("2 - Добавить новое лекарство");
                Console.WriteLine("3 - Изменить цену лекарства");
                Console.WriteLine("4 - Добавить аптеку");
                Console.WriteLine("5 - Показать все аптеки");
                Console.WriteLine("6 - Сменить аптеку");
                Console.WriteLine("7 - Сложить аптеки");
                Console.WriteLine("8 - Показать колличество лекарств");
                Console.WriteLine("9 - Изменить колличество мест для лекарств в аптеки");
                Console.WriteLine("10 - Выход");
                number = Console.ReadLine();
                if (number == "1")
                {
                    apteka1[i].display();
                }
                else if (number == "2")
                {
                    apteka1[i] = ++apteka1[i];
                }
                else if (number == "3")
                {
                    Console.WriteLine("Введите код лекарства");
                    mass = Console.ReadLine();
                    do
                    {
                        Console.WriteLine("Введите новую цену");
                        price = Convert.ToDouble(Console.ReadLine());
                    } while (price < 0);
                    apteka1[i].priceChange(mass, price);
                }
                else if (number == "4")
                {
                    apteka1[k] = new Apteka();
                    apteka1[k].read();
                    i = k;
                    k++;

                }
                else if (number == "5")
                {
                    for (n = 0; n < k; n++)
                    {
                        Console.WriteLine("Аптека:" + apteka1[n].Name);
                    }
                }
                else if (number == "6")
                {
                    Console.WriteLine("Введите название аптеки");
                    name = Console.ReadLine();
                    for (n = 0; n < k; n++)
                    {
                        if (apteka1[n].Name == name)
                        {
                            i = n;
                            n = k;
                        }
                    }
                }
                else if (number == "7")
                {
                    Console.WriteLine("Введите название аптеки");
                    name = Console.ReadLine();
                    for (n = 0; n < k; n++)
                    {
                        if (apteka1[n].Name == name)
                        {
                            apteka1[i] = apteka1[i] + apteka1[n];
                            n = k;
                        }
                    }
                }
                else if (number == "8")
                {
                    Console.WriteLine("1 - out, 0 - ref");
                    s = Console.ReadLine();
                    if (s == "1")
                    {
                        apteka1[i].getNumber(out n);
                        Console.WriteLine(n);
                    }
                    else
                    {
                        n = 1;
                        apteka1[i].getNumber1(ref n);
                        Console.WriteLine(n);
                    }
                }
                else if (number == "9")
                {
                    Console.WriteLine("Введите колличество лекарств");
                    numOfMeds = Convert.ToInt32(Console.ReadLine());
                    Apteka.maxNumOfMedsChange(numOfMeds);
                }
            }
        }
    }
}
