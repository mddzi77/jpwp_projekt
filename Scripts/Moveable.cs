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
        public float SpeedX = 6;
        public float Drag = 0.75f;

        public PictureBox Picture => _pictureBoxComponent;

        private Vector2 _movement = Vector2.Zero;
        private Vector2 _boundaries = Vector2.Zero;
        private PictureBox _pictureBoxComponent;
        private Size _size;

        private struct Size
        {
            public Size(int width, int height)
            {
                Width = width;
                Height = height;
            }
            public int Width;
            public int Height;
        }

        public Moveable()
        {
            KeyHandler.OnLeftArrow += LeftMove;
            KeyHandler.OnRightArrow += RightMove;
            _size = new Size(0, 0);
        }

        public void Update(object sender, EventArgs e)
        {
            if (_movement.Equals(Vector2.Zero)) return;
            var location = _pictureBoxComponent.Location;
            CheckBoundaries(location);
            location.X += (int)_movement.X;
            location.Y += (int)_movement.Y;
            _pictureBoxComponent.Location = location;
            Slowdown();
        }

        /// <summary>
        /// Add empty picture box
        /// </summary>
        public void AddPictureBox()
        {
            _pictureBoxComponent = new PictureBox();
            _size.Width = _pictureBoxComponent.Width;
            _size.Height = _pictureBoxComponent.Height;
        }

        /// <summary>
        /// Add given picture box
        /// </summary>
        /// <param name="pictureBox"></param>
        public void AddPictureBox(PictureBox pictureBox)
        {
            _pictureBoxComponent = pictureBox;
            _size.Width = _pictureBoxComponent.Width;
            _size.Height = _pictureBoxComponent.Height;
        }

        /// <summary>
        /// Set how much object can move
        /// </summary>
        /// <param name="horizontal"></param>
        /// <param name="vertical"></param>
        public void SetBoundaries(int horizontal, int vertical)
        {
            _boundaries.X = horizontal;
            _boundaries.Y = vertical;
        }

        /// <summary>
        /// Add left movement
        /// </summary>
        private void LeftMove()
        {
            _movement.X -= SpeedX;
        }

        /// <summary>
        /// Add right movement
        /// </summary>
        private void RightMove()
        {
            _movement.X += SpeedX;
        }

        /// <summary>
        /// Smoothly slow down object
        /// </summary>
        private void Slowdown()
        {
            _movement.X *= Drag;
            if (MathF.Abs(_movement.X) < 1) _movement.X = 0;
            _movement.Y *= Drag;
            if (MathF.Abs(_movement.Y) < 1) _movement.Y = 0;
        }

        /// <summary>
        /// Check if object can move further, if reset movement vector
        /// </summary>
        /// <param name="location">Current location</param>
        private void CheckBoundaries(Point location)
        {
            var left = location.X + _movement.X;
            var right = location.X + _movement.X + _size.Width;

            if (left <= 0) _movement.X = 0;
            if (right >= _boundaries.X) _movement.X = 0;
        }
    }
}
