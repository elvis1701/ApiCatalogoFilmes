using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoFilmes.Models
{
    public class Genero
    {
        public int GeneroId { get; set; }

        public string Nome { get; set; }

        public string Imagem { get; set; }

        public ICollection<Filme> Filmes { get; set; }
    }
}
