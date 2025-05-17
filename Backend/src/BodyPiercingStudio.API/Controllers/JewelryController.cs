using BodyPiercingStudio.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace BodyPiercingStudio.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JewelryController : ControllerBase
{

    public IEnumerable<Jewelry> _jewelry = new Jewelry[] {
            new Jewelry() {
                Id = 1,
                Name = "Brinco de Ouro",
                Description = "Brinco de Ouro 18k",
                BasePrice = 150.00m,
                Material = "Ouro",
                Category = "Brinco",
                ImageUrl = "https://example.com/image.jpg",
                StockQuantity = 10,
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new Jewelry() {
                Id = 2,
                Name = "Argola de Prata",
                Description = "Argola de Prata 925",
                BasePrice = 80.00m,
                Material = "Prata",
                Category = "Argola",
                ImageUrl = "https://example.com/image2.jpg",
                StockQuantity = 5,
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new Jewelry() {
                Id = 3,
                Name = "Piercing de Aço Cirúrgico",
                Description = "Piercing de Aço Cirúrgico",
                BasePrice = 50.00m,
                Material = "Aço Cirúrgico",
                Category = "Piercing",
                ImageUrl = "https://example.com/image3.jpg",
                StockQuantity = 20,
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            }
        };

    public JewelryController()
    {
    }

    [HttpGet()]
    public IEnumerable<Jewelry> Get() {
        return _jewelry;
    }

    [HttpGet("{id}")]
    public IEnumerable<Jewelry> GetById(int id) {
        return _jewelry.Where(jewelry => jewelry.Id == id);
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
