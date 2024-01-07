using VeggieSandwich.Scripts;
using VeggieSandwich.Scripts.Core;

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
            GameUpdate = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            pictureBox1 = new PictureBox();
            panel8 = new Panel();
            Pepper = new Panel();
            Tomato = new Panel();
            playerTagLabel = new Label();
            Salat = new Panel();
            Cucumber = new Panel();
            Eggplant = new Panel();
            Onion = new Panel();
            Corn = new Panel();
            Radish = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // GameUpdate
            // 
            GameUpdate.Enabled = true;
            GameUpdate.Interval = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 172);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(144, 516);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 48);
            panel1.TabIndex = 3;
            panel1.Tag = "collider";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Location = new Point(749, 528);
            panel2.Name = "panel2";
            panel2.Size = new Size(165, 100);
            panel2.TabIndex = 4;
            panel2.Tag = "collider";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Location = new Point(751, 384);
            panel3.Name = "panel3";
            panel3.Size = new Size(163, 83);
            panel3.TabIndex = 5;
            panel3.Tag = "collider";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Location = new Point(610, 417);
            panel4.Name = "panel4";
            panel4.Size = new Size(143, 53);
            panel4.TabIndex = 6;
            panel4.Tag = "collider";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Location = new Point(42, 284);
            panel5.Name = "panel5";
            panel5.Size = new Size(872, 65);
            panel5.TabIndex = 7;
            panel5.Tag = "collider";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Location = new Point(910, 344);
            panel6.Name = "panel6";
            panel6.Size = new Size(48, 342);
            panel6.TabIndex = 8;
            panel6.Tag = "collider";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Transparent;
            panel7.Location = new Point(3, 344);
            panel7.Name = "panel7";
            panel7.Size = new Size(47, 342);
            panel7.TabIndex = 9;
            panel7.Tag = "collider";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkOrange;
            pictureBox1.Location = new Point(488, 408);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 62);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Transparent;
            panel8.Location = new Point(42, 672);
            panel8.Name = "panel8";
            panel8.Size = new Size(872, 37);
            panel8.TabIndex = 8;
            panel8.Tag = "collider";
            // 
            // Pepper
            // 
            Pepper.BackColor = Color.Yellow;
            Pepper.Location = new Point(192, 475);
            Pepper.Name = "Pepper";
            Pepper.Size = new Size(53, 153);
            Pepper.TabIndex = 11;
            Pepper.Tag = "vegetable";
            // 
            // Tomato
            // 
            Tomato.BackColor = Color.OrangeRed;
            Tomato.Location = new Point(384, 475);
            Tomato.Name = "Tomato";
            Tomato.Size = new Size(50, 153);
            Tomato.TabIndex = 12;
            Tomato.Tag = "vegetable";
            // 
            // playerTagLabel
            // 
            playerTagLabel.AutoSize = true;
            playerTagLabel.BackColor = Color.Transparent;
            playerTagLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            playerTagLabel.ForeColor = Color.White;
            playerTagLabel.Location = new Point(488, 377);
            playerTagLabel.Name = "playerTagLabel";
            playerTagLabel.Size = new Size(70, 28);
            playerTagLabel.TabIndex = 13;
            playerTagLabel.Text = "label2";
            // 
            // Salat
            // 
            Salat.BackColor = Color.LawnGreen;
            Salat.Location = new Point(331, 475);
            Salat.Name = "Salat";
            Salat.Size = new Size(50, 153);
            Salat.TabIndex = 13;
            Salat.Tag = "vegetable";
            // 
            // Cucumber
            // 
            Cucumber.BackColor = Color.LightGreen;
            Cucumber.Location = new Point(440, 475);
            Cucumber.Name = "Cucumber";
            Cucumber.Size = new Size(50, 153);
            Cucumber.TabIndex = 13;
            Cucumber.Tag = "vegetable";
            // 
            // Eggplant
            // 
            Eggplant.BackColor = Color.BlueViolet;
            Eggplant.Location = new Point(496, 475);
            Eggplant.Name = "Eggplant";
            Eggplant.Size = new Size(71, 153);
            Eggplant.TabIndex = 14;
            Eggplant.Tag = "vegetable";
            // 
            // Onion
            // 
            Onion.BackColor = Color.Crimson;
            Onion.Location = new Point(633, 368);
            Onion.Name = "Onion";
            Onion.Size = new Size(50, 153);
            Onion.TabIndex = 14;
            Onion.Tag = "vegetable";
            // 
            // Corn
            // 
            Corn.BackColor = Color.LightYellow;
            Corn.Location = new Point(700, 369);
            Corn.Name = "Corn";
            Corn.Size = new Size(50, 153);
            Corn.TabIndex = 15;
            Corn.Tag = "vegetable";
            // 
            // Radish
            // 
            Radish.BackColor = Color.Salmon;
            Radish.Location = new Point(700, 531);
            Radish.Name = "Radish";
            Radish.Size = new Size(65, 97);
            Radish.TabIndex = 16;
            Radish.Tag = "vegetable";
            // 
            // GameWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            BackgroundImage = Properties.Resources.kitchen;
            ClientSize = new Size(954, 721);
            Controls.Add(pictureBox1);
            Controls.Add(playerTagLabel);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(label1);
            Controls.Add(Corn);
            Controls.Add(Onion);
            Controls.Add(Eggplant);
            Controls.Add(Radish);
            Controls.Add(Cucumber);
            Controls.Add(Tomato);
            Controls.Add(Salat);
            Controls.Add(Pepper);
            Name = "GameWindow";
            Text = "VeggieSandwich";
            Load += GameWindow_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer GameUpdate;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private PictureBox pictureBox1;
        private Panel panel8;
        private Panel Pepper;
        private Panel Tomato;
        private Label playerTagLabel;
        private Panel Salat;
        private Panel Cucumber;
        private Panel Eggplant;
        private Panel Onion;
        private Panel Corn;
        private Panel Radish;
    }
}