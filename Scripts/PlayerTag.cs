using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeggieSandwich.Scripts.Core;

namespace VeggieSandwich.Scripts
{
    public class PlayerTag : IGameObject
    {
        private Label _label;
        private IMoveable _player;
        private int yOffset;

        public PlayerTag(Label label, IMoveable player)
        {
            _label = label;
            _player = player;
            _label.Text = "";
        }

        public void Update(object sender, EventArgs e)
        {
            FollowPlayer();
        }

        public void SetText(string text)
        {
            _label.Text = text;
        }

        private void FollowPlayer()
        {
            var left = _player.Left;
            var top = _player.Top;
            var height = _label.Height;

            _label.Left = left;
            _label.Top = top - height;
        }
    }
}
