namespace VeggieSandwich
{
    partial class GameWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            GameUpdate = new System.Windows.Forms.Timer(components);
            Plate = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Plate).BeginInit();
            SuspendLayout();
            // 
            // GameUpdate
            // 
            GameUpdate.Interval = 20;
            GameUpdate.Tick += Update;
            // 
            // Plate
            // 
            Plate.BackColor = Color.Transparent;
            Plate.Image = (Image)resources.GetObject("Plate.Image");
            Plate.Location = new Point(396, 819);
            Plate.Name = "Plate";
            Plate.Size = new Size(138, 169);
            Plate.SizeMode = PictureBoxSizeMode.StretchImage;
            Plate.TabIndex = 0;
            Plate.TabStop = false;
            // 
            // GameWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(1000, 1000);
            Controls.Add(Plate);
            Name = "GameWindow";
            Text = "VeggieSandwich";
            KeyPress += OnKeyPress;
            ((System.ComponentModel.ISupportInitialize)Plate).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer GameUpdate;
        private PictureBox Plate;
    }
}