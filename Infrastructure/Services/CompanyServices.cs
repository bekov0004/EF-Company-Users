using Domain.Dtos;
using Domain.Entitis;
using Infrastructure.Date;

namespace Infrastructure.Services;

public class CompanyServices
{
    private readonly DataContext _context;

    public CompanyServices(DataContext context)
    {
        _context = context;
    }
    
    public List<CompanyDto> GetCompanies()
    {
        return _context.Companies.Select(x=>new CompanyDto(x.Id,x.Name)).ToList();
    }
    
    public Company GetCompany(int id)
    {
        return _context.Companies.FirstOrDefault(x => x.Id == id);
    }
    
    public void AddCompany(AddCompanyDto company)
    {
        var mapped = new Company(company.Id, company.Name);
        _context.Companies.Add(mapped);
        _context.SaveChanges();
    }

    public List<CompanyDto> GetCompanyByName(string name)
    {
        return _context.Companies.
            Where(x => x.Name.ToLower().Contains(name.ToLower())).
            Select(x => new CompanyDto(x.Id, x.Name)).ToList();
    }
    
}