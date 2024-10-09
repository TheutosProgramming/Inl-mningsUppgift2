namespace InlämningsUppgift2
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            buttonShoot = new Button();
            buttonBlock = new Button();
            buttonLoad = new Button();
            labelPlayer = new Label();
            labelComputer = new Label();
            buttonShotgun = new Button();
            labelPlayerAmmo = new Label();
            labelComputerAmmo = new Label();
            textBoxResults = new TextBox();
            buttonNewGame = new Button();
            pictureBoxCompShoot = new PictureBox();
            pictureBoxCompDefence = new PictureBox();
            pictureBoxCompLoad = new PictureBox();
            pictureBoxYouLose = new PictureBox();
            pictureBoxYouWin = new PictureBox();
            pictureBoxCompShotgun = new PictureBox();
            pictureBoxDraw = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCompShoot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCompDefence).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCompLoad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxYouLose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxYouWin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCompShotgun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDraw).BeginInit();
            SuspendLayout();
            // 
            // buttonShoot
            // 
            buttonShoot.BackgroundImage = (Image)resources.GetObject("buttonShoot.BackgroundImage");
            buttonShoot.Location = new Point(12, 265);
            buttonShoot.Name = "buttonShoot";
            buttonShoot.Size = new Size(149, 85);
            buttonShoot.TabIndex = 0;
            buttonShoot.Text = "Skjut";
            buttonShoot.UseVisualStyleBackColor = true;
            buttonShoot.Click += buttonShoot_Click;
            // 
            // buttonBlock
            // 
            buttonBlock.BackgroundImage = (Image)resources.GetObject("buttonBlock.BackgroundImage");
            buttonBlock.Location = new Point(87, 179);
            buttonBlock.Name = "buttonBlock";
            buttonBlock.Size = new Size(74, 80);
            buttonBlock.TabIndex = 1;
            buttonBlock.Text = "Blocka";
            buttonBlock.UseVisualStyleBackColor = true;
            buttonBlock.Click += buttonBlock_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.BackgroundImage = (Image)resources.GetObject("buttonLoad.BackgroundImage");
            buttonLoad.Location = new Point(12, 179);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(69, 80);
            buttonLoad.TabIndex = 2;
            buttonLoad.Text = "Ladda";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // labelPlayer
            // 
            labelPlayer.AutoSize = true;
            labelPlayer.Location = new Point(167, 131);
            labelPlayer.Name = "labelPlayer";
            labelPlayer.Size = new Size(39, 15);
            labelPlayer.TabIndex = 4;
            labelPlayer.Text = "Player";
            // 
            // labelComputer
            // 
            labelComputer.AutoSize = true;
            labelComputer.Location = new Point(343, 131);
            labelComputer.Name = "labelComputer";
            labelComputer.Size = new Size(61, 15);
            labelComputer.TabIndex = 5;
            labelComputer.Text = "Computer";
            // 
            // buttonShotgun
            // 
            buttonShotgun.BackgroundImage = (Image)resources.GetObject("buttonShotgun.BackgroundImage");
            buttonShotgun.Location = new Point(167, 199);
            buttonShotgun.Name = "buttonShotgun";
            buttonShotgun.Size = new Size(237, 151);
            buttonShotgun.TabIndex = 6;
            buttonShotgun.Text = "Shotgun";
            buttonShotgun.UseVisualStyleBackColor = true;
            buttonShotgun.Click += buttonShotgun_Click;
            // 
            // labelPlayerAmmo
            // 
            labelPlayerAmmo.AutoSize = true;
            labelPlayerAmmo.Location = new Point(167, 116);
            labelPlayerAmmo.Name = "labelPlayerAmmo";
            labelPlayerAmmo.Size = new Size(56, 15);
            labelPlayerAmmo.TabIndex = 7;
            labelPlayerAmmo.Text = "Ammo: 0";
            // 
            // labelComputerAmmo
            // 
            labelComputerAmmo.AutoSize = true;
            labelComputerAmmo.Location = new Point(348, 116);
            labelComputerAmmo.Name = "labelComputerAmmo";
            labelComputerAmmo.Size = new Size(56, 15);
            labelComputerAmmo.TabIndex = 8;
            labelComputerAmmo.Text = "Ammo: 0";
            // 
            // textBoxResults
            // 
            textBoxResults.Location = new Point(167, 149);
            textBoxResults.Multiline = true;
            textBoxResults.Name = "textBoxResults";
            textBoxResults.ReadOnly = true;
            textBoxResults.Size = new Size(237, 42);
            textBoxResults.TabIndex = 9;
            // 
            // buttonNewGame
            // 
            buttonNewGame.Location = new Point(167, 197);
            buttonNewGame.Name = "buttonNewGame";
            buttonNewGame.Size = new Size(237, 52);
            buttonNewGame.TabIndex = 10;
            buttonNewGame.Text = "Nytt spel";
            buttonNewGame.UseVisualStyleBackColor = true;
            buttonNewGame.Click += buttonNewGame_Click;
            // 
            // pictureBoxCompShoot
            // 
            pictureBoxCompShoot.BackgroundImage = (Image)resources.GetObject("pictureBoxCompShoot.BackgroundImage");
            pictureBoxCompShoot.Location = new Point(425, 270);
            pictureBoxCompShoot.Name = "pictureBoxCompShoot";
            pictureBoxCompShoot.Size = new Size(105, 80);
            pictureBoxCompShoot.TabIndex = 11;
            pictureBoxCompShoot.TabStop = false;
            // 
            // pictureBoxCompDefence
            // 
            pictureBoxCompDefence.BackgroundImage = (Image)resources.GetObject("pictureBoxCompDefence.BackgroundImage");
            pictureBoxCompDefence.Location = new Point(536, 204);
            pictureBoxCompDefence.Name = "pictureBoxCompDefence";
            pictureBoxCompDefence.Size = new Size(100, 146);
            pictureBoxCompDefence.TabIndex = 12;
            pictureBoxCompDefence.TabStop = false;
            // 
            // pictureBoxCompLoad
            // 
            pictureBoxCompLoad.BackgroundImage = (Image)resources.GetObject("pictureBoxCompLoad.BackgroundImage");
            pictureBoxCompLoad.Location = new Point(435, 184);
            pictureBoxCompLoad.Name = "pictureBoxCompLoad";
            pictureBoxCompLoad.Size = new Size(86, 80);
            pictureBoxCompLoad.TabIndex = 13;
            pictureBoxCompLoad.TabStop = false;
            // 
            // pictureBoxYouLose
            // 
            pictureBoxYouLose.BackgroundImage = (Image)resources.GetObject("pictureBoxYouLose.BackgroundImage");
            pictureBoxYouLose.Location = new Point(167, 10);
            pictureBoxYouLose.Name = "pictureBoxYouLose";
            pictureBoxYouLose.Size = new Size(237, 103);
            pictureBoxYouLose.TabIndex = 14;
            pictureBoxYouLose.TabStop = false;
            // 
            // pictureBoxYouWin
            // 
            pictureBoxYouWin.BackgroundImage = (Image)resources.GetObject("pictureBoxYouWin.BackgroundImage");
            pictureBoxYouWin.Location = new Point(167, 10);
            pictureBoxYouWin.Name = "pictureBoxYouWin";
            pictureBoxYouWin.Size = new Size(237, 103);
            pictureBoxYouWin.TabIndex = 15;
            pictureBoxYouWin.TabStop = false;
            // 
            // pictureBoxCompShotgun
            // 
            pictureBoxCompShotgun.BackgroundImage = (Image)resources.GetObject("pictureBoxCompShotgun.BackgroundImage");
            pictureBoxCompShotgun.Location = new Point(410, 147);
            pictureBoxCompShotgun.Name = "pictureBoxCompShotgun";
            pictureBoxCompShotgun.Size = new Size(229, 203);
            pictureBoxCompShotgun.TabIndex = 16;
            pictureBoxCompShotgun.TabStop = false;
            // 
            // pictureBoxDraw
            // 
            pictureBoxDraw.Image = (Image)resources.GetObject("pictureBoxDraw.Image");
            pictureBoxDraw.Location = new Point(167, 10);
            pictureBoxDraw.Name = "pictureBoxDraw";
            pictureBoxDraw.Size = new Size(237, 103);
            pictureBoxDraw.TabIndex = 17;
            pictureBoxDraw.TabStop = false;
            // 
            // FormGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 357);
            Controls.Add(pictureBoxDraw);
            Controls.Add(pictureBoxCompShotgun);
            Controls.Add(pictureBoxYouWin);
            Controls.Add(pictureBoxYouLose);
            Controls.Add(pictureBoxCompLoad);
            Controls.Add(pictureBoxCompDefence);
            Controls.Add(pictureBoxCompShoot);
            Controls.Add(buttonNewGame);
            Controls.Add(textBoxResults);
            Controls.Add(labelComputerAmmo);
            Controls.Add(labelPlayerAmmo);
            Controls.Add(buttonShotgun);
            Controls.Add(labelComputer);
            Controls.Add(labelPlayer);
            Controls.Add(buttonLoad);
            Controls.Add(buttonBlock);
            Controls.Add(buttonShoot);
            Name = "FormGame";
            Text = "Shotgun";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCompShoot).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCompDefence).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCompLoad).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxYouLose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxYouWin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCompShotgun).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDraw).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonShoot;
        private Button buttonBlock;
        private Button buttonLoad;
        private Label labelPlayer;
        private Label labelComputer;
        private TextBox textBox1;
        private Button buttonShotgun;
        private Label labelPlayerAmmo;
        private Label labelComputerAmmo;
        private TextBox textBoxResults;
        private Button buttonNewGame;
        private PictureBox pictureBoxCompShoot;
        private PictureBox pictureBoxCompDefence;
        private PictureBox pictureBoxCompLoad;
        private PictureBox pictureBoxYouLose;
        private PictureBox pictureBoxYouWin;
        private PictureBox pictureBoxCompShotgun;
        private PictureBox pictureBoxDraw;
    }
}
