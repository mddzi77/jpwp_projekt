using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeggieSandwich.Scripts.Core;

namespace VeggieSandwich.Scripts
{
    public class Detector : IGameObject
    {
        public event Action<String> DetectedVegetable;

        private Moveable gameObject;

        public Detector(Moveable parent)
        {
            gameObject = parent;
        }

        public void Update(object sender, EventArgs e)
        {
            var position = gameObject.CenterPoint;
            var detected = gameObject.Picture.Parent.GetChildAtPoint(position);
            if (detected == null | detected.Tag == null) return;
            if (detected.Tag.Equals("vegetable"))
                DetectedVegetable?.Invoke(detected.Name);
        }
    }
}
