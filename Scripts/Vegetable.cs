using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeggieSandwich.Scripts.Core;

namespace VeggieSandwich.Scripts
{
    public class Vegetable :  IGameObject
    {
        public BoostType Type;
        public int Strength;

        public Panel PanelComponenet => _panel;

        private Panel _panel;

        public Vegetable(Panel panel)
        {
            _panel = panel;
        }

        public void Update(object sender, EventArgs e)
        {
            
        }
    }
}
