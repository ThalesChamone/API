using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro_Serie.Models
{
    public class Serie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 40, MinimumLength = 3)]
        public string Titulo { get; set; }
        [Required]
        public int Ano { get; set; }
        [Required]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Required]
        [Display(Name = "Gênero")]
        public Genero Generos { get; set; }
    }
}