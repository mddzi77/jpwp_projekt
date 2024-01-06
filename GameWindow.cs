using System.Numerics;
using VeggieSandwich.Scripts;
using VeggieSandwich.Scripts.Core;

namespace VeggieSandwich
{
    public partial class GameWindow : Form
    {
        public Moveable Player = new();

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
                _gameObjects.Add(trigger);
            }

            SuspendLayout();
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

        public List<Panel> GetPanelsByTag(Control parentControl, string tag)
        {
            var list = parentControl.Controls.OfType<Panel>()
                .Where(panel => panel.Tag.Equals(tag))
                .ToList();
            return list;
        }

    }
}