using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop2
{
    class Service
    {
        static int cur_max_id = 0;

        int id;
        public string name;
        public int price;

        public Service(string _name,int _price)
        {
            id = cur_max_id;
            cur_max_id++;
            name = _name;
            price = _price;
        }

        public void print()
        {
            Console.WriteLine("Услуга № " + id + ":");
            Console.WriteLine("Название - "+ name);
            Console.WriteLine("Цена - " + price);
            Console.WriteLine("_______________");
        }

        public bool is_compare(Service another)
        {
            if (id == another.id && name == another.name && price == another.price)
            {
                return true;
            }
            return false;
        }
    }
}
