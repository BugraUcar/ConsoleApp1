using GameSimulator.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulator.Abstract
{
    interface IGamerService
    {
        public void SignIn(Player player);
        public void Update();
        public void DeleteAccount();

    }
}
