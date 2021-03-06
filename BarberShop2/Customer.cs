using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop2
{
    class Customer
    {
        static int cur_max_id =0;

        int id;
        public string name;
        public string last_name;

        public Customer(string _name, string _last_name)
        {
            id = cur_max_id;
            cur_max_id++;
            name = _name;
            last_name = _last_name;
        }

        public void print()
        {
            Console.WriteLine("Клиент № " + id + ":");
            Console.WriteLine(name + last_name);
            Console.WriteLine("_______________");
        }

        public bool is_compare(Customer another)
        {
            if(id == another.id && name == another.name && last_name == another.last_name)
            {
                return true;
            }
            return false;
        }
    }
}
