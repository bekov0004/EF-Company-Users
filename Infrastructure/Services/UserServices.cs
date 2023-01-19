using Domain.Entitis;
using Infrastructure.Date;

namespace Infrastructure.Services;

public class UserServices
{
    private readonly DataContext _context;

    public UserServices(DataContext context)
    {
        _context = context;
    }

    public List<User> GetUsers()
    {
        return _context.Users.ToList();
    }
    
    public User GetUser(int id)
    {
        return _context.Users.FirstOrDefault(x => x.Id == id);
    }
    
    public void AddUser(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
    }
}