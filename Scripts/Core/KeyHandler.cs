﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeggieSandwich.Scripts.Core
{
    public static class KeyHandler
    {
        public static event Action OnLeftArrow;
        public static event Action OnRightArrow;
        public static event Action OnUpArrow;
        public static event Action OnDownArrow;

        private static bool _leftArrow = false;
        private static bool _rightArrow = false;
        private static bool _upArrow = false;
        private static bool _downArrow = false;

        public static void InvokeKeys(object sender, EventArgs e)
        {
            if (_leftArrow) OnLeftArrow?.Invoke();
            if (_rightArrow) OnRightArrow?.Invoke();
            if (_upArrow) OnUpArrow?.Invoke();
            if (_downArrow) OnDownArrow?.Invoke();
        }

        public static void KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    _leftArrow = true;
                    break;
                case Keys.Right:
                    _rightArrow = true;
                    break;
                case Keys.Up:
                    _upArrow = true;
                    break;
                case Keys.Down:
                    _downArrow = true;
                    break;
            }
        }

        public static void KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    _leftArrow = false;
                    break;
                case Keys.Right:
                    _rightArrow = false;
                    break;
                case Keys.Up:
                    _upArrow = false;
                    break;
                case Keys.Down:
                    _downArrow = false;
                    break;
            }
        }

    }
}
