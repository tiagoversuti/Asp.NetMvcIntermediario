namespace ArtigoCodeFirstMvc5.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Produto
    {
        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        public string Nome { get; set; }

        public double Qtde { get; set; }

        public decimal Preco { get; set; }

        public DateTime Dt_Vencto { get; set; }
    }
}
