using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeggieSandwich.Scripts
{
    public interface ITrigger
    {
        string Name { get; }
        bool IsTriggered { get; }
        public event Action<ITrigger> TriggerEnter;
    }
}
