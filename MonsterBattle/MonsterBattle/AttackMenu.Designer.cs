namespace MonsterBattle
{
    partial class AttackMenu
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
            this.attackOneButton = new System.Windows.Forms.Button();
            this.attackThreeButton = new System.Windows.Forms.Button();
            this.attackTwoButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // attackOneButton
            // 
            this.attackOneButton.Location = new System.Drawing.Point(3, 3);
            this.attackOneButton.Name = "attackOneButton";
            this.attackOneButton.Size = new System.Drawing.Size(235, 34);
            this.attackOneButton.TabIndex = 1;
            this.attackOneButton.UseVisualStyleBackColor = true;
            // 
            // attackThreeButton
            // 
            this.attackThreeButton.Location = new System.Drawing.Point(242, 41);
            this.attackThreeButton.Name = "attackThreeButton";
            this.attackThreeButton.Size = new System.Drawing.Size(235, 34);
            this.attackThreeButton.TabIndex = 2;
            this.attackThreeButton.UseVisualStyleBackColor = true;
            // 
            // attackTwoButton
            // 
            this.attackTwoButton.Location = new System.Drawing.Point(242, 3);
            this.attackTwoButton.Name = "attackTwoButton";
            this.attackTwoButton.Size = new System.Drawing.Size(235, 34);
            this.attackTwoButton.TabIndex = 3;
            this.attackTwoButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(3, 41);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(235, 34);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // AttackMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.attackTwoButton);
            this.Controls.Add(this.attackThreeButton);
            this.Controls.Add(this.attackOneButton);
            this.Name = "AttackMenu";
            this.Size = new System.Drawing.Size(480, 78);
            this.Load += new System.EventHandler(this.AttackMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button attackOneButton;
        private System.Windows.Forms.Button attackThreeButton;
        private System.Windows.Forms.Button attackTwoButton;
        private System.Windows.Forms.Button backButton;
    }
}
