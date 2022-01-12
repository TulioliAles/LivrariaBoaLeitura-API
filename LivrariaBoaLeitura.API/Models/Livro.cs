using System;

namespace LivrariaBoaLeitura.API.Models
{
    public class Livro
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public string Categoria { get; set; }
    }
}
