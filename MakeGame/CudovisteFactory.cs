using System;
using System.Security.Cryptography.X509Certificates;

namespace MakeGame
{
    class CudovisteFactory
    {
        public static ICudoviste GetCudoviste()
        {
            ICudoviste cudoviste = null;

            var random = new Random();
            if (random.Next(1, 100) <= 50)
            {
                cudoviste = new Zmaj();
                //cudoviste.VrstaNapada = SetVrstaNapada(cudoviste.Naziv);
                //cudoviste.Damage = SetNapad(cudoviste.VrstaNapada);
            }
            else
            {
                cudoviste = new Pauk();
                //cudoviste.VrstaNapada = SetVrstaNapada(cudoviste.Naziv);
                //cudoviste.Damage = SetNapad(cudoviste.VrstaNapada);
            }

            return cudoviste;
        }
    }
}