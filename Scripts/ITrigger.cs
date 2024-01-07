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
        bool IsActive { get; }
        event Action<ITrigger> TriggerEnter;
        void SetActive(bool isActive);
    }
}
