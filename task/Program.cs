namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone1 = new Phone(01 , "Apple" , "Iphone 14 Pro" , 3999.99 , 20);
            Phone phone2 = new Phone(02 , "Samsung" , "Galaxy A51" , 759.59 , 38);
            Phone phone3 = new Phone(03 , "Xiaomi" , "Poco X3 Pro" , 919.90 , 23);
            Phone phone4 = new Phone(04 , "Apple" , "Iphone 15" , 4599.90 , 12);
            Phone phone5 = new Phone(05, "Xiaomi" , "Black Shark 5" , 1999.99 , 18);

            Store store = new Store();

            double min = 1000;
            double max = 3000;
            store.AddPhone(phone1);
            store.AddPhone(phone2);
            store.AddPhone(phone3);
            store.AddPhone(phone4);
            store.AddPhone(phone5);
            store.ShowPhoneForPrice(min, max);
            store.ShowAllPhone();
        }
    }
}