namespace InlämningsUppgift2.Classes
{
    public static class Computer
    {
        private static Random random;
        private static int decision = 0;
        public static string computerDecision = "";
        private static int ammo = 0;
        private static void NumberGenerator()
        {
            random = new Random();
            decision = random.Next(1, 4);
        }
        public static void ComputerDecision()
        {
            NumberGenerator();
            if (ammo == 3)
            {
                Shotgun();
            }
            else if (decision == 1)
            {
                Shoot();
            }
            else if (decision == 2)
            {
                Block();
            }
            else if (decision == 3)
            {
                Load();
            }
        }
        public static void Shotgun()
        {
            MessageBox.Show("Computer shotgun");
            computerDecision = "Shotgun";
        }
        public static void Shoot()
        {
            MessageBox.Show("Computer shoot");
            ammo--;
            computerDecision = "Shoot";
        }
        public static void Block()
        {
            MessageBox.Show("Computer block");
            computerDecision = "Block";
        }
        public static void Load()
        {
            ammo++;
            MessageBox.Show($"Computer loads! Computer has {ammo} rounds loaded!");
            computerDecision = "Load";
        }
    }
}
