namespace InlämningsUppgift2.Classes
{
    public static class Computer
    {
        private static Random random = new Random();
        private static int decision = 0;
        public static string computerDecision = "";

        public static void ComputerDecision()
        {
            if (Logic.computerAmmo == 0)
            {
                decision = random.Next(2, 4);
                if (Logic.playerAmmo == 0)
                {
                    Load();
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
            else if (Logic.computerAmmo == 3)
            {
                Shotgun();
            }
            else
            {
                decision = random.Next(1, 4);
                if (decision == 1)
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
        }
        public static void Shotgun()
        {
            computerDecision = "Shotgun";
            Logic.computerAmmo -= Logic.shotgunAmmoUsage;
        }
        public static void Shoot()
        {
            Logic.computerAmmo -= Logic.shootingAmmoUsage;
            computerDecision = "Shoot";
        }
        public static void Block()
        {
            MessageBox.Show("Computer block");
            computerDecision = "Block";
        }
        public static void Load()
        {
            Logic.computerAmmo += Logic.loadingAmmo;
            computerDecision = "Load";
        }
    }
}
