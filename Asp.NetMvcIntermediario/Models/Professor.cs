using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Asp.NetMvcIntermediario.Models
{
    public class Professor
    {
        [Key]
        public int IDProfessor { get; set; }

        [Required(ErrorMessage = "Digite o nome do professor." )]
        [MinLength(8, ErrorMessage = "O tamanho mínimo do nome é de 8 caracteres.")]
        public string Nome { get; set; }

        public string Telefone { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Sem remuneração")]
        [Range(1200, 25000, ErrorMessage = "O salário deverá estar entre R$1200,00 e R$25000,00.")]
        public decimal? Salario { get; set; }

        [Display(Name = "Twitter/Blog")]
        public string TwitterBlog { get; set; }

        public string Materia { get; set; }

        public bool Disponivel { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? Admissao { get; set; }

        // Chave estrangeira
        public List<Aluno> Alunos { get; set; }

        // Chave estrangeira
        public List<Topico> Topicos { get; set; }

    }
}