using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftLibrary
{
    public class GiftBuilder
    {
        private Gift _gift;
        private List<Package> _packages;
        private List<Sweetness> _sweets;

        public GiftBuilder()
        {
            CreatePackages();
            CreateSweetness();
        }

        private void CreatePackages ()
        {
            _packages = new List<Package>();

            var box = new Box();
            box.Color = Color.СИНИЙ;
            box.Size = Size.СРЕДНЯЯ;
            box.RemovableLid = true;

            var can = new Can
            {
                Color = Color.ЗОЛОТОЙ,
                Size = Size.СРЕДНЯЯ,
                SnapKind = SnapKind.КРЫШКА
            };

            var pack = new Pack
            {
                Color = Color.КРАСНЫЙ,
                Size = Size.БОЛЬШАЯ,
                Tape = Tape.АТЛАСНАЯ
            };

            _packages.Add(box);
            _packages.Add(can);
            _packages.Add(pack);
        }

        private void CreateSweetness()
        {
            _sweets = new List<Sweetness>();

            var candy = new ChocolateCandy
            {
                ChocolateKind = ChocolateKind.БЕЛЫЙ,
                Name = "Ромашка",
                Filling = new Filling
                {
                    Kind = "Орехи"
                },
                FilingWeight = 10,
                SelfWeight = 50,
                Shape = CandyShape.КВАДРАТНАЯ,
                CompanyName = "Nestle"
            };

            var candy1 = new ChocolateCandy
            {
                ChocolateKind = ChocolateKind.БЕЛЫЙ,
                Name = "Ferrero",
                Filling = new Filling
                {
                    Kind = "Нуга"
                },
                FilingWeight = 20,
                SelfWeight = 30,
                Shape = CandyShape.КРУГЛАЯ,
                CompanyName = "Красный октябрь"
            };

            var j = new Jelly
            {
                CompanyName = "Haribo",
                Consistency = Consistency.МАРМЕЛАД,
                Filling = new Filling
                {
                    Kind = "Ягодный сироп"
                },
                FilingWeight = 10,
                Name = "JellyBeans",
                SelfWeight = 30,
                Shape = CandyShape.КРУГЛАЯ,
                Shell = Shell.САХАРНАЯ,
                Taste = Taste.СЛАДКИЙ
            };

            var j1 = new Jelly
            {
                CompanyName = "Шармель",
                Consistency = Consistency.ЖЕЛЕ,
                Filling = new Filling
                {
                    Kind = "Клюква"
                },
                FilingWeight = 20,
                Name = "Ягодное желе",
                SelfWeight = 30,
                Shape = CandyShape.КВАДРАТНАЯ,
                Shell = Shell.КИСЛАЯ_ПОСЫПКА,
                Taste = Taste.КИСЛЫЙ
            };

            var k = new Caramel
            {
                CompanyName = "Sony",
                Filling = new Filling
                {
                    Kind = "Жидкая начинка"
                },
                FilingWeight = 10,
                Kind = CaramelKind.ЛЕДЕНЕЦ,
                Name = "DD",
                SelfWeight = 30,
                Shape = CandyShape.ПРЯМОУГОЛЬНАЯ,
                Taste = Taste.КИСЛЫЙ
            };

            var n = new Nougat
            {
                CompanyName = "wella",
                Name = "nugat",
                SelfWeight = 100,
                Shape = CandyShape.ПРЯМОУГОЛЬНАЯ,
                Shell = Shell.ГЛАЗУРЬ_ШОКОЛАДНАЯ
            };

            var ch1 = new Chocolate
            {
                ChocolateKind = ChocolateKind.МОЛОЧНЫЙ,
                SelfWeight = 200,
                Name = "Milka",
                CompanyName = "Milka"

            };

            _sweets.Add(candy);
            _sweets.Add(candy1);
            _sweets.Add(j);
            _sweets.Add(j1);
            _sweets.Add(k);
            _sweets.Add(n);
            _sweets.Add(ch1);
        }

        public Gift CreateGift(int count)
        {
            if (count > _sweets.Count)
                throw new Exception();

            _gift = new Gift();

            var r = new Random();

            var index = r.Next(3);

            _gift.Package = _packages[index];

            for (var i = 0; i<count; i++)
            {
                var randSweetIndex = new Random();
                var sweetIndex = r.Next(_sweets.Count);

                var CountRand = new Random();
                var countSweetness = r.Next(1, 11);

                _gift.Sweets.Add(_sweets[sweetIndex], countSweetness);

                _sweets.RemoveAt(sweetIndex);
            }

            CreateSweetness();

            return _gift;
        }

       
    }
}
