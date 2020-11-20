using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab8
{
    class Apteka
    {
        private string name;
        private string num;
        private int numOfMeds;
        private static int maxNumOfMeds = 10;
        private Lek[] lek = new Lek[10];
        public void read()
        {
            string number;
            Console.WriteLine("Введите название аптеки");
            name = Console.ReadLine();
            Console.WriteLine("Введите номер аптеки");
            num = Console.ReadLine();
            numOfMeds = 0;
            Console.WriteLine("Добавить лекарство ?(1 - Да, 2 - нет)");
            number = Console.ReadLine();
            while (number == "1" && numOfMeds < maxNumOfMeds)
            {
                lek[numOfMeds] = new Lek();
                lek[numOfMeds].read();
                numOfMeds++;
                Console.WriteLine("Добавить лекарство ?(1 - Да, 2 - Нет)");
                number = Console.ReadLine();
            }
        }
        public void init(string name, string num, int numOfMeds, string[] lekName1, string[] lekMass1, double[] lekPrice1, int[] itemAmount1)
        {
            int i;
            if (numOfMeds < Apteka.maxNumOfMeds)
            {
                this.name = name;
                this.num = num;
                this.numOfMeds = numOfMeds;
                for (i = 0; i < this.numOfMeds; i++)
                {
                    lek[i] = new Lek();
                    lek[i].init(lekMass1[i], lekName1[i], lekPrice1[i], itemAmount1[i]);
                }
            }
        }
        public void display()
        {
            int i;
            Console.WriteLine("Название аптеки:" + name);
            Console.WriteLine("Номер аптеки:" + num);
            Console.WriteLine("Колличество уникальных лекарств:" + numOfMeds);
            Console.WriteLine("Колличество мест для лекарств:" + maxNumOfMeds);
            for (i = 0; i < numOfMeds; i++)
            {
                Console.WriteLine("Лекарство: " + (i + 1));
                lek[i].display();
            }
        }
        public static Apteka operator ++(Apteka apteka)
        {
            Apteka newApteka = new Apteka();
            int n;
            if (apteka.numOfMeds < Apteka.maxNumOfMeds)
            {
                newApteka.name = apteka.name;
                newApteka.num = apteka.num;
                for (n = 0; n < apteka.numOfMeds; n++)
                {
                    newApteka.lek[n] = new Lek();
                    newApteka.lek[n] = apteka.lek[n];
                }
                newApteka.lek[apteka.numOfMeds] = new Lek();
                newApteka.lek[apteka.numOfMeds].read();
                newApteka.numOfMeds = ++apteka.numOfMeds;
                return newApteka;
            }
            else return apteka;
        }
        public void priceChange(string mass, double price)
        {
            int i = 0;
            while (i < numOfMeds)
            {
                if (lek[i].Mass == mass)
                {
                    lek[i].Price = price;
                    i = numOfMeds;
                }
                i++;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public static Apteka operator +(Apteka apteka1, Apteka apteka2)
        {
            int n, i;
            Apteka newApteka = new Apteka();
            if (apteka1.numOfMeds + apteka2.numOfMeds <= Apteka.maxNumOfMeds)
            {
                newApteka.name = apteka1.name;
                newApteka.num = apteka1.num;
                newApteka.numOfMeds = apteka1.numOfMeds + apteka2.numOfMeds;
                for (n = 0; n < apteka1.numOfMeds; n++)
                {
                    newApteka.lek[n] = apteka1.lek[n];
                }
                i = apteka1.numOfMeds;
                for (n = 0; n < apteka2.numOfMeds; n++)
                {
                    newApteka.lek[i] = apteka2.lek[n];
                    i++;
                }
                return newApteka;
            }
            else return apteka1;
        }
        public void getNumber(out int number)
        {
            number = numOfMeds;
        }
        public void getNumber1(ref int number)
        {
            number = numOfMeds;
        }
        public static void maxNumOfMedsChange(int newMax)
        {
            Apteka.maxNumOfMeds = newMax;
        }
    }
}
