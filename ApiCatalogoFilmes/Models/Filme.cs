using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoFilmes.Models
{
    public class Filme
    {
        public int FilmeId { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public string Ano { get; set; }

        public DateTime DataCadastro { get; set; }

        public Genero Genero { get; set; }

        public int GeneroId { get; set; }


    }
}
