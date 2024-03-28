using System.ComponentModel.DataAnnotations;

public class SuperHeros
{
    [Key] // Define primary key
    public int Id { get; set; }
    public string Name { get; set; }
    public string Power { get; set; }
    public SuperHeros(int id, string name, string power)
    {
        this.Id = id;
        this.Name = name;
        this.Power = power;
    }
}