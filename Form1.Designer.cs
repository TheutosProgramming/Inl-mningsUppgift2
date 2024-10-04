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
            buttonShoot = new Button();
            buttonBlock = new Button();
            buttonLoad = new Button();
            labelPlayer = new Label();
            labelComputer = new Label();
            listBoxResults = new ListBox();
            buttonShotgun = new Button();
            labelPlayerAmmo = new Label();
            labelComputerAmmo = new Label();
            SuspendLayout();
            // 
            // buttonShoot
            // 
            buttonShoot.Location = new Point(208, 194);
            buttonShoot.Name = "buttonShoot";
            buttonShoot.Size = new Size(75, 23);
            buttonShoot.TabIndex = 0;
            buttonShoot.Text = "Skjut";
            buttonShoot.UseVisualStyleBackColor = true;
            buttonShoot.Click += buttonShoot_Click;
            // 
            // buttonBlock
            // 
            buttonBlock.Location = new Point(289, 194);
            buttonBlock.Name = "buttonBlock";
            buttonBlock.Size = new Size(75, 23);
            buttonBlock.TabIndex = 1;
            buttonBlock.Text = "Blocka";
            buttonBlock.UseVisualStyleBackColor = true;
            buttonBlock.Click += buttonBlock_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(370, 194);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(75, 23);
            buttonLoad.TabIndex = 2;
            buttonLoad.Text = "Ladda";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // labelPlayer
            // 
            labelPlayer.AutoSize = true;
            labelPlayer.Location = new Point(207, 46);
            labelPlayer.Name = "labelPlayer";
            labelPlayer.Size = new Size(39, 15);
            labelPlayer.TabIndex = 4;
            labelPlayer.Text = "Player";
            // 
            // labelComputer
            // 
            labelComputer.AutoSize = true;
            labelComputer.Location = new Point(384, 44);
            labelComputer.Name = "labelComputer";
            labelComputer.Size = new Size(61, 15);
            labelComputer.TabIndex = 5;
            labelComputer.Text = "Computer";
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.ItemHeight = 15;
            listBoxResults.Location = new Point(208, 64);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(237, 124);
            listBoxResults.TabIndex = 3;
            // 
            // buttonShotgun
            // 
            buttonShotgun.Location = new Point(208, 223);
            buttonShotgun.Name = "buttonShotgun";
            buttonShotgun.Size = new Size(237, 23);
            buttonShotgun.TabIndex = 6;
            buttonShotgun.Text = "Shotgun";
            buttonShotgun.UseVisualStyleBackColor = true;
            buttonShotgun.Click += buttonShotgun_Click;
            // 
            // labelPlayerAmmo
            // 
            labelPlayerAmmo.AutoSize = true;
            labelPlayerAmmo.Location = new Point(208, 29);
            labelPlayerAmmo.Name = "labelPlayerAmmo";
            labelPlayerAmmo.Size = new Size(38, 15);
            labelPlayerAmmo.TabIndex = 7;
            labelPlayerAmmo.Text = "label1";
            // 
            // labelComputerAmmo
            // 
            labelComputerAmmo.AutoSize = true;
            labelComputerAmmo.Location = new Point(407, 29);
            labelComputerAmmo.Name = "labelComputerAmmo";
            labelComputerAmmo.Size = new Size(38, 15);
            labelComputerAmmo.TabIndex = 8;
            labelComputerAmmo.Text = "label2";
            // 
            // FormGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelComputerAmmo);
            Controls.Add(labelPlayerAmmo);
            Controls.Add(buttonShotgun);
            Controls.Add(labelComputer);
            Controls.Add(labelPlayer);
            Controls.Add(listBoxResults);
            Controls.Add(buttonLoad);
            Controls.Add(buttonBlock);
            Controls.Add(buttonShoot);
            Name = "FormGame";
            Text = "Shotgun";
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
        private ListBox listBoxResults;
        private Button buttonShotgun;
        private Label labelPlayerAmmo;
        private Label labelComputerAmmo;
    }
}
