namespace InlämningsUppgift2.Classes
{
    public static class Computer
    {
        private static Random random = new Random();
        private static int decision = 0;
        public static string computerDecision = "";
        public static int ammo = 0;
        private static void NumberGenerator()
        {
            random = new Random();
            decision = random.Next(1, 4);
        }
        
        private static void BlockOrLoad()
        {
            random = new Random();
            decision = random.Next(2, 4);
        }
        public static void ComputerDecision()
        {
            if (ammo == 0)
            {
                decision = random.Next(2, 4);
                if (Player.ammo == 0)
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
            else if (ammo == 3)
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

            /*if (Logic.gameRound == 0)
            {
                Load();
                Logic.gameRound++;
            }
            else
            {
                if (ammo == 0 && Player.ammo == 0)
                {
                    Load();
                }
                else if (ammo == 0)
                {
                    BlockOrLoad();
                }
                else
                {
                    NumberGenerator();
                }
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
            }*/
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
        public static void NewGame()
        {
            ammo = 0;

        }
    }
}
