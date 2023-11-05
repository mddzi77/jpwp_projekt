using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeggieSandwich.Scripts.Core;

namespace VeggieSandwich.Scripts
{
    public class Vegetable : PictureBox, IGameObject
    {
        public int FallSpeed = 3;
        public BoostType Type;
        public int Strength;

        public event Action<Vegetable> OnReturnToPool;

        private Random _random = new();

        public void Update(object sender, EventArgs e)
        {
            if (!Enabled) return;
            var location = Location;
            location.Y += FallSpeed;
            Location = location;

            if (location.Y >= Parent.Height)
            {
                OnReturnToPool?.Invoke(this);
                Enabled = false;
            }
        }

        /// <summary>
        /// Set object image and vegetable params
        /// </summary>
        public void Initialize()
        {
            Enabled = true;
            var id = _random.Next(0, VegetablesConfigs.Configs.Count);
            var config = VegetablesConfigs.Configs[id];
            Image = config.Image;
            Type = config.Type;
            Strength = config.Strength;

            Name = $"vegetable{id}";
            Size = new Size(105, 105);
            SizeMode = PictureBoxSizeMode.StretchImage;
            TabStop = true;
        }
    }
}
