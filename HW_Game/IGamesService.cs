using System;

namespace HW_Game
{
    public interface IGamesService
    {
        void AddGame();
        void AddDiscount();
        void RemoveGame();
        void UpdateGamePrice();
    }
}
