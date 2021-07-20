using System;

namespace MakeGame
{
    public interface ICudoviste
    {
        public string Naziv { get; }
        public int Health { get; set; }
        public string VrstaNapada { get; set; }
        public int Damage { get; set; }

        public string SetVrstaNapada(string tipCudovista)
        {
            var rez = "";
            var random = new Random();
            if (tipCudovista == "Zmaj")
            {
                if (random.Next(1, 100) <= 50)
                    rez = "udara";
                else
                    rez = "bljuje vatru";
            }
            else if (tipCudovista == "Pauk")
            {
                if (random.Next(1, 100) <= 50)
                    rez = "udara";
                else
                    rez = "ujeda";
            }

            return rez;

        }
        public int SetNapad(string vrstaNapada)
        {
            var rez = 0;
            if (VrstaNapada.ToLower() == "udara")
                rez = 5;
            if (VrstaNapada.ToLower() == "bljuje vatru")
                rez = 20;
            if (VrstaNapada.ToLower() == "ujeda")
                rez = 8;

            return rez;
        }
    }
}