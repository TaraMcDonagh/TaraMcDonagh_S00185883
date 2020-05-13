using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaraMcDonagh_S00185883
{
    //Create a class called Phone with properties Name, Price,
    //Operating System, OS_Image and Phone_Image.  
    //These are all strings apart from price. (10 marks)
    public class Phone
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }

        //Add a method called IncreasePrice which takes a percentage value 
        //and increases the price of a phone by that percentage. (10 marks)
        public double IncreasePrice()
        {
            double percentage;
            double IncreasePrice = (Price*percentage) + Price;

            return IncreasePrice;
        }

    }
}
