using GiftLibrary;
using LB5._2.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB5._2.Helper
{
    internal static class EnumHelper
    {
        public static Dictionary<string, ChocolateKind> ChocolateDict = new Dictionary<string, ChocolateKind>()
        {
            { ChocolateKind.БЕЛЫЙ.ToString(), ChocolateKind.БЕЛЫЙ },
            { ChocolateKind.ГОРЬКИЙ.ToString(), ChocolateKind.ГОРЬКИЙ },
            { ChocolateKind.МОЛОЧНЫЙ.ToString(), ChocolateKind.МОЛОЧНЫЙ },
            { ChocolateKind.ТЕМНЫЙ.ToString(), ChocolateKind.ТЕМНЫЙ },
        };

        public static Dictionary<string, CandyShape> ShapeDict = new Dictionary<string, CandyShape>()
        {
            { CandyShape.ДРУГАЯ.ToString(), CandyShape.ДРУГАЯ },
            { CandyShape.КРУГЛАЯ.ToString(), CandyShape.КРУГЛАЯ },
            { CandyShape.ПРЯМОУГОЛЬНАЯ.ToString(), CandyShape.ПРЯМОУГОЛЬНАЯ },
            { CandyShape.КВАДРАТНАЯ.ToString(), CandyShape.КВАДРАТНАЯ },
        };

        public static Dictionary<string, Shell> ShellDict = new Dictionary<string, Shell>()
        {
            { Shell.ВОЗДУШНЫЙ_РИС.ToString(), Shell.ВОЗДУШНЫЙ_РИС },
            { Shell.ГЛАЗУРЬ_ВАНИЛЬНАЯ.ToString(), Shell.ГЛАЗУРЬ_ВАНИЛЬНАЯ },
            { Shell.ГЛАЗУРЬ_ШОКОЛАДНАЯ.ToString(), Shell.ГЛАЗУРЬ_ШОКОЛАДНАЯ },
            { Shell.КАРАМЕЛЬ.ToString(), Shell.КАРАМЕЛЬ },
            { Shell.КИСЛАЯ_ПОСЫПКА.ToString(), Shell.КИСЛАЯ_ПОСЫПКА },
            { Shell.САХАРНАЯ.ToString(), Shell.САХАРНАЯ }
        };

        public static Dictionary<string, CaramelKind> CaramelKindDict = new Dictionary<string, CaramelKind>()
        {
            { CaramelKind.ЖЕВАТЕЛЬНАЯ.ToString(), CaramelKind.ЖЕВАТЕЛЬНАЯ },
            { CaramelKind.ЛЕДЕНЕЦ.ToString(), CaramelKind.ЛЕДЕНЕЦ },
            { CaramelKind.ТВЕРДАЯ.ToString(), CaramelKind.ТВЕРДАЯ }
        };

        public static Dictionary<string, Taste> TasteDict = new Dictionary<string, Taste>()
        {
            { Taste.ГОРЬКИЙ.ToString(), Taste.ГОРЬКИЙ },
            { Taste.КИСЛЫЙ.ToString(), Taste.КИСЛЫЙ },
            { Taste.ОСТРЫЙ.ToString(), Taste.ОСТРЫЙ },
            { Taste.СЛАДКИЙ.ToString(), Taste.СЛАДКИЙ },
            { Taste.СОЛЕНЫЙ.ToString(), Taste.СОЛЕНЫЙ }
        };

        public static Dictionary<string, Consistency> ConsistencyDict = new Dictionary<string, Consistency>()
        {
            { Consistency.ЖЕЛЕ.ToString(), Consistency.ЖЕЛЕ },
            { Consistency.МАРМЕЛАД.ToString(), Consistency.МАРМЕЛАД }
        };

        public static Dictionary<string, Package> PackageDict = new Dictionary<string, Package>()
        {
            {"Коробка" , new Box() },
            {"Банка" , new Can() },
            {"Пакет" , new Pack() },
        };

        public static Dictionary<string, Size> SizeDict = new Dictionary<string, Size>()
        {
            { Size.БОЛЬШАЯ.ToString(), Size.БОЛЬШАЯ },
            { Size.СРЕДНЯЯ.ToString(), Size.СРЕДНЯЯ },
            { Size.МАЛЕНЬКАЯ.ToString(), Size.МАЛЕНЬКАЯ }
        };

        public static Dictionary<string, Color> ColorDict = new Dictionary<string, Color>()
        {
            { Color.ЗОЛОТОЙ.ToString(), Color.ЗОЛОТОЙ },
            { Color.КРАСНЫЙ.ToString(), Color.КРАСНЫЙ },
            { Color.СЕРЕБРЯНЫЙ.ToString(), Color.СЕРЕБРЯНЫЙ },
            { Color.СИНИЙ.ToString(), Color.СИНИЙ }
        };

        public static Dictionary<string, bool> RemovableLidDict = new Dictionary<string, bool>()
        {
            { "TRUE", true },
            { "FALSE" , false }
        };

        public static Dictionary<string, SnapKind> SnapDict = new Dictionary<string, SnapKind>()
        {
            { SnapKind.ЗАМОК.ToString(), SnapKind.ЗАМОК },
            { SnapKind.ЗАЩЕЛКА.ToString(), SnapKind.ЗАЩЕЛКА },
            { SnapKind.КРЫШКА.ToString(), SnapKind.КРЫШКА }
        };

        public static Dictionary<string, Tape> TapeDict = new Dictionary<string, Tape>()
        {
            { Tape.АТЛАСНАЯ.ToString(), Tape.АТЛАСНАЯ },
            { Tape.ДЕКОРАТИВНАЯ_ЛЕНТА.ToString(), Tape.ДЕКОРАТИВНАЯ_ЛЕНТА },
            { Tape.ПЛАСТИКОВАЯ.ToString(), Tape.ПЛАСТИКОВАЯ },
            { Tape.ШНУРОК.ToString(), Tape.ШНУРОК },
        };

        public static Dictionary<string, IFactory> SweetnessDict = new Dictionary<string, IFactory>()
        {
            { "Карамель", new CaramelFactory() },
            { "Нуга", new NougatFactory() },
            { "Желе", new JellyFactory() },
            { "Шоколадная конфета", new ChocolateCandyFactory() },
            { "Шоколадка", new ChocolateFactory() }
        };
    }
}
