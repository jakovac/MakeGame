using System;

namespace MakeGame
{
    public interface IHeroj
    {
        public string Naziv { get; set; }
        public int Health { get; set; }
        public string Oruzije { get; set; }

        //public string AktivnoOruzije { get; set; }
        public int Damage { get; set; }
        public string[] Ranac { get; set; }


        public void BaciOruzije() { }
        public void UzmiOruzije() { }

        //public int Napad(string nacinNapada);
        public string SetOruzije(string tipHeroja)
        {
            var rez = "";
            var random = new Random();
            if (tipHeroja == "Mačevalac")
            {
                if (random.Next(1, 100) <= 50)
                    rez = "Mač";
                else
                    rez = "Koplje";
            }
            else if (tipHeroja == "Čarobnjak")
            {
                rez = "Čarolija";
            }

            return rez;

        }

        public int SetNapad(string oruzije)
        {
            var rez = 0;
            if (oruzije.ToLower() == "mač")
                rez = 10;
            if (oruzije.ToLower() == "koplje")
                rez = 15;
            if (oruzije.ToLower() == "čarolija")
                rez = 20;

            return rez;
        }
    }
}