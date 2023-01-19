using Domain.Entitis;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController:ControllerBase
{
    private readonly UserServices _userService;

    public UserController(UserServices userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public List<User> GetUsers()
    {
        return _userService.GetUsers();
    }
    
    [HttpGet("{id}")]
    public User GetUser(int id)
    {
        return _userService.GetUser(id);
    }
    
    [HttpPost]
    public bool AddUser(User user)
    {
        _userService.AddUser(user);
        return true;
    }
    
    
}