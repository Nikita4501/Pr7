using System;
using System.Collections.Generic;

namespace ConsoleApp_FirstApp
{
    /// <summary>Главный класс программы.</summary>
    class Program
    {
        /// <summary>Точка входа в приложение.</summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Galaxy News!");
            IterateThroughList();
            Console.ReadKey();
        }

        /// <summary>Создаёт список галактик и выводит их в консоль.</summary>
        private static void IterateThroughList()
        {
            var theGalaxies = new List<Galaxy>
        {
            new Galaxy() { Name="Tadpole", MegaLightYears=400, GalaxyType=new GType('S')},
            new Galaxy() { Name="Pinwheel", MegaLightYears=25, GalaxyType=new GType('S')},
            new Galaxy() { Name="Cartwheel", MegaLightYears=500, GalaxyType=new GType('L')},
            new Galaxy() { Name="Small Magellanic Cloud", MegaLightYears=.2, GalaxyType=new GType('I')},
            new Galaxy() { Name="Andromeda", MegaLightYears=3, GalaxyType=new GType('S')},
            new Galaxy() { Name="Maffei 1", MegaLightYears=11, GalaxyType=new GType('E')}
        };

            foreach (Galaxy theGalaxy in theGalaxies)
            {
                Console.WriteLine(theGalaxy.Name + "  " + theGalaxy.MegaLightYears + ",  " + theGalaxy.GalaxyType.MyGType);
            }

            // Expected Output:
            //  Tadpole  400,  Spiral
            //  Pinwheel  25,  Spiral
            //  Cartwheel, 500,  Lenticular
            //  Small Magellanic Cloud .2,  Irregular
            //  Andromeda  3,  Spiral
            //  Maffei 1,  11,  Elliptical
        }
    }

    /// <summary>Представляет галактику.</summary>
    public class Galaxy
    {
        /// <summary>Название галактики.</summary>
        public string Name { get; set; }

        /// <summary>Расстояние в миллионах световых лет.</summary>
        public double MegaLightYears { get; set; }

        /// <summary>Тип галактики.</summary>
        public GType GalaxyType { get; set; }
    }

    /// <summary>Тип галактики (конвертирует символ в enum).</summary>
    public class GType
    {
        /// <summary>Инициализирует тип по символу: S, E, I или L.</summary>
        /// <param name="type">Символ типа галактики.</param>
        public GType(char type)
        {
            switch (type)
            {
                case 'S':
                    MyGType = Type.Spiral;
                    break;
                case 'E':
                    MyGType = Type.Elliptical;
                    break;
                case 'I':
                    MyGType = Type.Irregular;
                    break;
                case 'L':
                    MyGType = Type.Lenticular;
                    break;
                default:
                    break;
            }
        }

        /// <summary>Название типа галактики (хранится как object).</summary>
        public object MyGType { get; set; }

        private enum Type { Spiral, Elliptical, Irregular, Lenticular }
    }
}