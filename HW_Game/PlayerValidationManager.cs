using System;

namespace HW_Game
{
    public class PlayerValidationManager
    {
        public bool Validation(Player player)
        {
            if (player.FirstName == "Ulaş" && player.NationalityId == "12345678910" && player.DateOfBirth.Year == 1984)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
