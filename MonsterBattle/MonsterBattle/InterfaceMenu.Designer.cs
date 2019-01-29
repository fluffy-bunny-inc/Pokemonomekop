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
            this.attackMenuButton.Location = new System.Drawing.Point(50, 3);
            this.attackMenuButton.Name = "attackMenuButton";
            this.attackMenuButton.Size = new System.Drawing.Size(427, 33);
            this.attackMenuButton.TabIndex = 0;
            this.attackMenuButton.Text = "Attack";
            this.attackMenuButton.UseVisualStyleBackColor = true;
            // 
            // inventoryMenuButton
            // 
            this.inventoryMenuButton.Location = new System.Drawing.Point(50, 42);
            this.inventoryMenuButton.Name = "inventoryMenuButton";
            this.inventoryMenuButton.Size = new System.Drawing.Size(427, 33);
            this.inventoryMenuButton.TabIndex = 1;
            this.inventoryMenuButton.Text = "Inventory";
            this.inventoryMenuButton.UseVisualStyleBackColor = true;
            // 
            // pokemonSwitchMenuButton
            // 
            this.pokemonSwitchMenuButton.Location = new System.Drawing.Point(3, 3);
            this.pokemonSwitchMenuButton.Name = "pokemonSwitchMenuButton";
            this.pokemonSwitchMenuButton.Size = new System.Drawing.Size(41, 72);
            this.pokemonSwitchMenuButton.TabIndex = 2;
            this.pokemonSwitchMenuButton.Text = "Switch";
            this.pokemonSwitchMenuButton.UseVisualStyleBackColor = true;
            // 
            // InterfaceMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pokemonSwitchMenuButton);
            this.Controls.Add(this.inventoryMenuButton);
            this.Controls.Add(this.attackMenuButton);
            this.Name = "InterfaceMenu";
            this.Size = new System.Drawing.Size(480, 78);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button attackMenuButton;
        private System.Windows.Forms.Button inventoryMenuButton;
        private System.Windows.Forms.Button pokemonSwitchMenuButton;
    }
}
