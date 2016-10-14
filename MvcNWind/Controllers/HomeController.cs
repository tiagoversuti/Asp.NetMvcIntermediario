using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcNWind.Models;
using MvcNWind.ViewModels;

namespace MvcNWind.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //return View();
            return View(new ProdutosMaisVendidosViewModel()
            {
                Top5 = GetTop5()
            });
        }

        private List<Products> GetTop5()
        {
            using (var db = new NorthwindEntities())
            {
                // selecionar os produtos mais vendidos
                var produto5 = (from p in db.Order_Details
                                 group p by p.ProductID into grupo
                                 select new
                                 {
                                     produto = grupo.Key,
                                     qtde = grupo.Count()
                                 })
                                .OrderByDescending(p => p.qtde)
                                .Take(5);

                // lista de IDs dos produtos
                List<int> filtro = new List<int>();
                foreach (var item in produto5)
                {
                    filtro.Add(item.produto);
                }

                // filtrar apenas os 5 produtos mais vendidos
                List<Products> model =
                    db.Products
                    .Where(p => filtro.Contains(p.ProductID))
                    .OrderBy(p => p.ProductName)
                    .ToList();

                return model;
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}