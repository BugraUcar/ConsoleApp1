using GameSimulator.Abstract;
using GameSimulator.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulator.Concrete
{
    class SalesManager : ISalesService
    {
        public void Sell(Player player, GameInformation game)
        {
            Console.WriteLine(player.PlayerName + " İsimli Oyuncuya " + game.GameName + " İsimli Oyun Satılmıştır.");
        }
    }
}
