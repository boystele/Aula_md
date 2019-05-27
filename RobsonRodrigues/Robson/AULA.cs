using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RobsonRodrigues.Models
{
    [MetadataType(typeof(AULA_MD))]
    public partial class AULA_MD { }

    public class AULA
    {
        [DisplayName("Codigo Aula")]
        public int AulaId { get; set; }
        [DisplayName("Descricao Aluno")]
        [Required(ErrorMessage = "Informe a Aula")]
        [Range(900, 2500, ErrorMessage = "Deve estar")]
        public string AulaDescricao { get; set; }
    }
}