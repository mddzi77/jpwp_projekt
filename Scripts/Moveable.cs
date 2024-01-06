using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using VeggieSandwich.Scripts.Core;

namespace VeggieSandwich.Scripts
{
    public class Moveable : IGameObject, IMoveable
    {
        public float Speed = 1.5f;
        public float Drag = 0.79f;

        public PictureBox Picture => _pictureBoxComponent;
        public Point CenterPoint => new(Left + _size.Width / 2, Top + _size.Height / 2);

        private Vector2 _movement = Vector2.Zero;
        private PictureBox _pictureBoxComponent;
        private Size _size;
        private Point _location;
        private int Left => _pictureBoxComponent.Left;
        private int Right => _pictureBoxComponent.Right;
        private int Top => _pictureBoxComponent.Top;
        private int Bottom => _pictureBoxComponent.Bottom;
        private Direction _direction = new(Directions.None, Directions.None);

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
            SetDirection();
            CanMove();
            _location.X += (int)_movement.X;
            _location.Y += (int)_movement.Y;
            _pictureBoxComponent.Location = _location;
            Slowdown();
            Console.WriteLine(_location.ToString());
        }

        public void AddPictureBox()
        {
            _pictureBoxComponent = new PictureBox();
            _size.Width = _pictureBoxComponent.Width;
            _size.Height = _pictureBoxComponent.Height;
            _location = _pictureBoxComponent.Location;
        }

        public void AddPictureBox(PictureBox pictureBox)
        {
            _pictureBoxComponent = pictureBox;
            _size.Width = _pictureBoxComponent.Width;
            _size.Height = _pictureBoxComponent.Height;
            _location = _pictureBoxComponent.Location;
        }

        public void OnVegetableTriggerEnter(string vegetableType)
        {
            Console.WriteLine(vegetableType);
        }

        public void OnTriggerEnter(string triggerType)
        {
            Console.WriteLine(triggerType);
        }

        private void LeftMove()
        {
            _movement.X -= Speed;
            _direction.X = Directions.Left;
        }

        private void RightMove()
        {
            _movement.X += Speed;
            _direction.X = Directions.Right;
        }

        private void UpMove()
        {
            _movement.Y -= Speed;
            _direction.Y = Directions.Up;
        }

        private void DownMove()
        {
            _movement.Y += Speed;
            _direction.Y = Directions.Down;
        }

        private void Slowdown()
        {
            _movement.X *= Drag;
            if (MathF.Abs(_movement.X) < 1) _movement.X = 0;
            _movement.Y *= Drag;
            if (MathF.Abs(_movement.Y) < 1) _movement.Y = 0;
        }

        private void CanMove()
        {
            CheckHorizontally();
            CheckVertically();
        }

        private void CheckHorizontally()
        {
            int newEdge;

            if (_movement.X > 0)
            {
                newEdge = Right + (int)_movement.X;
            }
            else if (_movement.X < 0)
            {
                newEdge = Left + (int)_movement.X;
            }
            else return;

            for (int i = Top; i < Bottom; i++)
            {
                var newPoint= new Point(newEdge, i);
                var control = Picture.Parent.GetChildAtPoint(newPoint);
                if (IsCollider(control))
                {
                    int maxMovement;
                    if (_movement.X > 0) maxMovement = control.Left - Right;
                    else maxMovement = control.Right - Left;
                    _movement.X = maxMovement;
                    return;
                }
            }
        }

        private void CheckVertically()
        {
            int newEdge;

            if (_movement.Y > 0)
            {
                newEdge = Bottom + (int)_movement.Y;
            }
            else if (_movement.Y < 0)
            {
                newEdge = Top + (int)_movement.Y;
            }
            else return;

            for (int i = Left; i < Right; i++)
            {
                var newPoint = new Point(i, newEdge);
                var control = _pictureBoxComponent.Parent.GetChildAtPoint(newPoint);
                if (IsCollider(control))
                {
                    int maxMovement;
                    if (_movement.Y > 0) maxMovement = control.Top - Bottom;
                    else maxMovement = control.Bottom - Top;
                    _movement.Y = maxMovement;
                    return;
                }
            }
        }

        private bool IsCollider(Control control)
        {
            if (control == null || control.Tag == null) return false;
            return control is Panel panel && panel.Tag.Equals("collider");
        }

        private void SetDirection()
        {
            _direction.X = _movement.X switch
            {
                > 0 => Directions.Right,
                < 0 => Directions.Left,
                _ => Directions.None
            };

            _direction.Y = _movement.Y switch
            {
                > 0 => Directions.Down,
                < 0 => Directions.Up,
                _ => Directions.None
            };
        }

        private void OnDetectedVegetable(string name)
        {
            Console.WriteLine(name);
        }

        public enum Directions
        {
            Left,
            Right,
            Up,
            Down,
            None
        }

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

        private struct Direction
        {
            public Direction(Directions x, Directions y)
            {
                X = x;
                Y = y;
            }
            public Directions X;
            public Directions Y;
        }
    }
}
