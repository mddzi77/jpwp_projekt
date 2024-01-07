using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeggieSandwich.Scripts.Core
{
    public static class KeyHandler
    {
        public static event Action PressedLeft;
        public static event Action PressedRight;
        public static event Action PressedUp;
        public static event Action PressedDown;
        public static event Action PressedE;

        private static bool _left = false;
        private static bool _right = false;
        private static bool _up = false;
        private static bool _down = false;


        public static void InvokeKeys(object sender, EventArgs e)
        {
            if (_left) PressedLeft?.Invoke();
            if (_right) PressedRight?.Invoke();
            if (_up) PressedUp?.Invoke();
            if (_down) PressedDown?.Invoke();
        }

        public static void OnKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    _left = true;
                    break;
                case Keys.D:
                    _right = true;
                    break;
                case Keys.W:
                    _up = true;
                    break;
                case Keys.S:
                    _down = true;
                    break;
                case Keys.E:
                    PressedE?.Invoke();
                    break;
                default: return;
            }
        }

        public static void OnKeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    _left = false;
                    break;
                case Keys.D:
                    _right = false;
                    break;
                case Keys.W:
                    _up = false;
                    break;
                case Keys.S:
                    _down = false;
                    break;
                default: return;
            }
        }

    }
}
