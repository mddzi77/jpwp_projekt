using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeggieSandwich.Properties;

namespace VeggieSandwich.Scripts
{
    public static class VegetablesConfigs
    {
        public static Dictionary<Image, Boost> Configs = new Dictionary<Image, Boost>()
        {
            { Resources.corn, new Boost(BoostType.Memory, 2) },
            { Resources.avocado, new Boost(BoostType.Memory, 5) },
            { Resources.broccoli, new Boost(BoostType.Eyesight, 3) },
            { Resources.cucumber, new Boost(BoostType.Muscles, 4) },
            { Resources.onion, new Boost(BoostType.Eyesight, 2) }
        };
    }

    public struct Boost
    {
        public Boost(BoostType type, int strength)
        {
            Type = type;
            Strength = strength;
        }
        public BoostType Type;
        public int Strength;
    }

    public enum BoostType
    {
        Unhealthy,
        Memory,
        Muscles,
        Eyesight
    }
}
