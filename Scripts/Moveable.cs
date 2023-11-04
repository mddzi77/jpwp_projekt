using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using VeggieSandwich.Scripts.Core;

namespace VeggieSandwich.Scripts
{
    public class Moveable : IGameObject
    {
        public float SpeedX = 10;

        public PictureBox Picture => _pictureBoxComponent;

        private Vector2 _movement = Vector2.Zero;
        private Vector2 _boundaries = Vector2.Zero;
        private PictureBox _pictureBoxComponent;

        public Moveable()
        {
            KeyHandler.OnLeftArrow += LeftMove;
            KeyHandler.OnRightArrow += RightMove;
        }

        public void Update(object sender, EventArgs e)
        {
            if (_movement == Vector2.Zero) return;
            var location = _pictureBoxComponent.Location;
            location.X += (int)_movement.X;
            location.Y += (int)_movement.Y;
            CheckBoundaries(location);
            _pictureBoxComponent.Location = location;
            _movement = Vector2.Zero;
        }

        public void AddPictureBox()
        {
            _pictureBoxComponent = new PictureBox();
        }

        public void AddPictureBox(PictureBox pictureBox)
        {
            _pictureBoxComponent = pictureBox;
        }

        public void SetBoundaries(int x, int y)
        {

        }

        private void LeftMove()
        {
            _movement.X -= SpeedX;
        }

        private void RightMove()
        {
            _movement.X += SpeedX;
        }

        private void CheckBoundaries(Point location)
        {

        }
    }
}
