using GameSimulator.Abstract;
using GameSimulator.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulator.Concrete
{
    class GamerManager : IGamerService

    {
        public void DeleteAccount()
        {
            Console.WriteLine("Hesap Silindi");
        }

        public void SignIn(Player player)
        {
            Console.WriteLine(player.PlayerName + " Adlı Kullanıcı " + player.PlayerId + " Id ile Kaydedildi.");
        }

        public void Update()
        {
            Console.WriteLine("Kayıt Bilgileri Güncellendi");
        }
    }
}
