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
        int Left { get; }
        int Right { get; }
        int Top { get; }
        int Bottom { get; }
        void OnVegetableTriggerEnter(ITrigger trigger);
        void OnTriggerEnter(ITrigger trigger);
    }
}
