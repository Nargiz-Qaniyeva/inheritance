 using System;
 using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //2.instance
            //2.(intro)-yaratdigimiz obyektlere instance deyirik. yeni product type-den bir product cixaracaq
            //type-i product oldugu ucun onunla yaziriq
            Product computer = new Product();
            //computerin bizde name, costprice, saledprice-i oldugu ucun, onlari yazdiririq
            computer.name = "Acer";     // stringi set elemesem null - bosluq verecek
            computer.costPrice = 1500; //deyerleri elave elemesek avt. 0 verecek.cunki classda int default deyeri 0-di
            computer.saledPrice = 2000;
            Console.WriteLine(computer .costPrice  );
            computer.common();    //39cu setiri oxutdu  


            Book publication = new Book();
            publication.name = "Robin Hood";
            publication.costPrice = 5;
            publication.saledPrice = 9;
            publication.authorName = "J.Walker";
            publication.pageCount = 217;
            publication.discountPercent = 5;
            Console.WriteLine(publication .authorName);



        }
       

    }

    class Product   //product artiq bir tipdir. classin type-i
    {
        internal string name;
        internal int costPrice;
        internal int saledPrice;

        internal void common()
        {
           // throw new NotImplementedException();
        }
    }

}
