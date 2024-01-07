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
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            saladImg = new PictureBox();
            pepperImg = new PictureBox();
            panel2 = new Panel();
            pictureBox7 = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            pictureBox8 = new PictureBox();
            pictureBox6 = new PictureBox();
            panel5 = new Panel();
            pictureBox2 = new PictureBox();
            panel6 = new Panel();
            panel7 = new Panel();
            pictureBox1 = new PictureBox();
            panel8 = new Panel();
            Pepper = new Panel();
            Tomato = new Panel();
            playerTagLabel = new Label();
            Salad = new Panel();
            Cucumber = new Panel();
            Eggplant = new Panel();
            Onion = new Panel();
            Corn = new Panel();
            Radish = new Panel();
            cupboardBox = new PictureBox();
            orderBtn = new Button();
            menuBtn = new Button();
            menuPanel = new Panel();
            closeBtn = new Button();
            restartBtn = new Button();
            panel9 = new Panel();
            label2 = new Label();
            resumeBtn = new Button();
            closeOrderBtn = new Button();
            orderPanel = new Panel();
            orderFinBtn = new Button();
            panel11 = new Panel();
            label3 = new Label();
            orderText = new RichTextBox();
            scoreLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saladImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pepperImg).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cupboardBox).BeginInit();
            menuPanel.SuspendLayout();
            panel9.SuspendLayout();
            orderPanel.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // GameUpdate
            // 
            GameUpdate.Enabled = true;
            GameUpdate.Interval = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(saladImg);
            panel1.Controls.Add(pepperImg);
            panel1.Location = new Point(144, 516);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 48);
            panel1.TabIndex = 3;
            panel1.Tag = "collider";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.eggplant;
            pictureBox5.Location = new Point(340, 6);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(41, 39);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 23;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.cucumber;
            pictureBox4.Location = new Point(293, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(38, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.tomato;
            pictureBox3.Location = new Point(243, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // saladImg
            // 
            saladImg.Image = Properties.Resources.salat;
            saladImg.Location = new Point(190, 0);
            saladImg.Name = "saladImg";
            saladImg.Size = new Size(47, 45);
            saladImg.SizeMode = PictureBoxSizeMode.StretchImage;
            saladImg.TabIndex = 1;
            saladImg.TabStop = false;
            // 
            // pepperImg
            // 
            pepperImg.BackColor = Color.Transparent;
            pepperImg.Image = Properties.Resources.yellow_pepper;
            pepperImg.Location = new Point(48, 0);
            pepperImg.Name = "pepperImg";
            pepperImg.Size = new Size(50, 40);
            pepperImg.SizeMode = PictureBoxSizeMode.StretchImage;
            pepperImg.TabIndex = 0;
            pepperImg.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pictureBox6);
            panel2.Location = new Point(749, 528);
            panel2.Name = "panel2";
            panel2.Size = new Size(165, 100);
            panel2.TabIndex = 4;
            panel2.Tag = "collider";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.onion;
            pictureBox7.Location = new Point(26, 0);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(47, 38);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 25;
            pictureBox7.TabStop = false;
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
            panel4.Controls.Add(pictureBox7);
            panel4.Controls.Add(pictureBox8);
            panel4.Location = new Point(610, 417);
            panel4.Name = "panel4";
            panel4.Size = new Size(143, 53);
            panel4.TabIndex = 6;
            panel4.Tag = "collider";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.corn;
            pictureBox8.Location = new Point(101, -12);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(42, 37);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 26;
            pictureBox8.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.radish2;
            pictureBox6.Location = new Point(22, 37);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(50, 40);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 24;
            pictureBox6.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(pictureBox2);
            panel5.Location = new Point(42, 284);
            panel5.Name = "panel5";
            panel5.Size = new Size(872, 65);
            panel5.TabIndex = 7;
            panel5.Tag = "collider";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._02_dish_2;
            pictureBox2.Location = new Point(135, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
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
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.char_left;
            pictureBox1.Location = new Point(509, 369);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
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
            Pepper.BackColor = Color.Transparent;
            Pepper.Location = new Point(192, 462);
            Pepper.Name = "Pepper";
            Pepper.Size = new Size(53, 166);
            Pepper.TabIndex = 11;
            Pepper.Tag = "vegetable";
            // 
            // Tomato
            // 
            Tomato.BackColor = Color.Transparent;
            Tomato.Location = new Point(384, 462);
            Tomato.Name = "Tomato";
            Tomato.Size = new Size(50, 166);
            Tomato.TabIndex = 12;
            Tomato.Tag = "vegetable";
            // 
            // playerTagLabel
            // 
            playerTagLabel.AutoSize = true;
            playerTagLabel.BackColor = Color.Transparent;
            playerTagLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            playerTagLabel.ForeColor = Color.White;
            playerTagLabel.Location = new Point(509, 338);
            playerTagLabel.Name = "playerTagLabel";
            playerTagLabel.Size = new Size(70, 28);
            playerTagLabel.TabIndex = 13;
            playerTagLabel.Text = "label2";
            // 
            // Salad
            // 
            Salad.BackColor = Color.Transparent;
            Salad.Location = new Point(331, 462);
            Salad.Name = "Salad";
            Salad.Size = new Size(50, 166);
            Salad.TabIndex = 13;
            Salad.Tag = "vegetable";
            // 
            // Cucumber
            // 
            Cucumber.BackColor = Color.Transparent;
            Cucumber.Location = new Point(440, 462);
            Cucumber.Name = "Cucumber";
            Cucumber.Size = new Size(50, 166);
            Cucumber.TabIndex = 13;
            Cucumber.Tag = "vegetable";
            // 
            // Eggplant
            // 
            Eggplant.BackColor = Color.Transparent;
            Eggplant.Location = new Point(496, 462);
            Eggplant.Name = "Eggplant";
            Eggplant.Size = new Size(71, 166);
            Eggplant.TabIndex = 14;
            Eggplant.Tag = "vegetable";
            // 
            // Onion
            // 
            Onion.BackColor = Color.Transparent;
            Onion.Location = new Point(633, 355);
            Onion.Name = "Onion";
            Onion.Size = new Size(50, 180);
            Onion.TabIndex = 14;
            Onion.Tag = "vegetable";
            // 
            // Corn
            // 
            Corn.BackColor = Color.Transparent;
            Corn.Location = new Point(700, 355);
            Corn.Name = "Corn";
            Corn.Size = new Size(50, 180);
            Corn.TabIndex = 15;
            Corn.Tag = "vegetable";
            // 
            // Radish
            // 
            Radish.BackColor = Color.Transparent;
            Radish.Location = new Point(700, 531);
            Radish.Name = "Radish";
            Radish.Size = new Size(65, 108);
            Radish.TabIndex = 16;
            Radish.Tag = "vegetable";
            // 
            // cupboardBox
            // 
            cupboardBox.BackColor = Color.Transparent;
            cupboardBox.Image = Properties.Resources.box;
            cupboardBox.Location = new Point(132, 355);
            cupboardBox.Name = "cupboardBox";
            cupboardBox.Size = new Size(124, 87);
            cupboardBox.SizeMode = PictureBoxSizeMode.AutoSize;
            cupboardBox.TabIndex = 17;
            cupboardBox.TabStop = false;
            // 
            // orderBtn
            // 
            orderBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            orderBtn.BackColor = Color.Transparent;
            orderBtn.BackgroundImage = Properties.Resources.BlueButton;
            orderBtn.BackgroundImageLayout = ImageLayout.Zoom;
            orderBtn.CausesValidation = false;
            orderBtn.FlatAppearance.BorderSize = 0;
            orderBtn.FlatStyle = FlatStyle.Flat;
            orderBtn.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            orderBtn.ForeColor = SystemColors.ControlLightLight;
            orderBtn.Location = new Point(796, 12);
            orderBtn.Name = "orderBtn";
            orderBtn.Size = new Size(146, 110);
            orderBtn.TabIndex = 18;
            orderBtn.Text = "Zamówienie";
            orderBtn.UseVisualStyleBackColor = false;
            orderBtn.Click += orderBtn_Click;
            // 
            // menuBtn
            // 
            menuBtn.BackColor = Color.Transparent;
            menuBtn.BackgroundImage = Properties.Resources.BlueButton;
            menuBtn.BackgroundImageLayout = ImageLayout.Zoom;
            menuBtn.FlatAppearance.BorderSize = 0;
            menuBtn.FlatStyle = FlatStyle.Flat;
            menuBtn.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuBtn.ForeColor = SystemColors.ControlLightLight;
            menuBtn.Location = new Point(633, 12);
            menuBtn.Name = "menuBtn";
            menuBtn.Size = new Size(146, 110);
            menuBtn.TabIndex = 19;
            menuBtn.Text = "Menu";
            menuBtn.UseVisualStyleBackColor = false;
            menuBtn.Click += menuBtn_Click;
            // 
            // menuPanel
            // 
            menuPanel.Anchor = AnchorStyles.None;
            menuPanel.BackColor = Color.Transparent;
            menuPanel.BackgroundImage = Properties.Resources.SettingsBackground;
            menuPanel.BackgroundImageLayout = ImageLayout.Stretch;
            menuPanel.CausesValidation = false;
            menuPanel.Controls.Add(closeBtn);
            menuPanel.Controls.Add(restartBtn);
            menuPanel.Controls.Add(panel9);
            menuPanel.Controls.Add(resumeBtn);
            menuPanel.Enabled = false;
            menuPanel.Location = new Point(289, 96);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(362, 477);
            menuPanel.TabIndex = 20;
            menuPanel.Tag = "menu";
            menuPanel.Visible = false;
            // 
            // closeBtn
            // 
            closeBtn.Anchor = AnchorStyles.None;
            closeBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            closeBtn.BackColor = Color.Transparent;
            closeBtn.BackgroundImage = Properties.Resources.RedButton;
            closeBtn.BackgroundImageLayout = ImageLayout.Stretch;
            closeBtn.CausesValidation = false;
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            closeBtn.ForeColor = SystemColors.ControlLightLight;
            closeBtn.Location = new Point(89, 338);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(187, 91);
            closeBtn.TabIndex = 21;
            closeBtn.Text = "Zamknij";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // restartBtn
            // 
            restartBtn.Anchor = AnchorStyles.None;
            restartBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            restartBtn.BackColor = Color.Transparent;
            restartBtn.BackgroundImage = Properties.Resources.GreenButton;
            restartBtn.BackgroundImageLayout = ImageLayout.Stretch;
            restartBtn.CausesValidation = false;
            restartBtn.FlatAppearance.BorderSize = 0;
            restartBtn.FlatStyle = FlatStyle.Flat;
            restartBtn.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            restartBtn.ForeColor = SystemColors.ControlLightLight;
            restartBtn.Location = new Point(89, 241);
            restartBtn.Name = "restartBtn";
            restartBtn.Size = new Size(187, 91);
            restartBtn.TabIndex = 20;
            restartBtn.Text = "restart";
            restartBtn.UseVisualStyleBackColor = false;
            restartBtn.Click += restartBtn_Click;
            // 
            // panel9
            // 
            panel9.BackgroundImage = Properties.Resources.BlueTitle;
            panel9.BackgroundImageLayout = ImageLayout.Zoom;
            panel9.Controls.Add(label2);
            panel9.Location = new Point(0, -7);
            panel9.Name = "panel9";
            panel9.Size = new Size(362, 138);
            panel9.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(109, 40);
            label2.Name = "label2";
            label2.Size = new Size(158, 60);
            label2.TabIndex = 0;
            label2.Text = "MENU";
            // 
            // resumeBtn
            // 
            resumeBtn.Anchor = AnchorStyles.None;
            resumeBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            resumeBtn.BackColor = Color.Transparent;
            resumeBtn.BackgroundImage = Properties.Resources.GreenButton;
            resumeBtn.BackgroundImageLayout = ImageLayout.Stretch;
            resumeBtn.CausesValidation = false;
            resumeBtn.FlatAppearance.BorderSize = 0;
            resumeBtn.FlatStyle = FlatStyle.Flat;
            resumeBtn.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            resumeBtn.ForeColor = SystemColors.ControlLightLight;
            resumeBtn.Location = new Point(89, 146);
            resumeBtn.Name = "resumeBtn";
            resumeBtn.Size = new Size(187, 91);
            resumeBtn.TabIndex = 19;
            resumeBtn.Text = "Wznów";
            resumeBtn.UseVisualStyleBackColor = false;
            resumeBtn.Click += resumeBtn_Click;
            // 
            // closeOrderBtn
            // 
            closeOrderBtn.BackgroundImage = Properties.Resources.CloseButton;
            closeOrderBtn.BackgroundImageLayout = ImageLayout.Stretch;
            closeOrderBtn.FlatAppearance.BorderSize = 0;
            closeOrderBtn.FlatStyle = FlatStyle.Flat;
            closeOrderBtn.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            closeOrderBtn.ForeColor = SystemColors.ControlLightLight;
            closeOrderBtn.Location = new Point(458, -9);
            closeOrderBtn.Name = "closeOrderBtn";
            closeOrderBtn.Size = new Size(129, 106);
            closeOrderBtn.TabIndex = 0;
            closeOrderBtn.Text = "X";
            closeOrderBtn.UseVisualStyleBackColor = true;
            closeOrderBtn.Click += closeOrderBtn_Click;
            // 
            // orderPanel
            // 
            orderPanel.Anchor = AnchorStyles.None;
            orderPanel.BackColor = Color.Transparent;
            orderPanel.BackgroundImage = Properties.Resources.SettingsBackground;
            orderPanel.BackgroundImageLayout = ImageLayout.Stretch;
            orderPanel.CausesValidation = false;
            orderPanel.Controls.Add(orderFinBtn);
            orderPanel.Controls.Add(closeOrderBtn);
            orderPanel.Controls.Add(panel11);
            orderPanel.Controls.Add(orderText);
            orderPanel.Location = new Point(194, 26);
            orderPanel.Name = "orderPanel";
            orderPanel.Size = new Size(566, 613);
            orderPanel.TabIndex = 22;
            orderPanel.Tag = "menu";
            // 
            // orderFinBtn
            // 
            orderFinBtn.Anchor = AnchorStyles.None;
            orderFinBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            orderFinBtn.BackColor = Color.Transparent;
            orderFinBtn.BackgroundImage = Properties.Resources.GreenButton;
            orderFinBtn.BackgroundImageLayout = ImageLayout.Stretch;
            orderFinBtn.CausesValidation = false;
            orderFinBtn.FlatAppearance.BorderSize = 0;
            orderFinBtn.FlatStyle = FlatStyle.Flat;
            orderFinBtn.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            orderFinBtn.ForeColor = SystemColors.ControlLightLight;
            orderFinBtn.Location = new Point(183, 513);
            orderFinBtn.Name = "orderFinBtn";
            orderFinBtn.Size = new Size(201, 100);
            orderFinBtn.TabIndex = 20;
            orderFinBtn.Text = "Finalizuj zamówienie";
            orderFinBtn.UseVisualStyleBackColor = false;
            orderFinBtn.Click += orderFinBtn_Click;
            // 
            // panel11
            // 
            panel11.BackgroundImage = Properties.Resources.BlueTitle;
            panel11.BackgroundImageLayout = ImageLayout.Stretch;
            panel11.Controls.Add(label3);
            panel11.Location = new Point(11, -9);
            panel11.Name = "panel11";
            panel11.Size = new Size(332, 119);
            panel11.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(44, 43);
            label3.Name = "label3";
            label3.Size = new Size(254, 46);
            label3.TabIndex = 0;
            label3.Text = "zamówienie";
            // 
            // orderText
            // 
            orderText.BackColor = Color.BurlyWood;
            orderText.BorderStyle = BorderStyle.None;
            orderText.CausesValidation = false;
            orderText.DetectUrls = false;
            orderText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            orderText.ForeColor = SystemColors.ControlLightLight;
            orderText.Location = new Point(61, 116);
            orderText.Name = "orderText";
            orderText.ReadOnly = true;
            orderText.ScrollBars = RichTextBoxScrollBars.None;
            orderText.Size = new Size(445, 400);
            orderText.TabIndex = 2;
            orderText.TabStop = false;
            orderText.Text = "Test test sadddddddddddddddddddddddddddddddddddddddddddddddddddddddd ąćę";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.BackColor = Color.Transparent;
            scoreLabel.Font = new Font("Showcard Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            scoreLabel.ForeColor = SystemColors.ControlLightLight;
            scoreLabel.Location = new Point(27, -7);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(180, 44);
            scoreLabel.TabIndex = 23;
            scoreLabel.Text = "Wynik: 0";
            // 
            // GameWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            BackgroundImage = Properties.Resources.kitchen;
            ClientSize = new Size(954, 721);
            ControlBox = false;
            Controls.Add(menuPanel);
            Controls.Add(orderPanel);
            Controls.Add(pictureBox1);
            Controls.Add(playerTagLabel);
            Controls.Add(scoreLabel);
            Controls.Add(menuBtn);
            Controls.Add(orderBtn);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(cupboardBox);
            Controls.Add(Pepper);
            Controls.Add(Salad);
            Controls.Add(Tomato);
            Controls.Add(Cucumber);
            Controls.Add(Eggplant);
            Controls.Add(Onion);
            Controls.Add(Corn);
            Controls.Add(Radish);
            KeyPreview = true;
            MaximizeBox = false;
            Name = "GameWindow";
            Text = "VeggieSandwich";
            Load += GameWindow_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)saladImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pepperImg).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cupboardBox).EndInit();
            menuPanel.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            orderPanel.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer GameUpdate;
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
        private Panel Salad;
        private Panel Cucumber;
        private Panel Eggplant;
        private Panel Onion;
        private Panel Corn;
        private Panel Radish;
        private PictureBox cupboardBox;
        private PictureBox pictureBox2;
        private Button orderBtn;
        private Button menuBtn;
        private Panel menuPanel;
        private Button closeOrderBtn;
        private Panel panel9;
        private Label label2;
        private Button restartBtn;
        private Button resumeBtn;
        private Button closeBtn;
        private Panel orderPanel;
        private Panel panel11;
        private Label label3;
        private RichTextBox orderText;
        private Button orderFinBtn;
        private Label scoreLabel;
        private PictureBox pepperImg;
        private PictureBox saladImg;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox6;
    }
}