using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeggieSandwich.Properties;

namespace VeggieSandwich.Scripts
{
    public static class GameManager
    {
        public static VegetableType InHand { get; set; } = VegetableType.None;
        public static String InHandName => PL(InHand);
        public static List<ITrigger> Triggers { get; set; } = new();
        public static List<VegetableType> Order { get; set; } = new();
        public static List<VegetableType> Plate { get; set; } = new();

        public static void CreateOrder()
        {
            var random = new Random();
            var orderCount = random.Next(1, 4);
            for (var i = 0; i < orderCount; i++)
            {
                var vegetable = (VegetableType)random.Next(0, 12);
                Order.Add(vegetable);
            }
        }

        public static void AddToPlate()
        {
            if (InHand == VegetableType.None) return;
            Plate.Add(InHand);
            InHand = VegetableType.None;
        }

        public static void Reset()
        {
            InHand = VegetableType.None;
            Order.Clear();
            foreach (var trigger in Triggers)
            {
                trigger.SetActive(true);
            }
        }

        public static string PL(VegetableType name)
        {
            var name_PL = name switch
            {
                VegetableType.Broccoli => "Brokuł",
                VegetableType.Cabbage => "Kapusta",
                VegetableType.Carrot => "Marchewka",
                VegetableType.Celery => "Seler",
                VegetableType.Corn => "Kukurydza",
                VegetableType.Cucumber => "Ogórek",
                VegetableType.Eggplant => "Bakłażan",
                VegetableType.Onion => "Cebula",
                VegetableType.Radish => "Rzodkiewka",
                VegetableType.Salad => "Sałata",
                VegetableType.Tomato => "Pomidor",
                VegetableType.Pepper => "Papryka",
                _ => "None"
            };
            return name_PL;
        }
    }

    public enum VegetableType
    {
        Broccoli,
        Cabbage,
        Carrot,
        Celery,
        Corn,
        Cucumber,
        Eggplant,
        Onion,
        Radish,
        Salad,
        Tomato,
        Pepper,
        None
    }
}
