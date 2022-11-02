using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyaçKrediManager();
            //ihtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            
            //tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            BasvuruManager basvuruManager = new BasvuruManager();

            ILoggerService fileLoggerService = new FileLoggerService();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();

            basvuruManager.BasvuruYap(new EsnafKrediManager(), new DatabaseLoggerService());

            List <IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,tasitKrediManager};

            //basvuruManager.KrediOnbilgilendirmesiYap(krediler);



        }
    }
}
