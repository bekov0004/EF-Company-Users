namespace Domain.Entitis;

public class Company
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public List<User> Users { get; set; } = new();

    public Company()
    {
        
    }
    public Company(int id, string name)
    {
        Id = id;
        Name = name;
    }
}