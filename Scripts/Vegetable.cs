using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeggieSandwich.Scripts.Core;

namespace VeggieSandwich.Scripts
{
    public class Vegetable : IGameObject
    {
        public int FallSpeed = 4;

        public enum Type { Broccoli, Corn }


        private PictureBox _pictureBoxComponent;

        public void Update(object sender, EventArgs e)
        {
            var location = _pictureBoxComponent.Location;
            location.Y -= FallSpeed;
        }

        public void SetType(Type type)
        {

        }
    }
}
