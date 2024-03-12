using Microsoft.AspNetCore.Mvc;
using Aula29MVCDB.Models;
namespace Aula29MVCDB.Controllers;

public class PedidoController : Controller
{
    private readonly MvcDBContext _context;

    public PedidoController(MvcDBContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Pedidos);
    }

    public IActionResult Show(int pedidoId)
    {
        Pedido? pedido =_context.Pedidos.Find(pedidoId);

        if(pedido == null)
        {
            return NotFound();
        }
        return View(pedido);
    }

    public IActionResult Create()
    {      
        return View();
    }

    public IActionResult CreateResult(int pedidoId, int empregadoId, string dataPedido, string peso, int codTransportadora, int pedidoClienteId)
    {
        if(_context.Pedidos.Find(pedidoId) == null)
        {
            _context.Pedidos.Add(new Pedido(pedidoId, empregadoId, dataPedido, peso, codTransportadora, pedidoClienteId));
            _context.SaveChanges();
            return RedirectToAction("Create");
        }
        else
        {
           return Content("Já existe um pedido com esse id.");
        }
       
    }

    public IActionResult Delete(int pedidoId)
    {
        _context.Pedidos.Remove(_context.Pedidos.Find(pedidoId));
        _context.SaveChanges();
        return View();
    }

    public IActionResult Update(int pedidoId)
    {
        Pedido pedido = _context.Pedidos.Find(pedidoId);
        if(pedido == null)
        {
            return Content("Esse pedido não existe.");
        }
        else
        {
           return View(pedido);
        }
    }

    public IActionResult UpdateResult(int pedidoId, int empregadoId, string dataPedido, string peso, int codTransportadora, int pedidoClienteId)
    {
        Pedido pedido = _context.Pedidos.Find(pedidoId);

        pedido.PedidoId = pedidoId;
        pedido.EmpregadoId = empregadoId;
        pedido.DataPedido = dataPedido;
        pedido.Peso = peso;
        pedido.CodTransportadora = codTransportadora;
        pedido.PedidoClienteId = pedidoClienteId;
        _context.SaveChanges();
        return RedirectToAction("Index");
    }   
}