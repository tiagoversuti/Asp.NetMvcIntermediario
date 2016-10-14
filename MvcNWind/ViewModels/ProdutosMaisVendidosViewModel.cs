using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcNWind.Models;

namespace MvcNWind.ViewModels
{
    public class ProdutosMaisVendidosViewModel
    {
        public List<Products> Top5 { get; set; }

    }
}