using GiftLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛБ4
{
    class Program
    {
        static void Main(string[] args)
        {
            //var cho1 = new Chocolate();
            //cho1.ChocolateKind = ChocolateKind.ТЕМНЫЙ;
            //cho1.SelfWeight = 200;
            //cho1.Name = "Миндаль и Кокос";
            //var candy1 = new ChocolateCandy();
            //candy1.Shape = CandyShape.КРУГЛАЯ;
            //candy1.Name = "Аленка";
            //candy1.CompanyName = "Красный октябрь";
            //candy1.SelfWeight = 50;
            //candy1.Filling = new Filling();
            //candy1.Filling.Kind = "Кислая";
            //candy1.FilingWeight = 10;
            //Console.WriteLine(candy1.CalcWeight());
            //var box = new Box();
            //box.Color = Color.КРАСНЫЙ;
            //box.Size = Size.СРЕДНЯЯ;
            //box.RemovableLid = true;
            //var gift1 = new Gift();
            //gift1.Package = box;
            //gift1.Sweets.Add(cho1, 1);
            //gift1.Sweets.Add(candy1,5);
            //Console.WriteLine(gift1.CalcWeight());
            //var c = gift1.Sweets[cho1];
            //Console.WriteLine(c);
            //var j = new Jelly();
            //j.SelfWeight = 30;
            //gift1.Sweets.Add(j, 10);
            //gift1.ShowSweets();
            var bilder = new GiftBuilder();
            var gift = bilder.CreateGift(7);
            var printer = new Printer();
            printer.Print(gift);
            //var printer2 = new GiftPrinter();
            //printer2.ConsolePrint(gift);
            Console.WriteLine(gift.CalcWeight());

            Console.ReadKey(); 
        }
    }
}
