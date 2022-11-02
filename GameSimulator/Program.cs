

using GameSimulator.Concrete;
using GameSimulator.Entitys;
using System;


namespace GameSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.PlayerId = 1;
            player1.PlayerName = "Bugra";
            player1.PlayerSurname = "Uçar";
            player1.DateOfTime = "01.06.1997";


            GamerManager gamerManager = new GamerManager();
            gamerManager.SignIn(player1);

            Player player2 = new Player();
            player2.PlayerId = 1;
            player2.PlayerName = "Bugra";
            player2.PlayerSurname = "Uçar";
            player2.DateOfTime = "01.06.1997";

            GameInformation game1 = new GameInformation();
            game1.GameName = "GTA V";


            SalesManager salesManager = new SalesManager();
            salesManager.Sell(player1, game1);

            Console.ReadKey();


        }
    }
}
