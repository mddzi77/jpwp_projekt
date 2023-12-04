using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeggieSandwich.Properties;

namespace VeggieSandwich.Scripts
{
    /// <summary>
    /// Container for vegetable configs
    /// </summary>
    public static class VegetablesConfigs
    {
        public static List<Boost> Configs = new ()
        {
            /*new Boost(Resources.corn, BoostType.Memory, 2),
            new Boost(Resources.avocado, BoostType.Memory, 5),
            new Boost(Resources.broccoli, BoostType.Eyesight, 3),
            new Boost(Resources.cucumber, BoostType.Muscles, 4),
            new Boost(Resources.onion, BoostType.Eyesight, 2)*/
        };
    }

    /// <summary>
    /// Necessary vegetable params
    /// </summary>
    public struct Boost
    {
        public Boost(Image image, BoostType type, int strength)
        {
            Image = image;
            Type = type;
            Strength = strength;
        }
        public Image Image;
        public BoostType Type;
        public int Strength;
    }

    /// <summary>
    /// Type od boost that vegetable gives
    /// </summary>
    public enum BoostType
    {
        Unhealthy,
        Memory,
        Muscles,
        Eyesight
    }
}
