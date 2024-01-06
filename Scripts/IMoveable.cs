using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeggieSandwich.Scripts
{
    public interface IMoveable
    {
        PictureBox Picture { get; }
        Point CenterPoint { get; }
        void OnVegetableTriggerEnter(string vegetableType);
        void OnTriggerEnter(string triggerType);
    }
}
