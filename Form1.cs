using InlämningsUppgift2.Classes;

namespace InlämningsUppgift2
{
    public partial class FormGame : Form
    {
        public FormGame()
        {
            InitializeComponent();
            labelPlayerAmmo.Text = "Ammo: " + Player.ammo.ToString();
            labelComputerAmmo.Text = "Ammo: " + Computer.ammo.ToString();
        }

        private void buttonShoot_Click(object sender, EventArgs e)
        {
            Computer.ComputerDecision();
            Player.Shoot();
            Logic.OutCome();
            labelPlayerAmmo.Text = "Ammo: " + Player.ammo.ToString();
            labelComputerAmmo.Text = "Ammo: " + Computer.ammo.ToString();
            textBoxResults.Text = Logic.outcome;
            Buttons();
            GameOver();
        }

        private void buttonBlock_Click(object sender, EventArgs e)
        {
            Computer.ComputerDecision();
            Player.Block();
            Logic.OutCome();
            labelComputerAmmo.Text = "Ammo: " + Computer.ammo.ToString();
            textBoxResults.Text = Logic.outcome;
            Buttons();
            GameOver();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            Computer.ComputerDecision();
            Player.Load();
            Logic.OutCome();
            labelPlayerAmmo.Text = "Ammo: " + Player.ammo.ToString();
            labelComputerAmmo.Text = "Ammo: " + Computer.ammo.ToString();
            textBoxResults.Text = Logic.outcome;
            Buttons();
            GameOver();
        }

        private void buttonShotgun_Click(object sender, EventArgs e)
        {
            Computer.ComputerDecision();
            Player.Shotgun();
            Logic.OutCome();
            labelPlayerAmmo.Text = "Ammo: " + Player.ammo.ToString();
            labelComputerAmmo.Text = "Ammo: " + Computer.ammo.ToString();
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
            Player.NewGame();
            Computer.NewGame();
            labelPlayerAmmo.Text = "Ammo: " + Player.ammo.ToString();
            labelComputerAmmo.Text = "Ammo: " + Computer.ammo.ToString();
            buttonNewGame.Visible = false;
            textBoxResults.Clear();
            Logic.gameOver = false;
            Buttons();
        }
        private void Buttons()
        {
            if (Logic.gameOver == false && Player.ammo == 0)
            {
                buttonShoot.Visible = false;
                buttonBlock.Visible = true;
                buttonLoad.Visible = true;
                buttonShotgun.Visible = false;
            }
            else if (Player.ammo == 0)
            {
                buttonShoot.Visible = false;
                buttonShotgun.Visible = false;
            }
            else if (Player.ammo >= 1)
            {
                buttonShoot.Visible = true;
            }
            else if (Player.ammo >= 3)
            {
                buttonShotgun.Visible = true;
            }
        }
    }
}
