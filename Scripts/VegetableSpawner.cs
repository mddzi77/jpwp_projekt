using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using VeggieSandwich.Scripts.Core;
using static System.Windows.Forms.Control;

namespace VeggieSandwich.Scripts
{
    public class VegetableSpawner : IGameObject
    {
        public int SpawnYOffset = 10;
        public int SpawnMinInterval = 100;
        public int SpawnMaxInterval = 500;

        public Vector2 SpawnBoundaries
        {
            set => _spawnBoundaries = value;
        }

        private Vector2 _spawnBoundaries = new();
        private Random _random = new();
        private int _interval = 0;
        private int _timer = 0;
        private bool _isSpawning = false;
        private List<Vegetable> _vegetables;
        private List<Vegetable> _vegetablesInUse = new();

        public VegetableSpawner(List<Vegetable> vegetables)
        {
            _vegetables = vegetables;
            _interval = _random.Next(SpawnMinInterval, SpawnMaxInterval);
        }

        public void Update(object sender, EventArgs e)
        {
            if (!_isSpawning) return;

            _timer++;
            if (_timer >= _interval)
            {
                SpawnVegetable();
                _timer = 0;
                _interval = _random.Next(SpawnMinInterval, SpawnMaxInterval);
            }
        }

        public void StartSpawnning() => _isSpawning = true;

        public void StopSpawnning() => _isSpawning = false;

        /// <summary>
        /// Get random vegetable from pool and spawn it
        /// </summary>
        /// <exception cref="IndexOutOfRangeException"></exception>
        private void SpawnVegetable()
        {
            if (_vegetables.Count == 0) throw new IndexOutOfRangeException("Vegetables pool is empty");
            var id = _random.Next(0, _vegetables.Count);
            var vegetable = _vegetables[id];
            _vegetables.Remove(vegetable);
            //vegetable.Initialize();
            vegetable.OnReturnToPool += ReturnToPool;
            SetSpawnPosition(vegetable);
            _vegetablesInUse.Add(vegetable);
        }

        /// <summary>
        /// Set position in between boundaries for given vegetable
        /// </summary>
        /// <param name="vegetable"></param>
        private void SetSpawnPosition(Vegetable vegetable)
        {
            var xPosition = _random.Next((int)_spawnBoundaries.X, (int)_spawnBoundaries.Y);
            var location = new Point(xPosition, -SpawnYOffset);
            vegetable.Location = location;
        }

        /// <summary>
        /// Remove vegetable from in use list and return it to pool
        /// </summary>
        /// <param name="vegetable"></param>
        private void ReturnToPool(Vegetable vegetable)
        {
            _vegetablesInUse.Remove(vegetable);
            _vegetables.Add(vegetable);
        }
    }
}
