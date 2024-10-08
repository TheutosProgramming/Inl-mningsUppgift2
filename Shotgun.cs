using InlämningsUppgift2.Classes;

namespace InlämningsUppgift2
{
    public partial class FormGame : Form
    {
        public FormGame()
        {
            InitializeComponent();
            UpdateLabel();
        }

        private void buttonShoot_Click(object sender, EventArgs e)
        {
            Computer.ComputerDecision();
            Player.Shoot();
            Logic.OutCome();
            UpdateLabel();
            textBoxResults.Text = Logic.outcome;
            Buttons();
            GameOver();
        }

        private void buttonBlock_Click(object sender, EventArgs e)
        {
            Computer.ComputerDecision();
            Player.Block();
            Logic.OutCome();
            UpdateLabel();
            textBoxResults.Text = Logic.outcome;
            Buttons();
            GameOver();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            Computer.ComputerDecision();
            Player.Load();
            Logic.OutCome();
            UpdateLabel();
            textBoxResults.Text = Logic.outcome;
            Buttons();
            GameOver();
        }

        private void buttonShotgun_Click(object sender, EventArgs e)
        {
            Computer.ComputerDecision();
            Player.Shotgun();
            Logic.OutCome();
            UpdateLabel();
            textBoxResults.Text = Logic.outcome;
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
            UpdateLabel();
            buttonNewGame.Visible = false;
            textBoxResults.Clear();
            Logic.gameOver = false;
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
        private void UpdateLabel()
        {
            labelPlayerAmmo.Text = "Ammo: " + Logic.playerAmmo.ToString();
            labelComputerAmmo.Text = "Ammo: " + Logic.computerAmmo.ToString();
        }
    }
}
