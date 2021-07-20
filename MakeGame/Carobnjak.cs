using System;

namespace MakeGame
{
    class Carobnjak : IHeroj
    {
        //public int Health = 100;
        //public string[] Oruzije = new[] {"Mać", "Koplje"};
        public string Naziv { get; set; } = "Čarobnjak";

        public int Health { get; set; } = 150;
        public string Oruzije { get; set; }
        public string[] Ranac { get; set; }
        public int Damage { get; set; }
        public void BaciOruzije()
        {
            Console.WriteLine("Čarobnjak bacio oruzije");
        }
        public void UzmiOruzije()
        {
            Console.WriteLine("Čarobnjak uzeo oruzije");
        }

        //public int Napad()
        //{
        //    return 20;
        //}

        //public int Napad(string nacinNapada)
        //{
        //    int skidaHealth = 0;

        //    if (nacinNapada.ToLower() == "čarolija")
        //        skidaHealth = 20;

        //    return skidaHealth;
        //}
    }
}