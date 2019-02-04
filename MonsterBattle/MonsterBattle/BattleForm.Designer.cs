namespace MonsterBattle
{
    partial class BattleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleForm));
            this.attackButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ownHealthBar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.enemyLevel = new System.Windows.Forms.Label();
            this.enemyHealthPictureBox = new System.Windows.Forms.PictureBox();
            this.enemyPictureBox = new System.Windows.Forms.PictureBox();
            this.friendlyPictureBox = new System.Windows.Forms.PictureBox();
            this.attackTimer = new System.Windows.Forms.Timer(this.components);
            this.screenShakeTimer = new System.Windows.Forms.Timer(this.components);
            this.backButton = new System.Windows.Forms.Button();
            this.attackTwoButton = new System.Windows.Forms.Button();
            this.attackThreeButton = new System.Windows.Forms.Button();
            this.attackOneButton = new System.Windows.Forms.Button();
            this.AttackMenuPannel = new System.Windows.Forms.Panel();
            this.MenuPannel = new System.Windows.Forms.Panel();
            this.hyperPotionButton = new System.Windows.Forms.Button();
            this.invetoryBackButton = new System.Windows.Forms.Button();
            this.reviveButton = new System.Windows.Forms.Button();
            this.maxPotionButton = new System.Windows.Forms.Button();
            this.InventoryPannel = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownHealthBar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyHealthPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendlyPictureBox)).BeginInit();
            this.AttackMenuPannel.SuspendLayout();
            this.MenuPannel.SuspendLayout();
            this.InventoryPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // attackButton
            // 
            this.attackButton.Location = new System.Drawing.Point(64, 82);
            this.attackButton.Margin = new System.Windows.Forms.Padding(4);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(253, 75);
            this.attackButton.TabIndex = 1;
            this.attackButton.Text = "Lightningstrike";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.enemyPictureBox);
            this.panel1.Controls.Add(this.friendlyPictureBox);
            this.panel1.Controls.Add(this.attackButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 276);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.ownHealthBar);
            this.panel3.Location = new System.Drawing.Point(340, 207);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 65);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "1";
            // 
            // ownHealthBar
            // 
            this.ownHealthBar.BackColor = System.Drawing.Color.Transparent;
            this.ownHealthBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ownHealthBar.Image = ((System.Drawing.Image)(resources.GetObject("ownHealthBar.Image")));
            this.ownHealthBar.Location = new System.Drawing.Point(116, 30);
            this.ownHealthBar.Margin = new System.Windows.Forms.Padding(4);
            this.ownHealthBar.Name = "ownHealthBar";
            this.ownHealthBar.Size = new System.Drawing.Size(120, 6);
            this.ownHealthBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ownHealthBar.TabIndex = 5;
            this.ownHealthBar.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.enemyLevel);
            this.panel2.Controls.Add(this.enemyHealthPictureBox);
            this.panel2.Location = new System.Drawing.Point(16, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 60);
            this.panel2.TabIndex = 2;
            // 
            // enemyLevel
            // 
            this.enemyLevel.AutoSize = true;
            this.enemyLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyLevel.Location = new System.Drawing.Point(204, 11);
            this.enemyLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enemyLevel.Name = "enemyLevel";
            this.enemyLevel.Size = new System.Drawing.Size(17, 17);
            this.enemyLevel.TabIndex = 4;
            this.enemyLevel.Text = "1";
            // 
            // enemyHealthPictureBox
            // 
            this.enemyHealthPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.enemyHealthPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.enemyHealthPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("enemyHealthPictureBox.Image")));
            this.enemyHealthPictureBox.Location = new System.Drawing.Point(99, 34);
            this.enemyHealthPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.enemyHealthPictureBox.Name = "enemyHealthPictureBox";
            this.enemyHealthPictureBox.Size = new System.Drawing.Size(120, 6);
            this.enemyHealthPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyHealthPictureBox.TabIndex = 4;
            this.enemyHealthPictureBox.TabStop = false;
            // 
            // enemyPictureBox
            // 
            this.enemyPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.enemyPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.enemyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("enemyPictureBox.Image")));
            this.enemyPictureBox.Location = new System.Drawing.Point(385, 15);
            this.enemyPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.enemyPictureBox.Name = "enemyPictureBox";
            this.enemyPictureBox.Size = new System.Drawing.Size(171, 153);
            this.enemyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyPictureBox.TabIndex = 1;
            this.enemyPictureBox.TabStop = false;
            // 
            // friendlyPictureBox
            // 
            this.friendlyPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.friendlyPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.friendlyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("friendlyPictureBox.Image")));
            this.friendlyPictureBox.Location = new System.Drawing.Point(79, 175);
            this.friendlyPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.friendlyPictureBox.Name = "friendlyPictureBox";
            this.friendlyPictureBox.Size = new System.Drawing.Size(149, 101);
            this.friendlyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.friendlyPictureBox.TabIndex = 0;
            this.friendlyPictureBox.TabStop = false;
            // 
            // attackTimer
            // 
            this.attackTimer.Interval = 1000;
            this.attackTimer.Tick += new System.EventHandler(this.attackTimer_Tick);
            // 
            // screenShakeTimer
            // 
            this.screenShakeTimer.Interval = 50;
            this.screenShakeTimer.Tick += new System.EventHandler(this.screenShakeTimer_Tick);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(4, 50);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(313, 42);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // attackTwoButton
            // 
            this.attackTwoButton.Location = new System.Drawing.Point(323, 4);
            this.attackTwoButton.Margin = new System.Windows.Forms.Padding(4);
            this.attackTwoButton.Name = "attackTwoButton";
            this.attackTwoButton.Size = new System.Drawing.Size(313, 42);
            this.attackTwoButton.TabIndex = 7;
            this.attackTwoButton.UseVisualStyleBackColor = true;
            // 
            // attackThreeButton
            // 
            this.attackThreeButton.Location = new System.Drawing.Point(323, 50);
            this.attackThreeButton.Margin = new System.Windows.Forms.Padding(4);
            this.attackThreeButton.Name = "attackThreeButton";
            this.attackThreeButton.Size = new System.Drawing.Size(313, 42);
            this.attackThreeButton.TabIndex = 6;
            this.attackThreeButton.UseVisualStyleBackColor = true;
            // 
            // attackOneButton
            // 
            this.attackOneButton.Location = new System.Drawing.Point(4, 4);
            this.attackOneButton.Margin = new System.Windows.Forms.Padding(4);
            this.attackOneButton.Name = "attackOneButton";
            this.attackOneButton.Size = new System.Drawing.Size(313, 42);
            this.attackOneButton.TabIndex = 5;
            this.attackOneButton.UseVisualStyleBackColor = true;
            // 
            // AttackMenuPannel
            // 
            this.AttackMenuPannel.Controls.Add(this.MenuPannel);
            this.AttackMenuPannel.Controls.Add(this.attackOneButton);
            this.AttackMenuPannel.Controls.Add(this.backButton);
            this.AttackMenuPannel.Controls.Add(this.attackThreeButton);
            this.AttackMenuPannel.Controls.Add(this.attackTwoButton);
            this.AttackMenuPannel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AttackMenuPannel.Location = new System.Drawing.Point(0, 273);
            this.AttackMenuPannel.Margin = new System.Windows.Forms.Padding(4);
            this.AttackMenuPannel.Name = "AttackMenuPannel";
            this.AttackMenuPannel.Size = new System.Drawing.Size(641, 100);
            this.AttackMenuPannel.TabIndex = 9;
            // 
            // MenuPannel
            // 
            this.MenuPannel.Controls.Add(this.hyperPotionButton);
            this.MenuPannel.Controls.Add(this.invetoryBackButton);
            this.MenuPannel.Controls.Add(this.reviveButton);
            this.MenuPannel.Controls.Add(this.maxPotionButton);
            this.MenuPannel.Controls.Add(this.InventoryPannel);
            this.MenuPannel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuPannel.Location = new System.Drawing.Point(0, 0);
            this.MenuPannel.Margin = new System.Windows.Forms.Padding(4);
            this.MenuPannel.Name = "MenuPannel";
            this.MenuPannel.Size = new System.Drawing.Size(641, 100);
            this.MenuPannel.TabIndex = 10;
            // 
            // hyperPotionButton
            // 
            this.hyperPotionButton.Location = new System.Drawing.Point(4, 4);
            this.hyperPotionButton.Margin = new System.Windows.Forms.Padding(4);
            this.hyperPotionButton.Name = "hyperPotionButton";
            this.hyperPotionButton.Size = new System.Drawing.Size(313, 42);
            this.hyperPotionButton.TabIndex = 5;
            this.hyperPotionButton.Text = "Hyper potion";
            this.hyperPotionButton.UseVisualStyleBackColor = true;
            this.hyperPotionButton.Click += new System.EventHandler(this.hyperPotionButton_Click);
            // 
            // invetoryBackButton
            // 
            this.invetoryBackButton.Location = new System.Drawing.Point(4, 50);
            this.invetoryBackButton.Margin = new System.Windows.Forms.Padding(4);
            this.invetoryBackButton.Name = "invetoryBackButton";
            this.invetoryBackButton.Size = new System.Drawing.Size(313, 42);
            this.invetoryBackButton.TabIndex = 8;
            this.invetoryBackButton.Text = "Back";
            this.invetoryBackButton.UseVisualStyleBackColor = true;
            this.invetoryBackButton.Click += new System.EventHandler(this.invetoryBackButton_Click);
            // 
            // reviveButton
            // 
            this.reviveButton.Location = new System.Drawing.Point(323, 50);
            this.reviveButton.Margin = new System.Windows.Forms.Padding(4);
            this.reviveButton.Name = "reviveButton";
            this.reviveButton.Size = new System.Drawing.Size(313, 42);
            this.reviveButton.TabIndex = 6;
            this.reviveButton.Text = "Revive";
            this.reviveButton.UseVisualStyleBackColor = true;
            // 
            // maxPotionButton
            // 
            this.maxPotionButton.Location = new System.Drawing.Point(323, 4);
            this.maxPotionButton.Margin = new System.Windows.Forms.Padding(4);
            this.maxPotionButton.Name = "maxPotionButton";
            this.maxPotionButton.Size = new System.Drawing.Size(313, 42);
            this.maxPotionButton.TabIndex = 7;
            this.maxPotionButton.Text = "Max potion";
            this.maxPotionButton.UseVisualStyleBackColor = true;
            this.maxPotionButton.Click += new System.EventHandler(this.maxPotionButton_Click);
            // 
            // InventoryPannel
            // 
            this.InventoryPannel.Controls.Add(this.button5);
            this.InventoryPannel.Controls.Add(this.button6);
            this.InventoryPannel.Controls.Add(this.button7);
            this.InventoryPannel.Controls.Add(this.button8);
            this.InventoryPannel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InventoryPannel.Location = new System.Drawing.Point(0, 0);
            this.InventoryPannel.Margin = new System.Windows.Forms.Padding(4);
            this.InventoryPannel.Name = "InventoryPannel";
            this.InventoryPannel.Size = new System.Drawing.Size(641, 100);
            this.InventoryPannel.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(4, 4);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(313, 42);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(4, 50);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(313, 42);
            this.button6.TabIndex = 8;
            this.button6.Text = "Back";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(323, 50);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(313, 42);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(323, 4);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(313, 42);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 373);
            this.Controls.Add(this.AttackMenuPannel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BattleForm";
            this.Text = "Pokemon Battle";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownHealthBar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyHealthPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendlyPictureBox)).EndInit();
            this.AttackMenuPannel.ResumeLayout(false);
            this.MenuPannel.ResumeLayout(false);
            this.InventoryPannel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox friendlyPictureBox;
        private System.Windows.Forms.PictureBox enemyPictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox enemyHealthPictureBox;
        private System.Windows.Forms.PictureBox ownHealthBar;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Timer attackTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label enemyLevel;
        private System.Windows.Forms.Timer screenShakeTimer;
        private System.Windows.Forms.Button attackOneButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button attackThreeButton;
        private System.Windows.Forms.Button attackTwoButton;
        private System.Windows.Forms.Panel AttackMenuPannel;
        private System.Windows.Forms.Panel MenuPannel;
        private System.Windows.Forms.Button hyperPotionButton;
        private System.Windows.Forms.Button invetoryBackButton;
        private System.Windows.Forms.Button reviveButton;
        private System.Windows.Forms.Button maxPotionButton;
        private System.Windows.Forms.Panel InventoryPannel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

