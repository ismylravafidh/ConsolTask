using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
//string Name - minimum 3 herfli olsun
//Phone[] Phones - adli propertysi olsun
namespace ConsoleApp2
{
    internal class Store
    {
        private string _name;
        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 2)
                {
                    _name = value;
                }
            }
        }
        public Phone[] Phones { get; set; }
        public Store()
        {
            Phones = new Phone[0];
        }

        public void AddPhone(Phone phone)
        {
            Phone[] newPhones = new Phone[Phones.Length+1];
            for(int i = 0; i < Phones.Length; i++)
            {
                newPhones[i] = Phones[i];
            }
            newPhones[newPhones.Length-1] = phone;
            Phones = newPhones;
        }
        public void ShowAllPhone()
        {
            foreach(var phone in Phones)
            {
                Console.WriteLine($"{phone.Name} {phone.BrandName} {phone.Price} {phone.Count}");
            }
        }
        
        public void ShowPhoneForPrice(double min , double max)
        {
            for(int i=0;  i<Phones.Length; i++)
            {
                if (Phones[i].Price>= min && Phones[i].Price <= max)
                {

                    Console.WriteLine($"{Phones[i].Name} {Phones[i].BrandName} {Phones[i].Price} {Phones[i].Count}");
                }
            }
        }
    }
}
