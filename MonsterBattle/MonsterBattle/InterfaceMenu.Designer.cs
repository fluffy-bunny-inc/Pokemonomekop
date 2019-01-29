namespace MonsterBattle
{
    partial class InterfaceMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.attackMenuButton = new System.Windows.Forms.Button();
            this.inventoryMenuButton = new System.Windows.Forms.Button();
            this.pokemonSwitchMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // attackMenuButton
            // 
            this.attackMenuButton.Location = new System.Drawing.Point(67, 4);
            this.attackMenuButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.attackMenuButton.Name = "attackMenuButton";
            this.attackMenuButton.Size = new System.Drawing.Size(569, 41);
            this.attackMenuButton.TabIndex = 0;
            this.attackMenuButton.Text = "Attack";
            this.attackMenuButton.UseVisualStyleBackColor = true;
            // 
            // inventoryMenuButton
            // 
            this.inventoryMenuButton.Location = new System.Drawing.Point(67, 52);
            this.inventoryMenuButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inventoryMenuButton.Name = "inventoryMenuButton";
            this.inventoryMenuButton.Size = new System.Drawing.Size(569, 41);
            this.inventoryMenuButton.TabIndex = 1;
            this.inventoryMenuButton.Text = "Inventory";
            this.inventoryMenuButton.UseVisualStyleBackColor = true;
            // 
            // pokemonSwitchMenuButton
            // 
            this.pokemonSwitchMenuButton.Location = new System.Drawing.Point(4, 4);
            this.pokemonSwitchMenuButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pokemonSwitchMenuButton.Name = "pokemonSwitchMenuButton";
            this.pokemonSwitchMenuButton.Size = new System.Drawing.Size(55, 89);
            this.pokemonSwitchMenuButton.TabIndex = 2;
            this.pokemonSwitchMenuButton.Text = "Switch";
            this.pokemonSwitchMenuButton.UseVisualStyleBackColor = true;
            this.pokemonSwitchMenuButton.Click += new System.EventHandler(this.pokemonSwitchMenuButton_Click);
            // 
            // InterfaceMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pokemonSwitchMenuButton);
            this.Controls.Add(this.inventoryMenuButton);
            this.Controls.Add(this.attackMenuButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InterfaceMenu";
            this.Size = new System.Drawing.Size(640, 96);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button attackMenuButton;
        private System.Windows.Forms.Button inventoryMenuButton;
        private System.Windows.Forms.Button pokemonSwitchMenuButton;
    }
}
