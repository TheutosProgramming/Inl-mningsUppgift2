namespace InlämningsUppgift2.Classes
{
    public static class Logic
    {
        public static int gameRound = 0;
        public static string outcome = "";
        public static void OutCome()
        {
            if (Computer.computerDecision == "Shotgun" && Player.playerDecision == "Shotgun")
            {
                MessageBox.Show("Draw!");
            }
            else if (Computer.computerDecision == "Shotgun")
            {
                MessageBox.Show("Computer wins!");
            }
            else if (Player.playerDecision == "Shotgun")
            {
                MessageBox.Show("Player wins!");
            }
            else if (Player.playerDecision == "Shoot" && Computer.computerDecision == "Shoot")
            {
                outcome = "Player shoots and computer shoots. Both loses ammo";
            }
            else if (Player.playerDecision == "Shoot" && Computer.computerDecision == "Block")
            {
                outcome = "Player shoots and computer blocks. Player loses ammo";
            }
            else if (Player.playerDecision == "Shoot" && Computer.computerDecision == "Load")
            {
                outcome = "Player shoots and computer loads. Player win!";
                MessageBox.Show("Player wins!");
            }
            else if (Player.playerDecision == "Block" && Computer.computerDecision == "Shoot")
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
            else if (Player.playerDecision == "Load" && Computer.computerDecision == "Shoot")
            {
                outcome = "Player loads and computer shoots. Computer win!";
                MessageBox.Show("Computer wins!");
            }
            else if (Player.playerDecision == "Load" && Computer.computerDecision == "Block")
            {
                outcome = "Player loads and computer blocks. Player gains ammo";
            }
            else if (Player.playerDecision == "Load" && Computer.computerDecision == "Load")
            {
                outcome = "Player loads and computer loads. Both gain ammo";
            }
        }
    }
}
