using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_006
{
    class Adress
    {
        public int Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public int Apartment { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Adress adress = new Adress()
            {
                Index = 00211,
                Country = "Ukraine",
                City = "Kiev",
                Street = "Hreschatik",
                House = "7/1B",
                Apartment = 231               
            };
            Console.WriteLine($"My adress:\nIndex = {adress.Index}\nCountry = {adress.Country}\nCity = {adress.City}");
            Console.WriteLine($"Street = {adress.Street}\nHouse = {adress.House}\nApartament = {adress.Apartment}");
            
        }
    }
}
