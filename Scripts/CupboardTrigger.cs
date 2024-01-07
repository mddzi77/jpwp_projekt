using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeggieSandwich.Scripts.Core;

namespace VeggieSandwich.Scripts
{
    public class CupboardTrigger : ITrigger, IGameObject
    {
        public string Name => "cupboard";
        public bool IsTriggered {get; private set; }
        public bool IsActive => _isActive;

        public event Action<ITrigger> TriggerEnter;

        private bool _isActive = true;
        private IMoveable _player;
        private PictureBox _image;

        public CupboardTrigger(IMoveable player, PictureBox image)
        {
            _player = player;
            TriggerEnter += _player.OnTriggerEnter;
            _image = image;
        }

        public void Update(object sender, EventArgs e)
        {
            if (!_isActive) return;
            CheckTriggerEnter();
        }

        public void SetActive(bool isActive)
        {
            _isActive = isActive;
        }

        private void CheckTriggerEnter()
        {
            var location = _player.CenterPoint;
            if (location.X > _image.Left && location.X < _image.Right
                && location.Y > _image.Top && location.Y < _image.Bottom)
            {
                TriggerEnter?.Invoke(this);
                IsTriggered = true;
                return;
            }
            IsTriggered = false;
        }
    }
}
