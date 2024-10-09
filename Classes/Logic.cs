using System.Numerics;

namespace InlämningsUppgift2.Classes
{
    public static class Logic
    {
        public static string outcome = "";
        public static bool gameOver = false;
        public static bool computerWin = false;
        public static bool playerWin = false;
        public static int playerAmmo = 0;
        public static int computerAmmo = 0;
        public static int loadingAmmo = 1;
        public static int shootingAmmoUsage = 1;
        public static int shotgunAmmoUsage = 3;

        public static bool OutCome()
        {
            if (Player.playerDecision == "Shotgun")
            {   if (Computer.computerDecision == "Shotgun")
                {
                    outcome = "Both player and Computer fires the shotgun and both loses";
                    gameOver = true;
                }
                else if (Computer.computerDecision == "Shoot")
                {
                    outcome = "Player fires the shotgun and Computer tries shooting. Player Win!";
                    gameOver = true;
                    playerWin = true;
                }
                else if (Computer.computerDecision == "Block")
                {
                    outcome = "Player fires the shotgun and Computer tries hiding. Player Win!";
                    gameOver = true;
                    playerWin = true;
                }
                else if (Computer.computerDecision == "Load")
                {
                    outcome = "Player fires the shotgun and Computer loads. Player Win!";
                    gameOver = true;
                    playerWin = true;
                }
            }
            else if (Player.playerDecision == "Shoot")
            {
                if (Computer.computerDecision == "Shoot")
                {
                    outcome = "Player shoots and computer shoots. Both loses ammo";
                }
                else if (Computer.computerDecision == "Block")
                {
                    outcome = "Player shoots and computer blocks. Player loses ammo";
                }
                else if (Computer.computerDecision == "Load")
                {
                    outcome = "Player shoots and computer loads. Player win!";
                    gameOver = true;
                    playerWin = true;
                }
                else if (Computer.computerDecision == "Shotgun")
                {
                    outcome = "Computer fires the shotgun and the player shoots. Computer wins!";
                    gameOver = true;
                    computerWin = true;
                }
            }
            else if (Player.playerDecision == "Block")
            {
                if (Computer.computerDecision == "Shoot")
                {
                    outcome = "Player blocks and computer shoots. Player lost ammo";
                }
                else if (Player.playerDecision == "Block" && Computer.computerDecision == "Block")
                {
                    outcome = "Player blocks and computer blocks. Nothing happens";
                }
                else if (Player.playerDecision == "Block" && Computer.computerDecision == "Load")
                {
                    outcome = "Player blocks and computer loads. Computer gains ammo";
                }
                else if (Computer.computerDecision == "Shotgun")
                {
                    outcome = "Computer fires the shotgun and the player tries hiding. Computer wins!";
                    gameOver = true;
                    computerWin = true;
                }
            }
            else if (Player.playerDecision == "Load")
            {
                if (Computer.computerDecision == "Shoot")
                {
                    outcome = "Player loads and computer shoots. Computer win!";
                    gameOver = true;
                    computerWin = true;
                }
                else if (Player.playerDecision == "Load" && Computer.computerDecision == "Block")
                {
                    outcome = "Player loads and computer blocks. Player gains ammo";
                }
                else if (Player.playerDecision == "Load" && Computer.computerDecision == "Load")
                {
                    outcome = "Player loads and computer loads. Both gain ammo";
                }
                else if (Computer.computerDecision == "Shotgun")
                {
                    outcome = "Computer fires the shotgun and the player loads. Computer wins!";
                    gameOver = true;
                    computerWin = true;
                }
            }
            return gameOver;
        }

        public static void NewGame()
        {
            playerAmmo = 0;
            computerAmmo = 0;
            Computer.computerDecision = "";
            gameOver = false;
            playerWin = false;
            computerWin = false;
        }
    }
}
