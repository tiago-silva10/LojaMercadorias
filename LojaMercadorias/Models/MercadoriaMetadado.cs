using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LojaMercadorias.Models
{
    [MetadataType(typeof(MercadoriaMetadado))]
    public partial class Mercadoria
    {
        public class MercadoriaMetadado
        {
            [Required(ErrorMessage="Obrigatório informar o Nome")]
            [StringLength(30, ErrorMessage="O Nome deve possuir no máximo 30 caracteres")]
            public string Nome { get; set; }

            [Required(ErrorMessage="Obrigatório informar a quantidade")]
            public int Quantidade { get; set; }


            [Required(ErrorMessage="Obrigatório informar o preço")]
            public double Preco { get; set; }
        }
    }
}