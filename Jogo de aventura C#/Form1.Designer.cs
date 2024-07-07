namespace Jogo_de_aventura_C_
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MoveBox = new System.Windows.Forms.GroupBox();
            this.MDown = new System.Windows.Forms.Button();
            this.MRight = new System.Windows.Forms.Button();
            this.MLeft = new System.Windows.Forms.Button();
            this.MUp = new System.Windows.Forms.Button();
            this.AttackBox = new System.Windows.Forms.GroupBox();
            this.ADown = new System.Windows.Forms.Button();
            this.ARight = new System.Windows.Forms.Button();
            this.ALeft = new System.Windows.Forms.Button();
            this.AUp = new System.Windows.Forms.Button();
            this.TextPlayerLife = new System.Windows.Forms.Label();
            this.TextBatLife = new System.Windows.Forms.Label();
            this.TextGhostLife = new System.Windows.Forms.Label();
            this.TextGhoulLife = new System.Windows.Forms.Label();
            this.PlayerLife = new System.Windows.Forms.Label();
            this.BatLife = new System.Windows.Forms.Label();
            this.GhostLife = new System.Windows.Forms.Label();
            this.GhoulLife = new System.Windows.Forms.Label();
            this.Bat = new System.Windows.Forms.PictureBox();
            this.Ghost = new System.Windows.Forms.PictureBox();
            this.Ghoul = new System.Windows.Forms.PictureBox();
            this.Sworld = new System.Windows.Forms.PictureBox();
            this.PotionRed = new System.Windows.Forms.PictureBox();
            this.Espinhos = new System.Windows.Forms.PictureBox();
            this.Bow = new System.Windows.Forms.PictureBox();
            this.BluePotion = new System.Windows.Forms.PictureBox();
            this.InSworld = new System.Windows.Forms.PictureBox();
            this.InPotionRed = new System.Windows.Forms.PictureBox();
            this.InEspinhos = new System.Windows.Forms.PictureBox();
            this.InBow = new System.Windows.Forms.PictureBox();
            this.InPotionBlue = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Background = new System.Windows.Forms.Panel();
            this.TelaPerder = new System.Windows.Forms.PictureBox();
            this.TelaVencer = new System.Windows.Forms.PictureBox();
            this.buttonReiniciar = new System.Windows.Forms.Button();
            this.MoveBox.SuspendLayout();
            this.AttackBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sworld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PotionRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Espinhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InSworld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InPotionRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InEspinhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InPotionBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TelaPerder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelaVencer)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveBox
            // 
            this.MoveBox.Controls.Add(this.MDown);
            this.MoveBox.Controls.Add(this.MRight);
            this.MoveBox.Controls.Add(this.MLeft);
            this.MoveBox.Controls.Add(this.MUp);
            this.MoveBox.Location = new System.Drawing.Point(605, 12);
            this.MoveBox.Name = "MoveBox";
            this.MoveBox.Size = new System.Drawing.Size(229, 116);
            this.MoveBox.TabIndex = 1;
            this.MoveBox.TabStop = false;
            this.MoveBox.Text = "Move";
            // 
            // MDown
            // 
            this.MDown.Location = new System.Drawing.Point(78, 78);
            this.MDown.Name = "MDown";
            this.MDown.Size = new System.Drawing.Size(75, 23);
            this.MDown.TabIndex = 3;
            this.MDown.Text = "Down";
            this.MDown.UseVisualStyleBackColor = true;
            this.MDown.Click += new System.EventHandler(this.MoveDown_Click);
            // 
            // MRight
            // 
            this.MRight.Location = new System.Drawing.Point(147, 49);
            this.MRight.Name = "MRight";
            this.MRight.Size = new System.Drawing.Size(75, 23);
            this.MRight.TabIndex = 2;
            this.MRight.Text = "Right";
            this.MRight.UseVisualStyleBackColor = true;
            this.MRight.Click += new System.EventHandler(this.MoveRight_Click);
            // 
            // MLeft
            // 
            this.MLeft.Location = new System.Drawing.Point(6, 49);
            this.MLeft.Name = "MLeft";
            this.MLeft.Size = new System.Drawing.Size(75, 23);
            this.MLeft.TabIndex = 1;
            this.MLeft.Text = "Left";
            this.MLeft.UseVisualStyleBackColor = true;
            this.MLeft.Click += new System.EventHandler(this.MoveLeft_Click);
            // 
            // MUp
            // 
            this.MUp.Location = new System.Drawing.Point(78, 20);
            this.MUp.Name = "MUp";
            this.MUp.Size = new System.Drawing.Size(75, 23);
            this.MUp.TabIndex = 0;
            this.MUp.Text = "Up";
            this.MUp.UseVisualStyleBackColor = true;
            this.MUp.Click += new System.EventHandler(this.MoveUp_Click);
            // 
            // AttackBox
            // 
            this.AttackBox.Controls.Add(this.ADown);
            this.AttackBox.Controls.Add(this.ARight);
            this.AttackBox.Controls.Add(this.ALeft);
            this.AttackBox.Controls.Add(this.AUp);
            this.AttackBox.Location = new System.Drawing.Point(605, 134);
            this.AttackBox.Name = "AttackBox";
            this.AttackBox.Size = new System.Drawing.Size(229, 116);
            this.AttackBox.TabIndex = 2;
            this.AttackBox.TabStop = false;
            this.AttackBox.Text = "Attack";
            // 
            // ADown
            // 
            this.ADown.Location = new System.Drawing.Point(78, 77);
            this.ADown.Name = "ADown";
            this.ADown.Size = new System.Drawing.Size(75, 23);
            this.ADown.TabIndex = 4;
            this.ADown.Text = "Down";
            this.ADown.UseVisualStyleBackColor = true;
            this.ADown.Click += new System.EventHandler(this.AttackDown_Click);
            // 
            // ARight
            // 
            this.ARight.Location = new System.Drawing.Point(147, 48);
            this.ARight.Name = "ARight";
            this.ARight.Size = new System.Drawing.Size(75, 23);
            this.ARight.TabIndex = 3;
            this.ARight.Text = "Right";
            this.ARight.UseVisualStyleBackColor = true;
            this.ARight.Click += new System.EventHandler(this.AttackRight_Click);
            // 
            // ALeft
            // 
            this.ALeft.Location = new System.Drawing.Point(6, 48);
            this.ALeft.Name = "ALeft";
            this.ALeft.Size = new System.Drawing.Size(75, 23);
            this.ALeft.TabIndex = 2;
            this.ALeft.Text = "Left";
            this.ALeft.UseVisualStyleBackColor = true;
            this.ALeft.Click += new System.EventHandler(this.AttackLeft_Click);
            // 
            // AUp
            // 
            this.AUp.Location = new System.Drawing.Point(78, 19);
            this.AUp.Name = "AUp";
            this.AUp.Size = new System.Drawing.Size(75, 23);
            this.AUp.TabIndex = 1;
            this.AUp.Text = "Up";
            this.AUp.UseVisualStyleBackColor = true;
            this.AUp.Click += new System.EventHandler(this.AttackUp_Click);
            // 
            // TextPlayerLife
            // 
            this.TextPlayerLife.AutoSize = true;
            this.TextPlayerLife.Location = new System.Drawing.Point(608, 265);
            this.TextPlayerLife.Name = "TextPlayerLife";
            this.TextPlayerLife.Size = new System.Drawing.Size(36, 13);
            this.TextPlayerLife.TabIndex = 3;
            this.TextPlayerLife.Text = "Player";
            // 
            // TextBatLife
            // 
            this.TextBatLife.AutoSize = true;
            this.TextBatLife.Location = new System.Drawing.Point(608, 292);
            this.TextBatLife.Name = "TextBatLife";
            this.TextBatLife.Size = new System.Drawing.Size(23, 13);
            this.TextBatLife.TabIndex = 4;
            this.TextBatLife.Text = "Bat";
            // 
            // TextGhostLife
            // 
            this.TextGhostLife.AutoSize = true;
            this.TextGhostLife.Location = new System.Drawing.Point(608, 319);
            this.TextGhostLife.Name = "TextGhostLife";
            this.TextGhostLife.Size = new System.Drawing.Size(35, 13);
            this.TextGhostLife.TabIndex = 5;
            this.TextGhostLife.Text = "Ghost";
            // 
            // TextGhoulLife
            // 
            this.TextGhoulLife.AutoSize = true;
            this.TextGhoulLife.Location = new System.Drawing.Point(608, 346);
            this.TextGhoulLife.Name = "TextGhoulLife";
            this.TextGhoulLife.Size = new System.Drawing.Size(35, 13);
            this.TextGhoulLife.TabIndex = 6;
            this.TextGhoulLife.Text = "Ghoul";
            // 
            // PlayerLife
            // 
            this.PlayerLife.AutoSize = true;
            this.PlayerLife.Location = new System.Drawing.Point(680, 265);
            this.PlayerLife.Name = "PlayerLife";
            this.PlayerLife.Size = new System.Drawing.Size(35, 13);
            this.PlayerLife.TabIndex = 7;
            this.PlayerLife.Text = "label1";
            // 
            // BatLife
            // 
            this.BatLife.AutoSize = true;
            this.BatLife.Location = new System.Drawing.Point(680, 292);
            this.BatLife.Name = "BatLife";
            this.BatLife.Size = new System.Drawing.Size(35, 13);
            this.BatLife.TabIndex = 8;
            this.BatLife.Text = "label1";
            // 
            // GhostLife
            // 
            this.GhostLife.AutoSize = true;
            this.GhostLife.Location = new System.Drawing.Point(680, 319);
            this.GhostLife.Name = "GhostLife";
            this.GhostLife.Size = new System.Drawing.Size(35, 13);
            this.GhostLife.TabIndex = 9;
            this.GhostLife.Text = "label1";
            // 
            // GhoulLife
            // 
            this.GhoulLife.AutoSize = true;
            this.GhoulLife.Location = new System.Drawing.Point(680, 346);
            this.GhoulLife.Name = "GhoulLife";
            this.GhoulLife.Size = new System.Drawing.Size(35, 13);
            this.GhoulLife.TabIndex = 10;
            this.GhoulLife.Text = "label1";
            // 
            // Bat
            // 
            this.Bat.BackColor = System.Drawing.Color.Transparent;
            this.Bat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Bat.Image = ((System.Drawing.Image)(resources.GetObject("Bat.Image")));
            this.Bat.Location = new System.Drawing.Point(325, 102);
            this.Bat.Name = "Bat";
            this.Bat.Size = new System.Drawing.Size(31, 31);
            this.Bat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bat.TabIndex = 15;
            this.Bat.TabStop = false;
            this.Bat.Visible = false;
            // 
            // Ghost
            // 
            this.Ghost.BackColor = System.Drawing.Color.Transparent;
            this.Ghost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Ghost.Image = ((System.Drawing.Image)(resources.GetObject("Ghost.Image")));
            this.Ghost.Location = new System.Drawing.Point(165, 62);
            this.Ghost.Name = "Ghost";
            this.Ghost.Size = new System.Drawing.Size(31, 31);
            this.Ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ghost.TabIndex = 16;
            this.Ghost.TabStop = false;
            this.Ghost.Visible = false;
            // 
            // Ghoul
            // 
            this.Ghoul.BackColor = System.Drawing.Color.Transparent;
            this.Ghoul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Ghoul.Image = ((System.Drawing.Image)(resources.GetObject("Ghoul.Image")));
            this.Ghoul.Location = new System.Drawing.Point(205, 62);
            this.Ghoul.Name = "Ghoul";
            this.Ghoul.Size = new System.Drawing.Size(31, 31);
            this.Ghoul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ghoul.TabIndex = 17;
            this.Ghoul.TabStop = false;
            this.Ghoul.Visible = false;
            // 
            // Sworld
            // 
            this.Sworld.BackColor = System.Drawing.Color.Transparent;
            this.Sworld.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Sworld.Image = ((System.Drawing.Image)(resources.GetObject("Sworld.Image")));
            this.Sworld.Location = new System.Drawing.Point(245, 62);
            this.Sworld.Name = "Sworld";
            this.Sworld.Size = new System.Drawing.Size(31, 31);
            this.Sworld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Sworld.TabIndex = 18;
            this.Sworld.TabStop = false;
            this.Sworld.Visible = false;
            // 
            // PotionRed
            // 
            this.PotionRed.BackColor = System.Drawing.Color.Transparent;
            this.PotionRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PotionRed.Image = ((System.Drawing.Image)(resources.GetObject("PotionRed.Image")));
            this.PotionRed.Location = new System.Drawing.Point(285, 62);
            this.PotionRed.Name = "PotionRed";
            this.PotionRed.Size = new System.Drawing.Size(31, 31);
            this.PotionRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PotionRed.TabIndex = 19;
            this.PotionRed.TabStop = false;
            this.PotionRed.Visible = false;
            // 
            // Espinhos
            // 
            this.Espinhos.BackColor = System.Drawing.Color.Transparent;
            this.Espinhos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Espinhos.Image = ((System.Drawing.Image)(resources.GetObject("Espinhos.Image")));
            this.Espinhos.Location = new System.Drawing.Point(325, 62);
            this.Espinhos.Name = "Espinhos";
            this.Espinhos.Size = new System.Drawing.Size(31, 31);
            this.Espinhos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Espinhos.TabIndex = 20;
            this.Espinhos.TabStop = false;
            this.Espinhos.Visible = false;
            // 
            // Bow
            // 
            this.Bow.BackColor = System.Drawing.Color.Transparent;
            this.Bow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Bow.Image = ((System.Drawing.Image)(resources.GetObject("Bow.Image")));
            this.Bow.Location = new System.Drawing.Point(365, 62);
            this.Bow.Name = "Bow";
            this.Bow.Size = new System.Drawing.Size(31, 31);
            this.Bow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bow.TabIndex = 21;
            this.Bow.TabStop = false;
            this.Bow.Visible = false;
            // 
            // BluePotion
            // 
            this.BluePotion.BackColor = System.Drawing.Color.Transparent;
            this.BluePotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BluePotion.Image = ((System.Drawing.Image)(resources.GetObject("BluePotion.Image")));
            this.BluePotion.Location = new System.Drawing.Point(405, 62);
            this.BluePotion.Name = "BluePotion";
            this.BluePotion.Size = new System.Drawing.Size(31, 31);
            this.BluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BluePotion.TabIndex = 22;
            this.BluePotion.TabStop = false;
            this.BluePotion.Visible = false;
            // 
            // InSworld
            // 
            this.InSworld.BackColor = System.Drawing.Color.Transparent;
            this.InSworld.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InSworld.Image = ((System.Drawing.Image)(resources.GetObject("InSworld.Image")));
            this.InSworld.Location = new System.Drawing.Point(75, 316);
            this.InSworld.Name = "InSworld";
            this.InSworld.Size = new System.Drawing.Size(58, 59);
            this.InSworld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InSworld.TabIndex = 23;
            this.InSworld.TabStop = false;
            this.InSworld.Visible = false;
            this.InSworld.Click += new System.EventHandler(this.InSworld_Click);
            // 
            // InPotionRed
            // 
            this.InPotionRed.BackColor = System.Drawing.Color.Transparent;
            this.InPotionRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InPotionRed.Image = ((System.Drawing.Image)(resources.GetObject("InPotionRed.Image")));
            this.InPotionRed.Location = new System.Drawing.Point(139, 316);
            this.InPotionRed.Name = "InPotionRed";
            this.InPotionRed.Size = new System.Drawing.Size(58, 59);
            this.InPotionRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InPotionRed.TabIndex = 24;
            this.InPotionRed.TabStop = false;
            this.InPotionRed.Visible = false;
            this.InPotionRed.Click += new System.EventHandler(this.InPotionRed_Click);
            // 
            // InEspinhos
            // 
            this.InEspinhos.BackColor = System.Drawing.Color.Transparent;
            this.InEspinhos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InEspinhos.Image = ((System.Drawing.Image)(resources.GetObject("InEspinhos.Image")));
            this.InEspinhos.Location = new System.Drawing.Point(203, 316);
            this.InEspinhos.Name = "InEspinhos";
            this.InEspinhos.Size = new System.Drawing.Size(58, 59);
            this.InEspinhos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InEspinhos.TabIndex = 25;
            this.InEspinhos.TabStop = false;
            this.InEspinhos.Visible = false;
            this.InEspinhos.Click += new System.EventHandler(this.InEspinhos_Click);
            // 
            // InBow
            // 
            this.InBow.BackColor = System.Drawing.Color.Transparent;
            this.InBow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InBow.Image = ((System.Drawing.Image)(resources.GetObject("InBow.Image")));
            this.InBow.Location = new System.Drawing.Point(267, 316);
            this.InBow.Name = "InBow";
            this.InBow.Size = new System.Drawing.Size(58, 59);
            this.InBow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InBow.TabIndex = 26;
            this.InBow.TabStop = false;
            this.InBow.Visible = false;
            this.InBow.Click += new System.EventHandler(this.InBow_Click);
            // 
            // InPotionBlue
            // 
            this.InPotionBlue.BackColor = System.Drawing.Color.Transparent;
            this.InPotionBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InPotionBlue.Image = ((System.Drawing.Image)(resources.GetObject("InPotionBlue.Image")));
            this.InPotionBlue.Location = new System.Drawing.Point(331, 316);
            this.InPotionBlue.Name = "InPotionBlue";
            this.InPotionBlue.Size = new System.Drawing.Size(58, 59);
            this.InPotionBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InPotionBlue.TabIndex = 27;
            this.InPotionBlue.TabStop = false;
            this.InPotionBlue.Visible = false;
            this.InPotionBlue.Click += new System.EventHandler(this.InPotionBlue_Click);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(365, 102);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(31, 31);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 14;
            this.Player.TabStop = false;
            this.Player.Visible = false;
            // 
            // Background
            // 
            this.Background.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Background.BackgroundImage")));
            this.Background.Controls.Add(this.TelaPerder);
            this.Background.Controls.Add(this.TelaVencer);
            this.Background.Controls.Add(this.InPotionBlue);
            this.Background.Controls.Add(this.Player);
            this.Background.Controls.Add(this.InBow);
            this.Background.Controls.Add(this.Bat);
            this.Background.Controls.Add(this.InEspinhos);
            this.Background.Controls.Add(this.Ghost);
            this.Background.Controls.Add(this.InPotionRed);
            this.Background.Controls.Add(this.Ghoul);
            this.Background.Controls.Add(this.InSworld);
            this.Background.Controls.Add(this.Sworld);
            this.Background.Controls.Add(this.BluePotion);
            this.Background.Controls.Add(this.PotionRed);
            this.Background.Controls.Add(this.Bow);
            this.Background.Controls.Add(this.Espinhos);
            this.Background.Location = new System.Drawing.Point(2, 3);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(600, 400);
            this.Background.TabIndex = 28;
            // 
            // TelaPerder
            // 
            this.TelaPerder.Image = ((System.Drawing.Image)(resources.GetObject("TelaPerder.Image")));
            this.TelaPerder.Location = new System.Drawing.Point(0, 0);
            this.TelaPerder.Name = "TelaPerder";
            this.TelaPerder.Size = new System.Drawing.Size(600, 302);
            this.TelaPerder.TabIndex = 29;
            this.TelaPerder.TabStop = false;
            this.TelaPerder.Visible = false;
            // 
            // TelaVencer
            // 
            this.TelaVencer.Image = ((System.Drawing.Image)(resources.GetObject("TelaVencer.Image")));
            this.TelaVencer.Location = new System.Drawing.Point(0, 0);
            this.TelaVencer.Name = "TelaVencer";
            this.TelaVencer.Size = new System.Drawing.Size(603, 302);
            this.TelaVencer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TelaVencer.TabIndex = 28;
            this.TelaVencer.TabStop = false;
            this.TelaVencer.Visible = false;
            // 
            // buttonReiniciar
            // 
            this.buttonReiniciar.Location = new System.Drawing.Point(743, 292);
            this.buttonReiniciar.Name = "buttonReiniciar";
            this.buttonReiniciar.Size = new System.Drawing.Size(91, 39);
            this.buttonReiniciar.TabIndex = 30;
            this.buttonReiniciar.Text = "Reiniciar";
            this.buttonReiniciar.UseVisualStyleBackColor = true;
            this.buttonReiniciar.Visible = false;
            this.buttonReiniciar.Click += new System.EventHandler(this.buttonReiniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 407);
            this.Controls.Add(this.buttonReiniciar);
            this.Controls.Add(this.GhoulLife);
            this.Controls.Add(this.GhostLife);
            this.Controls.Add(this.BatLife);
            this.Controls.Add(this.PlayerLife);
            this.Controls.Add(this.TextGhoulLife);
            this.Controls.Add(this.TextGhostLife);
            this.Controls.Add(this.TextBatLife);
            this.Controls.Add(this.TextPlayerLife);
            this.Controls.Add(this.AttackBox);
            this.Controls.Add(this.MoveBox);
            this.Controls.Add(this.Background);
            this.Name = "Form1";
            this.Text = "The Quest";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.MoveBox.ResumeLayout(false);
            this.AttackBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sworld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PotionRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Espinhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InSworld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InPotionRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InEspinhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InPotionBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.Background.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TelaPerder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelaVencer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox MoveBox;
        private System.Windows.Forms.GroupBox AttackBox;
        private System.Windows.Forms.Button MUp;
        private System.Windows.Forms.Button MDown;
        private System.Windows.Forms.Button MRight;
        private System.Windows.Forms.Button MLeft;
        private System.Windows.Forms.Button ADown;
        private System.Windows.Forms.Button ARight;
        private System.Windows.Forms.Button ALeft;
        private System.Windows.Forms.Button AUp;
        private System.Windows.Forms.Label TextPlayerLife;
        private System.Windows.Forms.Label TextBatLife;
        private System.Windows.Forms.Label TextGhostLife;
        private System.Windows.Forms.Label TextGhoulLife;
        private System.Windows.Forms.Label PlayerLife;
        private System.Windows.Forms.Label BatLife;
        private System.Windows.Forms.Label GhostLife;
        private System.Windows.Forms.Label GhoulLife;
        private System.Windows.Forms.PictureBox Bat;
        private System.Windows.Forms.PictureBox Ghost;
        private System.Windows.Forms.PictureBox Ghoul;
        private System.Windows.Forms.PictureBox Sworld;
        private System.Windows.Forms.PictureBox PotionRed;
        private System.Windows.Forms.PictureBox Espinhos;
        private System.Windows.Forms.PictureBox Bow;
        private System.Windows.Forms.PictureBox BluePotion;
        private System.Windows.Forms.PictureBox InSworld;
        private System.Windows.Forms.PictureBox InPotionRed;
        private System.Windows.Forms.PictureBox InEspinhos;
        private System.Windows.Forms.PictureBox InBow;
        private System.Windows.Forms.PictureBox InPotionBlue;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Panel Background;
        private System.Windows.Forms.Button buttonReiniciar;
        private System.Windows.Forms.PictureBox TelaPerder;
        private System.Windows.Forms.PictureBox TelaVencer;
    }
}

