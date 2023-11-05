using System.Numerics;
using VeggieSandwich.Scripts;
using VeggieSandwich.Scripts.Core;

namespace VeggieSandwich
{
    public partial class GameWindow : Form
    {
        public Moveable Plate = new();

        private List<IGameObject> _gameObjects = new();
        private readonly int _maxVegetablesPool = 50;
        private readonly List<Vegetable> _vegetablesPool = new();
        private VegetableSpawner _vegetableSpawner;

        public GameWindow()
        {
            InitializeComponent();
            GameObjectsInitialize();
            _vegetableSpawner = new VegetableSpawner(_vegetablesPool);
            _vegetableSpawner.SpawnBoundaries = new Vector2(0, Width);
            _gameObjects.Add(_vegetableSpawner);
            SubscribeToGameUpdate();
            _vegetableSpawner.StartSpawnning();
        }

        public void GameObjectsInitialize()
        {
            // Initialize arrows keys handler
            KeyDown += KeyHandler.KeyDown;
            KeyUp += KeyHandler.KeyUp;
            GameUpdate.Tick += KeyHandler.InvokeKeys;

            Plate.AddPictureBox(plate);
            Plate.SetBoundaries(Width, Height);
            _gameObjects.Add(Plate);

            SuspendLayout();
            for (int i = 0; i < _maxVegetablesPool; i++)
            {
                var vegetable = new Vegetable();
                vegetable.Enabled = false;
                ((System.ComponentModel.ISupportInitialize)vegetable).BeginInit();
                Controls.Add(vegetable);
                _vegetablesPool.Add(vegetable);
                _gameObjects.Add(vegetable);
                ((System.ComponentModel.ISupportInitialize)vegetable).EndInit();
            }
            ResumeLayout(false);
            PerformLayout();
        }

        private void SubscribeToGameUpdate()
        {
            foreach (var gameObject in _gameObjects)
            {
                GameUpdate.Tick += gameObject.Update;
            }
        }
    }
}