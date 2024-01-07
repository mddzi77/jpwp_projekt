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
        public int Left => _pictureBoxComponent.Left;
        public int Right => _pictureBoxComponent.Right;
        public int Top => _pictureBoxComponent.Top;
        public int Bottom => _pictureBoxComponent.Bottom;
        public PlayerTag MainLabel { get; set; }
        public List<Panel> Colliders { get; set; }

        private Vector2 _movement = Vector2.Zero;
        private PictureBox _pictureBoxComponent;
        private Size _size;
        private Point _location;
        private Direction _direction = new(Directions.None, Directions.None);
        private ITrigger _currentTrigger;
        private VegetableTrigger _vegeteableTrigger;

        public Moveable()
        {
            KeyHandler.PressedLeft += LeftMove;
            KeyHandler.PressedRight += RightMove;
            KeyHandler.PressedUp += UpMove;
            KeyHandler.PressedDown += DownMove;
            KeyHandler.PressedE += OnPressedE;
            _size = new Size(0, 0);
        }

        public void Update(object sender, EventArgs e)
        {
            CheckTrigger();
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

        public void OnVegetableTriggerEnter(ITrigger trigger)
        {
            var vegTrigger = (VegetableTrigger)trigger;
            _currentTrigger = trigger;
            if (GameManager.InHand == VegetableType.None)
            {
                MainLabel.SetText($"[E]: Podnieś {vegTrigger.Name}");
            }
            else if (GameManager.InHand == vegTrigger.Type)
            {
                MainLabel.SetText($"[E]: Odłóż z powrotem {vegTrigger.Name}");
            }
        }

        public void OnTriggerEnter(ITrigger trigger)
        {
            _currentTrigger = trigger;
            if (GameManager.InHand == VegetableType.None) return;
            MainLabel.SetText($"[E]: Odłóż {GameManager.InHandName} do zamówienia");
        }

        private void OnPressedE()
        {
            if (_currentTrigger == null | !_currentTrigger.IsTriggered) return;

            if (_currentTrigger is VegetableTrigger)
            {
                var vegetable = (VegetableTrigger)_currentTrigger;
                if (GameManager.InHand == VegetableType.None)
                {
                    GameManager.InHand = vegetable.Type;
                    MainLabel.SetText("");
                    _vegeteableTrigger = vegetable;
                }
                else if (GameManager.InHand == vegetable.Type)
                {
                    GameManager.AddToPlate();
                }
                else
                {
                    MainLabel.SetText($"Nie możesz trzymać {GameManager.InHandName} i {vegetable.Type} jednocześnie");
                }
            }
            else if (_currentTrigger is CupboardTrigger)
            {
                if (GameManager.InHand == VegetableType.None) return;
                var cupboard = (CupboardTrigger)_currentTrigger;
                _vegeteableTrigger.SetActive(false);
                MainLabel.SetText("");
                GameManager.InHand = VegetableType.None;
            }
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

        private async void CanMove()
        {
            await CheckColliders();
        }

        private async Task CheckColliders()
        {
            Vector4 edges = new(Left + (int)_movement.X, // X
                Right + (int)_movement.X, // Y
                Top + (int)_movement.Y, // Z
                Bottom + (int)_movement.Y); // W

            List<Task> tasks = new List<Task>();
            foreach (var collider in Colliders)
            {
                if (collider.Left > edges.Y && collider.Right < edges.X && collider.Top > edges.W && collider.Bottom < edges.Z) continue;
                tasks.Add(IsInCollider(edges, collider));
            }
            await Task.WhenAll(tasks);
        }

        private async Task IsInCollider(Vector4 edges, Panel collider)
        {
            for (int i = (int)edges.Z; i < edges.W; i++)
            {
                for (int j = (int)edges.X; j < edges.Y; j++)
                {
                    var newPoint = new Point(j, i);
                    if (newPoint.X > collider.Left && newPoint.X < collider.Right
                        && newPoint.Y > collider.Top && newPoint.Y < collider.Bottom)
                    {
                        _movement = Vector2.Zero;
                        return;
                    }
                }
            }
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
            Animate();
        }

        private void Animate()
        {
            if (_direction.X == Directions.Left)
            {
                _pictureBoxComponent.Image = Properties.Resources.char_left;
            }
            else if (_direction.X == Directions.Right)
            {
                _pictureBoxComponent.Image = Properties.Resources.char_right;
            }
        }

        private void CheckTrigger()
        {
            if (MainLabel.Text.Equals("")) return;
            if (_currentTrigger == null)
            {
                MainLabel.SetText("");
                return;
            }
            if (_currentTrigger.IsTriggered) return;
            MainLabel.SetText("");
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
