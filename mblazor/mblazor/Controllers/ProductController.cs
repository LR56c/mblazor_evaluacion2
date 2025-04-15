using mblazor.Context;
using Microsoft.AspNetCore.Mvc;

namespace mblazor.Controllers;

[Microsoft.AspNetCore.Components.Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly ProductDbContext _context;

    public ProductController(ProductDbContext context)
    {
        _context = context;
    }

    [HttpGet("connection")]
    public async Task<ActionResult<string>> GetConexionUsuarios()
    {
        try
        {
            // var respuesta = await _context.Productos.ToListAsync();
            // Console.WriteLine("respuesta:",respuesta.Count);
            return "Conectado a la base de datos y a la tabla PELICULAS";
        }
        catch (Exception ex)
        {
            return "Error de conexion con PELICULAS";
        }
    }
}