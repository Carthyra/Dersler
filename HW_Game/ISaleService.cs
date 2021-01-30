using System;

namespace HW_Game
{
    public interface ISaleService
    {
        void ApplySale(Games games, Sales sales);
        void UndoSale(Games games, Sales sales);
    }
}
