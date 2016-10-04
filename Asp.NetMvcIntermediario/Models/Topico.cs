
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Asp.NetMvcIntermediario.Models
{
    public class Topico
    {
        [Key]
        public int IDTopico { get; set; }

        [DisplayName("Professor")]
        public int IDProfessor { get; set; }

        [Required(ErrorMessage = "Digite o tópico.")]
        [MaxLength(100), MinLength(5)]
        public string Descricao { get; set; }

        // lazy loading = add virtual
        public virtual Professor Professor { get; set; }
    }
}