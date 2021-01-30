using System;

namespace HW_Game
{
    public interface IPurchaseService
    {
        void Buy(Player player, Games games);
        void Rebate(Player player, Games games);
    }
}
