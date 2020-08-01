using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage = "O título não pode ficar vazio")]
        [StringLength(50, ErrorMessage = "O título deve ter no máximo 50 caracteres")]
        public string Titulo { get; set; }

        [Required]
        public string Resumo { get; set; }

        public string Categoria { get; set; }

        public DateTime? DataPublicacao { get; set; }

        public bool Publicado { get; set; }

    }
}
