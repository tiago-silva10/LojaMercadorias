using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LojaMercadorias.Models
{
    [MetadataType(typeof(TipoNegocioMetadado))]
    public partial class TipoNegocio
    {
        public class TipoNegocioMetadado
        {
            [Required(ErrorMessage="Obrigatório informar o nome")]
            [StringLength(30, ErrorMessage = "O Nome deve possuir no máximo 30 caracteres")]
            public string Nome { get; set; }
        }
    }
}