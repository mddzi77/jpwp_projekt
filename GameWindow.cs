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
            Focus();
        }

        private void GameObjectsInitialize()
        {
            // Initialize arrows keys handler
            KeyDown += KeyHandler.OnKeyDown;
            KeyUp += KeyHandler.OnKeyUp;

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
            GameUpdate.Tick += KeyHandler.InvokeKeys;
        }

        private void UnsuscribeFromGameUpdate()
        {
            foreach (var gameObject in _gameObjects)
            {
                GameUpdate.Tick -= gameObject.Update;
            }
            GameUpdate.Tick -= KeyHandler.InvokeKeys;
        }

        private List<Panel> GetPanelsByTag(Control parentControl, string tag)
        {
            var list = parentControl.Controls.OfType<Panel>()
                .Where(panel => panel.Tag.Equals(tag))
                .ToList();
            return list;
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            orderText.Clear();
            orderPanel.Enabled = true;
            orderPanel.Visible = true;
            menuBtn.Enabled = false;
            orderBtn.Enabled = false;
            orderText.Text = GameManager.OrderMsg;
            UnsuscribeFromGameUpdate();
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            menuPanel.Enabled = true;
            menuPanel.Visible = true;
            menuBtn.Enabled = false;
            orderBtn.Enabled = false;
            UnsuscribeFromGameUpdate();
        }

        private void closeOrderBtn_Click(object sender, EventArgs e)
        {
            orderPanel.Visible = false;
            orderPanel.Enabled = false;
            menuBtn.Enabled = true;
            orderBtn.Enabled = true;
            Focus();
            SubscribeToGameUpdate();
        }

        private void resumeBtn_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = false;
            menuPanel.Enabled = false;
            menuBtn.Enabled = true;
            orderBtn.Enabled = true;
            Focus();
            SubscribeToGameUpdate();
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            GameManager.Restart();
            menuPanel.Visible = false;
            menuPanel.Enabled = false;
            menuBtn.Enabled = true;
            orderBtn.Enabled = true;
            Focus();
            SubscribeToGameUpdate();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            GameManager.StartGame();
            orderBtn_Click(sender, e);
        }

        private void orderFinBtn_Click(object sender, EventArgs e)
        {
            if (GameManager.IsGameRunning)
            {
                orderText.Clear();
                GameManager.EndGame();
                orderText.Text = GameManager.OrderMsg;
                closeOrderBtn.Enabled = false;
                orderFinBtn.Text = "Dalej";
                return;
            }
            orderText.Clear();
            GameManager.StartGame();
            closeOrderBtn.Enabled = true;
            orderFinBtn.Text = "Finalizuj zamówienie";
            scoreLabel.Text = $"Wynik: {GameManager.Score}";
        }
    }
}