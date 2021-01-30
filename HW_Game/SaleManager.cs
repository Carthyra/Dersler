using System;

namespace HW_Game
{
    public class SaleManager : ISaleService
    {
        public void ApplySale(Games games, Sales sales)
        {
            System.Console.WriteLine(games.Name + " isimli oyuna " + sales.SaleName + " indirim uygulanmıştır."); ;
        }

        public void UndoSale(Games games, Sales sales)
        {
            System.Console.WriteLine(games.Name + " isimli oyundan " + sales.SaleName + " indirimi kaldırılmıştır.");
        }
    }
}
