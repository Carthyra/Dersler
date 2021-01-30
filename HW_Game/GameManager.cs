using System;

namespace HW_Game
{
    public class GameManager : IGamesService
    {
        public void AddDiscount()
        {
            System.Console.WriteLine("İndirim uygulandı."); ;
        }

        public void AddGame()
        {
            System.Console.WriteLine("Oyun Magazaya eklendi."); ;
        }

        public void RemoveGame()
        {
            System.Console.WriteLine("Oyun magazadan kaldırıldı."); ;
        }

        public void UpdateGamePrice()
        {
            System.Console.WriteLine("Oyun fiyatı güncellendi."); ;
        }
    }
}
