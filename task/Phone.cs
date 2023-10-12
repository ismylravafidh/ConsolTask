using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ShowInfo() - mehsul infosunu consola yazdiran metod.
namespace ConsoleApp2
{
    internal class Phone
    {
        private int _id;
        private string _name;
        private string _brandname;
        private double _price;
        private int _count;
        public int Id 
        {
            get
            {
                return _id;
            }
            set
            {
                if (value > 0)
                {
                    _id = value;
                }
            } 
        }
        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 1)
                {
                    _name = value;
                }
            }
        }
        public string BrandName 
        {
            get
            {
                return _brandname;
            }
            set
            {
                if(value.Length > 2)
                {
                    _brandname = value;
                }
            }
        }
        public double Price 
        {
            get
            {
                return _price;
            }
            set
            {
                if(value > 0)
                {
                    _price = value;
                }
            }
        }
        public int Count 
        {
            get
            {
                return _count;
            }
            set
            {
                if (value > 0)
                {
                    _count = value;
                }
            }
        }
        public Phone(int id , string name , string brandName , double price , int count )
        {
            Id = id;
            Name = name;
            BrandName = brandName;
            Price = price;
            Count = count;
        }
        public void ShowInfo()
        {
            Console.WriteLine("ID <--> " + Id);
            Console.WriteLine("Name Phone <--> " + Name);
            Console.WriteLine("Brand Name Phone <--> "+ BrandName);
            Console.WriteLine("Price Phone <--> " + Price);
            Console.WriteLine("Phone Count <--> " + Count);
        }
    }
}
