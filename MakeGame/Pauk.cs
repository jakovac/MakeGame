namespace MakeGame
{
    class Pauk : ICudoviste
    {
        public string Naziv { get; set; } = "Pauk";
        public int Health { get; set; } = 100;
        public string VrstaNapada { get; set; }
        public int Damage { get; set; }

        //public int Napad(string nacinNapada)
        //{
        //    int skidaHealth = 0;

        //    if (nacinNapada == "udara")
        //        skidaHealth = 5;
        //    if (nacinNapada == "ujeda")
        //        skidaHealth = 8;

        //    return skidaHealth;
        //}
    }
}