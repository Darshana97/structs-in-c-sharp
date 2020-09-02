using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @struct
{

    struct Customer
    {
        private int _id;
        private string _name;

        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        public string Name { get => _name; set => _name = value; }

        public Customer(int Id,string Name)
        {
            this._id = Id;
            this._name = Name;

        }

        public void PrintDetails()
        {
            Console.WriteLine("My name is {0} and my id is {1}", this._name, this._id);
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            C1.Id = 100;
            C1.Name = "Achi";

            Customer C2 = new Customer(200,"Darshana");
            C1.PrintDetails();
            C2.PrintDetails();

            Console.ReadLine();


        }
    }
}
