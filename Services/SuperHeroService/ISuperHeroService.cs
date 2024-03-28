namespace SuperHero.Services.SuperHeroService
{
    public interface ISuperHeroService
    {
        IList<SuperHeros> GetSuperHeroes();
        SuperHeros GetHeros(int id);
        IList<SuperHeros> AddSuperHeros(SuperHeros heros);
        IList<SuperHeros> UpdateSuperHeros(int id, SuperHeros request);
        IList<SuperHeros> DeleteSuperHeros(int id);
    }
}