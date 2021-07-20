using System;
using System.IO;

namespace MakeGame
{

    class Program
    {
        static void Main(string[] args)
        {
            var heroj = HerojFactory.GetHeroj();

            var cudoviste = CudovisteFactory.GetCudoviste();

 
            Console.WriteLine($"{heroj.Naziv} vs {cudoviste.Naziv}");
            Console.WriteLine("Upis u C:\\log.txt");

            var log = $"{heroj.Naziv}:{heroj.Health} vs {cudoviste.Naziv}:{cudoviste.Health} \n";
            File.AppendAllText("C:\\" + "log.txt", log);
            while (cudoviste.Health >= 1 && heroj.Health >= 1)
            {
                heroj.Oruzije = heroj.SetOruzije(heroj.Naziv);
                heroj.Damage = heroj.SetNapad(heroj.Oruzije);
                cudoviste.VrstaNapada = cudoviste.SetVrstaNapada(cudoviste.Naziv);
                cudoviste.Damage = cudoviste.SetNapad(cudoviste.VrstaNapada);

                var random = new Random();
                if (random.Next(1, 100) < 50)
                {
                    cudoviste.Health -= heroj.Damage;
                    log = $"{heroj.Naziv} je napao {cudoviste.Naziv} pomoću {heroj.Oruzije}, damage {heroj.Damage} \n";
                    File.AppendAllText("C:\\" + "log.txt", log);
                }
                else
                {
                    heroj.Health -= cudoviste.Damage;
                    log = $"{cudoviste.Naziv} je napao {heroj.Naziv} pomoću {cudoviste.VrstaNapada} damage {cudoviste.Damage}\n";
                    File.AppendAllText("C:\\" + "log.txt", log);
                }

            }
                
            File.AppendAllText("C:\\" + "log.txt", log);
            if (cudoviste.Health <= 0)
            {
                log += $"{heroj.Naziv} ostalo {heroj.Health} healtha \n";
                log += $"{heroj.Naziv} je pobedio u duelu sa {cudoviste.Naziv} \n";
            }

            else
            {
                log += $"{cudoviste.Naziv} ostalo {cudoviste.Health} healtha \n";
                log += $"{cudoviste.Naziv} je pobedio u duelu sa {heroj.Naziv} \n";
            }

            log += $"--------------------------------------------\n";
            File.AppendAllText("C:\\" + "log.txt", log);


        }
    }
}

