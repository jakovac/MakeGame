using System;

namespace MakeGame
{
    class Macevalac : IHeroj
    {
        //public int Health = 100;
        //public string[] Oruzije = new[] {"Mać", "Koplje"};
        public string Naziv { get; set; } = "Mačevalac";

        public int Health { get; set; } = 100;

        public string Oruzije { get; set; }
        
        public string[] Ranac { get; set; }

        public int Damage { get; set; }

        public void BaciOruzije()
        {
            Console.WriteLine("Mačevalac bacio oruzije");
        }
        public void UzmiOruzije()
        {
            Console.WriteLine("Mačevalac uzeo oruzije");
        }

        public Macevalac()
        {
        }
        //public int Napad(string nacinNapada)
        //{
        //    int skidaHealth = 0;

        //    if (nacinNapada.ToLower() == "mač")
        //        skidaHealth = 10;
        //    if (nacinNapada.ToLower() == "koplje")
        //        skidaHealth = 15;

        //    return skidaHealth;
        //}
    }
}