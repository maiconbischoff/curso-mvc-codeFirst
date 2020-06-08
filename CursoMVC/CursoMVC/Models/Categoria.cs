using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Display(Name = "Descriçao")] //cria uma dataannotation com a label descriçao
        [Required(ErrorMessage = "O campo Descrição é obrigatoria")]
        public string Descricao { get; set;}
        //public virtual List<Produto> Produtos { get; set; } //set relationship with produtos
    }
}
