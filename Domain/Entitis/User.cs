namespace Domain.Entitis;

public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime BirthDate { get; set; }
    public int CompanyId { get; set; }
    public Company? Company { get; set; }

    public User()
    {
        
    }
    public User(int id, string name, int companyId)
    {
        Id = id;
        Name = name;
        CompanyId = companyId;
    }
}