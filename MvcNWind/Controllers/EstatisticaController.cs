using MvcNWind.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcNWind.Models;

namespace MvcNWind.Controllers
{
    public class EstatisticaController : Controller
    {
        private NorthwindEntities db = new NorthwindEntities();

        // GET: Estatistica
        public ActionResult Index()
        {
            //var model = new EstatisticaViewModel
            //{
            //    PrecoMedio = 5,
            //    PromoProduto = "AAA0",
            //    QtdeProdutos = 100
            //};
            //return PartialView("Index", model);

            Random num = new Random();
            int qtde = db.Products.Count();
            int id = num.Next(1, qtde);
            Products destaque = db.Products.FirstOrDefault(
                p => p.ProductID == id);

            // calcular o preço médio
            Decimal media = Convert.ToDecimal(
                db.Products.Average(p => p.UnitPrice));

            if (destaque != null)
            {
                var model = new EstatisticaViewModel
                {
                    PrecoMedio = media,
                    PromoProduto = destaque,
                    QtdeProdutos = qtde
                };
                return PartialView("Index", model);
            }

            return null;
            
        }
    }
}