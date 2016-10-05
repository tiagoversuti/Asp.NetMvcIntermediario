using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Asp.NetMvcIntermediario.Models
{
    public class Produto
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Digite o tamanho do produto.")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "O nome deve ter entre 5 e 200 caracteres.")]
        public string Nome { get; set; }

        [Display(Name = "Quantidade")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Estoque vazio")]
        [Range(10, 25, ErrorMessage = "A quantidade deve ser entre 10 e 25.")]
        public double Qtde { get; set; }

        [Display(Name = "Preço")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Sem preço")]
        [Range(3, 500, ErrorMessage = "O preço deverá ser entre 3 e 500.")]
        public decimal Preco { get; set; }

        [Display(Name = "Vencimento")]
        [DisplayFormat(DataFormatString = "0:dd/MM/yyyy")]
        public DateTime Dt_Vencto { get; set; }
    }
}