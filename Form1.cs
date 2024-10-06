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

        }

        private void buttonBlock_Click(object sender, EventArgs e)
        {
            Computer.ComputerDecision();
            Player.Block();
            Logic.OutCome();
            labelComputerAmmo.Text = "Ammo: " + Computer.ammo.ToString();
            textBoxResults.Text = Logic.outcome;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            Computer.ComputerDecision();
            Player.Load();
            Logic.OutCome();
            labelPlayerAmmo.Text = "Ammo: " + Player.ammo.ToString();
            labelComputerAmmo.Text = "Ammo: " + Computer.ammo.ToString();
            textBoxResults.Text = Logic.outcome;
        }

        private void buttonShotgun_Click(object sender, EventArgs e)
        {
            Computer.ComputerDecision();
            Player.Shotgun();
            Logic.OutCome();
            textBoxResults.Text = Logic.outcome;
        }
    }
}
