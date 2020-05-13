using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaraMcDonagh_S00185883;
namespace DatabaseMangement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use the code below to create the objects, image files are provided on Moodle (20 marks)
            PhoneData db = new PhoneData();
            using (db)
            {
                Phone p1 = new Phone()
                {
                    ID=1,
                    Name = "Samsung S20",
                    Price = 500,
                    OperatingSystem = "Android",
                    OS_Image = "/images/android.png",
                    Phone_Image = "/images/s20.jpg"
                };
                Phone p2 = new Phone()
                {
                    ID=1,
                    Name = "iPhone 11",
                    Price = 600,
                    OperatingSystem = "IOS",
                    OS_Image = "/images/apple.png",
                    Phone_Image = "/images/iphone11.png"
                };
                db.PhoneDetails.Add(p1);
                db.PhoneDetails.Add(p2);
                Console.WriteLine("Added");
                db.SaveChanges();


            }
        }
    }
}
