using System;

namespace HW_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Id = 1;
            player1.FirstName = "Ulaş";
            player1.Lastname = "Cumart";
            player1.DateOfBirth = new DateTime(1984, 4, 23);
            player1.NationalityId = "12345678910";

            Player player2 = new Player();
            player2.Id = 1;
            player2.FirstName = "Gizem";
            player2.Lastname = "Cumart";
            player2.DateOfBirth = new DateTime(1986, 6, 24);
            player2.NationalityId = "09876543112";

            Games game1 = new Games();
            game1.Id = 1907;
            game1.Name = "Witcher 3: Wild Hunt";
            game1.Platform = "Microsoft Windows";
            game1.Category = "RPG";
            game1.Developer = "CD Projekt";
            game1.Publisher = "CD Projekt RED";
            game1.Rating = 9.8;
            game1.Price = 250.00;

            //System.Console.WriteLine(player.DateOfBirth);

            Sales sale1 = new Sales();
            sale1.SaleName = "Black Friday";
            SaleManager saleManager = new SaleManager();
            PlayerValidationManager validationManager = new PlayerValidationManager();
            PurchaseManager purchaseManager = new PurchaseManager();
            PlayerManager playerManager = new PlayerManager();

            playerManager.Add(player1); // oyuncu valide edilerek eklendi.
            System.Console.WriteLine("-----------------------------------------");
            playerManager.Add(player2); // oyuncu valide edilerek eklenemedi.
            System.Console.WriteLine("-----------------------------------------");
            saleManager.ApplySale(game1, sale1); // indirim uygulandı.
            System.Console.WriteLine("-----------------------------------------");
            purchaseManager.Buy(player1, game1); // oyun satın alındı.
            System.Console.WriteLine("-----------------------------------------");
            purchaseManager.Rebate(player1, game1); // satın alınan oyun iade edildi.
            System.Console.WriteLine("-----------------------------------------");
            saleManager.UndoSale(game1, sale1); // oyun üzerindeki indirim kaldırıldı.


        }
    }
}
