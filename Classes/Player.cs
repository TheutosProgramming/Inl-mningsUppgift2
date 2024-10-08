namespace InlämningsUppgift2.Classes
{
    public static class Player
    {
        public static string playerDecision = "";
        
        public static void Shotgun()
        {
            playerDecision = "Shotgun";
            Logic.playerAmmo -= Logic.shotgunAmmoUsage;
        }
        public static void Shoot()
        {
            playerDecision = "Shoot";
            Logic.playerAmmo -= Logic.shootingAmmoUsage;
        }
        public static void Block()
        {
            MessageBox.Show("Player block");
            playerDecision = "Block";
        }
        public static void Load()
        {
            Logic.playerAmmo += Logic.loadingAmmo;
            playerDecision = "Load";
        }
    }
}
