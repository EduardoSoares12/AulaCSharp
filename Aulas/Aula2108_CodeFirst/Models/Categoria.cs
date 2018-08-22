using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Aula2108_CodeFirst.Models
{
    class Categoria
    {
        [Key]

        public int CategoriaID { get; set; }

        [Required]//NOT NULL
        [StringLength(30)]//MÁXIMO 30 CARACTERES
        public string Nome { get; set; }

        public string Descricao { get; set; }

        //Relação Categoria <==> Produto

        ICollection<Produto> _Produtos { get; set; } 

    }
}
