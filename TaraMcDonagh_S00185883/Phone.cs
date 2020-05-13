using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TaraMcDonagh_S00185883
{
    //Create a class called Phone with properties Name, Price,
    //Operating System, OS_Image and Phone_Image.  
    //These are all strings apart from price. (10 marks)
    public class Phone
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }

        //Add a method called IncreasePrice which takes a percentage value 
        //and increases the price of a phone by that percentage. (10 marks)
        public void IncreasePrice(int _price, double percentage)
        {
            double newPrice = (_price * percentage) + _price;
            Price = newPrice;

        }
       /* public Phone(string name, double price, string os,string osimage, string phoneimage)
        {
            Name = name;
            Price = price;
            OperatingSystem = os;
            OS_Image = osimage;
            Phone_Image = phoneimage;
        }*/
    }
        public class PhoneData:DbContext
        {
            public PhoneData() : base("My Phone Data") { }
            public DbSet<Phone> PhoneDetails { get; set; }
        }
    
}
