namespace InlämningsUppgift2.Classes
{
    public static class Logic
    {
        public static void OutCome()
        {
            if (Computer.computerDecision == "Shotgun" && Player.playerDecision == "Shotgun")
            {
                //DRAW
            }
            else if (Computer.computerDecision == "Shotgun")
            {
                //Datorn vinner
            }
            else if (Player.playerDecision == "Shotgun")
            {
                //Spelaren vinner
            }
            else if (Player.playerDecision == "Shoot" && Computer.computerDecision == "Shoot")
            {

            }
            else if (Player.playerDecision == "Shoot" && Computer.computerDecision == "Block")
            {

            }
            else if (Player.playerDecision == "Shoot" && Computer.computerDecision == "Load")
            {

            }
            else if (Player.playerDecision == "Block" && Computer.computerDecision == "Shoot")
            {

            }
            else if (Player.playerDecision == "Block" && Computer.computerDecision == "Block")
            {

            }
            else if (Player.playerDecision == "Block" && Computer.computerDecision == "Load")
            {

            }
            else if (Player.playerDecision == "Load" && Computer.computerDecision == "Shoot")
            {

            }
            else if (Player.playerDecision == "Load" && Computer.computerDecision == "Block")
            {

            }
            else if (Player.playerDecision == "Load" && Computer.computerDecision == "Load")
            {

            }
        }
    }
}
