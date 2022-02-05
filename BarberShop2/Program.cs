using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop2
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static void print()
        {
            Console.WriteLine("Привет! Это симуляция работы БарберШопа");
            Console.WriteLine("Есть такие функции:");
            Console.WriteLine("Вывести всю информацию о БарберШопе - введите print_all");
            Console.WriteLine("Добавить клиенты - введите add_customer name last_name");
            Console.WriteLine("Добавить услугу - введите add_service name price");
            Console.WriteLine("Выйти - введите q");
        }

        public static void add_customer (string[] user_input_array)
        {
            if(user_input_array.Length < 3)
            {
                Console.WriteLine("Для добавления клиента нужны имя и фамилия");
                return;
            }
            if(BarberShop.add_customer(user_input_array[1], user_input_array[2]))
            {
                Console.WriteLine("Клиент добавлен");
            }
            else
            {
                Console.WriteLine("Клиент не добавлен");
            }
        }

        public static void add_service(string[] user_input_array)
        {
            if (user_input_array.Length < 3)
            {
                Console.WriteLine("Для добавления услуги нужны название и цена");
                return;
            }
            int price = 0;
            try
            {
                price = Convert.ToInt32(user_input_array[2]);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Цена должна быть целым числом");
                return;
            }
            if (BarberShop.add_service(user_input_array[1], price))
            {
                Console.WriteLine("Услуга добавлена");
            }
            else
            {
                Console.WriteLine("Услуга не добавлена");
            }
        }

    }
}
