using System.Numerics;
using VeggieSandwich.Scripts;
using VeggieSandwich.Scripts.Core;

namespace VeggieSandwich
{
    public partial class GameWindow : Form
    {
        public Moveable Player = new();
        public CupboardTrigger Cupboard;

        private List<IGameObject> _gameObjects = new();

        public GameWindow()
        {
            InitializeComponent();
            GameObjectsInitialize();
            SubscribeToGameUpdate();
        }

        private void GameObjectsInitialize()
        {
            // Initialize arrows keys handler
            KeyDown += KeyHandler.KeyDown;
            KeyUp += KeyHandler.KeyUp;
            GameUpdate.Tick += KeyHandler.InvokeKeys;

            Player.AddPictureBox(pictureBox1);
            _gameObjects.Add(Player);

            var vegetables = GetPanelsByTag(this, "vegetable");
            foreach (var veg in vegetables)
            {
                var trigger = new VegetableTrigger(Player, veg);
                GameManager.Triggers.Add(trigger);
                _gameObjects.Add(trigger);
            }

            var playerTag = new PlayerTag(playerTagLabel, Player);
            _gameObjects.Add(playerTag);
            Player.MainLabel = playerTag;

            Cupboard = new CupboardTrigger(Player, cupboardBox);
            _gameObjects.Add(Cupboard);
            GameManager.Triggers.Add(Cupboard);

            var colliders = GetPanelsByTag(this, "collider");
            Player.Colliders = colliders;
        }

        private void SubscribeToGameUpdate()
        {
            foreach (var gameObject in _gameObjects)
            {
                GameUpdate.Tick += gameObject.Update;
            }
        }

        private void UnsuscribeFromGameUpdate()
        {
            foreach (var gameObject in _gameObjects)
            {
                GameUpdate.Tick -= gameObject.Update;
            }
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {

        }

        private List<Panel> GetPanelsByTag(Control parentControl, string tag)
        {
            var list = parentControl.Controls.OfType<Panel>()
                .Where(panel => panel.Tag.Equals(tag))
                .ToList();
            return list;
        }
    }
}