using System;

namespace HW_Game
{
    public interface IPlayerService
    {
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}
