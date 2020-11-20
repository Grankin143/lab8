using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab8
{
    class Lek
    {
        private string mass;
        private string name;
        private double price;
        private int amount;
        public void read()
        {
            Console.WriteLine("Введите название лекарства");
            name = Console.ReadLine();
            Console.WriteLine("Введите код лекарства");
            mass = Console.ReadLine();
            do
            {
                Console.WriteLine("Введите цену лекарства");
                price = Convert.ToDouble(Console.ReadLine());
            } while (price < 0);
            do
            {
                Console.WriteLine("Введите колличество лекарства");
                amount = Convert.ToInt32(Console.ReadLine());
            } while (amount < 0);
        }
        public void init(string mass, string name, double price, int amount)
        {
            this.name = name;
            this.mass = mass;
            this.price = price;
            this.amount = amount;
        }
        public void display()
        {
            Console.WriteLine("Название товара:" + name);
            Console.WriteLine("Код лекарства:" + mass);
            Console.WriteLine("Цена лекарства:" + price);
            Console.WriteLine("Колличество:" + amount);
        }
        public int Amount
        {
            set
            {
                if (value > 0)
                {
                    amount = value;
                }
            }
            get
            {
                return amount;
            }
        }
        public double Price
        {
            set
            {
                if (value > 0)
                {
                    price = value;
                }
            }
        }
        public string Mass
        {
            get
            {
                return mass;
            }
        }
    }
}