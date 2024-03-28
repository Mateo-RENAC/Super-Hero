namespace SuperHero.Services.SuperHeroService
{
    public interface ISuperHeroService
    {
        List<SuperHeros> GetSuperHeroes();
        SuperHeros GetHeros();
        List<SuperHeros> AddSuperHeros(SuperHeros heros);
        List<SuperHeros> UpdateSuperHeros(int id, SuperHeros request);
        List<SuperHeros> DeleteSuperHeros(string id);
    }
}