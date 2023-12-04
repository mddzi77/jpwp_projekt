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
        public float Speed = 2;
        public float Drag = 0.79f;

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
            KeyHandler.OnUpArrow += UpMove;
            KeyHandler.OnDownArrow += DownMove;
            _size = new Size(0, 0);
        }

        public void Update(object sender, EventArgs e)
        {
            if (_movement.Equals(Vector2.Zero)) return;
            var location = _pictureBoxComponent.Location;
            CanMove(location);
            location.X += (int)_movement.X;
            location.Y += (int)_movement.Y;
            _pictureBoxComponent.Location = location;
            Slowdown();
        }

        public void AddPictureBox()
        {
            _pictureBoxComponent = new PictureBox();
            _size.Width = _pictureBoxComponent.Width;
            _size.Height = _pictureBoxComponent.Height;
        }

        public void AddPictureBox(PictureBox pictureBox)
        {
            _pictureBoxComponent = pictureBox;
            _size.Width = _pictureBoxComponent.Width;
            _size.Height = _pictureBoxComponent.Height;
        }

        private void LeftMove()
        {
            _movement.X -= Speed;
        }

        private void RightMove()
        {
            _movement.X += Speed;
        }

        private void UpMove()
        {
            _movement.Y -= Speed;
        }

        private void DownMove()
        {
            _movement.Y += Speed;
        }

        private void Slowdown()
        {
            _movement.X *= Drag;
            if (MathF.Abs(_movement.X) < 1) _movement.X = 0;
            _movement.Y *= Drag;
            if (MathF.Abs(_movement.Y) < 1) _movement.Y = 0;
        }

        private void CanMove(Point location)
        {
            var left = location.X + (int)_movement.X;
            var right = location.X + (int)_movement.X + _size.Width;
            var top = location.Y + (int)_movement.Y;
            var bottom = location.Y + (int)_movement.Y + _size.Height;

            for (int i = left; i <= right; i++)
            {
                var positionTop = new Point(i, top);
                var positionBottom = new Point(i, bottom);

                var control = Picture.Parent.GetChildAtPoint(positionTop);
                if (IsCollider(control))
                {
                    var maxPosition = control.Location.Y + control.Height;
                    _movement.Y = maxPosition - location.Y;
                }

                control = Picture.Parent.GetChildAtPoint(positionBottom);
                if (IsCollider(control))
                {
                    var maxPosition = control.Location.Y;
                    _movement.Y = bottom - maxPosition ;
                }
            }



            for (int i = bottom; i <= top; i++)
            {
                var positionLeft = new Point(left, i);
                var positionRight = new Point(right, i);
            }
        }

        private bool IsCollider(Control control)
        {
            return control is Panel panel && panel.Tag.Equals("collider");
        }
    }
}
