using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    internal class Book: Product
    {
        //1.fields
        public string name;
        public int costPrice = 600; //default deyeri bu hissede veririk (15ci setir )
        public int saledPrice;
        public string authorName;
        public int pageCount;
        public int discountPercent;

        
        
        //constructor
        //1.ilk ise dusen methotdur
        //2.return type olmur
        //classin adi ile eynidi


        public void fullName()
        {
            Console.WriteLine("name");
        }


        public int common()     //class-in daxilindeki method
        {
            Console.WriteLine($" {costPrice } {saledPrice }");
            return costPrice;
        }
    }
}
