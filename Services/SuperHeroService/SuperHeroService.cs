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
            return superhero[id];
        }

        public IList<SuperHeros> UpdateSuperHeros(int id, SuperHeros request)
        {
            superhero[id] = request;
            //Je sais pas trop où en venir avec ça
        }

        public IList<SuperHeros> DeleteSuperHeros(int id)
        {

            superhero.Remove(superhero[id]);
        }

    }
}