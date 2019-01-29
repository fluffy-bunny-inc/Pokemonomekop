namespace MonsterBattle
{
    partial class InvetoryMenu
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
            this.hyperPotionButton = new System.Windows.Forms.Button();
            this.maxPotionButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.reviveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hyperPotionButton
            // 
            this.hyperPotionButton.Location = new System.Drawing.Point(4, 4);
            this.hyperPotionButton.Name = "hyperPotionButton";
            this.hyperPotionButton.Size = new System.Drawing.Size(235, 34);
            this.hyperPotionButton.TabIndex = 0;
            this.hyperPotionButton.Text = "Hyper Potion";
            this.hyperPotionButton.UseVisualStyleBackColor = true;
            // 
            // maxPotionButton
            // 
            this.maxPotionButton.Location = new System.Drawing.Point(242, 4);
            this.maxPotionButton.Name = "maxPotionButton";
            this.maxPotionButton.Size = new System.Drawing.Size(235, 34);
            this.maxPotionButton.TabIndex = 1;
            this.maxPotionButton.Text = "Max Potion";
            this.maxPotionButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(4, 41);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(235, 34);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // reviveButton
            // 
            this.reviveButton.Location = new System.Drawing.Point(242, 41);
            this.reviveButton.Name = "reviveButton";
            this.reviveButton.Size = new System.Drawing.Size(235, 34);
            this.reviveButton.TabIndex = 3;
            this.reviveButton.Text = "Revive";
            this.reviveButton.UseVisualStyleBackColor = true;
            // 
            // InvetoryMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reviveButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.maxPotionButton);
            this.Controls.Add(this.hyperPotionButton);
            this.Name = "InvetoryMenu";
            this.Size = new System.Drawing.Size(480, 78);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hyperPotionButton;
        private System.Windows.Forms.Button maxPotionButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button reviveButton;
    }
}
