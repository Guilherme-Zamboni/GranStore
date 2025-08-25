using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GranStore.Models;
using Microsoft.AspNetCore.OutputCaching;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Http.Connections;

namespace GranStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private List<Produto> produtos;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;

        Categoria categoria = new();
        categoria.Id = 1;
        categoria.Nome = "Eletrônicos";

        Categoria categoria2 = new()
        {
            Id = 2,
            Nome = "Roupas"
        };

        List<Produto> produtos = [
            new() {
                Id = 1,
                Nome = "Notebook G15",
                Descricao = "Lorem Ipsum",
                QtdeEstoque = 5,
                ValorCusto = 2000m,
                ValorVenda = 5500m,
                Categoria = categoria,
            }
        ];
    }

    public IActionResult Produto(int id)
    {



        var ptoduto = produtos.SingleOrDefault(p => p.Id == id);
        return View();
    }
    public IActionResult Index()
    {




        return View();
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
