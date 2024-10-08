using InlämningsUppgift2.Classes;

namespace InlämningsUppgift2
{
    public partial class FormGame : Form
    {
        public FormGame()
        {
            InitializeComponent();
            UpdateLabelAndTextBox();
        }

        private void buttonShoot_Click(object sender, EventArgs e)
        {
            Computer.ComputerDecision();
            Player.Shoot();
            Logic.OutCome();
            UpdateLabelAndTextBox();
            Buttons();
            GameOver();
        }

        private void buttonBlock_Click(object sender, EventArgs e)
        {
            Computer.ComputerDecision();
            Player.Block();
            Logic.OutCome();
            UpdateLabelAndTextBox();
            Buttons();
            GameOver();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            Computer.ComputerDecision();
            Player.Load();
            Logic.OutCome();
            UpdateLabelAndTextBox();
            Buttons();
            GameOver();
        }

        private void buttonShotgun_Click(object sender, EventArgs e)
        {
            Computer.ComputerDecision();
            Player.Shotgun();
            Logic.OutCome();
            UpdateLabelAndTextBox();
            GameOver();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }


        private void GameOver()
        {
            if (Logic.gameOver == true)
            {
                buttonNewGame.Visible = true;
                buttonShoot.Visible = false;
                buttonBlock.Visible = false;
                buttonLoad.Visible = false;
            }
        }

        private void NewGame()
        {
            Logic.NewGame();
            UpdateLabelAndTextBox();
            buttonNewGame.Visible = false;
            textBoxResults.Clear();
            Buttons();
        }
        private void Buttons()
        {
            if (Logic.gameOver == false && Logic.playerAmmo == 0)
            {
                buttonShoot.Visible = false;
                buttonBlock.Visible = true;
                buttonLoad.Visible = true;
                buttonShotgun.Visible = false;
            }
            else if (Logic.playerAmmo == 0)
            {
                buttonShoot.Visible = false;
                buttonShotgun.Visible = false;
            }
            else if (Logic.playerAmmo >= 3)
            {
                buttonShotgun.Visible = true;
            }
            else if (Logic.playerAmmo >= 1)
            {
                buttonShoot.Visible = true;
            }
        }
        private void UpdateLabelAndTextBox()
        {
            labelPlayerAmmo.Text = "Ammo: " + Logic.playerAmmo.ToString();
            labelComputerAmmo.Text = "Ammo: " + Logic.computerAmmo.ToString();
            textBoxResults.Text = Logic.outcome;

        }
    }
}
