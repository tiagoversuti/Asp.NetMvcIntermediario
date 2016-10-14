using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcNWind.Models;

namespace MvcNWind.ViewModels
{
    public class EstatisticaViewModel
    {
        public int QtdeProdutos { get; set; }
        public decimal PrecoMedio { get; set; }
        //public string PromoProduto { get; set; }
        public Products PromoProduto { get; set; }
    }
}