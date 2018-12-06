namespace PathfinderGameTool
{
    partial class FormBeginMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNewCharacterSheet = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNewCharacterSheet
            // 
            this.buttonNewCharacterSheet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNewCharacterSheet.FlatAppearance.BorderSize = 0;
            this.buttonNewCharacterSheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewCharacterSheet.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewCharacterSheet.ForeColor = System.Drawing.Color.White;
            this.buttonNewCharacterSheet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNewCharacterSheet.Location = new System.Drawing.Point(12, 12);
            this.buttonNewCharacterSheet.Name = "buttonNewCharacterSheet";
            this.buttonNewCharacterSheet.Size = new System.Drawing.Size(138, 45);
            this.buttonNewCharacterSheet.TabIndex = 7;
            this.buttonNewCharacterSheet.Text = "New character sheet";
            this.buttonNewCharacterSheet.UseVisualStyleBackColor = true;
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNewGame.FlatAppearance.BorderSize = 0;
            this.buttonNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewGame.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewGame.ForeColor = System.Drawing.Color.White;
            this.buttonNewGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNewGame.Location = new System.Drawing.Point(12, 63);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(137, 45);
            this.buttonNewGame.TabIndex = 8;
            this.buttonNewGame.Text = "New game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "Continue game";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormBeginMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(164, 171);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.buttonNewCharacterSheet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBeginMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "PathFinderGameTool";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNewCharacterSheet;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button button2;
    }
}

