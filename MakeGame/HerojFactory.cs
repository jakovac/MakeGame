using System;

namespace MakeGame
{
    class HerojFactory
    {
        
        public static IHeroj GetHeroj()
        {
            IHeroj heroj = null;

            var random = new Random();
            if (random.Next(1, 100) <= 50)
            {
                heroj = new Macevalac();
                //heroj.Oruzije = SetOruzije(heroj.Naziv);
                //heroj.Damage = SetNapad(heroj.Oruzije);
            }

            else
            {
                heroj = new Carobnjak();
                //heroj.Oruzije = SetOruzije(heroj.Naziv);
                //heroj.Damage = SetNapad(heroj.Oruzije);
            }

            return heroj;
        }

    }
}