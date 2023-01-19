namespace Domain.Dtos;

public class CompanyDto
{
    public CompanyDto()
    {
        
    }
    public CompanyDto(int id, string? name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; set; }
    public string? Name { get; set; }
}