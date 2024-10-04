using InlämningsUppgift2.Classes;

namespace InlämningsUppgift2
{
    public partial class FormGame : Form
    {
        public FormGame()
        {
            InitializeComponent();
        }

        private void buttonShoot_Click(object sender, EventArgs e)
        {
            Computer.ComputerDecision();
            Player.Shoot();
        }

        private void buttonBlock_Click(object sender, EventArgs e)
        {
            Computer.ComputerDecision();
            Player.Block();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            Computer.ComputerDecision();
            Player.Load();
        }

        private void buttonShotgun_Click(object sender, EventArgs e)
        {
            Computer.ComputerDecision();
            Player.Shotgun();
        }
    }
}
