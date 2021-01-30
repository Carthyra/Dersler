using System;

namespace HW_Game
{
    public class PurchaseManager : IPurchaseService
    {
        public void Buy(Player player, Games games)
        {
            System.Console.WriteLine(player.FirstName + " isimli oyuncu " + games.Name + " isimli oyunu satın almıştır.");
        }

        public void Rebate(Player player, Games games)
        {
            System.Console.WriteLine(player.FirstName + " isimli oyuncu " + games.Name + " isimli satın aldığı oyunu iade etmiştir.");
        }
    }
}
