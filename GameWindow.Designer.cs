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
            pictureBox2 = new PictureBox();
            panel6 = new Panel();
            panel7 = new Panel();
            pictureBox1 = new PictureBox();
            panel8 = new Panel();
            panel9 = new Panel();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            label1.Location = new Point(54, 9);
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
            panel3.Size = new Size(163, 99);
            panel3.TabIndex = 5;
            panel3.Tag = "collider";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Location = new Point(610, 417);
            panel4.Name = "panel4";
            panel4.Size = new Size(144, 65);
            panel4.TabIndex = 6;
            panel4.Tag = "collider";
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
            pictureBox2.Location = new Point(307, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 51);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "vegetable";
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
            pictureBox1.Location = new Point(323, 427);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 62);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Transparent;
            panel8.Location = new Point(42, 667);
            panel8.Name = "panel8";
            panel8.Size = new Size(872, 42);
            panel8.TabIndex = 8;
            panel8.Tag = "collider";
            // 
            // panel9
            // 
            panel9.Location = new Point(96, 392);
            panel9.Name = "panel9";
            panel9.Size = new Size(135, 99);
            panel9.TabIndex = 11;
            panel9.Tag = "vegetable";
            // 
            // GameWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            BackgroundImage = Properties.Resources.kitchen;
            ClientSize = new Size(954, 721);
            Controls.Add(pictureBox1);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "GameWindow";
            Text = "VeggieSandwich";
            Load += GameWindow_Load;
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox2;
        private Panel panel9;
    }
}