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
        public static string OrderMsg { get; set; } = "";
        public static int Score { get; private set; } = 0;
        public static bool IsGameRunning { get; private set; } = false;

        private static Dictionary<VegetableType, string> _boosts = new()
        {
         /*{VegetableType.Broccoli, "Brokuł"},
            {VegetableType.Cabbage, "Kapusta"},
            {VegetableType.Carrot, "Marchewka"},
            {VegetableType.Celery, "Seler"},*/   
            {VegetableType.Corn, "Jest dobrym źródłem błonnika dietetycznego oraz jest bogate w przeciwutleniacze."},
            {VegetableType.Cucumber, "Zmniejsza ryzyko nowotworu, reguluje ciśnienie krwi oraz oczyszcza organizm z nadmiaru wody i toksyn."},
            {VegetableType.Eggplant, "Wspomaga prawidłowe funkcjonowanie układu krwionośnego, poprawiając sczelność i elastyczność naczyń."},
            {VegetableType.Onion, "Posiada właściwości antybakteryjne, pomaga oczyścicć drogi oddechowe."},
            {VegetableType.Radish, "Jest dobre na choroby układu pokarmowego oraz wspomaga funkcjonowanie wątroby."},
            {VegetableType.Salad, "Pomaga chronić przed zwyrodnieniem plamki żółtej, wzmacnia układ nerwowy i odkwasza."},
            {VegetableType.Tomato, "Wspomaga reakcje antynowotworowe, zmniejsza ryzyko zawału poprzez wspomaganie normaliizacji ciśnienia krwi."},
            {VegetableType.Pepper, "Poprawia trawienie, hamuje starzenie się komórek, osłabia szkodliwe działanie cholesterolu."}
        };
        private static int _orderNumber = 1;

        public static void CreateOrder()
        {
            var random = new Random();
            var orderCount = random.Next(1, 4);
            for (var i = 0; i < orderCount; i++)
            {
                var vegetable = (VegetableType)random.Next(0, 7);
                if (Order.Contains(vegetable))
                {
                    i--; continue;
                }
                Order.Add(vegetable);
            }
            OrderMsg += $"Zamówienie #{_orderNumber}\n\n";
            OrderMsg += "Zamówione jest coś co:\n";
            foreach (var vegetable in Order)
            {
                var boost = _boosts[vegetable];
                OrderMsg += $"- {boost}\n";
            }
        }

        public static void StartGame()
        {
            IsGameRunning = true;
            CreateOrder();
        }

        public static void EndGame()
        {
            IsGameRunning = false;

            OrderMsg += $"Finalizacja zamówienia #{_orderNumber}\n\n";
            List<VegetableType> success = new();
            List<VegetableType> fail = new();

            foreach (var vegetable in Order)
            {
                if (Plate.Contains(vegetable))
                {
                    success.Add(vegetable);
                    continue;
                }
                fail.Add(vegetable);
            }

            OrderMsg += $"Udane punkty zamówienia ({success.Count}/{Order.Count}):\n";
            foreach (var vegetable in success)
            {
                var boost = _boosts[vegetable];
                OrderMsg += $"- {boost}\n";
            }

            OrderMsg += $"\nNieudane punkty zamówienia ({fail.Count}/{Order.Count}):\n";
            foreach (var vegetable in fail)
            {
                var boost = _boosts[vegetable];
                OrderMsg += $"- {boost}\n";
            }

            Score += success.Count;
        }

        public static void AddToPlate()
        {
            if (InHand == VegetableType.None) return;
            Plate.Add(InHand);
            InHand = VegetableType.None;
        }

        public static void Restart()
        {
            InHand = VegetableType.None;
            Order.Clear();
            _orderNumber = 1;
            foreach (var trigger in Triggers)
            {
                trigger.SetActive(true);
            }
            CreateOrder();
        }

        public static string PL(VegetableType name)
        {
            var name_PL = name switch
            {
                /*VegetableType.Broccoli => "Brokuł",
                VegetableType.Cabbage => "Kapusta",
                VegetableType.Carrot => "Marchewka",
                VegetableType.Celery => "Seler",*/
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
        /*Broccoli,
        Cabbage,
        Carrot,
        Celery,*/
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
