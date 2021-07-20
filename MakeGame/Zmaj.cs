namespace MakeGame
{
    class Zmaj : ICudoviste
    {
        public string Naziv { get; set; } = "Zmaj";
        public int Health { get; set; } = 150;
        public string VrstaNapada { get; set; }
        public int Damage { get; set; }

        //public int Napad(string nacinNapada)
        //{
        //    int skidaHealth = 0;

        //    if (nacinNapada == "udara")
        //        skidaHealth = 5;
        //    if (nacinNapada == "bljuje vatru")
        //        skidaHealth = 20;

        //    return skidaHealth;
        //}
    }
}