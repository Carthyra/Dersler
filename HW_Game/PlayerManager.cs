using System;

namespace HW_Game
{
    public class PlayerManager : IPlayerService
    {
        PlayerValidationManager playerValidationManager = new PlayerValidationManager();

        public void Add(Player player)
        {
            if (playerValidationManager.Validation(player) == true)
            {
                System.Console.WriteLine(player.FirstName + " isimli oyuncu sisteme eklendi"); ;
            }
            else
            {
                System.Console.WriteLine(player.FirstName + " isimli oyuncu Mernis sisteminde doğrulanamadı ve eklenemedi");
            }

        }

        public void Delete(Player player)
        {
            System.Console.WriteLine(player + " isimli oyuncu sistemden silindi.");
        }

        public void Update(Player player)
        {
            System.Console.WriteLine(player + " isimli oyuncunun bilgileri güncellendi.");
        }


    }
}
