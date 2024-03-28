namespace SuperHero.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        private static IList<SuperHeros> superhero = new List<SuperHeros>
        {
            new SuperHeros
            (
                1,
                "Superman",
                "Superpower"
            )
        };

        public IList<SuperHeros> AddSuperHeros(SuperHeros superheros)
        {
            superhero.Add(superheros);
            return superhero;
        }

        public IList<SuperHeros> GetSuperHeroes()
        {
            return superhero;
        }

        public SuperHeros GetHeros(int id)
        {
            return (SuperHeros)superhero.Where(hero => hero.Id == id);
        }

        public IList<SuperHeros> UpdateSuperHeros(int id, SuperHeros request)
        {
            SuperHeros hero = GetHeros(id);
            if (hero != null) 
            {
                Console.WriteLine("No Hero find at this Id : " + id);
                return superhero;
            }
            hero.Name = request.Name;
            hero.Power = request.Power;
            return superhero;
        }

        public IList<SuperHeros> DeleteSuperHeros(int id)
        {
            superhero.Remove((SuperHeros)superhero.Where(hero => hero.Id == id));
            return superhero;
        }

    }
}