using MvcPaginacao.Domain;
using System.Linq;
using System.Web.Mvc;
using PagedList;
namespace MvcPaginacao.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cursos(int ?page)
        {
            CursosDomain domain = new CursosDomain();
            int TamanhoPagina = 5;
            int numeroPagina = page ?? 1;
            var lista = domain.ListaCursos().ToPagedList(numeroPagina,TamanhoPagina);

            return View(lista);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}