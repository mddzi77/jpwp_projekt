using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeggieSandwich.Scripts.Core
{
    public interface IGameObject
    {
        void Update(object sender, EventArgs e);
    }
}
