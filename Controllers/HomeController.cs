using Microsoft.AspNetCore.Mvc;

namespace TPBase.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.ListaSeries = BD.ListarSeries();
        return View();
    }

    public List<actores> VerDetalleActores(int idSerie){
        return BD.ObtenerActores(idSerie);
    }

     public List<temporadas> VerDetalleTemporadas(int IdSerie){
        return BD.ObtenerTemporadas(IdSerie);
    }

    public Series VerSerie(int idSerie){
        return BD.VerSerie(idSerie);
    }

}
