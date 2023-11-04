using VeggieSandwich.Scripts;
using VeggieSandwich.Scripts.Core;

namespace VeggieSandwich
{
    public partial class GameWindow : Form
    {
        public Moveable Plate = new();
        public List<IGameObject> gameObjects = new();
        private readonly int _maxVegetablesPool = 50;

        public GameWindow()
        {
            InitializeComponent();
            GameObjectsInitialize();
            SubscribeToGameUpdate();
        }

        public void GameObjectsInitialize()
        {
            // Initialize arrows keys handler
            KeyDown += KeyHandler.KeyDown;
            KeyUp += KeyHandler.KeyUp;
            GameUpdate.Tick += KeyHandler.InvokeKeys;

            Plate.AddPictureBox(plate);
            Plate.SetBoundaries(Width, Height);
            gameObjects.Add(Plate);
        }

        private void SubscribeToGameUpdate()
        {
            foreach (var gameObject in gameObjects)
            {
                GameUpdate.Tick += gameObject.Update;
            }
        }
    }
}