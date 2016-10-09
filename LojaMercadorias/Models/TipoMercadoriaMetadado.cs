using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LojaMercadorias.Models
{
    [MetadataType(typeof(TipoMercadoriaMetadado))]
    public partial class TipoMercadoria
    {
        public class TipoMercadoriaMetadado
        {
            [Required(ErrorMessage = "Obrigatório informar o Nome")]
            [StringLength(30, ErrorMessage = "O Nome deve possuir no máximo 30 caracteres")]
            public string Nome { get; set; }
        }
    }
}