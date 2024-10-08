namespace InlämningsUppgift2.Classes
{
    public static class Player
    {
        public static string playerDecision = "";
        public static int ammo = 0;
        
        public static void Shotgun()
        {
            playerDecision = "Shotgun";
        }
        public static void Shoot()
        {
            MessageBox.Show("Player shoots");
            playerDecision = "Shoot";
            ammo--;
        }
        public static void Block()
        {
            MessageBox.Show("Player block");
            playerDecision = "Block";
        }
        public static void Load()
        {
            ammo++;
            MessageBox.Show($"Player loads! Player has {ammo} rounds loaded!");
            playerDecision = "Load";
        }
        public static void NewGame()
        {
            ammo = 0;
        }
    }
}
