using BodyPiercingStudio.API.Data;
using BodyPiercingStudio.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace BodyPiercingStudio.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JewelryController : ControllerBase
{

    private readonly DataContext _context;

    public JewelryController(DataContext context)
    {
        _context = context;
    }

    [HttpGet()]
    public IEnumerable<Jewelry> Get()
    {
        return _context.Jewelry;
    }

    [HttpGet("{id}")]
    public Jewelry? GetById(int id)
    {
        return _context.Jewelry.FirstOrDefault(jewelry => jewelry.Id == id);
    }

    [HttpPost()]
    public string Post()
    {
        return "Exemplo de Post";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"Exemplo de Put com id = {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"Exemplo de Delete com id = {id}";
    }

}
