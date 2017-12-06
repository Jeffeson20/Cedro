using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cedro.Model
{
    public class Computadores
    {
        public String Id { get; set; }

        //define campos obrigatorios
        [Required(ErrorMessage = "Informe o preço")]
        public float preco { get; set; }


        [Required(ErrorMessage = "Informe as Especificações")]
        public String especificacao { get; set; }

        
        [Required(ErrorMessage = "Informe o Nome")]
        public String nome { get; set; }

        public String imagem { get; set; }
    }
}
