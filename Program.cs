using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm5
{
    class Magazine
    {
        public string Name { get; set; }
        public int NumberOfEmployee { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public Magazine()
        {
            Name = null;
            Date = DateTime.Now;
            NumberOfEmployee = 0;
            Description = null;
            ContactNumber = null;
            Email = null;
        }
        public Magazine(string name, int numberOfEmployee, DateTime date, string description, string contactNumber, string email)
        {
            Name = name;
            NumberOfEmployee = numberOfEmployee;
            Date = date;
            Description = description;
            ContactNumber = contactNumber;
            Email = email;
        }

        public void displayInfo()
        {
            Console.WriteLine($"Name magazine: {Name}");
            Console.WriteLine($"Number of employees: {NumberOfEmployee}");
            Console.WriteLine($"Date of establishment: {Date}");
            Console.WriteLine($"Description magazine: \n{Description}");
            Console.WriteLine($"Contact number: {ContactNumber}");
            Console.WriteLine($"Email adsress: {Email}");
        }

        public static Magazine operator +(Magazine mag, int numberEmp)
        {
            mag.NumberOfEmployee += numberEmp;
            return mag;
        }
        public static Magazine operator -(Magazine mag, int numberEmp)
        {
            mag.NumberOfEmployee -= numberEmp;
            return mag;
        }
        public static bool operator ==(Magazine mag1, Magazine mag2)
        {
            return (mag1.NumberOfEmployee == mag2.NumberOfEmployee);
        }
        public static bool operator !=(Magazine mag1, Magazine mag2)
        {
            return (mag1.NumberOfEmployee != mag2.NumberOfEmployee);
        }
        public static bool operator >(Magazine mag1, Magazine mag2)
        {
            return (mag1.NumberOfEmployee > mag2.NumberOfEmployee);
        }
        public static bool operator <(Magazine mag1, Magazine mag2)
        {
            return (mag1.NumberOfEmployee < mag2.NumberOfEmployee);
        }
    }

    class Shop
    {
        public string Name { get; set; }
        public int Area { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }

        public Shop()
        {
            Name = null;
            Area = 0;
            Address = null;
            Description = null;
            ContactNumber = null;
            Email = null;
        }
        public Shop(string name, int area, string address, string description, string contactNumber, string email)
        {
            Name = name;
            Area = area;
            Address = address;
            Description = description;
            ContactNumber = contactNumber;
            Email = email;
        }
        public void displayInfo()
        {
            Console.WriteLine($"Name shop: {Name}");
            Console.WriteLine($"Area shop: {Area}");
            Console.WriteLine($"Store address: {Address}");
            Console.WriteLine($"Store profile description: \n{Description}");
            Console.WriteLine($"Contact number: {ContactNumber}");
            Console.WriteLine($"Email adsress: {Email}");
        }
        public static Shop operator +(Shop shop, int increaseArea)
        {
            shop.Area += increaseArea;
            return shop;
        }
        public static Shop operator -(Shop shop, int increaseArea)
        {
            shop.Area -= increaseArea;
            return shop;
        }
        public static bool operator ==(Shop shop1, Shop shop2)
        {
            return (shop1.Area == shop2.Area);
        }
        public static bool operator !=(Shop shop1, Shop shop2)
        {
            return (shop1.Area != shop2.Area);
        }
        public static bool operator >(Shop shop1, Shop shop2)
        {
            return (shop1.Area > shop2.Area);
        }
        public static bool operator <(Shop shop1, Shop shop2)
        {
            return (shop1.Area < shop2.Area);
        }
    }
    class ReadingList
    {
        private ArrayList items;

        public ReadingList()
        {
            items = new ArrayList();
        }
        public void AddItem(object item)
        {
            items.Add(item);
        }
        public void RemoveItem(object item)
        {
            items.Remove(item);
        }
        public bool ContainsItem(object item)
        {
            return items.Contains(item);
        }
        public int Count()
        {
            return items.Count;
        }
        public object GetItem(int index)
        {
            return items[index];
        }
        public void SetItem(int index, object item)
        {
            items[index] = item;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HM_1");
            Magazine magazine1 = new Magazine();
            magazine1.Name = "TechMag";
            magazine1.NumberOfEmployee = 20;
            magazine1.Date = new DateTime(2020, 5, 15);
            magazine1.Description = "TechMag is a technology magazine covering the latest trends in software development.";
            magazine1.ContactNumber = "+123456789";
            magazine1.Email = "info@techmag.com";

            magazine1.displayInfo();

            Console.WriteLine();

            Magazine magazine2 = new Magazine("FashionMag", 15, new DateTime(2019, 10, 10), "FashionMag is a fashion magazine showcasing the latest trends in clothing and accessories.", "+987654321", "info@fashionmag.com");

            magazine2.displayInfo();

            Console.WriteLine();

            Magazine magazine3 = magazine1 + 5;
            Console.WriteLine($"After adding 5 employees to {magazine1.Name}: {magazine3.NumberOfEmployee}");

            Magazine magazine4 = magazine2 - 3;
            Console.WriteLine($"After subtracting 3 employees from {magazine2.Name}: {magazine4.NumberOfEmployee}");

            if (magazine1 == magazine2)
            {
                Console.WriteLine("The number of employees in magazine1 is equal to the number of employees in magazine2.");
            }
            else
            {
                Console.WriteLine("The number of employees in magazine1 is not equal to the number of employees in magazine2.");
            }

            if (magazine1 > magazine2)
            {
                Console.WriteLine($"The number of employees in {magazine1.Name} is greater than the number of employees in {magazine2.Name}.");
            }
            else if (magazine1 < magazine2)
            {
                Console.WriteLine($"The number of employees in {magazine1.Name} is less than the number of employees in {magazine2.Name}.");
            }



            Console.WriteLine("HM_2");
            Shop shop1 = new Shop();
            shop1.Name = "Grocery Store";
            shop1.Area = 100;
            shop1.Address = "123 Main St";
            shop1.Description = "This is a grocery store selling a variety of food items.";
            shop1.ContactNumber = "+123456789";
            shop1.Email = "info@grocerystore.com";

            shop1.displayInfo();

            Console.WriteLine();

            Shop shop2 = new Shop("Hardware Store", 80, "456 Oak St", "This is a hardware store selling tools and equipment.", "+987654321", "info@hardwarestore.com");

            shop2.displayInfo();

            Console.WriteLine();

            Shop shop3 = shop1 + 20;
            Console.WriteLine($"After increasing area by 20 sq. ft. for {shop1.Name}: {shop3.Area}");

            Shop shop4 = shop2 - 10;
            Console.WriteLine($"After decreasing area by 10 sq. ft. for {shop2.Name}: {shop4.Area}");

            if (shop1 == shop2)
            {
                Console.WriteLine("The area of shop1 is equal to the area of shop2.");
            }
            else
            {
                Console.WriteLine("The area of shop1 is not equal to the area of shop2.");
            }

            if (shop1 > shop2)
            {
                Console.WriteLine($"The area of {shop1.Name} is greater than the area of {shop2.Name}.");
            }
            else if (shop1 < shop2)
            {
                Console.WriteLine($"The area of {shop1.Name} is less than the area of {shop2.Name}.");
            }


            Console.WriteLine();

            Console.WriteLine("HM_3");
            ReadingList myReadingList = new ReadingList();

            myReadingList.AddItem("The Great Gatsby");
            myReadingList.AddItem("To Kill a Mockingbird");
            myReadingList.AddItem("1984");

            Console.WriteLine("Number of items in the reading list: " + myReadingList.Count());


            myReadingList.RemoveItem("To Kill a Mockingbird");

            Console.WriteLine("Is '1984' in the reading list? " + myReadingList.ContainsItem("1984"));

            Console.WriteLine("Number of items in the reading list: " + myReadingList.Count());

            Console.WriteLine("Items in the reading list:");
            for (int i = 0; i < myReadingList.Count(); i++)
            {
                Console.WriteLine($"- {myReadingList.GetItem(i)}");
            }

            Console.ReadKey();
        }
    }
}
