﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeggieSandwich.Scripts.Core;

namespace VeggieSandwich.Scripts
{
    public class VegetableTrigger : IGameObject, ITrigger
    {
        public event Action<string> TriggerEnter;

        private VegetableType _type;
        private IMoveable _player;
        private Panel _panel;

        public VegetableTrigger(IMoveable player, Panel panel)
        {
            _player = player;
            TriggerEnter += _player.OnVegetableTriggerEnter;
            _panel = panel;
            SetType();
        }

        public void Update(object sender, EventArgs e)
        {
            CheckTriggerEnter();
        }

        private void CheckTriggerEnter()
        {
            var location = _player.CenterPoint;
            if (location.X > _panel.Left && location.X < _panel.Right
                && location.Y > _panel.Top && location.Y < _panel.Bottom)
            {
                TriggerEnter?.Invoke(_type.ToString());
            }
        }

        private void SetType()
        {
            _type = _panel.Name switch
            {
                "Broccoli" => VegetableType.Broccoli,
                "Cabbage" => VegetableType.Cabbage,
                "Carrot" => VegetableType.Carrot,
                "Celery" => VegetableType.Celery,
                "Corn" => VegetableType.Corn,
                "Cucumber" => VegetableType.Cucumber,
                "Eggplant" => VegetableType.Eggplant,
                "Onion" => VegetableType.Onion,
                "Radish" => VegetableType.Radish,
                "Salad" => VegetableType.Salad,
                "Tomato" => VegetableType.Tomato,
                "Pepper" => VegetableType.Pepper,
                _ => VegetableType.None
            };
        }
    }
}