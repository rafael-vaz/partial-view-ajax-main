using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Vendas.Models;

namespace Vendas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private List<Produto> RealizaConsulta(string ordem)
{
string ordenacao;
switch(ordem)
{
case "P":
ordenacao = "preco";
break;
case "C":
ordenacao = "Categoria";
break;
default:
ordenacao = "nome";
break;
}
BaseDados bd = new BaseDados();
return bd.Lista(ordenacao);
}
public IActionResult Index(string ordem)
{
List<Produto> produtos = RealizaConsulta(ordem);
return View(produtos);
}
public IActionResult ListaProdutos(string ordem)
{
List<Produto> produtos = RealizaConsulta(ordem);
return PartialView("_ListaProdutos", produtos);
}

public IActionResult Carrinho(){
    return View("Carrinho");
}



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
