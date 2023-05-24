using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Usando_Heranca_Desafio2
{
    public class Livro
    {
        public string Autor { get; private set; }
        public string Titulo { get; private set; }
        public string PaisPublicacao { get; set; }
        public int AnoPublicacao { get; set; }
        public int NumeroPaginas { get; set; }
        public string Isbn { get; private set; }
        public string Genero { get; set; }

        public Livro(string isbn, string autor, string titulo)
        {
            this.Isbn = isbn;
            this.Titulo = titulo;
            this.Autor = autor;
        }

    }

}

